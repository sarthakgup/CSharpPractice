using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* SOLITAIRE PROJECT
 * By: Sarthak Gupta
 * Computer Programming
*/

namespace simpleCardGame
{
    class SimpleCardGame
    {
        /*
         * Name: Sarthak Gupta 
         * Date: 3/28/2018
         * Assignment: Solitaire Project
         * Description: This is a card game.
         */
        static string[] m_pileArray = null;
        static string[][] m_playArray = null;
        static string[] m_unusedArray = null;
        static string[] m_faceDownDeckArray = null;
        static string[] m_faceUpDeckArray = null;
        static int m_faceUpDeckCounter = -1;
        static int m_unusedCounter = 0;
        static int m_faceDownDeckCounter = -1;
        static int[] m_playArrayCounter = null;
        

        public static void Main(string[] args)
        {
            //int m_unusedCounter = 0; //Counter I am creating just for keeping track of items in my unused card array.
            string whileLoopCondition;
            bool exitLoop = false; //Using this variable to exit the while loop

            //Create an initialize an array that holds a m_faceDownDeckArray of cards. Each card will be represented by a string “Value of Suit” (ex: Ace of Spades, 3 of Hearts, King of Diamonds, Queen of Clubs) (2pts)
            //Shuffle your m_faceDownDeckArray.Hints: you will want to use random number generation and a loop for this – remember to swap two items in an array you need to save one to a temp variable first. (6pts)
            //Deal the cards by outputting each one to the console(2pts)

            // allocate all arrays
            m_pileArray = new string[4] {null, null, null, null}; //Part of Part2
            m_unusedArray = new string[52];
            m_playArray = new string[7][]; //7 Pile Arrays

            //Creating 19 slots in the 7 arrays in the jagged array.
            for (int i = 0; i < 7; i++)
            {
                m_playArray[i] = new string[19] {null, null, null, null, null, null,
                                                 null, null, null, null, null, null,
                                                 null, null, null, null, null, null,
                                                 null};
            }
            m_faceDownDeckArray = new string[52];
            m_faceUpDeckArray = new string[52];
            m_playArrayCounter = new int[7] { -1, -1, -1, -1, -1, -1, -1 };

            //Concatenate to Number + "of" + Suit
            //And add cards to faceDownDeck
            InitializeFaceDownDeckArray();

            //Shuffling the m_faceDownDeckArray         
            ShuffleDeck(m_faceDownDeckArray);

            PreparePlayArray();

            

            // display board the first time
            DisplayInstructions();
            // do first deal to have one card on fdace up deck
            Deal();
            DisplayBoard();

            // command processing loop
            do
            {
                Console.WriteLine("\nEnter Command: [Deal/Quit/Move] [play[#]/deck] [play[#]/pile] ");
                string command = Console.ReadLine();

                // Quit command will exit from this loop
                ProcessCommand(command);
                Console.Write("\n");
                DisplayBoard();
            } while (true);
        }   
            
