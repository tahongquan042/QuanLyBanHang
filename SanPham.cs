using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Entities
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int MaSP { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSP { get; set; }

        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
    }
}
