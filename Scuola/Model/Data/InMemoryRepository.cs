using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;

namespace Scuola.Model.Data
{
    public class InMemoryRepository : IRepository
    {
        private List<Corso> courses = new List<Corso>();
        private List<EdizioneCorso> courseEditions = new List<EdizioneCorso>();
        public InMemoryRepository()
        {
            Corso c = new Corso(345, "matematica", 50, ExperienceLevel.PRINCIPIANTE, "molto bello", 19.99m);
            courses.Add(c);
            EdizioneCorso e = new EdizioneCorso(678, c, new LocalDate(2021, 9, 20), new LocalDate(2021, 9, 30), 20, 100);
            courseEditions.Add(e);
        }
        public Corso AddCourse(Corso corso)
        {
            if (courses.Contains(corso))
            {
                return null;
            }

            courses.Add(corso);
            return corso;
        }

        public IEnumerable<EdizioneCorso> FindEditionsByCourse(long courseId)
        {
            List<EdizioneCorso> editions = new List<EdizioneCorso>();
            foreach(var ed in courseEditions)
            {
                if(ed.Corso.Id == courseId)
                {
                    editions.Add(ed);
                }
               
            }
            return editions;
        }

        public IEnumerable<Corso> GetCourses()
        {
            return courses;
        }
    }
}
