
using System;
class QueenAttacks{
    static void Main(){
        //Console.WriteLine("Please Enter 1 to start: ");
        //int number = int.Parse(Console.ReadLine());
        int number=0;
        do{
            Console.WriteLine("Please Enter x coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter another coordinate: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter another coordinate: ");
            int b = int.Parse(Console.ReadLine());

            Queen x_y = new Queen(x,y,a,b);
            if(x_y.checkCoordinates()==true){
                Console.WriteLine("x and y coordinates match with Queen coordinates.");
            }
            else{
                Console.WriteLine("x and y coordinates dont't match with Queen coordinates.");
            }
            Console.WriteLine("Please Enter 1 to continue or any number to exit the program: ");
            number = int.Parse(Console.ReadLine());
        }while(number==1);
        Console.WriteLine("See you next time!");
        

    }
}
public class Queen{
    public int X;
    public int Y;
    public int A;
    public int B;
    public Queen(int x,int y,int a, int b){
        X = x;
        Y = y;
        A = a;
        B = b;
    }

    public bool checkCoordinates(){
        if(X==A && Y==B){
            return true;
        }
        else if((X-A)==(Y-B)){
            return true;
        }
        else if((X-A)==(B-Y)){
            return true;
        }
        
        return false;
        
    }
    // public bool checkCoordinates(){
    //     if(X==Y){
    //         return true;
    //     }
    //     else if(X==0 && Y=!0){
    //         return true;
    //     }
    //     else if(Y==0 && X!=0){
    //         return true;
    //     }
    //     else{
    //         return false;
    //     }
    // }

    
}