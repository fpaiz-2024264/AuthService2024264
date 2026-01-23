using System.ComponentModel.DataAnnotations;
using System.Timers;
namespace AuthServiceIN6BV.Domain.Entities;

public class UserProfile
{
    //Llave primaria
    [Key]
    [MaxLength(16)]
    public string Id{get; set;} = string.Empty;

    //Llave foranea
    [Required]
    [MaxLength(16)]
    public string UserId{get; set;} = string.Empty;

    [MaxLength(512)]
    public string ProfilePicture {get; set;} = string.Empty;

    [Required]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "El número de teléfono debe tener exactamente 8 dígitos")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "El teléfono solo debe contener números")]
    public string Phone{get; set;} = string.Empty;

    [Required]
    public User User {get; set;} = null!;

}