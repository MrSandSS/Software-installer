using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Software_installer
{
    internal class Program
    {
            
        public static void Main(string[] args)
        {
            
            Console.WriteLine("A quick installer of the necessary programs");
            Console.WriteLine("Type anything to continue ");
            Console.WriteLine("Type info to more information ");
            string cont = Console.ReadLine();

            if (cont == "info")
            {
                Console.Clear();
                Console.WriteLine("all installations are downloaded using WinGet. Drivers for the graphics card are installed from the Russian domains of official hardware suppliers (there is no automatic installation of drivers on the graphics card)");
                Console.WriteLine("Non-current programm versions may be installed. For an update request, write to the email MrSandSS@outlook.com");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Thread.Sleep(400);
                Console.WriteLine("Type anything to continue");
                string infonextmethod = Console.ReadLine();
                if (infonextmethod == "info")
                {
                    Console.WriteLine("bruh why did you write Info again ^_-");
                    GraphicsDriver(args);
                }

                Main(args);

            } else
            {
                var osver = Environment.OSVersion;

                Console.WriteLine("Checking System Requirements");
                Thread.Sleep(2000);
                Console.WriteLine("Found supported version " + osver);
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Don't forget put SimpleSoftwareInstaller folder to C: folder ");
                Thread.Sleep(1500);

                GraphicsDriver(args);
            }

        }
        
        //public static void activation(bool activation)
        //{
        //    if (activation == false)
        //    {
        //        Console.WriteLine("false");
        //    }
        //    else { Console.WriteLine("s"); }
        //}
        //static void wingetcheck(string[] args)
        //{
        //    Console.WriteLine("Programm using winget to install most of programms.");
        //}

        static void GraphicsDriver(string[] args)
        {
            Console.WriteLine("Install graphics card driver? (type yes or no)");
            string VideoCardDriver = Console.ReadLine();

            switch (VideoCardDriver)
            {
                case "yes":
                    Console.WriteLine("Enter the maker of the graphics card (nvidia ir amd. intel is not supported yet)");
                    string stringgraphicsdriver = Console.ReadLine();

                    switch (stringgraphicsdriver)
                    {
                        case "nvidia":
                            string nvidiapath = "https://ru.download.nvidia.com/GFE/GFEClient/3.28.0.417/GeForce_Experience_v3.28.0.417.exe";

                            Console.WriteLine("Downloading Nvidia GeForce Experience ");
                            Process.Start(nvidiapath);
                            Archivator(args);
                            break;

                        case "amd":
                            string amdpath = "https://www.amd.com/en/support/download/drivers.html";

                            Console.WriteLine("AMD does not support installing software outside AMD.com. Please install AMD Software: Adrenalin Edition directly from the AMD website");
                            Archivator(args);
                            break;
                        default:
                            Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                            Thread.Sleep(2000);
                            break;
                    }
                    break;


            case "no":
                    Console.WriteLine("no");
                    Archivator(args);
                    break;

            }
        }

        static void Archivator(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Install winrar or 7zip? *type no to skip this part*");
            string stringarchivator = Console.ReadLine();
            if (stringarchivator == "winrar")
            {
                string winrarpath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\winrar.ps1";
                Console.WriteLine();
                Process.Start(winrarpath);
                gamelauncherchoose(args);
            }

            else if (stringarchivator == "7zip")
            {
                string sevenzippath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\7zip.ps1";
                Process.Start(sevenzippath);
                gamelauncherchoose(args);
            }
            else if (stringarchivator == "skip")
            {
                gamelauncherchoose(args);
            } else
            {
                Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                Thread.Sleep(2000);
            }


        }
        static void gamelauncherchoose(string[] args)
        {
            Console.WriteLine("Install game launcher? (yes or no)");
            string stringgamelaucher = Console.ReadLine();
            if (stringgamelaucher == "yes")
            {
                gamelaucher(args);
            }
            else if (stringgamelaucher == "no")
            {
                discord(args);
            } else
            {
                Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                Thread.Sleep(2000);
            }
        }

        static void gamelauncherreturn(string[] args)
        {
            gamelaucher(args);
        }
        

        static void gamelaucher(string[] args)
        {
            Console.WriteLine("Type 1 if you want to download Steam ");
            Console.WriteLine("Type 2 if you want to download Epic Games Store ");
            Console.WriteLine("Type 3 if you want to download GOG Galaxy");  
            Console.WriteLine("Type skip to skip ");
            string stringgamelauncherchoose = Console.ReadLine();

            if(stringgamelauncherchoose == "1") 
            {
                string steampath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\steam.ps1";
                Process.Start(steampath);
                gamelauncherreturn(args);
            }
            else if(stringgamelauncherchoose == "2")
            {
                string epicgamespath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\epicgames.ps1";
                Process.Start(epicgamespath);
                gamelauncherreturn(args);
            }   
            else if(stringgamelauncherchoose == "3")
            {
                string gogpath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\gog.ps1";
                Process.Start(gogpath);
                gamelauncherreturn(args);
            }
            else if ((stringgamelauncherchoose == "skip"))
            {
                discord(args);
            } else
            {
                Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                Thread.Sleep(2000);
            }

        }

        static void discord(string[] args)
        {
            Console.WriteLine("Install discord? (yes or no)");
            string stringdiscord = Console.ReadLine();
            if(stringdiscord == "yes")
            {
                string discordpath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\discord.ps1";
                Process.Start(discordpath);
                telegram(args);
            }
            else if ((stringdiscord == "no"))
            {
                telegram(args);
            } else
            {
                Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                Thread.Sleep(2000);
            }
        }

        static void telegram(string[] args)
        {
            Console.WriteLine("Install Telegram? (yes or no)");
            string telegram = Console.ReadLine();
            if(telegram == "yes")
            {
                string telegrampath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\telegram.ps1";
                Process.Start(telegrampath);
                chrome(args);
            }
            else if((telegram == "no"))
            {
                chrome(args);
            } else
            {
                Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                Thread.Sleep(2000);
            }
        }

        static void chrome(string[] args)
        {
            Console.WriteLine("Install chrome? (yes or no)");
            string chrome = Console.ReadLine();
            if (chrome == "yes")
            {
                string chromepath = "C:\\SimpleSoftwareInstaller\\WGFiles\\Install Scripts\\chrome.ps1";
                Process.Start(chromepath);
                end(args);
            }
            else if (chrome == "no")
            {
                end(args);
            } else
            {
                Console.WriteLine("Error! You have entered an incorrect argument. The program will be closed. Error code: 1");
                Thread.Sleep(2000);
            }
        }








        
        static void end(string[] args)
        {
            Console.WriteLine("You have installed all the added programs. With further updates of the program, I will add more and more programs.");
            Thread.Sleep(5000);
        }
    }
}

