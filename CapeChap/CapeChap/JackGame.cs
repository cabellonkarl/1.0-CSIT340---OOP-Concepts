using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CapeChap.JackGame;
using static System.Net.Mime.MediaTypeNames;

namespace CapeChap
{
    public class JackGame
    {
        public string nickName { get; set; } 
        public string LvlofChar { get; set; } //Master, Novice , Beginner
        /// <summary>
		/// [ENCAPSULATION]
		/// <insert Encapsulation is used in this fields due to the fact that the type of information you will see needs to be protected.     
        ///         I tried running it in the Arch.cs using the gamePin and server but
        ///         I will receive an error about its not accessible due to its protection level.
        ///         As you can see it has a getter and setter this is so I can pass it to another class since this are private fields.
        ///         I cant access it to the others so I used the get and set Pin and Ser which
        ///         are accessors so I can access this private fields and show it in my Main if I want to when I run the project.>
		/// </summary>
        private string gamePin; // Encapsulation 
        private string server; // Encapsulation //HongKong, United States, Tokyo, United Kingdom

        public string Pin
        {
            get { return gamePin; }
            set { gamePin = value; }
        }
        public string Ser
        {
            get { return server; }
            set { server = value; }
        }
        public virtual string GetInfoG()
        {
            return "\tCustomer:" + nickName + "(" + LvlofChar + ") " + "\n\tGame Pin: " + gamePin + "\n\tType Of Server: " + server + "\n"; 
        }
    }
}

