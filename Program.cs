using System;
using System.Media;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    internal class Program
    {
        private static string userName = "Friend";
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Assistant - South Africa";
            UiHelper.PrintHeader();

            PlayVoiceGreeting();
            UiHelper.DisplayAsciiArt();
            UiHelper.ShowWelcomeMessage();

            GetUserName();
            CybersecurityAwarenessBot.Chatbot.StartConversation();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot. Stay safe online!");
            Console.ResetColor();
        }

        private static void PlayVoiceGreeting()
        {
            try
            {
                using (var player = new SoundPlayer("greeting.wav"))
                {
                    player.PlaySync();   // Waits for the audio to finish
                }
            }
            catch
            {
                UiHelper.ShowWarning("Voice greeting file not found. Continuing with text only.");
            }
        }

        private static void GetUserName()
        {
            UiHelper.PrintBorder();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ResetColor();
            userName = Console.ReadLine()?.Trim() ?? "Friend";
            if (string.IsNullOrWhiteSpace(userName)) userName = "Friend";
        }

        public static string UserName => userName; // Used by Chatbot class
    }
}

