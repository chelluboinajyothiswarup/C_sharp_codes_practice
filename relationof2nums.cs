// relation b/w numbers.
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter the first Nmuber: ");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the second Nmuber: ");
      int y = Convert.ToInt32(Console.ReadLine());
      if(x>y){
          Console.WriteLine($"{x} is greater than {y}");
      }
      else if(x==y){
          Console.WriteLine($"{x} is equal to {y}");
      }
      else{
          Console.WriteLine($"{y} is greater than {x}");
      }
  }
}
