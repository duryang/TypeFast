using System;

namespace TypeFast
{
    static class Repl
    {
        private static bool loopDone = false;

        private static string help = "Available commands:\n" +
            "'start' - start a new game\n" +
            "'quit' - exit the app";

        private static string info = "Unrecognized command\n" +
            "Type 'help' for available commands";

        public static void Run()
        {
            while (!loopDone)
            {
                Console.Write("-> ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "start":
                    case "s":
                        Game game = new Game();
                        game.Start();
                        break;

                    case "quit":
                    case "q":
                        loopDone = true;
                        break;

                    case "help":
                    case "h":
                    case "commands":
                        PrintMessage(help);
                        break;


                    default:
                        PrintMessage(info);
                        break;
                }
            }
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine('\n' + message + '\n');
        }
    }
}
