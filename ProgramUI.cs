using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mad_Libs_Game
{
    class ProgramUI
    {
        private readonly Interstellar _interstellarStory = new Interstellar();
        private readonly Destiny _destinyStory = new Destiny();
        private readonly SoundPlayer _soundPlayer = new SoundPlayer();
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();

                Console.WriteLine("Please enter the option number for the adventure you'd like to experience: \n" +
                    "1) Interstellar \n" +
                    "2) Destiny \n" +
                    "3) Exit");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        //Show All
                        _interstellarStory.InterstellarMusic();
                        _interstellarStory.InterstellarInputs();
                        _interstellarStory.InterstellarStory();
                        _interstellarStory.InterstellarPlayerStop(_soundPlayer);
                        Console.Clear();
                        break;

                    case "2":
                        _destinyStory.DestinyMusic();
                        _destinyStory.DestinyUserInputs();
                        _destinyStory.DestinyStory();
                        _destinyStory.DestinyPlayerStop(_soundPlayer);
                        Console.Clear();
                        break;

                    case "3":
                        //Exit
                        continueToRun = false;
                        break;

                    default:
                        //default
                        Console.WriteLine("Please enter a valid number between 1 and 3. \n" +
                            "Press any key to continue......");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
    

