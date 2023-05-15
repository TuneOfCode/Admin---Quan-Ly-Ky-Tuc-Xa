using ManageDormitory.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.DataAccessLayer {
    public partial class BaseDAL<T> : IBaseDAL<T> where T : class {
        /// <summary>
        /// Đối tượng của lớp định danh T
        /// </summary>
        protected T _instance;
        /// <summary>
        /// Thực thể chung
        /// </summary>
        protected ManageDormitoryEntities _manageDormitoryEntities;
        /// <summary>
        /// Thực thể cơ sở
        /// </summary>
        protected DbSet<T> _baseEntity;
        /// <summary>
        /// Cấu hình chuỗi kết nối
        /// </summary>
        public BaseDAL(T t, ManageDormitoryEntities manageDormitoryEntities, DbSet<T> entity)
            : base() {
            _instance = t;
            _manageDormitoryEntities = manageDormitoryEntities;
            _baseEntity = entity;
        }
        /// <summary>
        /// Lấy tất cả dữ liệu có tìm kiếm
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public IList<T> List(string table = null, string column = null, string searchValue = null) {
            try {
                if (string.IsNullOrEmpty(table)
                       && string.IsNullOrEmpty(column)
                       && string.IsNullOrEmpty(searchValue)) {
                    return _baseEntity.ToList();
                }
                string sql = $"SELECT * FROM {table} WHERE {column} LIKE N'%{searchValue}%'";
                return _baseEntity.SqlQuery(sql).ToList();
            } catch (DbEntityValidationException ex) {
                string errors = "";
                foreach (var validationErrors in ex.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        errors = $"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}";
                    }
                }
                MessageBox.Show(
                   errors,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return null;
            }
        }
        /// <summary>
        /// Đếm số lượng
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public int Count(string table = null, string column = null, string value = null) {
            try {
                if (string.IsNullOrEmpty(table)
                       && string.IsNullOrEmpty(column)
                       && string.IsNullOrEmpty(value)) {
                    return _baseEntity.Count();
                }
                string sql = $"SELECT * FROM {table} WHERE {column} = '{value}'";
                return _baseEntity.SqlQuery(sql).Count();
            } catch (DbEntityValidationException ex) {
                string errors = "";
                foreach (var validationErrors in ex.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        errors = $"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}";
                    }
                }
                MessageBox.Show(
                   errors,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return -1;
            }
        }
        /// <summary>
        /// Lấy một bản ghi có điều kiện
        /// </summary>
        /// <param name="id">Mã ID trong database</param>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        public T Get(string id, string table = null, string column = null, string value = null) {
            try {
                if (string.IsNullOrEmpty(id)) {
                    string sql = $"SELECT * FROM {table} WHERE {column} = '{value}'";
                    return _baseEntity.SqlQuery(sql).First();
                }
                return _baseEntity.Find(id);
            } catch (DbEntityValidationException ex) {
                string errors = "";
                foreach (var validationErrors in ex.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        errors = $"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}";
                    }
                }
                MessageBox.Show(
                   errors,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return null;
            }
        }
        /// <summary>
        /// Thêm một dòng dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Create(T data) {
            try {
                _baseEntity.Add(data);
                return _manageDormitoryEntities.SaveChanges();
            } catch (DbEntityValidationException ex) {
                string errors = "";
                foreach (var validationErrors in ex.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        errors = $"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}";
                    }
                }
                MessageBox.Show(
                   errors,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return -1;
            }
        }
        /// <summary>
        /// Cập nhật một dòng dữ liệu   
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns> 
        public int Update(T data) {
            try {
                // _manageDormitoryEntities.Entry(_instance).State = EntityState.Modified;
                _baseEntity.AddOrUpdate(data);
                return _manageDormitoryEntities.SaveChanges();
            } catch (DbEntityValidationException ex) {
                string errors = "";
                foreach (var validationErrors in ex.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        errors = $"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}";
                    }
                }
                MessageBox.Show(
                   errors,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return -1;
            }
        }
        /// <summary>
        /// Xoá một dòng dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Delete(T data) {
            try {
                _baseEntity.Remove(data);
                return _manageDormitoryEntities.SaveChanges();
            } catch (DbEntityValidationException ex) {
                string errors = "";
                foreach (var validationErrors in ex.EntityValidationErrors) {
                    foreach (var validationError in validationErrors.ValidationErrors) {
                        errors = $"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}";
                    }
                }
                MessageBox.Show(
                   errors,
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return -1;
            }
        }
        /// <summary>
        /// Thực thi câu lệnh SQL dạng truy vấn
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        IList<T> IBaseDAL<T>.QuerySQL(string sql) {
            return _baseEntity.SqlQuery(sql).ToList();
        }
        /// <summary>
        /// Thực thi câu lệnh SQL dạng tác động
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        int IBaseDAL<T>.ExecuteSQL(string sql) {
            return _baseEntity.SqlQuery(sql).Count();
        }
    }
}
