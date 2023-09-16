using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace GymManegmentApplication.Exceptions
{
    public class validationException:ApplicationException
    {
        public List<string> Error { get; set; }= new List<string>();

        public validationException(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Error.Add(error.ErrorMessage);
            }
        }
    }
}
