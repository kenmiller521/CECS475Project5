using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;

        public BusinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
        }

        public void AddStandard(Standard standard)
        {
            _standardRepository.Insert(standard);
        }

        public void Addstudent(Student student)
        {
            _studentRepository.Insert(student);
        }

        public Standard GetStandardByID(int id)
        {
            return _standardRepository.getByID(id);
        }

        public Standard GetStandardByIDWithStudents(int id)
        {
            return _standardRepository.GetSIngle(
            S => s.standardID == id,
            S => s.students);
        }

        public Student GetStudentByID(int id)
        {
            return _studentRepository.getByID(id);
        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<t, object>>[])
        {

        }
    }
}
