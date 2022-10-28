using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapeChap
{
    /// <summary>
    /// [INHERITANCE]
    /// <insert as you can see here inheritance means to inherit fields and methods from a class. To be more specific it means that creating a new class from an existing class.
    ///         Arch class is inheriting from JackGame it can access the different fields in JackGame.cs.
    ///         I used the said OOP Concept here since I need different types of Character for my Game Info.
    ///         The purpose why I used Inheritance here is to simply add the different types of Character in the Game.>
    /// </summary>
    public class Arch : JackGame // inheritance
    {
        public String Archer { get; set; }
        public override string GetInfoG() //Polymorphism
        {
            return "\tPlayer:" + nickName + "(" + LvlofChar + ") " + "\n\tType Of Character: " + Archer + "\n\tGame Pin: " + Pin + "\n\tType Of Server: " + Ser + "\n";
        }
    }
    public class War : JackGame // inheritance
    {
        public String Warrior { get; set; }
        /// <summary>
        /// [POLYMORPHISM]
        /// <insert From what I understood Polymorphism is all about overriding data or simply having the ability to use the methods.
        ///         As you can see here I used this to override the data by using the methods here in this class and using it in different ways.
        ///         in the Arch class you can see I used Arch and in the Warrrior class I used warrior but it is still the same method GetInfoG
        ///         I used it here so I can simply change the data easily since the inheritance classes are all from the same parent class JackGame>
        /// </summary>
        public override string GetInfoG() //Polymorphism
        {
            return "\tPlayer: " + nickName + "(" + LvlofChar + ") " + "\n\tType Of Character: " + Warrior + "\n\tGame Pin: " + Pin + "\n\tType Of Server: " + Ser + "\n";
        }
    }
    public class Ma : JackGame // inheritance
    {
        public String Mage { get; set; }

        public override string GetInfoG() //Polymorphism
        {
            return "\tCustomer:" + nickName + "(" + LvlofChar + ") " + "\n\tType Of Character: " + Mage + "\n\tGame Pin: " + Pin + "\n\tType Of Server: " + Ser + "\n";
        }
    }
}
