using System;
using Entidad;


namespace proyecto.Models
{
    public class LoginInputModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        
    }

    public class LoginViewModel : LoginInputModel
    {
        public LoginViewModel(User user)
        {
            UserName = user.UserName;
            Password = user.Password;
            FirstName = user.FirstName;
            LastName = user.LastName;

        }

        public string Token { get; set; }

        public LoginViewModel()
        {
            
        }

            


    }



}