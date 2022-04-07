using abstraindo_poo.src.entities;
using static System.Console;


class Program       
 {
    static void Main(string[] args)
    {

        Wizard wolf = new Wizard ("Wolf", 23, "White Wizard");
        Wizard topapa = new Wizard ("Topapa", 32, "Black Wizard");
        Knight arus = new Knight ("Arus", 19, "Knight");
        Ninja wedge = new Ninja ("Wedge", 43, "Ninja");
        Knight viking = new Knight("Viking", 15, "Warrior");

        WriteLine(wolf.Attack());
        WriteLine(topapa.Attack());
        WriteLine(arus.Attack());
        WriteLine(wedge.Attack());
        WriteLine(viking.Attack());
 
    }   
    
}