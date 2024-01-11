using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();

            list.Add(new Potion());
            list.Add(new Sword());
        }
    }
    public class Item
    {

    }
    public class Potion : Item
    {

    }
    public class Sword : Item
    {

    }
}