using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Core_2_0_Mar_2022
{
    public class Top
    {
        public Menu menu { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(menu.header);

            foreach (Item item in menu.items)
            {
                Console.Write("\t");

                if (item == null)
                {
                    Console.Write("null");
                }
                else
                {
                    Console.Write($"id: {item.id}" );
                    if (item.label != null)
                    {
                        Console.Write($"\tlabel: {item.label}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
