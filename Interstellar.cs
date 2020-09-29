using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mad_Libs_Game
{
    public class Interstellar
    {
        string name, sillyWord, favNumber, adjectiveOne, noun, adjectiveTwo, familyMember, adjectiveThree, verb, adjectiveFour, adjectiveFive;

        SoundPlayer _soundPlayer = new SoundPlayer();
        public void InterstellarInputs()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("You're about to embark on an interstellar adventure. Press Enter to prepare for lift off!");
            Console.ReadLine();

            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter a silly word: ");
            sillyWord = Console.ReadLine();

            Console.WriteLine("Enter your favorite number: ");
            favNumber = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveOne = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveTwo = Console.ReadLine();

            Console.WriteLine("Enter a family member's name: ");
            familyMember = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveThree = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            verb = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveFour = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjectiveFive = Console.ReadLine();
        }

        public void InterstellarStory()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine($"Hello my name is {name} , I'm an astronaut.");
            Console.WriteLine($"I am on my way to a planet called {sillyWord}");
            Console.WriteLine($"I will be gone for {favNumber} years.");
            Console.WriteLine($"I am very {adjectiveOne} about the trip but I will miss my {noun}.");
            Console.WriteLine($"I know that space travel is {adjectiveTwo} but I must save humanity.");
            Console.WriteLine($"Luckily my {familyMember} will be able to send me videos to keep me {adjectiveThree}.");
            Console.WriteLine($"When I land on the planet I will {verb} for joy.");
            Console.WriteLine($"I am {adjectiveFour} to walk on another planet.");
            Console.WriteLine($"But I must travel through a blackhole to reach {sillyWord}. This is extremely {adjectiveFive} for me!");
            Console.ReadLine();

            Console.ResetColor();

        }
        public void InterstellarMusic()
        {
            SoundPlayer soundPlayer = _soundPlayer;
            {
                _soundPlayer.SoundLocation = @"C:\ElevenFiftyProjects\Mad Libs Game\Life.wav";
            };
            soundPlayer.PlayLooping();
        }

        public void InterstellarPlayerStop(SoundPlayer soundPlayer)
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

