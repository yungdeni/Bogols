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
            //int[] array1 = new int[5];
            var varNames = new Dictionary<string, int>()
            {
            {"a", 0},
            {"b", 0},
            {"c", 0},
            {"d", 0},
            {"e", 0}
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
                    try 
	                {	        
		                varNames.Add(cword[1],0);
	                }
	                catch (ArgumentException)
	                {
                        
                        //varNames[cword[1]] = int.Parse(cword[3]);
		                
	                }
                

                    if(cword.Length == 4)
                    {
                        int trash = 0;
                        bool result = int.TryParse(cword[3],out trash);
                        if (result == true)
                        {
                            varNames[cword[1]] = trash;
                            Console.WriteLine("Variable " + cword[1]+ " now has the value " + varNames[cword[1]]);
                        }
                        else
                        {
                            varNames[cword[1]] = varNames[cword[3]];
                        }
                    }
                }

                    

                if (cword.Length == 6)
                {
                           
                    int garbo = 0;
                    bool result2 = int.TryParse(cword[5],out garbo);
                    int trash = 0;
                    bool result = int.TryParse(cword[3],out trash);
                    if (result & result2 == true)
                    {
                        varNames[cword[1]] = DoOps(trash,garbo,cword[4]);
                       
                    }
                    else if(result == false && result2 == false)

                    {
                        varNames[cword[1]] = DoOps(varNames[cword[3]],varNames[cword[5]],cword[4]);
               
                    }
                    else if (result == true && result2 == false)
                    {
                        varNames[cword[1]] = DoOps(trash,varNames[cword[5]],cword[4]);
                    }
                     else if (result == false && result2 == true)
                    {
                        varNames[cword[1]] = DoOps(varNames[cword[3]],garbo,cword[4]);
                    }



                
                
                }
                else if (cword[0] == "print")
                {
                    if (cword[1] == "all")
                    {
                        foreach (var item in varNames)
	                    {
                            Console.WriteLine(item.Key + " = "+ item.Value);
	                    }

                        
                    }
                    else
                    {
                        Console.WriteLine(varNames[cword[1]]);
                    }
                }

                else if(cword[0] != "set")
                {
                    Console.WriteLine("Unkown command " + command);
                }
            }
        }

        static int DoOps(int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "/":
                    return a / b;
                case "*":
                    return a * b;
                default:
                    throw new ArgumentException("op");
                
            }
        }

    }
}

