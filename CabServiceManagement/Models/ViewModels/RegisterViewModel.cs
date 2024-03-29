﻿namespace CabServiceManagement.Models.ViewModels
{
    public enum Roles
    {
        User,
        Driver
    }
    public class RegisterViewModel
    {

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public Roles Roles { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [StringLength(25)]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
