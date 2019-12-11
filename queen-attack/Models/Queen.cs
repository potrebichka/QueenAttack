
using System;

namespace QueenAttacks.Models {
    public class Queen{
        private int XQ;
        private int YQ;

        public Queen(int x,int y){
            XQ = x;
            YQ = y;
        }

        public bool checkCoordinates(int XC, int YC){
            if(XQ==XC && YQ==YC){
                return true;
            }
            else if((XQ-XC)==(YQ-YC)){
                return true;
            }
            else if((XQ-XC)==(YC-YQ)){
                return true;
            } 
            return false;
        }
    }
}
