using System.Collections.Generic;

namespace ManageDormitory.DataAccessLayer {
    public interface IBaseDAL<T> where T : class {
        /// <summary>
        /// Lấy tất cả dữ liệu có tìm kiếm
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        IList<T> List(string table = null, string column = null, string searchValue = null);
        /// <summary>
        /// Đếm số lượng
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        int Count(string table = null, string column = null, string value = null);
        /// <summary>
        /// Lấy một bản ghi có điều kiện
        /// </summary>
        /// <param name="id">Mã ID trong database</param>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        T Get(string id, string table = null, string column = null, string value = null);
        /// <summary>
        /// Thêm một dòng dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Create(T data);
        /// <summary>
        /// Cập nhật một dòng dữ liệu   
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Update(T data);
        /// <summary>
        /// Xoá một dòng dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Delete(T data);
        /// <summary>
        /// Thực thi câu lệnh SQL dạng truy vấn
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        T QuerySQL(string sql);
        /// <summary>
        /// Thực thi câu lệnh SQL dạng tác động
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int ExecuteSQL(string sql);
    }
}
