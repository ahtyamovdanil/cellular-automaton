using System;

namespace Cellular_Automaton{
    public class Manager{
        public static void Main(string[] args){ 
            Grid grid = new Grid(500, 100);
                
            //grid.SetShape("glider",0,0); //avaliable 3 shapes: glider, LWSS, toad
            //grid.SetShape("toad",0,0);
            //grid.SetRandom();
            grid.SetSell(0, 50, true);
            
            //grid.Draw();            
            //Console.ReadKey();
            //Life life = new Life(grid);
            Wolfram wolfram = new Wolfram();
            wolfram.SetRule161(grid);
            grid.Draw();
            Console.ReadKey();
            //life.Run();
            //wolfram.r
        }
    }
}