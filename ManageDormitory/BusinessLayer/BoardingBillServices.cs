using ManageDormitory.DataAccessLayer;
using ManageDormitory.DataAccessLayer.SQLServer;
using ManageDormitory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.BusinessLayer {
    public class BoardingBillServices {
        private static ManageDormitoryEntities manageDormitoryEntities;
        private static BoardingBill boardingBill;
        private static readonly IBaseDAL<BoardingBill> boardingBillDAL;
        /// <summary>
        /// 
        /// </summary>
        static BoardingBillServices() {
            manageDormitoryEntities = new ManageDormitoryEntities();
            boardingBill = new BoardingBill();
            boardingBillDAL = new BoardingBillDAL(boardingBill, manageDormitoryEntities, manageDormitoryEntities.BoardingBills);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boardingBillDGV"></param>
        /// <param name="boardingBills"></param>
        public static void LoadDatatable(DataGridView BoardingBillDGV, IList<BoardingBill> boardingBills) {
            if (boardingBills.Count == 0) {
                return;
            }

            for (int i = 0; i < boardingBills.Count; i++) {
                var boardingBill = boardingBills[i];
                var student = StudentServices.GetStudent(boardingBill.student_id);
                BoardingBillDGV.Rows.Add(
                    false,
                    (i + 1),
                    boardingBill.id,
                    boardingBill.name,
                    boardingBill.date_founded,
                    boardingBill.total,
                    student.id,
                    student.name,
                    student.school,
                    boardingBill.status,
                    boardingBill.payment_date,
                    boardingBill.note
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
        public static List<BoardingBill> ListOfBoardingBills(
                string table = null,
                string column = null,
                string searchValue = null) {
            return boardingBillDAL.List(table, column, searchValue).ToList();
        }
        /// <summary>
        /// Lấy chi tiết một hoá đơn ở có điều kiện
        /// </summary>
        /// <param name="id">Mã hoá đơn ở trong database</param>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static BoardingBill GetBoardingBill(
                string id,
                string table = null,
                string column = null,
                string searchValue = null) {
            return boardingBillDAL.Get(id, table, column, searchValue);
        }
        /// <summary>
        /// Tạo mới một hoá đơn nội trú
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int CreateNewBoardingBill(string[] data) {
            boardingBill = new BoardingBill();
            boardingBill.name = data[0];
            boardingBill.date_founded = DateTime.Parse(data[1]);
            boardingBill.total = decimal.Parse(data[2]);
            boardingBill.student_id = data[3];
            boardingBill.note = data[4];
            return boardingBillDAL.Create(boardingBill);
        }
        /// <summary>
        /// Cập nhật hoá đơn
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int UpdateBoardingBill(BoardingBill data) {
            return boardingBillDAL.Update(data);
        }
    }
}
