using System.ComponentModel.DataAnnotations;
namespace TEMPO.Models
{
	public class LoginData
	{
        [Key]

        [Required(ErrorMessage = "กรุณาป้อนชื่อ-นามสกุล")]
        public string Name { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้งาน")]
        public string Username { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนรหัสผ่าน")]
        public string Password { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนอีเมล์สำหรับติดต่อ")]
        public string Email { get; set; }

        [Compare("Password", ErrorMessage = "รหัสผ่านไม่ตรงกัน")]
        [Required(ErrorMessage = "กรุณายืนยันรหัสผ่านอีกครั้ง")]
        public string ConfirmPassword { get; set; }

    }
}

