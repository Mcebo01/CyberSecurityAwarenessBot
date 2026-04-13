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
            //Foreground color is set to dark gray for the closing message, and then reset to default after displaying the message.
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot. Stay safe online!");
            Console.ResetColor();
        }
        //voice greeting method 
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
            {   //if there is an issue with the audio file, it will catch the exception and show a warning message
                UiHelper.ShowWarning("Voice greeting file not found. Continuing with text only.");
            }
        }
        //method to get the user's name, it will prompt the user to enter their name and store it in the userName variable. If the user does not enter a name, it defaults to "Friend".
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

