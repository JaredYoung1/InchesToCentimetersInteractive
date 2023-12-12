using System;

class Program {
  public static void Main (string[] args) {
   const double y = 2.54;
    
    Console.WriteLine("Enter inches to be converted");
    var x = int.Parse(Console.ReadLine());


    
      Console.WriteLine("{0} inches * {1} = {2} centimeters", x, y, (x * y));
      
   
  
    
  
    
    
  }
}