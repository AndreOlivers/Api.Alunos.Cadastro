using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Domain.Validator
{
    public class DomainExceptioValidator : Exception
    {
        public DomainExceptioValidator(string error) : base(error) { }

        public static void When(bool hasError, string error)
        {
            if(hasError)
                throw new Exception(error);
        }
    }
}
