using System;

namespace Cellular_Automaton{
    public class Grid : ICloneable{
        
        private int height;
        private int width;
        private bool[,] matrix;

        public int Height{
            get { return height; }
            set { height = value; }
        }

        public int Width{
            get { return width; }
            set { width = value; }
        }

        public bool[,] Matrix{
            get { return matrix; }
            set { matrix = value; }
        }

        public Grid(int height, int width){
            this.height = height;
            this.width = width;
            matrix = new bool[height,width];
            for (int i = 0; i < height; i++){
                for (int j = 0; j < width; j++){
                    matrix[i, j] = false;
                }         
            }
        }
        
        public void SetSell(int h, int w, bool value){
            matrix[h, w] = value;
        }

        public int NeighborsCount(int h, int w){
            int count = 0;
            for (int i = h - 1; i <= h + 1; i++){
                int t1 = i;
                if (i >= height) t1 = 0;
                if (i < 0) t1 = height-1;
                for (int j = w - 1; j <= w + 1; j++){
                    int t2 = j;
                    if (j >= width) t2 = 0;
                    if (j < 0) t2 = width-1;
                    if (matrix[t1, t2]) count++;
                }
            }
            if (matrix[h, w]) count--;
            return count;
        }
        
        public void Draw(){
            Console.SetWindowPosition(0,0);   // sets window position to upper left
            Console.SetBufferSize(450,1000);   // make sure buffer is bigger than window
            //Console.SetWindowSize(450,140);   //set window size to almost full screen 
            for (int i = 0; i < height; i++){
                for (int j = 0; j < width; j++){
                    if (matrix[i, j]) Console.Write("{0} ", 'X');
                    else Console.Write("{0} ", " ");
                    //System.Threading.Thread.Sleep(1);   //set delay for each cell drawing
                }         
                Console.WriteLine();
            }
            //Console.ReadKey();
        }

        public object Clone(){
            Grid grid = new Grid(height, width);
            grid.matrix = (bool[,])matrix.Clone();
            return grid;
        }
    }
}