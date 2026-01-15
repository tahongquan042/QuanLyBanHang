using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Entities
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int MaKH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKH { get; set; }

        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
