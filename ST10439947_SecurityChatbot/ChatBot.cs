//==================================================================================/
/*
 * Amelia Swart
 * ST10439947
 * POE - Part 1: Security Chatbot
 */
//-----------------------------------------------------------------------------------/
/*Reference List:
 *ASCII Font for "CyberMiku" - https://github.com/xero/figlet-fonts/blob/master/Basic.flf
 * (Line [ENTER])
 *Spectre console for the figlet fonts, loading bars, & colours https://spectreconsole.net/
 * (Line [ENTER])
 */
//-----------------------------------------------------------------------------------/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

//----------------------------------------------------------------------------------/
namespace ST10439947_SecurityChatbot
{
    internal class ChatBot
    {
        public ChatBot()
        {
            //default constructor
        }

        //---------------------------------------------------------------------------------/
        //creates instance variables for the 3 ascii art strings
        #region Instance Variables

        public FigletFont basicFont = FigletFont.Load("fonts/Basic.flf");
        public string Name = "";

        #endregion

        //---------------------------------------------------------------------------------/
        //loads the ASCII art from the text files and displays the title and subtitle
        public void SetLayout()
        {
            var grid = new Grid();
            grid.AddColumn();
            grid.AddColumn();

            grid.AddRow(
                new FigletText(basicFont,"CyberMiku").Color(Color.Turquoise2), 
                new Panel(new Markup("[mediumpurple1 bold]\nYOUR PERSONAL\nCYBER-SECURITY\nCHATBOT.\n[/]"))
                 {
                    Border = BoxBorder.None,
                    Padding = new Padding(0, 0, 26, 0),
                }
            );

            AnsiConsole.Write(grid);

            AskQuestion();

        }
        //---------------------------------------------------------------------------------/
        private void AskQuestion()
        {
            //ask user for their name
            AnsiConsole.MarkupLine("[cyan]CyberMiku:[/] What is your name?");
            Name = AnsiConsole.Ask<string>("[mediumpurple1]Enter your name: [/]");
            //checks if the name is empty or contains numbers
            while (string.IsNullOrWhiteSpace(Name) || Name.Any(char.IsDigit))
            {
                AnsiConsole.MarkupLine("[red]Invalid name. Please enter a valid name.[/]");
                Name = AnsiConsole.Ask<string>("[mediumpurple1]Enter your name: [/]");
            }
            AnsiConsole.MarkupLine($"[cyan]CyberMiku:[/] Hello, {Name}! How can I assist you today?");
        }

    }
}
//==================================================================================/