using System;

namespace Cellular_Automaton{
    public class Wolfram{
        
        //private int grid.Height;
        //private int grid.Width;
        //private bool[,] grid.Matrix;
        private Grid _grid;
        
        public Wolfram(Grid grid){
            this._grid = grid;
        }

        public Grid Grid{
            get { return _grid; }
            set { _grid = value; }
        }

        public void SetRule30(){
            int t1, t2;
            for (int i = 1; i < _grid.Height; i++){               
                for (int j = 0; j < _grid.Width; j++){
                    if (j == 0){
                        t1 = _grid.Width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == _grid.Width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }
            if (((_grid.Matrix[i - 1, t1]) && !(_grid.Matrix[i - 1, j]) && !(_grid.Matrix[i - 1, t2])) ||
                (!(_grid.Matrix[i - 1, t1]) && (_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2])) ||
                (!(_grid.Matrix[i - 1, t1]) && (_grid.Matrix[i - 1, j]) && !(_grid.Matrix[i - 1, t2])) ||
                (!(_grid.Matrix[i - 1, t1]) && !(_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2])) 
            ) _grid.Matrix[i, j] = true;
                }         
            }
        }
        
        public void SetRule110(){
            int t1, t2;
            for (int i = 1; i < _grid.Height; i++){               
                    for (int j = 0; j < _grid.Width; j++){
                    if (j == 0){
                        t1 = _grid.Width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == _grid.Width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }
                    if (((_grid.Matrix[i - 1, t1]) && (_grid.Matrix[i - 1, j]) && !(_grid.Matrix[i - 1, t2])) ||
                        ((_grid.Matrix[i - 1, t1]) && !(_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2])) ||
                        (!(_grid.Matrix[i - 1, t1]) && (_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2])) ||
                        (!(_grid.Matrix[i - 1, t1]) && (_grid.Matrix[i - 1, j]) && !(_grid.Matrix[i - 1, t2])) ||
                        (!(_grid.Matrix[i - 1, t1]) && !(_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2]))
                    ) _grid.Matrix[i, j] = true;
                }         
            }
        }
        
        public void SetRule161(){
            int t1, t2;
            for (int i = 1; i < _grid.Height; i++){
                for (int j = 0; j < _grid.Width; j++){
                    if (j == 0){
                        t1 = _grid.Width - 1;
                        t2 = j + 1;
                    } else 
                    if (j == _grid.Width - 1){
                        t1 = j - 1;
                        t2 = 0;
                    }
                    else{
                        t1 = j - 1;
                        t2 = j + 1;
                    }

                    if (((_grid.Matrix[i - 1, t1]) && (_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2])) ||
                        ((_grid.Matrix[i - 1, t1]) && !(_grid.Matrix[i - 1, j]) && (_grid.Matrix[i - 1, t2])) ||
                        (!(_grid.Matrix[i - 1, t1]) && !(_grid.Matrix[i - 1, j]) && !(_grid.Matrix[i - 1, t2]))
                    ) _grid.Matrix[i, j] = true;
                }         
            }
        }
    }
}