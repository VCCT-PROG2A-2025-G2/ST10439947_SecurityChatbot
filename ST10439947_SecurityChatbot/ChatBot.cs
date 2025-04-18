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
 * ChatGPT - for one line where I needed to delete the spinner line after it showed as it simulated typing - 
 * https://chatgpt.com/ (Lines [ENTER])
 */
//-----------------------------------------------------------------------------------/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;

//----------------------------------------------------------------------------------/
namespace ST10439947_SecurityChatbot
{
    internal class ChatBot
    {
        //---------------------------------------------------------------------------------/
        public ChatBot()
        {
            //default constructor
        }
        //---------------------------------------------------------------------------------/
        //creates instance variables
        #region Instance Variables

        //loads the figlet font for the title 
        public FigletFont basicFont = FigletFont.Load("fonts/Basic.flf");

        //creates the instance variables for the name and question that the user enters
        public string Name = "";
        public string Question = "";

        //calls the random class to generate random numbers
        Random rand = new Random();

        #endregion
        //---------------------------------------------------------------------------------/
        //creates the layout for the title and subtitle and displays it in the console
        public void SetLayout()
        {
            //creates a grid layout for the title and subtitle
            var grid = new Grid();
            grid.AddColumn();
            grid.AddColumn();

            
            grid.AddRow(
                //adds the title using the figlet font and using the color turquoise2
                new FigletText(basicFont,"CyberMiku").Color(Color.Turquoise2),
                //adds the subtitle using Markup and using the color mediumpurple1
                new Panel(new Markup("[mediumpurple1 bold]\nYOUR PERSONAL\nCYBER-SECURITY\nCHATBOT.[/]"))
                 {
                    //creates a border around the panel and adds padding
                    //this is used to set where the text is in the panel
                    Border = BoxBorder.None,
                    Padding = new Padding(0, 0, 26, -1),
                }
            );

            //adds the grid to the console
            AnsiConsole.Write(grid);

            //
            AnsiConsole.Markup("[turquoise2]Type 'help' to see the commands, or type 'What can I ask you about?'.\n[/]");

            //creates a line under the title and subtitle
            //this uses the Spectre.Console library
            var rule = new Rule();
            rule.Style = new Style(Color.Cyan1);
            AnsiConsole.Write(rule);

            //checks if user has already entered their name
            //this is for when the user clears the screen
            if (string.IsNullOrWhiteSpace(Name))
            {
                //if not, call the Introduce method
                Introduce();
            }
            else
            {
                //asks the user if they have any other questions
                AnsiConsole.MarkupLine($"\n[cyan]CyberMiku:[/] Do you have any other questions today, {Name}?");
                //if they have, call the Questions method
                Questions();
            }

        }
        //---------------------------------------------------------------------------------/
        //introduces the chatbot and asks for the user's name
        private void Introduce()
        {
            //introduces the chatbot
            AnsiConsole.MarkupLine("\n[cyan]CyberMiku:[/] Hi there! I'm CyberMiku, " +
                                   "your personal cyber-security chatbot.");

            //ask user for their name 
            AnsiConsole.MarkupLine("[cyan]CyberMiku:[/] What is your name?");

            //gets the user's name
            Name = AnsiConsole.Ask<string>("[mediumpurple1]Enter your name: [/]");

            //checks if the name is empty or contains numbers
            while (string.IsNullOrWhiteSpace(Name) || Name.Any(char.IsDigit))
            {
                //if it is, display an error message and ask for the name again
                AnsiConsole.MarkupLine("[red]Invalid name. Please enter a valid name.[/]");
                Name = AnsiConsole.Ask<string>("[mediumpurple1]Enter your name: [/]");
            }

            //asks the user how they can help
            AnsiConsole.MarkupLine($"[cyan]CyberMiku:[/] Hello, {Name}! How can I assist you today?");

            //calls the Questions method to start the conversation
            Questions();
        }

