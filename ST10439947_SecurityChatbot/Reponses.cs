//====================================================================================/
/*
 * Amelia Swart
 * ST10439947
 * POE - Part 1: Security Chatbot
 */
//-----------------------------------------------------------------------------------/
/*Reference List:
 * I asked ChatGPT to give me examples of cybersecurity questions and answers:
 * https://chatgpt.com/ (Lines [ENTER])
 */
//-----------------------------------------------------------------------------------/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

//------------------------------------------------------------------------------------/
namespace ST10439947_SecurityChatbot
{
    //-----------------------------------------------------------------------------------/
    internal class Reponses
    {
        //---------------------------------------------------------------------------------/
        //default constructor
        public Reponses()
        {
            //default constructor
        }
        //---------------------------------------------------------------------------------/
        //All Cybersecurity facts/responses in a list/array
        public String[] Responses = new String[]
        {
            "Hello {Name}, I'm doing great! Thanks for asking! ",
            "You can ask me about, cybersecurit topics like phishing, malware, viruses, passwords and more!",
            "I'm here to help you, {Name}, learn about cybersecurity and stay safe online.",
            "Well {Name}, Cybersecurity is the protection of computers, networks, " +
            "and data from attacks or unauthorized access.",
            "Phishing is when scammers trick you into giving away personal info, " +
            "usually through fake emails or messages.",
            "Ransomware locks your files and asks for money to unlock them, so stay safe {Name}!",
            "Malware is any harmful software made to damage or steal information from your device. " +
            "Stay protected, {Name}.",
            "Spyware secretly watches what you do and can steal your passwords or personal data.",
            "Pharming redirects you to fake websites that look real so attackers can steal your info. " +
            "Always double-check those URLs, {Name}.",
            "A firewall blocks unwanted access to your network or computer, " +
            "keeping the bad stuff out, {Name}.",
            "Antivirus software helps detect and stop harmful programs like viruses or trojans.",
            "A virus is a type of malware that spreads and harms files or programs on your device.",
            "Hacking is when someone gains unauthorized access to systems or data. " +
            "Keep your passwords secure, {Name}.",
            "Encryption turns your information into a code so that only the right people can read it.",
            "A data breach happens when private information is accessed or leaked without permission.",
            "A DDoS attack floods a system with traffic so it slows down or crashes.",
            "A trojan is a type of malware that hides inside a normal-looking program.",
            "To keep your passwords safe include symbols, numbers, and uppercase letters. " +
            "Don't use the same password for everything, {Name}.",
            "Safe browsing means being careful about what you click on and where you go online. "
        };
        //---------------------------------------------------------------------------------/
        public String[] Questions = new string[]
        {
            "how are you",
            "ask",
            "purpose",
            "cybersecurity",
            "phish",
            "ransomware",
            "malware",
            "spyware",
            "pharm",
            "firewall",
            "antivirus",
            "virus",
            "hack",
            "encryption",
            "data breach",
            "DDoS attack",
            "trojan",
            "password",
            "safe brows"
        };

    }
}
//====================================================================================/
