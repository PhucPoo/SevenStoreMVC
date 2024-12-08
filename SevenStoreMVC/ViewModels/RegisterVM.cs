using System.ComponentModel.DataAnnotations;

namespace SevenStoreMVC.ViewModels
{
    public class RegisterVM
    {
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="*")]
        [MaxLength(20, ErrorMessage ="Tối đa 20 ký tự")]

        public string MaKh { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Mật khẩu")] 
        
        

        public string? MatKhau { get; set; }
        [Display(Name ="Họ và tên")]
        [MaxLength(50, ErrorMessage ="Tối đa 50 kí tự")]

        public string HoTen { get; set; }

        public bool GioiTinh { get; set; } = true;
        [Display(Name ="Ngày sinh")]
        [DataType(DataType.Date)]

        public DateTime? NgaySinh { get; set; }
        [MaxLength(50,ErrorMessage ="tối đa 50 kí tự")]

        public string DiaChi { get; set; }
        [RegularExpression(@"0\d{9}",ErrorMessage ="Chưa nhập đúng số điện thoại")]

        public string DienThoai { get; set; }
        [EmailAddress(ErrorMessage ="Chưa đúng định dạng email")]

        public string Email { get; set; } 

        public string? Hinh { get; set; }
    }
}
