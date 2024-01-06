using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenMinhQuan546.Models
{
    [Table("LopHoc")]
    public class LopHoc{
        [Key]
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaSinhVien { get; set; }
        [ForeignKey("MaSinhVien")]
        public SinhVien? SinhVien { get; set; }
    }
}