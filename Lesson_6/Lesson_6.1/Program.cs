using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processList = Process.GetProcesses();
            
            foreach (Process process in processList)
            {
                Console.WriteLine(@"Name: {0}   |   ID:{1}   |",process.ProcessName, process.Id);
            }
            if (true)
            {
                KillByName();
            }
            KillByID();
                                    
            Console.ReadLine();
        }
                
        static void KillByID()
        {
            Console.WriteLine("\nВведите Id процесса, который нужно отключить!");
            int pid = int.Parse(Console.ReadLine());
            try
            {
                Process p = Process.GetProcessById(pid);
                p.Kill();

                p.WaitForExit();
            }
            catch (Exception)
            {
                Console.WriteLine("такого id процесса нет");
            }
         
        }
        static void KillByName()
        {
            Console.WriteLine("\nВведите имя процесса, который нужно отключить!");
            string name = Console.ReadLine();
            if(true)
            {
                foreach (Process pr in Process.GetProcessesByName(name))
                {
                    pr.Kill();
                    pr.WaitForExit();
                }    
            }
            Console.WriteLine("Такого процесса не запущено!");
            
        }   
            
    }
}

