using System;

namespace Cellular_Automaton{
    public class Life{
        
        private Grid _gridLast;
        private Grid _gridCurrent;

        public Life(Grid grid){
            _gridLast = grid;
            _gridCurrent = grid;
        }

        public Grid GridLast{
            get { return _gridLast; }
            set { _gridLast = value; }
        }

        public Grid GridCurrent{
            get { return _gridCurrent; }
            set { _gridCurrent = value; }
        }

        public void SetCell(int x, int y, bool value){
            _gridLast.SetSell(x, y, value);
        }

        public void Run(){
            int stage = 0;
            while (true){
                stage++;
                _gridCurrent = (Grid)_gridLast.Clone();
                for (int i = 0; i < _gridLast.Height; i++){
                    for (int j = 0; j < _gridLast.Width; j++){
                        if (!_gridLast.Matrix[i, j] && _gridLast.NeighborsCount(i, j) == 3)
                            _gridCurrent.SetSell(i, j, true);
                        if (_gridLast.Matrix[i, j] &&
                            (_gridLast.NeighborsCount(i, j) < 2 || _gridLast.NeighborsCount(i, j) > 3)){
                            _gridCurrent.SetSell(i, j, false);
                        }
                    }
                }
                Console.SetCursorPosition(0, 0);
                 _gridCurrent.Draw();
                Console.WriteLine("stage: "+stage);
                _gridLast = _gridCurrent;                
            }
        }
    }
}