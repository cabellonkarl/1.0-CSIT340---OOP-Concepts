using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CapeChap
{
    public class program
    {
        public static void ShowInfo(JackGame j) //method to get details from the JackGame class if you ask why the other things in main like Arch War and Ma can still be used its
                                                //because it is derived from the JackGame class
        {
            string details = j.GetInfoG();
            Console.WriteLine(details);
            Console.ReadLine();
        }
        static void Main(string[] args) // main method
        {
            Console.WriteLine("\t\tJack Game");
            Quest que = new Quest();
            que.giveQuest();
            que.showQuest();

            //Console.WriteLine("Player Info: ");
            //JackGame g = new JackGame();
            //g.nickName = "Littl3Monster";
            //g.LvlofChar = "Master";
            //g.Ser = "United States";
            //g.Pin = "1123";
            Arch j = new Arch();
            j.nickName = "Littl3Monster";
            j.LvlofChar = "Master";
            j.Archer = "Archer";
            j.Ser = "United States";
            j.Pin = "1123";
            //War war = new War();
            //war.nickName = "Bigg3rMonster";
            //war.LvlofChar = "Novice";
            //war.Warrior = "Warrior";
            //war.Ser = "Tokyo";
            //war.Pin = "1441";
            //Ma m = new Ma();
            //m.nickName = "Mod3rateMonster";
            //m.LvlofChar = "Beginner";
            //m.Mage = "Mage";
            //m.Ser = "United Kingdom";
            //m.Pin = "1881";
            

            ShowInfo(j);

        }
    }
}

