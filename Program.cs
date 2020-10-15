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
                        

                   if(cword.Length == 4){
                        int trash = 0;
                        bool result = int.TryParse(cword[3],out trash);
                        if (result == true)
                        {
                            array1[varNames[cword[1]]] = trash;
                            Console.WriteLine("Variable " + cword[1]+ " now has the value " + array1[varNames[cword[1]]]);


                        }
                        else
                        {
                            array1[varNames[cword[1]]] = array1[varNames[cword[3]]];
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
                            switch (cword[4])
                            {
                            case "+":
	                         array1[varNames[cword[1]]] = trash + garbo;
                                break;
                            case "-":
                             array1[varNames[cword[1]]] = trash - garbo;
                                break;
                            case "/":
                             array1[varNames[cword[1]]] = trash/garbo;
                                break;
                            case "*":
                             array1[varNames[cword[1]]] = trash * garbo;
                                break;
                            default:
                                throw new ArgumentException("op");
                                }
                           }
                           else if(result == false && result == false)
                        {
                                        switch (cword[4])
                            {
                            case "+":
	                         array1[varNames[cword[1]]] = array1[varNames[cword[3]]] + array1[varNames[cword[5]]];
                                break;
                            case "-":
                             array1[varNames[cword[1]]] = array1[varNames[cword[3]]] - array1[varNames[cword[5]]];
                                break;
                            case "/":
                             array1[varNames[cword[1]]] = array1[varNames[cword[3]]] / array1[varNames[cword[5]]];
                                break;
                            case "*":
                             array1[varNames[cword[1]]] = array1[varNames[cword[3]]] * array1[varNames[cword[5]]];
                                break;
                            default:
                                throw new ArgumentException("op");
                                }   
                    }



                
                
                        }
                else if (cword[0] == "print")
                {
                    if (cword[1] == "all")
                    {
                        
                        Console.WriteLine("a = "+array1[0]);
                        Console.WriteLine("b = "+ array1[1]);
                        Console.WriteLine("c = "+ array1[2]);
                        Console.WriteLine("d = "+ array1[3]);
                        Console.WriteLine("e = "+ array1[4]);
                        
                    }
                    else
                    {
                        Console.WriteLine(array1[varNames[cword[1]]]);
                    }
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

