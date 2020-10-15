using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bogol
{
    class Program
    {
       
        static void Main(string[] args)
        {

            string command;
            string[] cword;
            Program bogol = new Program();
            bool quit = false;
            int[] array1 = new int[5];
            var varNames = new Dictionary<string, int>()
        {
            {"a", 0},
            {"b", 1},
            {"c", 2},
            {"d", 3},
            {"e", 4}
        };
            Console.WriteLine("Hello and welcome to BOGOL!");
            Console.WriteLine("Quit by writing 'quit'!");
            while (quit == false)
            {
                command = Console.ReadLine();
                cword = command.Split(' ');
                if (cword[0] == "quit")
                {
                    quit = true;

                }
                else if (cword[0] == "set")
                {

                    switch (cword[1])
                    {
                        case "a":
                            array1[0] = int.Parse(cword[3]);
                            Console.WriteLine("Variable a has now the value: " + array1[0]);
                            break;
                        case "b":
                            array1[1] = int.Parse(cword[3]);
                            Console.WriteLine("Variable b has now the value: " + array1[1]);
                            break;
                        case "c":
                            array1[2] = int.Parse(cword[3]);
                            Console.WriteLine("Variable c has now the value: " + array1[2]);
                            break;
                        case "d":
                            array1[3] = int.Parse(cword[3]);
                            Console.WriteLine("Variable d has now the value: " + array1[3]);
                            break;
                        case "e":
                            array1[4] = int.Parse(cword[3]);
                            Console.WriteLine("Variable e has now the value: " + array1[4]);
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }

                }
                else if (cword[0] == "print")
                {
                    Console.WriteLine(array1[varNames[cword[1]]]);
                }
                else 
                {
                    Console.WriteLine("Unkown command " + command);
                }
            }
        }
        public void VarOperations(string[] cwords)
        {
            
            
        }
    }
}
