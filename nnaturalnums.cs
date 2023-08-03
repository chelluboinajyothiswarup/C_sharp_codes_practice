// Print n natural numbers using for, while, do while
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter the Nmuber: ");
      int x = Convert.ToInt32(Console.ReadLine());
      
      //using for loop
      for(int i=0;i<x;i++){
          Console.Write(i);
      }
      
      
      Console.WriteLine();
      
      // using while loop
      int y = 0;
      while(y<x){
          Console.Write($"{y} ");
          y++;
      }
      Console.WriteLine();
      //using dowhile
      int c = 0;
      do{
          Console.Write(c);
          c++;
      }while(c<x);
      
      
      
  }
}
