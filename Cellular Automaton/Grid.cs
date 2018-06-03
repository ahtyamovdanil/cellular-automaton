using System;
using System.Linq.Expressions;

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
        
        public void Draw(int delay){
            Console.SetWindowPosition(0,0);  
            Console.SetBufferSize(800,800);   
            for (int i = 0; i < height; i++){
                for (int j = 0; j < width; j++){
                    if (matrix[i, j]) Console.Write("{0} ", '\u25A0');
                    else Console.Write("{0} ", " ");
                    System.Threading.Thread.Sleep(delay);   //set delay for each cell drawing
                }         
                Console.WriteLine();
            }
        }

        public void SetShape(String shape, int x, int y){
            switch (shape){
                case "glider":
                    SetSell(x, y + 2, true);
                    SetSell(x + 1, y, true);
                    SetSell(x + 1, y + 2, true);
                    SetSell(x + 2, y + 1, true);
                    SetSell(x + 2, y + 2, true);
                    break;
                case "LWSS": //lightweight spaceship
                    SetSell(x, y + 1, true);
                    SetSell(x, y + 4, true);
                    SetSell(x + 1, y, true);
                    SetSell(x + 2, y, true);
                    SetSell(x + 2, y + 4, true);
                    SetSell(x + 3, y, true);
                    SetSell(x + 3, y + 1, true);
                    SetSell(x + 3, y + 2, true);
                    SetSell(x + 3, y + 3, true);
                    break;
                case "toad":
                    SetSell(x + 1, y + 1, true);
                    SetSell(x + 1, y + 2, true);
                    SetSell(x + 1, y + 3, true);
                    SetSell(x + 2, y, true);
                    SetSell(x + 2, y + 1, true);
                    SetSell(x + 2, y + 2, true);
                    break;
            }
        }

        public void SetRandom(){
            Random random = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    SetSell(i,j,random.Next(0,2)==1);
                }
            }
        }

        public void Clean(){
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    SetSell(i, j, false);
                }
            }
        }

        public object Clone(){
            Grid grid = new Grid(height, width);
            grid.matrix = (bool[,])matrix.Clone();
            return grid;
        }
  }    
}


