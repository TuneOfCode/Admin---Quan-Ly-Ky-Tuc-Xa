using ManageDormitory.DataAccessLayer;
using ManageDormitory.DataAccessLayer.SQLServer;
using ManageDormitory.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.BusinessLayer {
    public static class RoomServices {
        private static string FORMAT_DATETIME = "dd/MM/yyyy";
        private static ManageDormitoryEntities manageDormitoryEntities;
        private static Room room;
        private static readonly IBaseDAL<Room> roomDAL;
        /// <summary>
        /// ctor
        /// </summary>
        static RoomServices() {
            manageDormitoryEntities = new ManageDormitoryEntities();
            room = new Room();
            roomDAL = new RoomDAL(room, manageDormitoryEntities, manageDormitoryEntities.Rooms);
        }
        /// <summary>
        /// Load lại dữ liệu bảng phòng ở
        /// </summary>
        /// <param name="RoomDGV"></param>
        public static void LoadDatatable(DataGridView RoomDGV, IList<Room> rooms) {
            // TODO: [Ni] Load lại dữ liệu bảng phòng ở
        }
        /// <summary>
        /// Lấy tất cả dữ liệu có tìm kiếm của phòng ở
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static List<Room> ListOfRooms(
                string table = null,
                string column = null,
                string searchValue = null) {
            return roomDAL.List(table, column, searchValue).ToList();
        }
        /// <summary>
        /// Lấy chi tiết một phòng ở có điều kiện
        /// </summary>
        /// <param name="id">Mã phòng ở trong database</param>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static Room GetRoom(
                string id,
                string table = null,
                string column = null,
                string searchValue = null) {
            return roomDAL.Get(id, table, column, searchValue);
        }
        /// <summary>
        /// Tạo mới một phòng ở
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int CreateNewRoom(string[] data) {
            room = new Room();
            // TODO: [Ni] Thêm dữ liệu phòng ở gán từng giá trị cho room
            return roomDAL.Create(room);
        }
        /// <summary>
        /// Cập nhật thông tin của một phòng ở
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int UpdateRoom(string[] data) {
            room = new Room();
            // TODO: [Ni] Cập nhật dữ liệu phòng ở gán từng giá trị cho room
            return roomDAL.Update(room);
        }
        /// <summary>
        /// Xoá một hoặc nhiều sinh viên
        /// </summary>
        /// <param name="roomIDs"></param>
        /// <returns></returns>
        public static int DeleteRoom(IList<string> roomIDs) {
            int isDeleted = 1;
            foreach (string roomID in roomIDs) {
                room = roomDAL.Get(roomID);
                isDeleted = roomDAL.Delete(room);
                if (isDeleted == 0) {
                    break;
                }
            }
            return isDeleted;
        }
        /// <summary>
        /// Đếm số lượng
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Count(
                string table = null,
                string column = null,
                string value = null) {
            return roomDAL.Count(table, column, value);
        }
    }
}
