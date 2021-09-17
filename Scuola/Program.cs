using Scuola.Model;
using Scuola.Model.Data;
using System;

namespace Scuola
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repo = new InMemoryRepository();
            CourseService cs = new CourseService(repo);
            UserInterface ui = new UserInterface(cs);
            //iniezione delle dipendenze 
            ui.Start();
        }
    }
}
