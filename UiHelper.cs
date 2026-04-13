using System;
using System.Drawing;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    public static class UiHelper
    {
        public static void PrintHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("══════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("                  CYBERSECURITY AWARENESS ASSISTANT");
            Console.WriteLine("                       Protecting South Africa");
            Console.WriteLine("══════════════════════════════════════════════════════════════════════════════");
            Console.ResetColor();
        }
        // Method to display ASCII art from an image file
        public static void DisplayAsciiArt()
        {
            string path = "logo.jpg";

            if (!System.IO.File.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[WARNING] logo.jpg not found. Using fallback ASCII art.");
                Console.ResetColor();
                DisplayFallbackAsciiArt();
                return;
            }

            // Your original code adjusted and improved
            Bitmap image = new Bitmap(path);

            // Resize for perfect console fit
            int width = 80;  // ideal width for console
            int height = (int)(image.Height * (width / (double)image.Width) * 0.55); // fixes tall console characters

            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            string asciiChars = "@#S%?*+;:,. ";

            Console.ForegroundColor = ConsoleColor.Cyan;  // makes the logo look premium

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
        // Fallback ASCII art if the image file is missing
        private static void DisplayFallbackAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" CYBER SHIELD - STAY SAFE ONLINE");
            Console.ResetColor();
        }

        public static void ShowWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I'm here to help South African citizens stay safe online.\n");
            Console.ResetColor();
        }

        public static void PrintBorder()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("══════════════════════════════════════════════════════════════════════════════");
            Console.ResetColor();
        }

        public static void ShowWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] {message}");
            Console.ResetColor();
        }

        public static void ShowDefaultResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeText(message, 30);
            Console.ResetColor();
        }

        public static void TypeText(string text, int delayMs)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
        }
    }
}