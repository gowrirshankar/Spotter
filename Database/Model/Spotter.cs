using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Model
{
    public class Spotter
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter manufacturer name")]
        [StringLength(128, MinimumLength = 3, ErrorMessage = "Please enter minimum 3 characters and maximum 128 characters")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Please enter model name")]
        [StringLength(128, MinimumLength = 3, ErrorMessage = "Please enter minimum 3 characters and maximum 128 characters")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please enter registration number")] 
        [RegularExpression(@"^(?=\w{1,2}(-\w{1,5}))[\w-]{1,8}$", ErrorMessage ="Enter maximum of 2 characters followed by hyphen and maximum of 5 characters")]
        public string Registration { get; set; }
        [Required(ErrorMessage = "Please enter location")]
        [StringLength(128, MinimumLength = 3, ErrorMessage = "Please enter minimum 3 characters and maximum 128 characters")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please enter date of capturing")]
        public DateTime Date { get; set; }
    }
}
