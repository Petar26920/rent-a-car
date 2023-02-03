using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pokusajNecega3.Models
{
    public class PodrazumevanaValidacija : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return new ValidationResult("Polje ne sme ostati prazno");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
