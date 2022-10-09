




/*                              USEFUL CODE
 




int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.CursorTop = Console.WindowTop + Console.WindowHeight - 1;
        Console.Write(text);
        // Restore previous position
        Console.SetCursorPosition(x, y);






*/











using System;
using System.Threading;

namespace xhyaOne_
{
    class Program
    {

        public static class Globals
            {

                

                public static string[] methodArr = { "none", "admin", "owner", "??" };
                public static string userN = Environment.UserName;
                public static string pcN = Environment.MachineName;
                public static string method;

                public static string lineReader;
            
            }

        public class ConsoleSpinner
        {
            int counter;

            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {   
                    case 0: Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("/"); counter = 0; break;
                    case 1: Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("-"); break;
                    case 2: Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\\"); break;
                    case 3: Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("|"); break;
                }
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }



        // ------------------- ERRORS ------------------------



        public class error
        {
            public void NL()
            {
                var mgmt = new mgmt();
                mgmt.NewLine();
            }

            public void er()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("[ERROR]");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" :: ");
            }

            public void value()
            {
                                var newL = Environment.NewLine;
                er();
                Console.Write("value error");
                Console.WriteLine(newL);
                NL();
            }

            public void badCmd()
            {
                er();
                Console.Write("unhandled command [ check for typos");
                NL();
            }



        }

        public class mgmt
        {

            public void intro()
            {
                        
                var mgmt = new mgmt();
                var newL = Environment.NewLine;
                var spin = new ConsoleSpinner();
                var error = new error();

            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.Title = "xhyaOne";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("             xhyaOne");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("   -v0_1b");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("   -by @xhyabunny");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(newL);
            Globals.method = Globals.methodArr[0];
                

            }


            public void Cleanse()
            {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(Globals.userN + "@" + Globals.pcN);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" " + Globals.method);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" / ");

            NewLine();

            }

            public void newFullLine()
            {

           
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(Globals.userN + "@" + Globals.pcN);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" " + Globals.method);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" / ");

            NewLine();

            }

            public void NewPrompt()
            {
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("$ ");

            }

            public void NewLine()
            {
                
            var mgmt = new mgmt();
                            
            
            
            mgmt.NewPrompt();

            var readLine = Console.ReadLine();

            Globals.lineReader = readLine.ToString();

            mgmt.commandHandle();

            }




            // ------------------------- COMMAND HANDLER --------------------------





            public void commandHandle()
            {

                

                var mgmt = new mgmt();
                var newL = Environment.NewLine;
                var spin = new ConsoleSpinner();
                var error = new error();


                         if (Globals.lineReader.StartsWith("method"))
                         {
                    
                               var splitLine1 = Globals.lineReader.Split(' ');

                                   if (splitLine1.Length == 2)
                                   {

                                            switch (splitLine1[1])
                                            {
                                                case "0":
                                                    Globals.method = Globals.methodArr[0];
                                                        Console.WriteLine(Globals.method);
                                                        
                                                        

                                                        mgmt.newFullLine();
                                                    break;
                                                case "1":
                                                    Globals.method = Globals.methodArr[1];
                                                        Console.WriteLine(Globals.method);

                                                                                

                                                        mgmt.newFullLine();
                                                    break;
                                                case "2":
                                                    Globals.method = Globals.methodArr[2];
                                                        Console.WriteLine(Globals.method);



                                                        mgmt.newFullLine();
                                                    break;
                                                case "3":
                                                    Globals.method = Globals.methodArr[3];
                                                        Console.WriteLine(Globals.method);


                                                        mgmt.newFullLine();
                                                    break;
                                                case "h":
                                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                                    Console.Write("command: method,\nusage: ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.Write("method ");
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("n ");
                                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                                    Console.Write("<< 'n' represents a number from 0 to 3");
                                                    Console.WriteLine();

                                                        mgmt.NewLine();
                                                        
                                                    break;

                                                default: 
                                                        error.value();
                                                    break;
                                            }

                                   }
                                   else
                                   {
                                        error.value();
                                   }



                         } else if (Globals.lineReader.StartsWith("ohio"))

                         {
                             Console.WriteLine("yes");
                             mgmt.NewLine();
                         }
                         else
                         {
                             error.badCmd();
                         }
            
            
            }

        }


        // --------------------------------- APP START ----------------------------------

        

        static void Main(string[] args)
        {
           

           
                var mgmt = new mgmt();
                var newL = Environment.NewLine;
                var spin = new ConsoleSpinner();
                var error = new error();
            
            
            

            Console.BackgroundColor
            = ConsoleColor.Green;

            Console.Write("Working... ",
            Console.BackgroundColor);

            for (int i = 0; i < 8; ++i)
            {
                spin.Turn();
            }



            mgmt.intro();
            

            Console.ReadKey();
            
                
                mgmt.Cleanse();
                mgmt.NewLine();
            
            

        }

    }

}
