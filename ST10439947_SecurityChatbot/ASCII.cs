//==================================================================================/
/*
 * Amelia Swart
 * ST10439947
 * Hello World Project
 */
//-----------------------------------------------------------------------------------/
/*Reference List:
 * ASCII art that I customised and adjusted based on this example:
 * http://anime.en.utf8art.com/arc/hatsune_miku_24.html
 * (Lines 40-49; 52-61)
 */
//-----------------------------------------------------------------------------------/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This Class Holds the ASCII Art for the welcome screen,
//---------------------------------------------------------------------------------/
namespace ST10439947_SecurityChatbot
{
    //---------------------------------------------------------------------------------/
    //this class holds the ASCII art for the chatbot
    internal class ASCII
    {
        //---------------------------------------------------------------------------------/
        //Default Constructor
        public ASCII() { }
        //---------------------------------------------------------------------------------/
        //creates instance variables for the 3 ascii art strings
        #region Instance Variables
        public String Welcome = "";
        public String Goodbye = "";
        #endregion  
        //---------------------------------------------------------------------------------/
        //loads the ASCII art from the text files
        public void LoadAscii()
        {
            //-----------------------------------------------------------------------------/
            //Welcome ASCII art for the welcome screen
            Welcome = @"
                                                  /^^>)),---.＜^^}
                                                 /:::/,==´::::;:::.
                                                /:::/:::/ |:/ }:::\
                                               /:::/|:/   //   |::}
                                              /::::||/  > ' <  ;::/
                                             /::::||\    3    /:/
                                            |:::::| /.|~~~/------/
                                            |:::::| (:::)/  <3  /
                                         -------------＼/______/---";

            //-----------------------------------------------------------------------------/
            //Goodbye ASCII art for the exit screen
            Goodbye = @"
                                             /^^>)),---.＜^^} Bye Bye!
                                            /:::/,==´::::;:::.
                                           /:::/:::/ |:/ }:::\
                                          /:::/|:/   //   |::}
                                         /::::||/  > ' <  ;::/
                                        /::::||\    3    /:/
                                       |:::::| /.|~~~/------/
                                       |:::::| (:::)/  <3  /
                                    -------------＼/______/---";
            //----------------------------------------------------------------------------/
        }
    }
}
//==================================================================================/