        public static bool CanPlay(int currentCard, int pileNumber)
        {
            if (currentCard - pileNumber == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void InitializeFaceDownDeckArray()
        {
            //Suits Array below
            string[] Suits = new string[4]
            {   
                "Club", "Diamond", "Heart", "Spade"
            };
            string[] Values = new string[13]
            {
                "1" /*Ace*/, "2","3","4","5","6","7","8",
                "9","10","11" /*Jack*/,"12"/*Queen*/,"13" /*King*/
            };
            
            for (int z = 0; z < 4; z++)
            {
                for (int y = 0; y < 13; y++)
                {
                    m_faceDownDeckCounter++; //Since counter is initialized to -1
                    m_faceDownDeckArray[m_faceDownDeckCounter] = Values[y] + " of " + Suits[z];                   
                }
            }           
        }

        public static void ShuffleDeck(string[] m_faceDownDeckArray)
        {
            //Below, I'm creating a temporary variable for later in the program.
            string temporary;
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int RandomNumber = random.Next(0, 51);
                temporary = m_faceDownDeckArray[i];
                m_faceDownDeckArray[i] = m_faceDownDeckArray[RandomNumber];
                m_faceDownDeckArray[RandomNumber] = temporary;
            }
        }

        public static void PreparePlayArray()
        {
            for(int i = 0; i < 7; i++)
            {
                m_playArrayCounter[i]++; //Initialized to -1 earlier...
                m_playArray[i][m_playArrayCounter[i]] = RemoveFromFaceDownDeck();                
            }
        }

        public static void AddCardToPlayArray(int playArrayIndex, string card)
        {
            int counter = ++(m_playArrayCounter[playArrayIndex]);
            m_playArray[playArrayIndex][counter] = card;
        }

        public static string RemoveCardFromPlayArray(int playArrayIndex)
        {
            int counter = m_playArrayCounter[playArrayIndex];
            string card = m_playArray[playArrayIndex][counter];
            m_playArray[playArrayIndex][counter] = null;
            m_playArrayCounter[playArrayIndex]--;
            return card;
        }

        public static string RemoveFromFaceUpDeck()
        {
            string removedCard = null;
            if (m_faceUpDeckCounter >= 0)
            {
                removedCard = m_faceUpDeckArray[m_faceUpDeckCounter];
                m_faceUpDeckArray[m_faceUpDeckCounter] = null;
                m_faceUpDeckCounter--;
            }
            return removedCard;
        }

        public static string RemoveFromFaceDownDeck()
        {
            string removedCard = null;
            if (m_faceDownDeckCounter >= 0)
            {
                removedCard = m_faceDownDeckArray[m_faceDownDeckCounter];
                m_faceDownDeckArray[m_faceDownDeckCounter] = null;
                m_faceDownDeckCounter--;
            }
            return removedCard;
        }

        public static void ProcessCommand(string command)
        {
            string[] cmds = command.Split(' ');
            //Quit
            if(cmds.Length < 1)
            {
                Console.WriteLine("Incorrect command...");
                Environment.Exit(0);
            }

            if(cmds[0].ToLower() == "quit")
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }

            if(cmds[0].ToLower() == "deal")  //Deal
            {
                Deal();
            }                                                
            else if(cmds[0].ToLower() == "move")  //Move
            {                
                Move(cmds[1].ToLower(), cmds[2].ToLower());
            }

        }

        public static void Deal()
        {           
            m_faceUpDeckCounter++; //Initialized to -1 earlier
            m_faceUpDeckArray[m_faceUpDeckCounter] = RemoveFromFaceDownDeck();            
        }

        public static void Move(string cmd1, string cmd2)
        {
            int num1 = 0;
            int num2 = 0;           
            if(IsNumber(cmd1, out num1) && IsNumber(cmd2, out num2))  // play#, play#
            {              
                int sourceIndex = num1-1; //Because these are user provided 1-based number indexes.
                int targetIndex = num2-1; //Because these are user provided 1-based number indexes.

                string sourceCard = QueryPlayCard(sourceIndex);
                string targetCard = QueryPlayCard(targetIndex);

                if (GetValue(targetCard)-GetValue(sourceCard) != 1)
                {
                    Console.WriteLine("Invalid Card Movement!");
                }                
                else
                {
                    string card = RemoveCardFromPlayArray(sourceIndex);
                    AddCardToPlayArray(targetIndex, card);
                }
            }
            else if (IsNumber(cmd1, out num1) && cmd2 == "pile") // play#, pile
            {
                //1. Check which pile it corresponds to
                //2. Check if play num - pile num = 1
                //   If is, add to deck  
                int playArrayIndex = num1-1; //Because it is 1-based
                string card = QueryPlayCard(playArrayIndex);                                                                          
                MoveCardToPile("play", card, playArrayIndex);               
            }
            else if (cmd1 == "deck" && IsNumber(cmd2, out num2)) //deck, play#
            {
                //Deck to Play# - only if the bottom card of that row is one value higher and a different color 
                //(example – queen of hearts can play on king of spades or king of clubs)
                //move deck 4 where 4 is play array index (1-based index)
                //1. Check if play# card number - deck# card number = 1
                //   (if yes) Check suit
                //         (if suit Deck = diamond || heart , suit play# must be spade || club)
                int playArrayIndex = num2-1; //Since user provided 1-based index rather than 0-based
                string deckCard = QueryFaceupDeck();
                string playCard = QueryPlayCard(playArrayIndex);

                if (IsCompatibleCardForDeckToPlay(deckCard, playCard) == false)
                {
                    Console.WriteLine("incompatible");
                }
                else
                {
                    //move card from deck to play array
                    AddCardToPlayArray(playArrayIndex, RemoveFromFaceUpDeck());                   
                }
            }
            else if(cmd1 == "deck" && cmd2 == "pile") //deck, pile
            {
                //1. Check faceup has a card. If not, retrun
                //2. Check if faceup is ace
                //   if (faceup is ace) - add to corresponding pile
                //   else give error message and return
                //  
                if (m_faceUpDeckCounter < 0)
                {
                    Console.WriteLine("Need to Deal First!");
                }                
                else
                {
                    string deckCard = m_faceUpDeckArray[m_faceUpDeckCounter];
                    MoveCardToPile("deck", deckCard, 0); // 0 is ignored since it applies to the play scenario.                                                 
                }
            }           
        }

