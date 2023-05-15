using ManageDormitory.Models;
using System.Data.Entity;

namespace ManageDormitory.DataAccessLayer.SQLServer {
    public class RoomDAL : BaseDAL<Room> {
        public RoomDAL(Room t, ManageDormitoryEntities manageDormitoryEntities, DbSet<Room> entity) : base(t, manageDormitoryEntities, entity) {
        }
    }
}
