====================================================================================================
				Cybersecurity Chatbot Read-Me File
====================================================================================================

// AUTHOR:
// Amelia Swart

// STUDENT NUMBER:
// ST10439947

// SUBJECT:
// PROG6221 - Programming 2A

----------------------------------------------------------------------------------------------------

// INTRODUCTION:
This project is a C# console-based security chatbot. It allows users to ask a variety of 
cyber-security based questions and get tailored responses. 

----------------------------------------------------------------------------------------------------

// GUTHUB 
GitHub Repository: https://github.com/VCCT-PROG2A-2025-G2/ST10439947_SecurityChatbot/
Access the above link for the source code of the project

----------------------------------------------------------------------------------------------------

// INSTALLATION:
1. Click the blue code button and at the bottom of the popup there is a 'download zip' option. ***********
2. Unzip the downloaded folder [ST10349947_SecurityChatbot.Zip]:
	-To do this right-click on the zipped folder, then click "Extract All" and confirm.
3. Open the extracted folder [ST10349947_SecurityChatbot].

----------------------------------------------------------------------------------------------------

// RUNNING THE CODE:
Option 1 – Run the Executable:
- After the file has been unzipped, open the folders inside one by one like this:
  ST10439947_SecurityChatbot → bin → Debug
- In the Debug folder, look for a file called:
  ST10439947_SecurityChatbot.exe
- Double-click on that file. It will open the chatbot program and show a welcome screen.
- If you see a warning or message pop up, just click “Run anyway” or “More info” → “Run anyway” (if it asks).

Option 2 – Run from Visual Studio:
- Open the 'ST10439947_SecurityChatbot.sln' file in Visual Studio.
- Extra Package Installation is Required as follows:
	- Click on 'Tools' at the top -> 'NuGet Package Manager' -> 'Manage NuGet Packages for Solution...'
	- Click 'Browse' and search for 'Spectre.Console'
	- Click on it and 'Install' on the right
	- Accept the terms
	- Search for 'Spectre.Console.Cli'
	- Click on it and 'Install' on the right
	- Accept the terms
[Ensure these are installed by going to 'Installed' and see if the 'Spectre.Console' 
and 'Spectre.Console.Cli' packages are present]
- Press `F5` or click "Start" to run the program.

----------------------------------------------------------------------------------------------------

// HOW IT WORKS:
- Displays a welcome screen with a custom message using ASCII text, 
  an ASCII image, and a loading animation.
- Redirects the user to the Main Chatbot Screen, while showing 
  the stylized title "CyberMiku" in ASCII art alongside a subtitle panel.
- Shows the user a Tip that they can type 'help' for more options or they can type 
  'What can I ask you?' to find out what type of questions can be asked.
- Prompts the user for their name, making sure it's valid (not empty or numeric).
- Accepts the user’s question and checks it against a pre-defined list of topics.
- Simulates typing with a spinner and a short random delay to feel more realistic.
- Plays a random idle .wav sound to simulate CyberMiku “speaking” during replies.
- Displays the appropriate response, sometimes personalized with the user's name.
- Supports commands like 'exit' to end the chat or 'clear' to reset the screen.
- Loops back to allow for further questions until the user chooses to exit.
- Displays a Closing Screen if the user types 'exit'/'quit', displaying a goodbye message 
  as well as an ASCII Image.

----------------------------------------------------------------------------------------------------

// REFERENCES:
- ASCII Font for "Welcome To" - https://github.com/xero/figlet-fonts/blob/master/Graceful.flf/
- ASCII Font for "CyberMiku" - https://github.com/xero/figlet-fonts/blob/master/Basic.flf/
- Spectre console for the figlet fonts, loading bars, grids, & colours https - //spectreconsole.net/
- ASCII art that I customised and adjusted based on this example - http://anime.en.utf8art.com/arc/hatsune_miku_24.html/
- Start Up Sound - https://www.youtube.com/watch?v=e6fDjYtbsCY/
- Sounds to simulate talking when displaying responses - https://www.youtube.com/watch?v=fVtxsDQ2ja4/
- I asked ChatGPT to give me examples of cybersecurity questions and answers - https://chatgpt.com/
- ChatGPT for a full and conclusive Read-Me File - https://chatgpt.com/

====================================================================================================
