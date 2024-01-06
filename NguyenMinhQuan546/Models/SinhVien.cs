using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenMinhQuan546.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public int MaLop { get; set; }
        
    }
}