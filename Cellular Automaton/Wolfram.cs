using System;

namespace Cellular_Automaton{
    public class Wolfram{
        
        private int height;
        private int width;
        private bool[,] matrix;

        public Wolfram(int height, int width){
            this.height = height;
            this.width = width;
            matrix = new bool[height,width];
            for (int i = 0; i < height; i++){
                for (int j = 0; j < width; j++){
                    matrix[i, j] = false;
                }         
            }
        }

        public void set_cell(int x, int y){
            matrix[x, y] = true;
        }

        public void rule_30(){
            int t1, t2;
            for (int i = 1; i < height; i++){               
                for (int j = 0; j < width; j++){
                    if (j == 0){
                        t1 = width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }
            if (((matrix[i - 1, t1]) && !(matrix[i - 1, j]) && !(matrix[i - 1, t2])) ||
                (!(matrix[i - 1, t1]) && (matrix[i - 1, j]) && (matrix[i - 1, t2])) ||
                (!(matrix[i - 1, t1]) && (matrix[i - 1, j]) && !(matrix[i - 1, t2])) ||
                (!(matrix[i - 1, t1]) && !(matrix[i - 1, j]) && (matrix[i - 1, t2])) 
            ) matrix[i, j] = true;
                }         
            }
        }
        
        public void rule_110(){
            int t1, t2;
            for (int i = 1; i < height; i++){               
                    for (int j = 0; j < width; j++){
                    if (j == 0){
                        t1 = width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }
                    if (((matrix[i - 1, t1]) && (matrix[i - 1, j]) && !(matrix[i - 1, t2])) ||
                        ((matrix[i - 1, t1]) && !(matrix[i - 1, j]) && (matrix[i - 1, t2])) ||
                        (!(matrix[i - 1, t1]) && (matrix[i - 1, j]) && (matrix[i - 1, t2])) ||
                        (!(matrix[i - 1, t1]) && (matrix[i - 1, j]) && !(matrix[i - 1, t2])) ||
                        (!(matrix[i - 1, t1]) && !(matrix[i - 1, j]) && (matrix[i - 1, t2]))
                    ) matrix[i, j] = true;
                }         
            }
        }
        
        public void rule_161(){
            int t1, t2;
            for (int i = 1; i < height; i++){
                for (int j = 0; j < width; j++){
                    if (j == 0){
                        t1 = width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }

                    if (((matrix[i - 1, t1]) && (matrix[i - 1, j]) && (matrix[i - 1, t2])) ||
                        ((matrix[i - 1, t1]) && !(matrix[i - 1, j]) && (matrix[i - 1, t2])) ||
                        (!(matrix[i - 1, t1]) && !(matrix[i - 1, j]) && !(matrix[i - 1, t2]))
                    ) matrix[i, j] = true;
                }         
            }
        }

        public void draw(){
            Console.SetWindowPosition(0,0);   // sets window position to upper left
            Console.SetBufferSize(450,1000);   // make sure buffer is bigger than window
            Console.SetWindowSize(450,140);   //set window size to almost full screen 
            for (int i = 0; i < height; i++){
                for (int j = 0; j < width; j++){
                    if (matrix[i, j]) Console.Write("{0} ", 'X');
                    else Console.Write("{0} ", " ");
                    //System.Threading.Thread.Sleep(1);
                }         
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}