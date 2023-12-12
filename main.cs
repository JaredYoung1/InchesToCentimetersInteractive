using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter inches to be converted");
    var x = Console.ReadLine();
    var y = 2.54;

    int firstNumber;
    int secondNumber;
    if (int.TryParse(x, out firstNumber) && int.TryParse(y, out secondNumber)){
      Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, (firstNumber * secondNumber));
      }
    else {
      Console.WriteLine("Enter Numbers Only");
    }
  
    
  
    
    
  }
}