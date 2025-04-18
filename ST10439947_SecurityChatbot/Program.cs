//==================================================================================/
/*
 * Amelia Swart
 * ST10439947
 * POE - Part 1: Security Chatbot
 */
//-----------------------------------------------------------------------------------/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
//---------------------------------------------------------------------------------/
namespace ST10439947_SecurityChatbot
{
    //---------------------------------------------------------------------------------/
    //this is the main class for the program 
    internal class Program
    {
        //---------------------------------------------------------------------------------/
        //this is the main method that starts the program
        private static void Main(string[] args)
        {
            //creates an instance of the Welcome class
            var welcome = new Welcome();
            //calls the welcome sequence method to display the welcome message
            welcome.WelcomeSequence();
        }
        //---------------------------------------------------------------------------------/
    }
}
//==================================================================================/