//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment5.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Guest
    {
        #region "Guest model"
        public int Id { get; set; }

        [Required]
        [RegularExpression("([a-zA-Z .&'-]+)", ErrorMessage = "Enter only alphabets ")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "Age must be numeric")]
        public int Age { get; set; }

        [Required]
        public Nullable<int> InvitationId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOFBirth { get; set; }

        [Required]
        public string Gender { get; set; }
    
        public virtual Invitation Invitation { get; set; }
        #endregion
    }
}
