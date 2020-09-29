using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mad_Libs_Game
{
    public class Destiny
    {
        string name, planetName, favNumber, adjectiveOne, noun, adjectiveTwo, villainName, verb, adjectiveThree, adjectiveFour;

        SoundPlayer _soundPlayer = new SoundPlayer();
        public void DestinyUserInputs()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.WriteLine("Come to me Warrior of Light! Press Enter to begin your Destiny!");
            Console.ReadLine();

            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter a planet name: ");
            planetName = Console.ReadLine();

            Console.WriteLine("Enter your favorite number: ");
            favNumber = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveOne = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveTwo = Console.ReadLine();

            Console.WriteLine("Enter a villain's name: ");
            villainName = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            verb = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveThree = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveFour = Console.ReadLine();
        }

        public void DestinyStory()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            Console.WriteLine($"Hello guardian, I'm your ghost. You can call me, {name}.");
            Console.WriteLine($"I was exploring {planetName} and I found your body.");
            Console.WriteLine($"You have been dead for {favNumber} years.");
            Console.WriteLine($"I am so {adjectiveOne} that I found you. With your light now  restored we can begin our journey to save {noun}.");
            Console.WriteLine($"Don't be {adjectiveTwo}, your light is strong enough to take on the universe.");
            Console.WriteLine($"Not even {villainName} can stand in our way!");
            Console.WriteLine($"We must {verb} for {villainName} and destroy them along with their army.");
            Console.WriteLine($"Only then may the universe be {adjectiveThree} again.");
            Console.WriteLine($"I've prepared your jump ship to leave {planetName} at once.");
            Console.WriteLine($"The journey and mission will be {adjectiveFour}, but this is your destiny!");
            Console.ReadLine();

            Console.ResetColor();


        }
        public void DestinyMusic()
        {
            SoundPlayer soundPlayer = _soundPlayer;
            {
                _soundPlayer.SoundLocation = @"C:\ElevenFiftyProjects\Mad Libs Game\Inner Light.wav";
            };
            soundPlayer.PlayLooping();
        }

        public void DestinyPlayerStop(SoundPlayer soundPlayer)
        {
            soundPlayer = _soundPlayer;
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
                soundPlayer.Dispose();
            }
        }
    }
}
    


    
