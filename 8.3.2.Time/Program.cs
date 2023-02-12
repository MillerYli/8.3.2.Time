using System;
using System.IO;

class Task2
{
    public static void Main()
    {
        var fileInfo = new FileInfo("/Users/mille/SkillFactory/module_7/7.1.10_task/7.1.10_task/Program.cs");

        using (StreamWriter sw = fileInfo.AppendText())
        {
            sw.WriteLine();
            sw.WriteLine($"//Время запуска: {DateTime.Now}");
        }

        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }
    }
}