using CyberSecurityAwarenessBot;
using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public static class Chatbot
    {   // Main method to start the conversation loop
        public static void StartConversation()
        {
            UiHelper.PrintBorder();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello, {Program.UserName}! I'm your Cybersecurity Awareness Assistant.");
            Console.WriteLine("I can help you with phishing, passwords, safe browsing, 2FA and more.\n");
            Console.ResetColor();

            Console.WriteLine("Type 'exit' or 'quit' to end the chat.\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{Program.UserName}: ");
                string input = Console.ReadLine()?.Trim().ToLower();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    UiHelper.ShowDefaultResponse("I didn't quite understand that. Could you please rephrase?");
                    continue;
                }

                if (input == "exit" || input == "quit")
                    break;

                string response = ResponseHandler.GetResponse(input, Program.UserName);
                UiHelper.TypeText(response, 25);
                Console.WriteLine("\n");
                UiHelper.PrintBorder();
            }
        }
    }
}