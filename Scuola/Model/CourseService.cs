using Scuola.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola.Model
{
    public class CourseService
    {
        public IRepository Repository { get; private set; }

        public CourseService(IRepository repo)
        {
            Repository = repo;
        }
        public IEnumerable<Corso> GetAllCourses()
        {
            return Repository.GetCourses();

        }
        public Corso CreateCourse(Corso c)
        {
            return Repository.AddCourse(c);
        }
        public IEnumerable<EdizioneCorso> GetCourseEdition(long id)
        {
            return Repository.FindEditionsByCourse(id);
        }


    }
}     
