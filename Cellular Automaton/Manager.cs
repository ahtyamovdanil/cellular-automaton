using System;

namespace Cellular_Automaton{
    public class Manager{
        public static void Main(string[] args){
            int a=1;
            char b='n';
            String r = "qwertyu";
            Wolfram wolfram = new Wolfram(3000,200);
            Wolfram wolfram2 = new Wolfram(2000,100);
            wolfram.set_cell(0,100);
            //wolfram.set_cell(1,99);
            //wolfram.set_cell(1,101);
            wolfram.rule_161();
            wolfram.draw(); 
        }
    }
}