using ManageDormitory.Models;
using System.Data.Entity;

namespace ManageDormitory.DataAccessLayer.SQLServer {
    public class ElectricityWaterBillDAL : BaseDAL<ElectricityWaterBill> {
        public ElectricityWaterBillDAL(ElectricityWaterBill t, ManageDormitoryEntities manageDormitoryEntities, DbSet<ElectricityWaterBill> entity) : base(t, manageDormitoryEntities, entity) {
        }
    }
}
