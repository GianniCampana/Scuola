using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola.Model.Data
{
    public interface IRepository
    {
        IEnumerable<Corso> GetCourses();
        Corso AddCourse(Corso corso);
        IEnumerable<EdizioneCorso> FindEditionsByCourse(long courseId);
    }


}
