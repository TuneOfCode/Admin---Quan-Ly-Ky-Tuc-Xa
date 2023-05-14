using System.Windows.Forms;

namespace PresentationLayer {
    public static class CustomException {
        /// <summary>
        /// Kiểm tra dữ liệu đầu vào
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="values"></param>
        public static bool ValidateNotEmptyFields(string[] cols, string[] values) {
            int length = cols.Length > values.Length ? cols.Length : values.Length;
            int countError = length;
            string err = "";
            for (int i = 0; i < length; i++) {
                if (string.IsNullOrEmpty(values[i])) {
                    string col = cols[i].Replace(":", "");
                    err += $"\n {i + 1}. {col}";
                } else {
                    countError--;
                }
            }
            if (countError == 0) {
                return false;
            }
            MessageBox.Show(
                $"Những trường sau đang bị trống: {err}",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return true;
        }
    }
}
