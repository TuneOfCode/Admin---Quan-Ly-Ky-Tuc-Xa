using ManageDormitory.DataAccessLayer;
using ManageDormitory.DataAccessLayer.SQLServer;
using ManageDormitory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManageDormitory.BusinessLayer {
    public static class StudentServices {
        private static string FORMAT_DATETIME = "dd/MM/yyyy";
        private static ManageDormitoryEntities manageDormitoryEntities;
        private static Student student;
        private static readonly IBaseDAL<Student> studentDAL;
        /// <summary>
        /// ctor
        /// </summary>
        static StudentServices() {
            manageDormitoryEntities = new ManageDormitoryEntities();
            student = new Student();
            studentDAL = new StudentDAL(student, manageDormitoryEntities, manageDormitoryEntities.Students);
        }
        /// <summary>
        /// Load lại dữ liệu bảng sinh viên
        /// </summary>
        /// <param name="StudentDGV"></param>
        public static void LoadDatatable(DataGridView StudentDGV, IList<Student> students) {
            if (students.Count == 0) {
                return;
            }
            for (int i = 0; i < students.Count; i++) {
                var student = students[i];
                StudentDGV.Rows.Add(
                    false,
                    (i + 1),
                    student.id,
                    student.name,
                    student.gender ? "nam" : "nữ",
                    student.birthdate.ToString(FORMAT_DATETIME),
                    student.phone,
                    student.school,
                    student.contract_signing_date?.ToString(FORMAT_DATETIME)
                ); ;
            }
        }
        /// <summary>
        /// Lấy tất cả dữ liệu có tìm kiếm của sinh viên
        /// </summary>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static List<Student> ListOfStudents(
                string table = null,
                string column = null,
                string searchValue = null) {
            return studentDAL.List(table, column, searchValue).ToList();
        }
        /// <summary>
        /// Lấy chi tiết một sinh viên có điều kiện
        /// </summary>
        /// <param name="id">Mã sinh viên trong database</param>
        /// <param name="table">Tên bảng trong database</param>
        /// <param name="column">Tên cột trong model</param>
        /// <param name="searchValue">Giá trị tìm kiếm nếu có</param>
        /// <returns></returns>
        public static Student GetStudent(
                string id,
                string table = null,
                string column = null,
                string searchValue = null) {
            return studentDAL.Get(id, table, column, searchValue);
        }
        /// <summary>
        /// Tạo mới một sinh viên
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int CreateNewStudent(string[] data) {
            student = new Student();
            student.avatar = data[0];
            student.id = data[1];
            student.name = data[2];
            student.gender = Boolean.Parse(data[3]);
            student.birthdate = DateTime.Parse(data[4]);
            student.citizen_identification = data[5];
            student.date_issue = DateTime.Parse(data[6]);
            student.place_issue = data[7];
            student.address = data[8];
            student.phone = data[9];
            student.email = data[10];
            student.school = data[11];
            student.industry = data[12];
            student.course = data[13];
            student.room_id = data[14];
            return studentDAL.Create(student);
        }
        /// <summary>
        /// Cập nhật thông tin của một sinh viên
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int UpdateStudent(string[] data) {
            student = new Student();
            student.avatar = data[0];
            student.id = data[1];
            student.name = data[2];
            student.gender = Boolean.Parse(data[3]);
            student.birthdate = DateTime.Parse(data[4]);
            student.citizen_identification = data[5];
            student.date_issue = DateTime.Parse(data[6]);
            student.place_issue = data[7];
            student.address = data[8];
            student.phone = data[9];
            student.email = data[10];
            student.school = data[11];
            student.industry = data[12];
            student.course = data[13];
            student.room_id = data[14];
            return studentDAL.Update(student);
        }
        /// <summary>
        /// Xoá một hoặc nhiều sinh viên
        /// </summary>
        /// <param name="studentIDs"></param>
        /// <returns></returns>
        public static int DeleteStudent(IList<string> studentIDs) {
            int isDeleted = 1;
            foreach (string studentID in studentIDs) {
                student = studentDAL.Get(studentID);
                isDeleted = studentDAL.Delete(student);
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
            return studentDAL.Count(table, column, value);
        }
    }

}
