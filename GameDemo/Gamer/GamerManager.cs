using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer has been added!");
            }
            else
            {
                Console.WriteLine("Gamer could not be added!");
            }
            
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer information has been updated!");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer has been deleted!");
        }
    }
}
