using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapeChap 
{
    /// <summary>
    /// [ABSTRACTION]
    /// <insert From what I understood is that abstraction is still hiding data but only the most important. Its all about showing result but I wont show you the type of
    ///         tasks or what I performed to achieve that. In this class I used abstract to understand it more from the abstract class you can see that I called giveQuest
    ///         without creating giveQuest first the reason for this is so that I can only show the result and not the process behind it. 
    ///         I used it here in this class to show that the Player is done creating his Character and he must proceed to the Town Square.
    ///         Its simply skipping the details and just go straight to the answer to protect the data around it>
    /// </summary>
    public abstract class Instructions // abstraction
    {
        public abstract void giveQuest();
        public void showQuest()
        {
            Console.WriteLine("Go to the Town Square Now!!!\n");
        }
    }

    class Quest  : Instructions
    {
        public override void giveQuest()
        {
            Console.WriteLine("Congratulations on Completing the Creation of Your Character");
        }
    }
}
