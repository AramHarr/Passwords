using System;

namespace Passwords
{
    class Program
    {
        static void Main(string[] args)
        {

            Design.DrawTitle();

            while (true)
            {
                Design.CurrentUser("Aram");

                Command.ReadCommandLine();

                FileManagement.Save();
            }
        }
    }
}
