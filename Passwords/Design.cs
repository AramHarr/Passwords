using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Design
    {
        public static void CreateBorder(Field field)
        {

        }

        public static int CountBorderLength(List<Secret> AllSecrets, Field field)
        {
            int len = 0;
            List<string> fields = new List<string>();

            foreach (var secret in AllSecrets)
            {
                switch (field)
                {
                    case Field.Name:
                        fields.Add(secret.Name);
                        break;

                    case Field.Email:
                        fields.Add(secret.EmailAddress);
                        break;

                    case Field.Phone:
                        fields.Add(secret.PhoneNumber);
                        break;

                    case Field.Username:
                        fields.Add(secret.UserName);
                        break;

                    case Field.Password:
                        fields.Add(secret.Password);
                        break;
                }
            }

            foreach (string str in fields)
            {
                if (str.Length > len)
                {
                    len = str.Length;
                }
            }

            return len;
        }

        public static void CurrentUser(string name)
        {
            Console.Write($"<~keeper/{ name }~> ");
        }

        public static void DrawTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(
                @"
  ██████ ▓█████  ▄████▄   ██▀███  ▓█████▄▄▄█████▓  ██████ 
▒██    ▒ ▓█   ▀ ▒██▀ ▀█  ▓██ ▒ ██▒▓█   ▀▓  ██▒ ▓▒▒██    ▒ 
░ ▓██▄   ▒███   ▒▓█    ▄ ▓██ ░▄█ ▒▒███  ▒ ▓██░ ▒░░ ▓██▄   
  ▒   ██▒▒▓█  ▄ ▒▓▓▄ ▄██▒▒██▀▀█▄  ▒▓█  ▄░ ▓██▓ ░   ▒   ██▒
▒██████▒▒░▒████▒▒ ▓███▀ ░░██▓ ▒██▒░▒████▒ ▒██▒ ░ ▒██████▒▒
▒ ▒▓▒ ▒ ░░░ ▒░ ░░ ░▒ ▒  ░░ ▒▓ ░▒▓░░░ ▒░ ░ ▒ ░░   ▒ ▒▓▒ ▒ ░
░ ░▒  ░ ░ ░ ░  ░  ░  ▒     ░▒ ░ ▒░ ░ ░  ░   ░    ░ ░▒  ░ ░
░  ░  ░     ░   ░          ░░   ░    ░    ░      ░  ░  ░  
      ░     ░  ░░ ░         ░        ░  ░              ░  
                ░                                         

                                                  "

                );

            Console.ResetColor();
        }
    }
}
