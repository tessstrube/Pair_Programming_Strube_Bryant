using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mad_Libs_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            ProgramUI newStory = new ProgramUI();
            newStory.Run();
        }
    }
}

