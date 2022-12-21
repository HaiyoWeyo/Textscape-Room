/* 
 * Title: 		Textscape Room
 * Developed by: 	Jordan Franks
 * Date started:	8/28/21
 * Date completed:	11/7/21	
*/

using System;
using static System.Console;
using System.Linq;
using System.Diagnostics;

class TextAdventure
{   
   static void Main()
   {
      WriteLine("Welcome to Textscape Room!\n... a title soon-to-be changed.");
      ReadLine();
      WriteLine("What is your name?");
      Write(">>> ");
      string name = ReadLine();

//Player name = "Umbra" --> Automatic win/lose?      
      if(name == "Umbra" || name == "umbra" || name == "UMBRA")
      {
         WriteLine();
         WriteLine("Your name is 'Umbra' too?");
         ReadLine();
         WriteLine("Wait...");
         ReadLine();
         WriteLine("You tricked me!");
         ReadLine();
         WriteLine("I knew this was a bad idea.\nI'm outta here!");
         ReadLine();
         WriteLine("---GAME OVER?---");
         ReadLine();
         Environment.Exit(0);
      }
      
//Begin WHILE loop for act 0. This will repeat the opening lines until a player either says NO or says YES. When response = YES, act = 1.
      int yesno = 0; 
      int act = 0;
      string response;
      while(act == 0)
      { 
         WriteLine();
         WriteLine("Do you want to play a game {0}?", name);
         Write(">>> ");
         response = ReadLine();
         WriteLine();
         
//Begin nested if statement to react to player input: either close program, re-prompt player, or start game.
         if(response != "Yes" && response != "yes" && response != "YES" && response != "No" && response != "no" && response != "NO") 
         {  
            WriteLine("I asked you a 'Yes or no' question {0}. Please answer appropriately.", name);
            yesno = 1;
         }
         else
            if(response == "No" || response == "no" || response == "NO")
            {  
               WriteLine("Well, you're no fun");
               ReadLine();
               WriteLine("...");
               ReadLine();
               WriteLine("You're still here? Goodbye!");
               for(int i = 0; i <= 1; ++i)
               {
                  WriteLine();
               }
               WriteLine("---GAME OVER---");
               ReadLine();
               Environment.Exit(0);
            }
            else
               act += 1;
      } 

      { 

//Ask player if instructions are desired         
         int intro = 0;
         while(intro == 0)
         {
            WriteLine("Would you like instructions before we begin?");
            Write(">>> ");
            response = ReadLine();
            WriteLine();
         
            if(response != "Yes" && response != "yes" && response != "YES" && response != "No" && response != "no" && response != "NO" && yesno == 1) 
            {
               WriteLine("Still haven't learned how to answer 'yes' or 'no'?\nYou're already disappointing me {0}.", name);
               WriteLine();
            }
            else
               if(response != "Yes" && response != "yes" && response != "YES" && response != "No" && response != "no" && response != "NO" && yesno == 0) 
               {  
                  WriteLine("I asked you a 'Yes or no' question {0}. Please answer appropriately.", name);
                  yesno = 1;
               }
               else
                  if(response == "Yes" || response == "yes" || response == "YES")
                  {  
                     WriteLine("This game involves some investigative work.\nActions can be taken by using two or three-word commands.\nAction words should be followed by the object that the action is to be performed on or with.\nThe following lists a few:\n");
                     WriteLine("* examine lamp");
                     WriteLine("* close table drawer");
                     WriteLine("* open door");
                     WriteLine();
                     WriteLine("Some more specific actions are CAPITALIZED.\nAt any point during the game, you may type the word 'map' to see the game map.");
                     intro += 1;
                     ReadLine();
                  }
                  else
                     intro += 1;
         }

//Start of game (proper indentation of code not followed for convenience 
//FOR loop to create extra space at start of game
         for(int i = 0; i <= 1; ++i)
         {
            WriteLine();
         }
         WriteLine("---GAME START---");
         for(int i = 0; i <= 1; ++i)
         {
            WriteLine();
         }
         WriteLine("{0}, you are lying on your bed, quietly reading in your room.\nThe open window lets in an abundance of light,\nwith long shadows being cast on the wall opposite.\nThere is not a cloud in the sky on this fine day.", name);
         ReadLine();
         WriteLine("You suddenly notice the soft sound of raindrops.\nYou look over and see that it is dark outside,\nas if a large thunder cloud has hidden the glorious sun from the world.\nThe light in your room has now dimmed, and the shadows have all gone.\nBut you notice movement out of the corner of your eye on the wall opposite the window.\nYou look and observe that one shadow remains, and it is growing in size up the wall.");
         ReadLine();
         WriteLine("The shadow reaches the ceiling.\nIt is blurred and unclear.\nIt slowly begins to take shape.");
         ReadLine();
         WriteLine("The rain strikes harder.");
         ReadLine();
         WriteLine("Second on second, the shadow coalesces and configures itself\ninto the form of a human-like figure.\nYour eyes widen as fear seeps into your every pore."); 
         ReadLine();
         WriteLine("The rain is crashing down now.");
         ReadLine();
         WriteLine("The shadow begins separating from the wall.\nIt reaches towards you.\nOne long, inky arm inches closer.");
         ReadLine();
         WriteLine("Closer...");
         ReadLine();
         WriteLine("Closer...");
         ReadLine();
         WriteLine("There is a flash of lightning.\nThe room is instantly blindingly bright.\nBut the shadow continues to creep closer.\nIt appears vantablack against the backdrop of pure light.\nIn this world of black and white, you hear a loud crash.");
         ReadLine();
         WriteLine("BOOM!!!");
         ReadLine();
         WriteLine("You are awake. You no longer see the shadow.\nOutside, the rain continues its savage song.\nThe drops pelting the trees sing backup to the single,\nloud pulse of runoff pouring down from the roof.\nYou realize you must have been dreaming,\nbut you can't recall when you transitioned from sleeping to waking.\nThe thought makes you shudder.");
         ReadLine();
         WriteLine("Just now, you notice your breathing comes in erratic bursts.\nThe feeling of being covered in cold sweat is now apparent.");
         ReadLine();
         WriteLine("And you're thirsty.");
         ReadLine();
         WriteLine("You pull the soaked covers off your body,\nand swing your legs over the edge of the bed.\nThe hardwood is cold beneath your feet.\nYou walk to the bedroom door and reach for the knob.");
         ReadLine();
         WriteLine("It won't turn.");
         ReadLine();
         WriteLine("The door is locked.");

         //Begin timing player
         Stopwatch sw = Stopwatch.StartNew();

//Variables that control events
         const int MISS = 20;
         bool isValidResponse = false;
         bool scratchesSeen = false;
         bool isJournalTaken = false;
         bool isJournalLocked = true;
         bool isTableOpen = false;
         //int wordsearch = 0;
         int binChk = 0;
         bool arePostersChk = false;
         bool isDoorChk = false;
         bool isTableChk = false;
         bool areKeysTaken = false;
         bool isRugChk = false;
         bool isPatternChk = false;
         bool isGuessCorrect = false; //Start this as false, and then make it true once the if statement begins for guessing the rug pattern
         bool isGuessedRug = false; //Use this to prevent the correctly guessing rug pattern IF statement from replaying forever
         bool isFirstLearned = false;
         bool isSecondLearned = false;
         bool isThirdLearned = false;
         bool isShelfChk = false;
         bool isShelfLatin = false;
         bool isDeskChk = false;
         bool isWordSearchSolved = false;
         bool isHaze = false;
         int shadow = 0;
         int counter = 0;
         int defeat = 0;

//Random generation of three digits for journal combination lock
         System.Random random = new System.Random();
         int david, freddie, first;
            david = random.Next(0, 6);
            freddie = random.Next(0, 5);
            bool isDavidChk = false;
            bool isFreddieChk = false;
         first = david + freddie;
         int second = random.Next(0, 10);
         int third = random.Next(0, 10);
         string code = first.ToString() + second.ToString() + third.ToString();
         string guess = "";

//Arrays that contain string section of each number (13 x 10)
         string[ , ] numberPattern = new string[13, 10] { {"       /////////      ", "         /////        ", "      /////////       ", "    /////////////     ", "             //       ", "    /////////////     ", "          //////      ", "   //////////////     ", "       /////////      ", "         /////        "},                                                                                                                
                                                          {"     //         //    ", "        //  //        ", "    //        //      ", "              //      ", "            ///       ", "    //                ", "         //    //     ", "              //      ", "     //         //    ", "       //     //      "},
                                                          {"   //            //   ", "       //   //        ", "   //          //     ", "             //       ", "           ////       ", "    //                ", "       //             ", "             //       ", "   //            //   ", "     //        //     "},
                                                          {"  //              //  ", "            //        ", "               //     ", "            //        ", "          // //       ", "    //                ", "     //               ", "            //        ", "   //            //   ", "    //          //    "},
                                                          {" //                // ", "            //        ", "              //      ", "           //         ", "         //  //       ", "    //                ", "    //                ", "           //         ", "    //         //     ", "    //          //    "},
                                                          {" //                // ", "            //        ", "            //        ", "          //          ", "        //   //       ", "    ////////          ", "    //                ", "          //          ", "      ////////        ", "     //         //    "},
                                                          {" //                // ", "            //        ", "          //          ", "            //        ", "       //    //       ", "            //        ", "    //   /////        ", "         //           ", "    //        //      ", "       //   // //     "},
                                                          {" //                // ", "            //        ", "        //            ", "              //      ", "      //     //       ", "              //      ", "    // //     //      ", "        //            ", "  //            //    ", "         //   //      "},
                                                          {" //                // ", "            //        ", "      //              ", "               //     ", "     ////////////     ", "               //     ", "    ///        //     ", "       //             ", " //              //   ", "             //       "},
                                                          {" //                // ", "            //        ", "     //               ", "    //          //    ", "             //       ", "    //          //    ", "    //          //    ", "      //              ", " //              //   ", "            //        "},
                                                          {"  //              //  ", "            //        ", "    //                ", "     //        //     ", "             //       ", "     //        //     ", "     //        //     ", "     //               ", "  //             //   ", "  //       //         "},
                                                          {"    //          //    ", "            //        ", "   //                 ", "       //   //        ", "             //       ", "       //   //        ", "       //   //        ", "    //                ", "    //         //     ", "   //    //           "},
                                                          {"      //////////      ", "       ///////////    ", "  ///////////////     ", "        ////          ", "             //       ", "        ////          ", "        ////          ", "   //                 ", "      /////////       ", "     ////             "} };

                                                                                         

//Random ordering of array for showing rugPattern
         int[] rugPatternNum = new int[13];
         for(int i = 0; i < 13; ++i)
         {
            rugPatternNum[i] = i;
         }
         rugPatternNum = rugPatternNum.OrderBy(x => random.Next()).ToArray();

//RugPattern as an array
         string[] rugPattern = new string[13];
         for(int i = 0; i < 13; ++i)
         {
            rugPattern[i] = numberPattern[rugPatternNum[i], second];
         } 

//Array to store player's guessed pattern
         string[] guessedPattern = new string[13];
                                                              
         while(act == 1)
         {  
            //Variable to check if a valid response was given by player
            isValidResponse = false;

            WriteLine(); 
            Write(">>> ");
            response = ReadLine();
            WriteLine();
            
            //Everytime an action is performed, shadow counter increases by 1. Over time, shadow will become apparent and deadly
            ++shadow;
            //attack is what the variable defeat will be compared to. If attack < defeat, then player dies
            //comment is what determine when an attack from Umbra is declared. MISS is compared to comment, and if comment < MISS and counter = 3, then Umbra's attack is declared to the player 
            int attack = random.Next(0, 101);
            int comment = random.Next(0, 101);
            
            //Variables that randomly generate different numbers to give variety in shadow attacks and invalid response feedback
            int invalidType = random.Next(0, 3);
            int attackType = random.Next(0, 3);



//Non-random version of wordsearch, and transformation when guessed correctly
            string guessName;
            string[] wordSearch = new string[13] {"A R C T D A R K R D A I N",
                                                  "B U Z Z P R A B C E Q K L",    
                                                  "B A E V I L S E Y E S O C",
                                                  "O V E R O W I Q S I A N P",
                                                  "T O L D L A T I N S H I U",
                                                  "E P H E M I R A L E U X N",
                                                  "S N I G H T M A R E I O I",
                                                  "H C P Z K A M U R D N N S",
                                                  "A G H O S T O U R D K I H",
                                                  "D R A C U L T I C A Y C M",
                                                  "O M E U M B R A X B S Y E",
                                                  "W O D S E R V A N K A I N",
                                                  "S P E C T R E S C A R E T"}; 

            string[] faceSearch1 = new string[13] {"                         ",
                                                   "                         ",    
                                                   "    E V I L   E Y E S    ",
                                                   "                         ",
                                                   "                         ",
                                                   "           I             ",
                                                   "                         ",
                                                   "          A M            ",
                                                   "                         ",
                                                   "                         ",
                                                   "        U M B R A        ",
                                                   "                         ",
                                                   "                         "};


            string[] faceSearch2 = new string[13] {"                         ",
                                                   "                         ",    
                                                   "    E V I L   E Y E S    ",
                                                   "     V   I     Y   E     ",
                                                   "      I V       E Y      ",
                                                   "           I             ",
                                                   "                         ",
                                                   "          A M            ",
                                                   "                         ",
                                                   "       U M B R A         ",
                                                   "       U       A         ",
                                                   "       U       A         ",
                                                   "       U M B R A         "};

//Computer monitor face
            string[] monitorFace = new string[13] {"                         ",
                                                   "                         ",    
                                                   "    X X X X   X X X X    ",
                                                   "     X   X     X   X     ",
                                                   "      X X       X X      ",
                                                   "           X             ",
                                                   "                         ",
                                                   "          X X            ",
                                                   "  X                 X    ",
                                                   "    X X X X X X X X      ",
                                                   "      X         X        ",
                                                   "        X     X          ",
                                                   "          X X            "};

//Map command 
            if(response == "map" || response == "Map" || response == "MAP")
            {  
               WriteLine("    CLOSET                   POSTERS");
               for(int i = 1; i <= 40; ++i)
                  Write("-");
               WriteLine();
               WriteLine("|  __________     |                    |");
               WriteLine("|  |        |     |          BED       |");
               WriteLine("|  |        |     |                    |");
               WriteLine("|  |        |     |                    |");
               WriteLine("|  |  RUG   |     |____________________|");
               WriteLine("|  |        |                       ___|W");
               WriteLine("|  |________|                       | T|I");
               WriteLine("|                                   | A|N");
               WriteLine("|                                   | B|D");
               WriteLine("|                                   | L|O");
               WriteLine("|                                   |_E|W");
               WriteLine("|                                      |");
               WriteLine("|               ________  ____________ |");
               WriteLine("|               |      |  |          | |");
               WriteLine("|           BIN | DESK |  |BOOKSHELF | |");
               for(int i = 1; i <= 40; ++i)
                  Write("-");
               WriteLine();
               WriteLine("    DOOR");
               WriteLine();
               isValidResponse = true;
            }
 
            
            //Create in-game commands

//Door commands
            if(response == "Knock on door" || response == "knock on door" || response == "KNOCK ON DOOR")
            {
               WriteLine("You knock on the door and listen,\nbut only the rain drops reply.");
               isValidResponse = true; 
            }
            if(response == "Open door" || response == "Open Door" || response == "open door" || response == "OPEN DOOR")
            {
               WriteLine("We already told you the door is locked.\nPay attention {0}!", name);
               isValidResponse = true;
            }
            if((response == "Examine door" || response == "Examine Door" || response == "examine door" || response == "EXAMINE DOOR") && isDoorChk == false)
            {
               WriteLine("Looking at the door more closely,\nyou notice what appear to be faint scratches up and down it.\nYou don't recall seeing them before.\nA sudden shiver overtakes you as you realize\nthat there is no door knob anymore.");
               isDoorChk = true;
               scratchesSeen = true;
               isValidResponse = true; 
            }
            else
            if((response == "Examine door" || response == "Examine Door" || response == "examine door" || response == "EXAMINE DOOR") && isDoorChk == true)
            {
               WriteLine("Nothing new to report. Scratches and missing door knob, remember?");
               isValidResponse = true; 
            }
            if(scratchesSeen == true && (response == "Examine scratches" || response == "examine scratches" || response == "EXAMINE SCRATCHES"))
            {
               WriteLine("You stand back and scrutinize the scratches\nmore closely. They resemble a number:");
               WriteLine();
               ReadLine();
               for(int i = 0; i < 13; ++i)
               {
                  WriteLine(numberPattern[i, third]);
               }
               isThirdLearned = true;
               isValidResponse = true; 
            }

//Bin commands
            if((response == "Examine bin" || response == "Examine Bin" || response == "examine bin" || response == "EXAMINE BIN") && binChk == 0)
            {
               WriteLine("You look through your small trash bin.\nAmong a wad of crusty tissues you find a small note.\nIt reads:");
               WriteLine();
               WriteLine("      I AM LIKE AN UMBRELLA");
               WriteLine("           I GIVE YOU SHADE");
               WriteLine("      IF YOU AREN'T CAREFUL");
               WriteLine("            MY NAME IS SAID");
               ++binChk;
               isValidResponse = true;
            }
            else
            if((response == "Examine bin" || response == "Examine Bin" || response == "examine bin" || response == "EXAMINE BIN") && binChk == 1)
            {
               WriteLine("What do you get when you combine the tissues with the note?");
               ReadLine();
               WriteLine("Sticky notes!");
               ReadLine();
               WriteLine("WAH HA HA HA!");
               ++binChk;
               isValidResponse = true;   
            }
            else
            if((response == "Examine bin" || response == "Examine Bin" || response == "examine bin" || response == "EXAMINE BIN") && binChk == 2)
            {  
               WriteLine("Fine, take another look at the note.");
               WriteLine();
               WriteLine("      I AM LIKE AN UMBRELLA");
               WriteLine("           I GIVE YOU SHADE");
               WriteLine("      IF YOU AREN'T CAREFUL");
               WriteLine("            MY NAME IS SAID");
               isValidResponse = true;
            }

//Table commands
            if((response == "Examine table" || response == "Examine Table" || response == "examine table" || response == "EXAMINE TABLE") && isTableChk == false)
            {
               WriteLine("A small lamp sits on the little, one-drawer table.\nYour wallet and keys are right where you left them.\nAn action figure from your childhood\nstands on the table, one arm reaching out.");   
               isTableChk = true;
               isValidResponse = true;
            }
            else
            if((response == "Examine table" || response == "Examine Table" || response == "examine table" || response == "EXAMINE TABLE") && isTableChk == true)
            {
               WriteLine("All the same stuff.\nMaybe try checking out some of these things {0}.", name);
               WriteLine("Here, in case you forgot:\nLamp, figure, drawer, wallet and keys.");
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Examine lamp" || response == "Examine Lamp" || response == "examine lamp" || response == "EXAMINE LAMP"))
            {
               WriteLine("Just a standard lamp.\nJust like you, it can be turned on or off.\nCurrently the lamp is on...\nHow else can you see any of this stuff?");
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Turn off lamp" || response == "turn off lamp" || response == "TURN OFF LAMP"))
            {
               WriteLine("You switch the lamp off.\nThe room is instantly bathed in pale moonlight.\nA sharp shiver runs through you\nas you look to the wall opposite the window.");
               ReadLine();
               WriteLine("Horror...");
               ReadLine();
               WriteLine("Show large shadow!");
               WriteLine("You quickly turn the lamp back on.\nYour heart races\nas fear erases.");
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Examine keys" || response == "Examine Keys" || response == "examine keys" || response == "EXAMINE KEYS"))
            {
               WriteLine("These are keys to your car\nand the front and back doors of your home.\nWhat, do you think you can just drive\noutta this?");
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Take keys" || response == "Take Keys" || response == "take keys" || response == "TAKE KEYS"))
            {
               WriteLine("You have the keys now.");
               areKeysTaken = true;
               isValidResponse = true;
            }
            if(areKeysTaken == true & (response == "Throw keys" || response == "Throw Keys" || response == "throw keys" || response == "THROW KEYS"))
            {
               WriteLine("At the thought of being my prisoner,\nyou suddenly throw the keys in anger.");
               ReadLine();
               WriteLine("Do you feel better now {0}?", name);
               areKeysTaken = false;
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Examine figure" || response == "Examine Figure" || response == "examine figure" || response == "EXAMINE FIGURE"))
            {
               WriteLine("The figure is of Cockroachman,\nthe least known\n(and most detested)\nsuperhero ever created.");
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Take figure" || response == "Take Figure" || response == "take figure" || response == "TAKE FIGURE"))
            {
               WriteLine("You reach for the action figure.\nAs your hand is about to make contact,\nthe figure begins to distort and wave like a dark flame.\nYour hand feels icy cold, and passes right through.");
               isValidResponse = true;
            }            
            if(response == "Open drawer" || response == "Open Drawer" || response == "open drawer" || response == "OPEN DRAWER")
            {
               WriteLine("Can you be more specific?\nWhich drawer do you want to open {0}?", name);
               isValidResponse = true;
            }
            if(isTableOpen == false && isJournalTaken == false && (response == "Open table drawer" || response == "open table drawer" || response == "OPEN TABLE DRAWER"))
            {
               WriteLine("Inside the drawer, lying like a Bible\nin a hotel side table, is a\nleather-bound journal.\nThe journal is locked by a\n3-digit combination lock.");
               isTableOpen = true;
               isValidResponse = true;
            }
            else
            if(isTableOpen == false && isJournalTaken == true && (response == "Open table drawer" || response == "open table drawer" || response == "OPEN TABLE DRAWER"))
            {
               WriteLine("You have the journal. Only the hard wood\nstares stiffly back at you.");
               isTableOpen = true;
               isValidResponse = true;
            }
            if(isTableOpen == true && isJournalTaken == false && (response == "Take journal" || response == "Take Journal" || response == "take journal" || response == "TAKE JOURNAL"))
            {
               WriteLine("The journal is yours.\nDon't lose it now.");
               isJournalTaken = true;
               isValidResponse = true;
            }
            else
            if(isJournalTaken == true && (response == "Take journal" || response == "Take Journal" || response == "take journal" || response == "TAKE JOURNAL"))
            {
               WriteLine("I told you not to lose it {0}", name);
               ReadLine();
               WriteLine("*Sigh...*");
               ReadLine();
               WriteLine("Did you check your hands?");
               ReadLine();
               WriteLine("Yep. You were holding it this whole time.");
               isValidResponse = true;
            }
            if(isTableOpen == true && (response == "Close table drawer" || response == "close table drawer" || response == "CLOSE TABLE DRAWER"))
            {
               WriteLine("The table drawer is closed again.");
               isTableOpen = false;
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Examine wallet" || response == "examine wallet" || response == "Examine Wallet" || response == "EXAMINE WALLET"))
            {
               WriteLine("Your wallet contains only an ID.\nBut the face is shadowy and dark.");
               isValidResponse = true;
            }
            if(isTableChk == true && (response == "Take wallet" || response == "take wallet" || response == "Take Wallet" || response == "TAKE WALLET"))
            {
               WriteLine("You aren't going to buy your way\noutta this {0}.", name);
               isValidResponse = true;
            }

//Journal commands
            if(isJournalTaken == true && isJournalLocked == true && (response == "Open journal" || response == "Open Journal" || response == "open journal" || response == "OPEN JOURNAL"))
            {
               WriteLine("You have to unlock the journal first.\nPerhaps there is a clue to the code.");
               isValidResponse = true;
            } 
            if(isJournalTaken == true && isJournalLocked == true && (response == "Examine journal" || response == "Examine Journal" || response == "examine journal" || response == "EXAMINE JOURNAL"))
            {
               WriteLine("The cover of the journal contains a riddle:");
               ReadLine();
               WriteLine("This journal can only be opened\nwith some strong hands.\nA magic carpet you must depend\non to scratch the sands\nof time and space.");
               isValidResponse = true;
            } 
            if(isFirstLearned == false && isSecondLearned == false && isThirdLearned == false && isJournalTaken == true && isJournalLocked == true && (response == "Unlock journal" || response == "Unlock Journal" || response == "unlock journal" || response == "UNLOCK JOURNAL"))
            {
               WriteLine("There are 6000 possible combinations, {0}.\nGuessing would be silly.", name);
               isValidResponse = true;
            }
            if((response == "Unlock journal" || response == "Unlock Journal" || response == "unlock journal" || response == "UNLOCK JOURNAL") &&
               ((isFirstLearned == true && isSecondLearned == false && isThirdLearned == false) || 
               (isFirstLearned == false && isSecondLearned == true && isThirdLearned == false) ||
               (isFirstLearned == false && isSecondLearned == false && isThirdLearned == true)) && 
                isJournalTaken == true && isJournalLocked == true)
            {
               WriteLine("So you learned one number, {0}.\nThat still leaves 600 possible combinations\nfor the other two numbers.", name);
               ReadLine();
               WriteLine("Be patient, {0}, and find the other two.", name);
               isValidResponse = true;
            }
            if((response == "Unlock journal" || response == "Unlock Journal" || response == "unlock journal" || response == "UNLOCK JOURNAL") &&
               ((isFirstLearned == true && isSecondLearned == true && isThirdLearned == false) || 
               (isFirstLearned == true && isSecondLearned == false && isThirdLearned == true) ||
               (isFirstLearned == false && isSecondLearned == true && isThirdLearned == true)) && 
                isJournalTaken == true && isJournalLocked == true)
            {
               WriteLine("Only one more number to go, {0}.\n60 possibilities for that one.\nGuessing now would be reasonble.", name);
               ReadLine();
               WriteLine("But I won't allow it.\nJust play along, will you {0}?", name);
               isValidResponse = true;
            }
            if((response == "Unlock journal" || response == "Unlock Journal" || response == "unlock journal" || response == "UNLOCK JOURNAL") &&
                isFirstLearned == true && isSecondLearned == true && isThirdLearned == true && 
                isJournalTaken == true && isJournalLocked == true)
            {
               Write("You think you figured out the code?\nLet's have it then {0}: >>> ", name);
               guess = ReadLine();
               WriteLine();
               if(guess == code)
               {
                  WriteLine("You successfully unlock the journal.");
                  ReadLine();
                  WriteLine("As you slowly open the journal,\nthe spine creaks like stiff joints\nand a cloud of black dust emerges\nfrom between the pages.");
                  WriteLine("The pages are blank except for one lonely page\nnear the middle containing a wordsearch."); 
                  isJournalLocked = false;
               }
               else
               {
                  WriteLine("Every wrong guess puts you one step\ncloser to being eternally mine...");
               }  
               isValidResponse = true;
            }           
            if(isJournalLocked == false && (response == "Examine wordsearch" || response == "Examine Wordsearch" || response == "examine wordsearch" || response == "EXAMINE WORDSEARCH"))
            {
               WriteLine("A phrase is written at the top of the wordsearch:");
               ReadLine();
               WriteLine();
               WriteLine("       To cast out a demon you must learn its name      ");
               WriteLine();
               WriteLine();
               for(int i = 0; i < wordSearch.Length; ++i)
               {
                  WriteLine(wordSearch[i]);
               }
               ReadLine();
               WriteLine();
               WriteLine("You think you can SOLVE this wicked WORDSEARCH, {0}?", name);
               isValidResponse = true;
            }
            if(isJournalLocked == false && (response == "Solve wordsearch" || response == "Solve Wordsearch" || response == "solve wordsearch" || response == "SOLVE WORDSEARCH"))
            {
               WriteLine();
               WriteLine("       To cast out a demon you must learn its name      ");
               WriteLine();
               WriteLine();
               for(int i = 0; i < wordSearch.Length; ++i)
               {
                  WriteLine(                 wordSearch[i]);
               }
               WriteLine();
               Write("SAY MY NAME! >> ");
               guessName = ReadLine();
               WriteLine();
               if(guessName == "Umbra")
               {
                  isWordSearchSolved = true;
               }
               else
               {
                  WriteLine("YOU ARE TOO SPINELESS TO KNOW ME!!\nACQUIRE ONE BEFORE YOU TRY AGAIN!");
                  isShelfLatin = true;
               }
               isValidResponse = true;
            }

//Wordsearch commands
            if(isWordSearchSolved == true)
            {
               for(int i = 0; i < wordSearch.Length; ++i)
               {
                  WriteLine(wordSearch[i]);
               }
               WriteLine();
               ReadLine();
               for(int i = 0; i < faceSearch1.Length; ++i)
               {
                  WriteLine(faceSearch1[i]);
               }
               WriteLine();
               ReadLine();
               for(int i = 0; i < faceSearch2.Length; ++i)
               {
                  WriteLine(faceSearch2[i]);
               }
            //Stop timer
            sw.Stop();
            
            WriteLine();
            WriteLine();
            WriteLine("You hear a high-pitched scream\n- MY scream -\nthat turns into a maniacal laugh.");
            ReadLine();
            WriteLine("The entire room begins shaking violently,\nbut oddly no object is propelled from its position.");
            ReadLine();
            WriteLine("Everything spins upside down,\nthe world flipping through an instantaneous rotation,\nand suddenly stopping as if locked into place.");
            ReadLine();
            WriteLine("Silence...");
            ReadLine();
            WriteLine("Stillness...");
            ReadLine();
            WriteLine("Standing on the ceiling-floor,\nbeneath a cluttered sky of inertia,\nyou feel a cold drop land on your nose.");
            ReadLine();
            WriteLine("It's raining.");
            ReadLine();
            WriteLine("...inside");
            ReadLine();
            WriteLine("And the water is as black as empty space...");
            ReadLine();
            WriteLine("A torrent of nothing pours down.\nIt collects and pools and covers.");
            ReadLine();
            WriteLine("...over your feet.");
            ReadLine();
            WriteLine("...over your knees.");
            ReadLine();
            WriteLine("...over your throat.");
            ReadLine();
            WriteLine("As the darkness begins to cover your eyes,\nthe room collapses in on you\nto a singular point.");
            ReadLine();
            WriteLine("Just before all is gone, you hear\nan explosion of such magnitude and force\nthat it seems to die out immediately.");
            ReadLine();
            WriteLine("Sound with a beginning but no end.\nAnd yet it does not extend.\nIt's just...");
            ReadLine();
            WriteLine("...gone.");
            ReadLine();
            WriteLine("Without realizing it, your visible world expanded\nand opened an infinitesimal instant before\nthe phantom-boom.");
            ReadLine();
            WriteLine("You are awake in your bed,\nthe sunlight streaming in through the open window\nand the smell of Spring in the air.");
            ReadLine();
            WriteLine("And the figure on your nightstand smiling,\nwith one inky arm extended towards the open door...");
            ReadLine();
            WriteLine("\n\n");

            //Display game length
            WriteLine("Play time: " + sw.Elapsed.ToString(@"hh") + " hours, " + sw.Elapsed.ToString(@"mm") + " minutes, and " + sw.Elapsed.ToString(@"ss") + " seconds.");;
            ReadLine(); 
            Environment.Exit(0);
            }            

//Rug commands
            if((response == "Examine rug" || response == "Examine Rug" || response == "examine rug" || response == "EXAMINE RUG") && isRugChk == false)
            {
               WriteLine("You look at the large embroidered rug\nresting at the foot of your bed.\nYou no longer recognize the pattern,\nbut it nonetheless seems familiar.");   
               isRugChk = true;
               isValidResponse = true;
            }
            else
            if((response == "Examine rug" || response == "Examine Rug" || response == "examine rug" || response == "EXAMINE RUG") && isRugChk == true)
            {
               WriteLine("The same strange pattern stares back at you.\nYou feel its cold judgment,\nas if it were an abyss\nlooking deep into you.");   
               isValidResponse = true;
            }
            if((response == "Examine pattern" || response == "examine pattern" || response == "EXAMINE PATTERN") && isRugChk == true)
            {
               for(int i = 0; i < 13; ++i)
               {
                  WriteLine("{0, 2}" + rugPattern[i], i + 1); //Integers from 1 to 13 are displayed right aligned in a field that is two characters large. This keeps the large number properly aligned
               }
               ReadLine();
               WriteLine("Well {0}, do you want to\nGUESS the PATTERN?", name);
               isPatternChk = true;   
               isValidResponse = true;
            }
            if((response == "Guess pattern" || response == "guess pattern" || response == "GUESS PATTERN") && isPatternChk == true)
            {
               WriteLine("Enter the line numbers in the order\nthat show the correct pattern:");
               ReadLine();
               int[] lineNum = new int[13];
               try
               {
                  isGuessCorrect = true; //Set this to true, and as long as it stays true through this if block, then the player will get access to the code number               
                  for(int line = 1; line < 14; ++line)
                  {
                     Write("Line {0} >>> ", line);
                     lineNum[line - 1] = Convert.ToInt32(ReadLine()) - 1; //Subract by 1 so that each element in lineNum corresponds to the appropriate element in rugPattern
                  }
                  WriteLine();
                  ReadLine();
                  WriteLine("{0, 26}", "Guess");
                  WriteLine("{0, 36}", "***************");
                  for(int line = 0; line < 13; ++line)
                  {
                     guessedPattern[line] = rugPattern[lineNum[line]];
                     Write(guessedPattern[line]);
                     if(guessedPattern[line] == numberPattern[line, second]) //Gives feedback for which lines were correct using player's input (lineNum[line] + 1). Also, if all are correct, then player gets access to the number for the journal code
                     {
                        WriteLine("	{0, 2} Correct", lineNum[line] + 1);
                     }
                     else
                     {
                        WriteLine("	{0, 2} Incorrect", lineNum[line] + 1);
                        isGuessCorrect = false; //All it takes is one wrong guess to fail
                     }
                  }
                  WriteLine();
                  isValidResponse = true;
               }
               catch(Exception)
               {
                  WriteLine();
                  WriteLine("I only like numbers between 1 and 13.\nSee to it, {0},\nthat you get it right next time.", name);
                  isGuessCorrect = false; //Make isGuessCorrect false here to avoid it being true up until the exception triggering, and thus potentially allowing the player to get access to the code number without actually guessing the pattern correctly
                  isValidResponse = true;
               }
            }
            if(isGuessCorrect == true && isGuessedRug == false)
            {
               WriteLine();
               WriteLine("{0} is just another number.\nYou probably don't even know\nwhat you have to do with it {1}", second, name);
               isSecondLearned = true;
               isGuessedRug = true;
            } 

//Posters commands
            if(response == "Examine posters" || response == "Examine Posters" || response == "examine posters" || response == "EXAMINE POSTERS")
            {
               WriteLine("The posters on the wall are of your two favorite wrestlers,\nDavid Arrowie and Freddie Jupiter.\nStanding there with pronounced pectorals and colorful speedoes,\nthey make symbolic gestures with their hands.");
               arePostersChk = true;
               isValidResponse = true;
            } 
            if(arePostersChk == true && (response == "Examine hands" || response == "Examine Hands" || response == "examine hands" || response == "EXAMINE HANDS"))
            {
               WriteLine("Whose hands are you referring to {0}?\n", name);
               isValidResponse = true;
            } 
            if(arePostersChk == true && (response == "Examine freddie hands" || response == "Examine Freddie Hands" || response == "examine freddie hands" || response == "EXAMINE FREDDIE HANDS"))
            {
               WriteLine("Jupiter is holding up {0} fingers", freddie);
               isFreddieChk = true;
               isValidResponse = true;
            }
            if(arePostersChk == true && (response == "Examine david hands" || response == "Examine David Hands" || response == "examine david hands" || response == "EXAMINE DAVID HANDS"))
            {
               WriteLine("Arrowie is holding up {0} fingers", david);
               isDavidChk = true;
               isValidResponse = true;
            } 
            if(isFreddieChk == true && isDavidChk == true)
            {
               isFirstLearned = true;
               isValidResponse = true;
            } 

//Bookshelf commands
            if(response == "Examine bookshelf" || response == "Examine Bookshelf" || response == "examine bookshelf" || response == "EXAMINE BOOKSHELF")
            {
               WriteLine("The bookshelf contains a random assortment of\nfiction and non-fiction books.\nThe spines are worn and faded");
               isShelfChk = true;
               isValidResponse = true;
            } 
            if(isShelfChk == true && isShelfLatin == false && (response == "Examine spines" || response == "examine spines" || response == "EXAMINE SPINES"))
            {
               WriteLine("The titles of the books are illegible,\nfaint shadows of their former names.");
               isValidResponse = true;
            }
            if(isShelfChk == true && isShelfLatin == true && (response == "Examine spines" || response == "examine spines" || response == "EXAMINE SPINES"))
            {
               WriteLine("The titles of the books are illegible,\nfaint shadows of their former names.");
               ReadLine();
               WriteLine("...");
               ReadLine();
               WriteLine("The titles suddenly become clearer before your eyes.\nThey seem to be in another language.\n");
                     WriteLine("* Meditationes de Prima philosophia");
                     WriteLine("* Philosophiæ Naturalis Principia Mathematica");
                     WriteLine("* Junius: Stat Nominis Umbra");
               isValidResponse = true;
            }

//Window commands
            if(response == "Examine window" || response == "Examine Window" || response == "examine window" || response == "EXAMINE WINDOW")
            {
               WriteLine("The window is locked.\nYou can barely make out the trees\nthrough the thick curtain of rain.");
               isValidResponse = true;
            } 

//Closet commands
            if(response == "Examine closet" || response == "Examine Closet" || response == "examine closet" || response == "EXAMINE CLOSET")
            {
               WriteLine("Your closet is full of clothes.\nMaybe you should pick out an outfit to be buried in, {0}.", name);
               isValidResponse = true;
            } 

//Desk commands
            if(response == "Examine desk" || response == "Examine Desk" || response == "examine desk" || response == "EXAMINE DESK")
            {
               WriteLine("Your computer sits on your desk.\nThe monitor is off but the computer is on.\nYour desk drawers are locked.\nYou don't remember there being a key for it.");
               isDeskChk = true;
               isValidResponse = true;
            }
            if(isDeskChk == true && (response == "Examine computer" || response == "Examine Computer" || response == "examine computer" || response == "EXAMINE COMPUTER"))
            {
               WriteLine("Maybe try turning the monitor on {0}?", name);
               isValidResponse = true;
            }
            if(isDeskChk == true && (response == "Turn on monitor" || response == "turn on monitor" || response == "TURN ON MONITOR"))
            {
               WriteLine("BOO!!");
               WriteLine();
               for(int i = 0; i < monitorFace.Length; ++i)
               {
                  WriteLine(monitorFace[i]);
               }
               isValidResponse = true;
            }

//Bed commands
            if(response == "Examine bed" || response == "Examine Bed" || response == "examine bed" || response == "EXAMINE BED")
            {
               WriteLine("Tired of playing already, {0}?\nWould you like to quit?", name);
               Write(">>> ");
               string reply = ReadLine();
               WriteLine();

               if(reply == "yes" || reply == "YES" || reply == "Yes")
               {
                  WriteLine("Too bad!\nYou aren't sleeping away this problem, {0}.", name);
               }
               else if(reply == "No" || reply == "NO" || reply == "no")
               {
                  WriteLine("Very good...");
               }
               else
               {
                  WriteLine("Must you speak such irrelevancies, {0}?", name);
               }
         
               isValidResponse = true;
            }  

//Umbra (shadow) progression code
//At counter = 3 it will become deadly, starting at 1% per action, then 5%, and finally 10% (harder difficulty will be 2%, 10%, and 20% if needed).
            if(counter == 1 && (response == "Examine whisper" || response == "Examine Whisper" || response == "examine whisper" || response == "EXAMINE WHISPER" || response == "Examine whispers" || response == "Examine Whispers" || response == "examine whispers" || response == "EXAMINE WHISPERS"))
            {
               WriteLine("Looking at the wall where the whispers came from,\nyou see a faint darkish haze near the baseboards.");
               isHaze = true;
               isValidResponse = true;
            }
            if(isHaze == true && (response == "Examine haze" || response == "Examine Haze" || response == "examine haze"|| response == "EXAMINE HAZE"))
            {  
               WriteLine("It's just a little haze. Nothing to worry about...");
               isValidResponse = true;
            }
            if(counter == 2 && (response == "Examine blotch" || response == "Examine Blotch" || response == "examine blotch" || response == "EXAMINE BLOTCH"))
            {
               WriteLine("The shadowy blotch appears to be\ncoalescing...");
               isHaze = false;
               isValidResponse = true;
            }

//Temporary journal code check (remove once game completed)
            if(response == "give the code")
            {
               WriteLine(code);
               isValidResponse = true;
            }
            if(isJournalLocked == true && guess == code)
            {
               WriteLine("Code correct!");
               isJournalLocked = false;
               isValidResponse = true;
            }
         
//Valid response check. This must be after all the valid commands, or else game will not work  
            if(isValidResponse == false)
            {
               if(invalidType == 0)              
               {    
                  WriteLine("Do what now?");
               }
               else
               if(invalidType == 1)
               {
                  WriteLine("How about trying something else?");
               } 
               else
               {
                  WriteLine("Don't be silly {0}.", name);
               }
            } 

//Escalation of shadow (after in-game commands, so those activate first, and then the shadow triggers)
            //Place attack Umbra's attacks before code that escalates his form. This avoids possibility of an attack occurring at the same time
            //that Umbra reaches full form (counter = 3).
            if(counter == 3 && attack > defeat && comment < MISS)
            {
               if(attackType == 0)
               {
                  WriteLine("...");
                  ReadLine();
                  WriteLine("The dark arm reaches for you,\nbut you duck under just in time,\nand scramble to the other side of the room.");
               }
               else
               if(attackType == 1)
               {
                  WriteLine("...");
                  ReadLine();
                  WriteLine("You feel the hairs on your neck stand up.\nYou throw yourself to the ground\njust as the inky tendril glides overhead.");
               }
               else
               {
                  WriteLine("...");
                  ReadLine();
                  WriteLine("The shadow extends its arms\nup and to the ceiling.\nDarkness descends upon you,\nbut you leap away just in time.");
               }
            }
            if(counter == 3 && attack < defeat)
            {
               WriteLine("...");
               ReadLine();
               WriteLine("The dark arm reaches for you.\nYou try to duck, but you're too slow.\nYou are caught in its oily clutches.\nFear upon fear pounds upon you,\nuntil you are one with the darkness...");
               ReadLine();
               WriteLine("'Goodbye'");
               ReadLine();
               WriteLine("'{0}...'", name);
               ReadLine();
               for(int i = 0; i <= 1; ++i)
               {
                  WriteLine();
               }
               WriteLine("---GAME OVER---");
               ReadLine();

               //Display game length
               WriteLine("Play time: " + sw.Elapsed.ToString(@"hh") + " hours, " + sw.Elapsed.ToString(@"mm") + " minutes, and " + sw.Elapsed.ToString(@"ss") + " seconds.");
               ReadLine();
               Environment.Exit(0);  
            }            
            if(shadow == 10)
            {
               WriteLine("...");
               ReadLine();
               WriteLine("You hear faint whispers coming from the wall opposite the window.\nYou can't make out what they're saying,\nbut they sound disembodied and enticing.");
               counter = 1;
            }
            if(shadow == 20)
            {
               WriteLine("...");
               ReadLine();
               WriteLine("You feel the ground start to shake beneath your feet.\nA low rumbling sound builds up from\nbehind the wall that earlier whispered.\nThe haze has increased in size up the wall,\nrevealing a large shadowy blotch.");
               counter = 2;
               isHaze = false;
            }
            if(shadow == 30)
            {
               WriteLine("...");
               ReadLine();
               WriteLine("A deep laugh echoes from the wall.\nThe tone is laced with evil and misery.\nYou turn to face it,\nand find yourself staring at\nthe shadow from your dreams.\nOne inky arm extends towards you...");
               counter = 3;
               defeat = 2;
            }
           if(shadow == 40)
            {
               defeat = 5;
            }  
           if(shadow == 50)
            {
               defeat = 10;
            }   
         }    
      }
   }  
}