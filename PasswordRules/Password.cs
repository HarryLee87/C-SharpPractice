using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordRules
{
    public class Password
    {
        private char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

        public char[] NotAllowedSymbols { get => notAllowedSymbols; set => notAllowedSymbols = value; }

        public Password()
        {
            PasswordType();
        }

        public static void PasswordType()
        {
            Console.Write("Enter New Password: ");
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };
            bool isValid = false;
            foreach (char symbol in notAllowedSymbols) 
            {
                if(password.Contains(symbol))
                {
                    isValid = true;
                    Console.WriteLine("Password cannot have following symbols\n'!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-'");
                    break;
                }
            }
            if(!isValid)
            {
                Console.Write("Reenter the new password: ");
                string confirmPassword = Console.ReadLine();
                if(confirmPassword == password) 
                {
                    Console.WriteLine("Password is created!");
                }
                else
                {
                    Console.WriteLine("Please check your password again!");
                }
            }
        }
    }
}
