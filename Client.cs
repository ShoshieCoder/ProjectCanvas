using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyCanvas.CreateNewButton(2, 3, 4, 7));
            Console.WriteLine(MyCanvas.CreateNewButton(3, 2, 5, 8));
            Console.WriteLine(MyCanvas.CreateNewButton(1, 2, 3, 4));
            Console.WriteLine(MyCanvas.GetCurrentNumberOfButtons());
            Console.WriteLine(MyCanvas.GetMaxNumberOfButtons());
            Console.WriteLine(MyCanvas.GetMaxWidthOffAButton());
            Console.WriteLine(MyCanvas.GetMaxHeightOffAButtoon());
            MyCanvas.Print();
            Console.WriteLine(MyCanvas.IsPointeInsideAButton(3,5));
            Console.WriteLine(MyCanvas.CheckIfAnyButtonIsOverlapping());
            Console.WriteLine(MyCanvas.MoveButton(1,2,2));
            Console.WriteLine(MyCanvas.DeleteLasButton());
            MyCanvas.ClearAllButtons();

        }
    }
}
