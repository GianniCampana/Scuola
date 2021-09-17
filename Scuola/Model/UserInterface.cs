using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace Scuola.Model
{
    public class UserInterface
    {
        public CourseService CourseService { get; set; }
        const string MAIN_MENU = "Operazioni disponibili: inserisci a per vedere tutti i corsi\n inserisci c per inserire un corso\n inserisci e per ricercare le edizioni di un corso\n inserisci q per uscire dal menu";
        const string BASE_PROMPT = "->";
        public UserInterface(CourseService service)
        {
            CourseService = service;
        }
        
        public void Start()
        {
            bool quit = false;
            do
            {
                WriteLine(MAIN_MENU);
                char c = ReadChar(BASE_PROMPT);
                switch (c)
                {
                    case 'a':
                        ShowCourses();
                        break;
                    case 'c':
                        CreateCourse();
                        break;
                    case 'e':
                        ShowCourseEditionByCourse();
                        break;
                    case 'q':
                        quit = true;
                        break;
                    default:
                        WriteLine("Comando non riconosciuto");
                        break;
                }
            } while (!quit);

        }

        private void ShowCourseEditionByCourse()
        {
            long id = ReadLong("inserisci l'id ");
            IEnumerable<EdizioneCorso> editions = CourseService.GetCourseEdition(id);
            foreach (var c in editions)
            {
                WriteLine(c.ToString());
            }
        }

        private void CreateCourse()
        {
            long id = ReadLong("inserisci l'id del corso ");
            string titolo = ReadString("inserisci il titolo del corso ");
            string descrizione = ReadString("inserisci la descrizione del corso ");
            string levelString = ReadString("inserisci il livello del corso PRINCIPIANTE-MEDIO-ESPERTO-GURU ");
            Enum.TryParse(levelString, out ExperienceLevel level);
            int durata = (int) ReadLong("inserisci la durata del corso ");
            decimal prezzo = ReadDecimal("inserisci il prezzo del corso ");
            Corso c = new Corso(id, titolo, durata, level, descrizione, prezzo);
            CourseService.CreateCourse(c);
            WriteLine("corso inserito correttamente");
        }

        private void ShowCourses()
        {
            IEnumerable<Corso> courses = CourseService.GetAllCourses();
            foreach(var c in courses)
            {
                WriteLine(c.ToString());
            }
        }

        private char ReadChar(string prompt)
        {

            return ReadString(prompt)[0];
        }
        private long ReadLong(string prompt)
        {
            bool isNumber = false;
            long num;
            do
            {
                string answer = ReadString(prompt);
                isNumber = long.TryParse(answer, out num);
                if (!isNumber)
                {
                    WriteLine("devi inserire un numero");
                }
            } while (!isNumber);

            return num;
            
            
        }
        private decimal ReadDecimal(string prompt)
        {
            bool isNumber = false;
            decimal num;
            do
            {
                string answer = ReadString(prompt);
                isNumber = decimal.TryParse(answer, out num);
                if (!isNumber)
                {
                    WriteLine("devi inserire un numero");
                }
            } while (!isNumber);

            return num;


        }
        private string ReadString(string prompt)
        {
            string answer = null;

            do
            {
                Write(prompt);
                answer = ReadLine().Trim();

                if (string.IsNullOrEmpty(answer))
                {
                    WriteLine("Devi inserire almeno un carattere");
                }
            } while (string.IsNullOrEmpty(answer));

            return answer;
        }
        
    }
}
