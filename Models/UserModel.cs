using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationUser.Models;

public class UserModel
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The Name field is required.")] // атрибут, для обов'язкового заповнення
    [StringLength(20, ErrorMessage = "The Name field must be a string with a maximum length of 20.")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "The Surname field is required.")]
    [StringLength(20, ErrorMessage = "The Surname field must be a string with a maximum length of 20.")]
    public string Surname { get; set; }
    
    [Required(ErrorMessage = "The Mail field is required.")]
    [MaxLength(100, ErrorMessage = "The Mail field must be a string with a maximum length of 100.")]
    public string Mail { get; set; }
    
    public string City { get; set; }
}