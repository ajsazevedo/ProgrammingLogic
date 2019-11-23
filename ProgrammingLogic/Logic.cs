using System;

namespace ProgrammingLogic
{
  public class Logic
  {
    private const int fail = -1;

    public void Start()
    {
      while (true)
      {
        Console.WriteLine("Insira um numero ou tecle exit para sair");
        var input = Console.ReadLine();
        if (input == "exit")
          break;

        Print(GetNumber(input));
      }      
    }

    protected int GetNumber(string input)
    {      
      int value;
      if (int.TryParse(input, out value))
        return value;
      else
      {
        Console.WriteLine("Deve ser inserido um numero!");
        return -1;
      }        
    }

    protected void Print(int number)
    {
      var remainder = number % 3;
      if (remainder == 0)
        Console.Write("Cira");
      if (number.ToString().Contains('5'))
        Console.Write("Dinha");

      Console.Write(Environment.NewLine);
    }
  }
}
