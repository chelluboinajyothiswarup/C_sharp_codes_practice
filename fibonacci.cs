// fibonacci series
using System;
class HelloWorld {
  static void Main() {
    int a = 0;
    int b = 1;
    int c = 0;
    Console.WriteLine(a);
    Console.WriteLine(b);
    for(int i=2;i<10;i++){
        c = a+b;
        Console.WriteLine(c);
        a = b;
        b = c;
    }
  }
}
