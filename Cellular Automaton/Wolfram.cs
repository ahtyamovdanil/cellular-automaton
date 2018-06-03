using System;

namespace Cellular_Automaton{
    public class Wolfram{
        
        //private int grid.Height;
        //private int grid.Width;
        //private bool[,] grid.Matrix;
        //private Grid grid;
        
        public Wolfram(){
            //grid = grid;
        }

        public void SetRule30(Grid grid){
            int t1, t2;
            for (int i = 1; i < grid.Height; i++){               
                for (int j = 0; j < grid.Width; j++){
                    if (j == 0){
                        t1 = grid.Width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == grid.Width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }
            if (((grid.Matrix[i - 1, t1]) && !(grid.Matrix[i - 1, j]) && !(grid.Matrix[i - 1, t2])) ||
                (!(grid.Matrix[i - 1, t1]) && (grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2])) ||
                (!(grid.Matrix[i - 1, t1]) && (grid.Matrix[i - 1, j]) && !(grid.Matrix[i - 1, t2])) ||
                (!(grid.Matrix[i - 1, t1]) && !(grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2])) 
            ) grid.Matrix[i, j] = true;
                }         
            }
        }
        
        public void SetRule110(Grid grid){
            int t1, t2;
            for (int i = 1; i < grid.Height; i++){               
                    for (int j = 0; j < grid.Width; j++){
                    if (j == 0){
                        t1 = grid.Width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == grid.Width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }
                    if ((grid.Matrix[i - 1, t1]) && (grid.Matrix[i - 1, j]) && !(grid.Matrix[i - 1, t2]) ||
                        (grid.Matrix[i - 1, t1]) && !(grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2]) ||
                        !(grid.Matrix[i - 1, t1]) && (grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2]) ||
                        !(grid.Matrix[i - 1, t1]) && (grid.Matrix[i - 1, j]) && !(grid.Matrix[i - 1, t2]) ||
                        !(grid.Matrix[i - 1, t1]) && !(grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2])
                    ) grid.Matrix[i, j] = true;
                }         
            }
        }
        
        public void SetRule161(Grid grid){
            int t1, t2;
            for (int i = 1; i < grid.Height; i++){
                for (int j = 0; j < grid.Width; j++){
                    if (j == 0){
                        t1 = grid.Width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == grid.Width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }

                    if ((grid.Matrix[i - 1, t1]) && (grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2]) ||
                        (grid.Matrix[i - 1, t1]) && !(grid.Matrix[i - 1, j]) && (grid.Matrix[i - 1, t2]) ||
                        (!(grid.Matrix[i - 1, t1]) && !(grid.Matrix[i - 1, j]) && !grid.Matrix[i - 1, t2])
                    ) grid.Matrix[i, j] = true;
                }         
            }
        }
    }
}