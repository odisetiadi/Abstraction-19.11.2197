using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{ 
  public abstract class Air : Hewan
{
    public void Berenang()
    {
        Console.WriteLine("Berenang di air .. !!!");
    }
}
}