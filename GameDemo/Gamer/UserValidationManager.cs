using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "BESTE" && gamer.LastName == "DÜLGER" && gamer.NationalIdentityNumber == 1111111111) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
