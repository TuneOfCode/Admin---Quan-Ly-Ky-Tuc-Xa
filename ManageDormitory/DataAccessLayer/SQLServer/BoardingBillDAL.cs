using ManageDormitory.Models;
using System.Data.Entity;

namespace ManageDormitory.DataAccessLayer.SQLServer {
    public class BoardingBillDAL : BaseDAL<BoardingBill> {
        public BoardingBillDAL(BoardingBill t, ManageDormitoryEntities manageDormitoryEntities, DbSet<BoardingBill> entity) : base(t, manageDormitoryEntities, entity) {
        }
    }
}
