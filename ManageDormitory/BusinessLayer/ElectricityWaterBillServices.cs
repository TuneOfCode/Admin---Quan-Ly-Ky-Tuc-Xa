using ManageDormitory.DataAccessLayer;
using ManageDormitory.DataAccessLayer.SQLServer;
using ManageDormitory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.BusinessLayer {
    public static class ElectricityWaterBillServices {
        private static ManageDormitoryEntities manageDormitoryEntities;
        private static ElectricityWaterBill elecWaterBill;
        private static readonly IBaseDAL<ElectricityWaterBill> elecWaterDAL;
        /// <summary>
        /// 
        /// </summary>
        static ElectricityWaterBillServices() {
            manageDormitoryEntities = new ManageDormitoryEntities();
            elecWaterBill = new ElectricityWaterBill();
            elecWaterDAL = new ElectricityWaterBillDAL(elecWaterBill, manageDormitoryEntities, manageDormitoryEntities.ElectricityWaterBills);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ElecWaterBillDGV"></param>
        /// <param name="electricityWaterBills"></param>
        public static void LoadDatatable(DataGridView ElecWaterBillDGV, IList<ElectricityWaterBill> electricityWaterBills) {
            if (electricityWaterBills.Count == 0) {
                return;
            }

            for (int i = 0; i < electricityWaterBills.Count; i++) {
                var electricityWaterBill = electricityWaterBills[i];
                ElecWaterBillDGV.Rows.Add(
                    false,
                    (i + 1),
                    electricityWaterBill.id,
                    electricityWaterBill.name,
                    electricityWaterBill.date_founded,
                    electricityWaterBill.electricity_money,
                    electricityWaterBill.water_money,
                    electricityWaterBill.into_money,
                    electricityWaterBill.room_id,
                    electricityWaterBill.status,
                    electricityWaterBill.payment_date,
                    electricityWaterBill.note
                );
            }
        }
        /// <summary>
        /// Lấy tất cả dữ liệu có tìm kiếm của hoá đơn
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static List<ElectricityWaterBill> ListOfElectricityWaterBills(
                string table = null,
                string column = null,
                string searchValue = null) {
            return elecWaterDAL.List(table, column, searchValue).ToList();
        }
        /// <summary>
        /// Lấy chi tiết một hoá đơn ở có điều kiện
        /// </summary>
        /// <param name="id">Mã hoá đơn ở trong database</param>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static ElectricityWaterBill GetElectricityWaterBill(
                string id,
                string table = null,
                string column = null,
                string searchValue = null) {
            return elecWaterDAL.Get(id, table, column, searchValue);
        }
        /// <summary>
        /// Tạo mới một hoá đơn nội trú
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int CreateNewElectricityWaterBill(string[] data) {
            elecWaterBill = new ElectricityWaterBill();
            elecWaterBill.name = data[0];
            elecWaterBill.date_founded = DateTime.Now;
            elecWaterBill.old_power_indicator = int.Parse(data[1]);
            elecWaterBill.new_power_indicator = int.Parse(data[2]);
            elecWaterBill.amount_electricity_consumed = int.Parse(data[3]);
            elecWaterBill.electricity_money = decimal.Parse(data[4]);
            elecWaterBill.old_water_index = int.Parse(data[5]);
            elecWaterBill.new_water_index = int.Parse(data[6]);
            elecWaterBill.amount_water_consumed = int.Parse(data[7]);
            elecWaterBill.water_money = decimal.Parse(data[8]);
            elecWaterBill.note = data[9];
            elecWaterBill.environmental_charges = decimal.Parse(data[10]);
            elecWaterBill.into_money = decimal.Parse(data[11]);
            elecWaterBill.room_id = data[12];
            return elecWaterDAL.Create(elecWaterBill);
        }
        /// <summary>
        /// Cập nhật hoá đơn
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int UpdateElectricityWaterBill(ElectricityWaterBill data) {
            return elecWaterDAL.Update(data);
        }
    }
}