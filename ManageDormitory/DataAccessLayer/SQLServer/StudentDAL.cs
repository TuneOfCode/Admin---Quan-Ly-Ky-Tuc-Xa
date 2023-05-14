using ManageDormitory.Models;
using System.Data.Entity;

namespace ManageDormitory.DataAccessLayer.SQLServer {
    public class StudentDAL : BaseDAL<Student> {
        public StudentDAL(Student t, ManageDormitoryEntities manageDormitoryEntities, DbSet<Student> entity) : base(t, entity, manageDormitoryEntities) {
        }
    }
}
