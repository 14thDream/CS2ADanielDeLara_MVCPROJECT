using CS2ADanielDeLara_MVCPROJECT.BusLogic.Model;
using CS2ADanielDeLara_MVCPROJECT.BusLogic.Repository;

namespace CS2ADanielDeLara_MVCPROJECT.BusLogic.Service
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository = new();
        public IEnumerable<tblStudent> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public bool Add(tblStudent student)
        {
            return _studentRepository.Add(student);
        }
    }
}
