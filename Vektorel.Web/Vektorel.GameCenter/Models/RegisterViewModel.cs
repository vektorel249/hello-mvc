using System.ComponentModel.DataAnnotations;

namespace Vektorel.GameCenter.Models;

public class RegisterViewModel
{
    [Required]
    [MaxLength(32)]
    public string EMail { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    [Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmuyor.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [MaxLength(32)]
    public string FullName { get; set; }
}
/*
 
http://url/fdd/yy/gds?q=45&r=Can
 
 */