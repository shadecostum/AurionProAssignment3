using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureIsland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Treasure Island your mission is to find the teasure");
            Console.WriteLine("choose Left or Right");
            string choose1 = Console.ReadLine().ToLower(); 

            SwitchEx(choose1);
        }
            static void SwitchEx(string choosen)
            {
               
                
                switch (choosen)
                {
                    case "left":
                    Console.WriteLine("Swim or Wait");
                    string choose2=Console.ReadLine().ToLower();
                    switch (choose2)
                    {
                        case "wait":
                            Console.WriteLine("Yellow,red,blue,anything");
                            string color = Console.ReadLine().ToLower();
                            switch (color)
                            {
                                case "yellow":
                                    Console.WriteLine(" You Win 1CR cash");
                                    break;
                                case "red":
                                    Console.WriteLine("Burned by fire ------Game over------");
                                    break;
                                case "green":
                                    Console.WriteLine("Eaten by beast ------Game over------");
                                    break;
                                default:
                                    Console.WriteLine("------Game over------");
                                    break;

                            }
                            break;
                        case "swim":
                            Console.WriteLine("Attacked by trout \n ------Game over------");
                            break;
                        default:
                            Console.WriteLine("------Game over------");
                            break;

                    }
                        break;
                    case "right":
                        Console.WriteLine("Fall into a hole -----Game over-----");
                        break;
                    
                    default:
                        Console.WriteLine("------Game over--------");
                        break;
                }
            }
    }
}
