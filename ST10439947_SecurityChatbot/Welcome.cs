//==================================================================================/
/*
 * Amelia Swart
 * ST10439947
 * POE - Part 1: Security Chatbot
 */
//----------------------------------------------------------------------------------/
/* Reference List:
 * Start Up Sound: https://www.youtube.com/watch?v=e6fDjYtbsCY
 * Spectre console for the figlet fonts, loading bars, & colours https://spectreconsole.net/
 * (Line [ENTER])
 *ASCII Font for "CyberMiku" - https://github.com/xero/figlet-fonts/blob/master/Basic.flf
 * (Line [ENTER])
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
    internal class Welcome
    {
        //---------------------------------------------------------------------------------/
        //default constructor
        public Welcome()
        {
        }

        //---------------------------------------------------------------------------------/

        #region Instance Variables

        public FigletFont graceFont = FigletFont.Load("fonts/Graceful.flf");
        public FigletFont basicFont = FigletFont.Load("fonts/Basic.flf");

        Random rand = new Random();

        #endregion
        //---------------------------------------------------------------------------------/
        public void WelcomeSequence()
        {
            //get file path play the startup sound
            var path = "Sounds\\start.wav"; ;
            SoundPlayer startUpNoise = new SoundPlayer(path);
            startUpNoise.Play();

            //set the console window position
            Console.SetWindowPosition(0, 0);
            //call the ASCII class to load the ASCII art
            var ascii = new ASCII();

            //write the welcome message to the console using the figlet font
            AnsiConsole.Write(
                new FigletText(graceFont, "Welcome to")
                    .Centered()
                    .Color(Color.Turquoise2));
            AnsiConsole.Write(
                new FigletText(basicFont, "\nCyberMiku!")
                    .Centered()
                    .Color(Color.Turquoise2));

            //load the ASCII art
            ascii.LoadAscii();
            Console.Write(ascii.Welcome);

            //this is the loading animation
            //it will show a spinner and a few messages which show up using a random delay
            AnsiConsole.Status()
                .Spinner(Spinner.Known.Star2)
                .Start("Loading...", ctx =>
                {
                    AnsiConsole.MarkupLine("[teal]\nCatching Bugs...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[teal]Trolling Scammers...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[teal]Gone Phishing...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[teal]Hacking the Matrix...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));

                    AnsiConsole.MarkupLine("[teal]Encrypting messages...[/]");
                    Thread.Sleep(1000 + rand.Next(2000));
                });
            Console.Clear();

            var chat = new ChatBot();
            chat.SetLayout();
        }

        //---------------------------------------------------------------------------------/
    }
}
//==================================================================================/