        public static bool IsNumber(string numString, out int numValue)
        {
            bool parsed = Int32.TryParse(numString, out numValue);
            if(parsed && numValue >= 1 && numValue <= 7)
            {
                return true; //wont execute returning false if this is true.
            }
            Console.WriteLine("Invalid Number! Enter again... ");
            return false;
        }

        public static string GetSuit(string card)
        {
            return card.Split(' ')[2];
        }

        public static int GetValue(string card)
        {
            return Convert.ToInt32(card.Split(' ')[0]);
        }

        public static string QueryFaceupDeck()
        {
            return m_faceUpDeckArray[m_faceUpDeckCounter];
        }

        public static string QueryPlayCard(int playArrayIndex)
        {
            int counter = m_playArrayCounter[playArrayIndex];
            string card = m_playArray[playArrayIndex][counter];
            return card;
        }

        public static void MoveFromPlayNumToPile(int playArrayIndex)
        {
            //1. Check which pile it corresponds to
            //2. Check if play num - pile num = 1
            //   If is, add to deck 

            string card = QueryPlayCard(playArrayIndex);

        }

        public static void MoveCardToPile(string source, string card, int playArrayIndex)
        {
            string CurrentSuit;
            int CurrentNumber;
            int PileNumber = 0;

            CurrentSuit = GetSuit(card);
            CurrentNumber = GetValue(card);

            //CanPlay(CurrentSuit, m_pileArray);

            //Now I will match the selected card with the corresponding suit.
            if (CurrentSuit == "Club") //If the selected card suit is club.
            {
                if (m_pileArray[0] != null)
                {
                    PileNumber = Convert.ToInt32(m_pileArray[0].Split(' ')[0]);
                }
                if (CanPlay(CurrentNumber, PileNumber))
                {
                    m_pileArray[0] = (source == "deck" ? RemoveFromFaceUpDeck() : RemoveCardFromPlayArray(playArrayIndex));                  
                    //Console.WriteLine(m_pileArray[1]);
                }
                else
                {
                    Console.WriteLine("Incorrect Card. Did Not Move");
                }
            }
            else if (CurrentSuit == "Diamond")//If the selected card suit is diamond.
            {
                if (m_pileArray[1] != null)
                {
                    PileNumber = Convert.ToInt32(m_pileArray[1].Split(' ')[0]);
                }
                if (CanPlay(CurrentNumber, PileNumber))
                {
                    m_pileArray[1] = (source == "deck" ? RemoveFromFaceUpDeck() : RemoveCardFromPlayArray(playArrayIndex));
                }
                else
                {
                    Console.WriteLine("Incorrect Card. Did Not Move");
                }
            }
            else if (CurrentSuit == "Heart")//If the selected card suit is heart.
            {
                if (m_pileArray[2] != null)
                {
                    PileNumber = Convert.ToInt32(m_pileArray[2].Split(' ')[0]);
                }
                if (CanPlay(CurrentNumber, PileNumber))
                {
                    m_pileArray[2] = (source == "deck" ? RemoveFromFaceUpDeck() : RemoveCardFromPlayArray(playArrayIndex));
                }
                else
                {
                    Console.WriteLine("Incorrect Card. Did Not Move");
                }
            }
            else if (CurrentSuit == "Spade")//If the selected card suit is spade
            {
                if (m_pileArray[3] != null)
                {
                    PileNumber = Convert.ToInt32(m_pileArray[3].Split(' ')[0]);
                }
                if (CanPlay(CurrentNumber, PileNumber))
                {
                    m_pileArray[3] = (source == "deck" ? RemoveFromFaceUpDeck() : RemoveCardFromPlayArray(playArrayIndex));
                }
                else
                {
                    Console.WriteLine("Incorrect Card. Did Not Move");
                }
            }
        }

