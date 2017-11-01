using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _475_Lab_4_Part_3
{
    class ConcreteRepository
    {
        public interface ISTatndardRepository : IRepository<Standard>
        public interface IStudentRepository : IRepository<Student>

        public class StandardRepository : Repository<Standard>, IStandardRepository
        {
            public StandardRepository() : base(new SchoolDBEntities()) { }
        }

        public class StudentRepository : Repository<Student>, IStudentRepository
        {
            public StudentRepository() : base(new SchoolDBEntities()) { }
        }
    }
}
