using System;

namespace ProgrammingLogic
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine(@"
      Choose program:
        1 - CiraDinha;
        2 - Arvore
        3 - Sair");

        var program = Console.ReadLine();

        if (program == "1")
        {
          Logica();
        }
        else if (program == "2")
        {
          Arvore();
        }
        else if (program == "3")
        {
          break;
        }
        else
        {
          Console.WriteLine("Nao implementado.");
        }
      }
    }

    protected static void Logica()
    {
      new Logic().Start();
    }

    protected static void Arvore()
    {
      Tree.PrintTree();
    }
  }
}
