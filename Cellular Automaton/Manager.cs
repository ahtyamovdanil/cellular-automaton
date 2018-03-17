using System;

namespace Cellular_Automaton{
    public class Manager{
        public static void Main(string[] args){ 
            Grid grid = new Grid(100, 100);
            /*grid.SetSell(1,3,true);
            grid.SetSell(2,1,true);
            grid.SetSell(2,3,true);
            grid.SetSell(3,2,true);
            grid.SetSell(3,3,true);*/  //glider
                Random random = new Random();
                for (int i = 0; i < 100; i++){
                    for (int j = 0; j < 100; j++){
                        //Console.WriteLine(random.Next(0,2));
                        grid.SetSell(i,j,random.Next(0,2)==1);
                    }
                }
            grid.Draw();            
            //Console.ReadKey();
//            grid.SetSell(2,4,true);
//            grid.SetSell(3,4,true);
//            grid.SetSell(4,4,true);  //stick
            Life life = new Life(grid);
            life.Run();
        }
    }
}