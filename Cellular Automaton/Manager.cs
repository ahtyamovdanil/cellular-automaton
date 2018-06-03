using System;

namespace Cellular_Automaton{
    public class Manager{
        public static void Main(string[] args){

            


            //creating new Grid object with 2 parametres: height, width
            Grid grid = new Grid(70, 70);


            Console.WriteLine("ATTENTION: set font size 10 and window size 140x75 minimum (for 70x70 grid)");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();


            //setting grid сell with true value in coordinates 0:50 
            grid.SetSell(0, 50, true);

            //creating new Wolfram object
            Wolfram wolfram = new Wolfram();

            //setting 161st rule for the grid (avaliable 3 rules: 30, 110, 161)
            wolfram.SetRule161(grid);       
                                            
            //printing the grid in the console
            grid.Draw(0);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();




            //creating new Life object with current grid as parameter
            Life life = new Life(grid);
            
            //filling the grid with true,false in random order
            grid.SetRandom();
            
            //runing game-life in the console with delay =0 count of stages =50
            life.Run(0, 50);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();





            //filling the grid with false values.
            grid.Clean();                   

            //setting shapes to the grid.
            //methodes take 3 parametres: shape name, coordinate 1, coordinate 2
            grid.SetShape("glider", 0, 0);  
            grid.SetShape("toad", 10, 10);
            grid.SetShape("LWSS", 50, 30);

            //re-create the Life object with the updated grid.
            life = new Life(grid);

            //runing game-life in the console delay =0 count of stages =100.
            life.Run(0, 100);
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}