        public static bool IsCompatibleCardForDeckToPlay(string deckCard, string playCard)
        {
            int deckCardNum = GetValue(deckCard);
            string deckCardSuit = GetSuit(deckCard);
            int playCardNum = GetValue(playCard);
            string playCardSuit = GetSuit(playCard);

            if(playCardNum - deckCardNum != 1)
            {
                return false;
            }

            if(deckCardSuit == "Club" && playCardSuit == "Club" ||
                deckCardSuit == "Club" && playCardSuit == "Spade" ||
                deckCardSuit == "Spade" && playCardSuit == "Spade" ||
                deckCardSuit == "Spade" && playCardSuit == "Club")
            {
                return false;
            }

            if (deckCardSuit == "Diamond" && playCardSuit == "Heart" ||
                deckCardSuit == "Heart" && playCardSuit == "Diamond" ||
                deckCardSuit == "Heart" && playCardSuit == "Heart" ||
                deckCardSuit == "Diamond" && playCardSuit == "Diamond")
            {
                return false;
            }

            return true;
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("INSTRUCTIONS: Choose your moves to win the game of Solitaire");
            Console.WriteLine("Add a space between your commands in a command line.");
            Console.WriteLine("For Example: Move 2 3  --> This will move card from play row 2 to row 3\n");
        }

        public static void DisplayBoard()
        {
            Console.WriteLine("\n\n\n****** BOARD: ******");      
            string emptyCard = "--           ";

            // [pile1] [pile2] [pile3] [pile4]      [faceUpDeck] [faceDownDeck]
            // [play1] [play2] [play3] [play4] [play5] [play6] [play7]
            // Enter Command: [Deal/Quit/Move] [play[#]/deck] [play[#]/pile]
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0, -13}  ", (m_pileArray[i] == null ? emptyCard : m_pileArray[i]));
            }

            Console.ForegroundColor = ConsoleColor.Red;
            if (m_faceUpDeckCounter == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("FaceUp: {0, -13}  ", emptyCard);
            }
            else
            {
                Console.Write("FaceUp: {0, -13}  ", m_faceUpDeckArray[m_faceUpDeckCounter]);
            }

            if (m_faceDownDeckCounter == -1)
            {
                Console.Write("FaceDown: {0, -13}  ", emptyCard);
            }
            else
            {
                Console.Write("FaceDown: {0, -13}  ", m_faceDownDeckArray[m_faceDownDeckCounter]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            // find higest play row length
            // print play rows
            int higestPlayRowLength = 0;
            for (int j = 0; j < m_playArray[0].Length; j++)
            {
                for (int i = 0; i < m_playArray.Length; i++)
                {
                    if (m_playArray[i][j] != null)
                    {
                        higestPlayRowLength = j;
                    } 
                }
            }

            // print play rows
            for (int j = 0; j <= higestPlayRowLength; j++)
            {
                for (int i = 0; i < m_playArray.Length; i++)
                {                    
                    Console.Write("{0, -13}  ", m_playArray[i][j] == null ? emptyCard : m_playArray[i][j]);
                }
                Console.WriteLine();
            }


            
        }
    }
}
//END OF CODE