        //---------------------------------------------------------------------------------/
        //this method handles the questions and responses
        private void Questions(){
            //calls the Responses class to get the questions and responses
            var qna = new Reponses();

            //allows user to enter questions, compares the questions to the question list,
            //and gives them the related response
            while (true)
            {
                //asks the user for a question
                Question = AnsiConsole.Ask<string>($"[mediumpurple1]{Name}: [/]");

                //checks if the question is empty
                if (string.IsNullOrWhiteSpace(Question))
                {
                    //if it is, display an error message and ask for the question again
                    AnsiConsole.MarkupLine("[red]Please enter a valid question.[/]");
                    continue;
                }

                //this makes it look like the user is typing before the response is displayed
                //this is done by using a random delay & using the spinner from spectre console
                //sets color of spinner to paleturquoise4
                //after it deletes just the spinner
                AnsiConsole.Status()
                    .Spinner(Spinner.Known.Star2)
                    .SpinnerStyle(new Style(Color.PaleTurquoise4))
                    .Start("Typing...", ctx =>
                    {
                        //random delay between 1.5 and 3 seconds
                        Thread.Sleep(rand.Next(1500, 3000));
                    });


                //checks if any of the question phrases are in the user input & displays linked response
                //adds the user's name to the response
                //checks if the user wishes to exit
                if (qna.Questions.Any(q => Question.ToLower().Contains(q)))
                {
                    //finds the index of the question in the list
                    int index = Array.FindIndex(qna.Questions, q => Question.ToLower().Contains(q));
                    //gets the response from the responses list using the index
                    string response = qna.Responses[index];

                    //plays random idle sound to simulate the chatbot thinking and talking
                    var path = $"Sounds\\idle{rand.Next(1, 4)}.wav";
                    SoundPlayer idleSound = new SoundPlayer(path);
                    idleSound.Load();
                    idleSound.Play();

                    //adds the user's name to the response
                    if (response.Contains("{Name}"))
                    {
                        response = response.Replace("{Name}", Name);
                    }

                    //displays the response in the console
                    AnsiConsole.MarkupLine($"[cyan]CyberMiku:[/] {response}");
                }
                //checks if the user needs help
                else if (Question.ToLower() == "help")
                {
                    //displays the help message
                    AnsiConsole.MarkupLine("[cyan]CyberMiku:[/] Type 'exit' or 'quit' to leave the chat, " +
                                           "'clear' to clear the screen, or 'What can I ask you about?'.");
                }
                //checks if the user wants to clear the screen
                else if (Question.ToLower() == "clear")
                {
                    //clears the screen
                    Console.Clear();
                    //displays the title and subtitle again
                    SetLayout();
                }
                //checks if the user wants to exit
                else if (Question.ToLower() == "exit" || Question.ToLower() == "quit")
                {
                    //calls the exit method
                    Exit();
                }
                else
                {
                    //plays random idle sound to simulate the chatbot thinking and talking
                    var path = $"Sounds\\idle{rand.Next(1, 4)}.wav";
                    SoundPlayer idleSound = new SoundPlayer(path);
                    idleSound.Load();
                    idleSound.Play();

                    //if the question is not found in the list, display a default message
                    AnsiConsole.MarkupLine($"[red]Sorry, I didn't quite understand that, {Name}. " +
                                           "Could you please rephrase?[/]");
                }

            }
        }
        //---------------------------------------------------------------------------------/
        //displays the exit message
        private void Exit()
        {
            //clears the screen
            Console.Clear();

            //displays the exit message 
            AnsiConsole.MarkupLine("[cyan]CyberMiku:[/] Thank you for chatting with me today, " +
                                   $"{Name}. \nI hope you learned something new about cybersecurity!");

            //call the ASCII class to load the ASCII art
            var ascii = new ASCII();
            //load the ASCII art
            ascii.LoadAscii();
            Console.Write(ascii.Goodbye);

            //plays the exit sound
            var path = "Sounds\\exit.wav";
            SoundPlayer exitSound = new SoundPlayer(path);
            exitSound.Load();
            exitSound.Play();

            //wait for the sound to finish playing
            Thread.Sleep(2000);
            //exit the program
            Environment.Exit(0);
        }
        //---------------------------------------------------------------------------------/
    }
}
//==================================================================================/