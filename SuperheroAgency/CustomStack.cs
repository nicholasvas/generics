using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class CustomStack
    {
    Stack<object> MyItems = new Stack<object>();

    public void AddItems()
        {
            MyItems.Push(1);
            MyItems.Push("item");
            MyItems.Push(2.7);
            MyItems.Push(89.00);
            Console.WriteLine();

            foreach (var item in MyItems)
            {
                Console.WriteLine(item);

            }
        }


    }


}
