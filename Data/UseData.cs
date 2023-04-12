using System.ComponentModel.DataAnnotations;
namespace WebFormValidationTest.Data;

public class Person {
    [Required(ErrorMessage ="氏名は必須です")]
    [StringLength(10,ErrorMessage ="氏名は10桁までです")]
    public string Name { get; set; } = null!;
    [Required]
    public DateOnly Birthday { get; set; }
    [Required(ErrorMessage ="メールアドレスは必須です")]
    [StringLength(50,ErrorMessage ="メールアドレスは50桁までです")]
    public string MailAddress { get; set; } = null!;
}