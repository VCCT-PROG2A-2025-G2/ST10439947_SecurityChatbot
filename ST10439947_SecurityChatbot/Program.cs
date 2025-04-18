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
    internal class Program
    {
//---------------------------------------------------------------------------------/
        private static void Main(string[] args)
        {
            var welcome = new Welcome();
            welcome.WelcomeSequence();
        }
    }
}
//==================================================================================/