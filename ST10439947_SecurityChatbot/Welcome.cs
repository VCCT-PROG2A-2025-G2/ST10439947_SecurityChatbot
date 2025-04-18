//==================================================================================/
/*
 * Amelia Swart
 * ST10439947
 * POE - Part 1: Security Chatbot
 */
//----------------------------------------------------------------------------------/
/* Reference List:
 * Start Up Sound:
 * https://www.youtube.com/watch?v=e6fDjYtbsCY
 * (Lines 61-67)
 * Spectre console for the figlet fonts, loading bars, & colours:
 * https://spectreconsole.net/
 * (Lines 49, 50, 72-86, 92-110)
 * ASCII Font for "Welcome to":
 * https://github.com/xero/figlet-fonts/blob/master/Graceful.flf
 * (Lines 49, 74)
 * ASCII Font for "CyberMiku":
 * https://github.com/xero/figlet-fonts/blob/master/Basic.flf
 * (Line 50, 78)
 */
//----------------------------------------------------------------------------------/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;

//---------------------------------------------------------------------------------/
namespace ST10439947_SecurityChatbot
{
    //---------------------------------------------------------------------------------/
    //this class holds the welcome sequence for the chatbot
    internal class Welcome
    {
        //---------------------------------------------------------------------------------/
        //default constructor
        public Welcome()
        {
        }

        //---------------------------------------------------------------------------------/
        //creates instance variables for the 3 ascii art strings
        #region Instance Variables
        //loads the figlet font for the titles
        public FigletFont graceFont = FigletFont.Load("fonts/Graceful.flf");
        public FigletFont basicFont = FigletFont.Load("fonts/Basic.flf");

        //calls the random class to generate random numbers
        Random rand = new Random();

        #endregion
        //---------------------------------------------------------------------------------/
        //this is the welcome sequence that is called when the program starts
        //it will play the startup sound and display the welcome message
        public void WelcomeSequence()
        {
            //get file path play the startup sound
            var path = "Sounds\\start.wav"; ;
            SoundPlayer startUpNoise = new SoundPlayer(path);
            //load the sound
            startUpNoise.Load();
            //play the sound
            startUpNoise.Play();

            //set the console window position
            Console.SetWindowPosition(0, 0);

            //write the welcome message to the console using the figlet font
            AnsiConsole.Write(
                new FigletText(graceFont, "Welcome to")
                    .Centered()
                    .Color(Color.Turquoise2));
            AnsiConsole.Write(
                new FigletText(basicFont, "\nCyberMiku!")
                    .Centered()
                    .Color(Color.Turquoise2));

            //call the ASCII class to load the ASCII art
            var ascii = new ASCII();

            //load the ASCII art
            ascii.LoadAscii();
            Console.Write(ascii.Welcome);

            //--------------------------------------------------/
            //this is the loading animation
            //it will show a spinner and a few messages which show up using a random delay
            AnsiConsole.Status()
                .Spinner(Spinner.Known.Star2)
                .Start("Loading...", ctx =>
                {
                    AnsiConsole.MarkupLine("[cyan]\nCatching Bugs...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[cyan]Trolling Scammers...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[cyan]Gone Phishing...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[cyan]Hacking the Matrix...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[cyan]Encrypting messages...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));
                });
            //--------------------------------------------------/
            Console.Clear();

            //create an instance of the ChatBot class
            //this will call the SetLayout method which will display the title and subtitle
            var chat = new ChatBot();
            chat.SetLayout();
        }

        //---------------------------------------------------------------------------------/
    }
}
//==================================================================================/