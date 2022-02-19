using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Secret
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; } = "none";
        public string PhoneNumber { get; set; } = "none";
        public string UserName { get; set; } = "none";
        public string Password { get; set; } = "none";
        // name|email|phone|username|pass

        public static List<Secret> AllSecrets = GetAll(FileManagement.Secrets);


        public Secret() { }

        public Secret(string data)
        {
            string[] fields = data.Split('|');

            Name = fields[0];
            EmailAddress = fields[1];
            PhoneNumber = fields[2];
            UserName = fields[3];
            Password = fields[4];
        }


        public static List<Secret> GetAll(List<string> db)
        {
            List<Secret> AllSecrets = new List<Secret>();

            foreach (string line in db)
            {
                Secret secret = new Secret(line);
                AllSecrets.Add(secret);
            }

            return AllSecrets;
        }

        private static void ShowSecret(Secret secret)
        {
            Console.WriteLine($"Name: { secret.Name }");
            Console.WriteLine($"Email: { secret.EmailAddress }");
            Console.WriteLine($"Phone: { secret.PhoneNumber }");
            Console.WriteLine($"Username: { secret.UserName }");
            Console.WriteLine($"Password: { secret.Password }");
        }

        public static void ShowAll(List<Secret> Secrets)
        {
            foreach (var secret in Secrets)
            {
                ShowSecret(secret);
            }
        }

        public static void ShowSpecific(List<Secret> Secrets, string field)
        {
            foreach (var secret in Secrets)
            {
                if (secret.Name == field)
                {
                    ShowSecret(secret);
                }
            }
        }

        public static Secret CreateSecret()
        {
            Secret newSecret = new Secret();

            Console.Write("Name: ");
            newSecret.Name = Console.ReadLine();
            Console.Write("E-mail: ");
            newSecret.EmailAddress = Console.ReadLine();
            Console.Write("Phone: ");
            newSecret.PhoneNumber = Console.ReadLine();
            Console.Write("Username: ");
            newSecret.UserName = Console.ReadLine();
            Console.Write("Password: ");
            newSecret.Password = Console.ReadLine();

            return newSecret;
        }

        public string CreateData()
        {
            string data = $"{ Name }|{ EmailAddress }|{ PhoneNumber }|{ UserName }|{ Password }";

            return data;
        } 

        public static void AddData()
        {
            Secret newSecret = CreateSecret();
            string data = newSecret.CreateData();

            FileManagement.Secrets.Add(data);
        }
    }
}
