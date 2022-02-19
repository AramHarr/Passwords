using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Command
    {
        public static string commandLine;
        public static string[] commands = new string[10];

        public static void ReadCommandLine()
        {
            commandLine = Console.ReadLine();
            commands = commandLine.Split(' ');

            ManageCommand(commands);
        }

        public static void ManageCommand(string[] commands)
        {
            if (commands[0] == "show")
            {
                if (commands[1] == "all")
                {
                    Secret.ShowAll(Secret.AllSecrets);
                }
                else
                {
                    Secret.ShowSpecific(Secret.AllSecrets, commands[1]);
                }
            }
            else if (commands[0] == "add")
            {
                Secret.AddData();
            }
        }
    }
}
