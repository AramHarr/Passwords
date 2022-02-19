using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Passwords
{
    public class FileManagement
    {
        public static string dbPath = @"C:\Users\aramh\Desktop\db.txt";

        public static List<string> Secrets = File.ReadAllLines(dbPath).ToList();

        public static void Save()
        {
            File.WriteAllLines(dbPath, Secrets);
            Console.WriteLine();
        }
    }
}
