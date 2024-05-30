using System.ComponentModel.DataAnnotations;

namespace QuizWebApp.Models;
public class UserViewModel
{
        public int ID { get; set; }  
        // -- Validating Student Name  
        [Required(ErrorMessage ="Name is required")]  
        [MaxLength(12)]  
        public required string Name { get; set; }  
        // -- Validating Email Address  
        [Required(ErrorMessage ="Email is required")]  
        [EmailAddress(ErrorMessage = "Invalid Email Address")]  
        public required string Email { get; set; }  
        // -- Validating Contact Number  
        [Required(ErrorMessage = "Contact is required")]  
        [DataType(DataType.PhoneNumber)]  
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]  
        public required string Phone{get;set;}

        [Required(ErrorMessage = "Password is required")] 
        public required string Password{get;set;}

        [Required(ErrorMessage = " Confrim Password is required")] 
        public required string ConfirmPassword{get;set;}
}