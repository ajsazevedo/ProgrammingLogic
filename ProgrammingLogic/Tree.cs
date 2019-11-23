using System;

namespace ProgrammingLogic
{
  public static class Tree
  {
    public static void PrintTree()
    {
      for (int line = 0; line < 6; line++)
      {
        string galho = string.Empty.PadLeft(line, ' ');

        for (int leaf = 5; leaf > line; leaf--)
        {
          galho += "* ";
        }
        
        Console.WriteLine(galho);
      }      
    }
  }
}
