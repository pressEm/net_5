using System;
using System.Collections.Generic;
using System.Text;

namespace net_5
{
    abstract class Notebook : Paper
    {
        public int Format { get; set; }
        private int Count_pages { get; set; }
        private int[] Pages { get; set; }
        private string Lining { get; set; }
        private int Price { get; set; }

        public Notebook(int format, int count, string lining, int price)
        {
            Format = format;
            Count_pages = count;
            Lining = lining;
            Price = price;
            Pages = new int[count];
        }

        public void buy()
        {
            System.Console.WriteLine("Покупка тетради: " + Price);
            
        }
        public void sell()
        {
            System.Console.WriteLine("Продажа тетради: " + Price);

        }
        public void tear_out(int num)
        {
            System.Console.WriteLine("Вырвать страницу тетради: " + num);
            Count_pages = Count_pages - 1;

        }
        public void cut()
        {
            System.Console.WriteLine("Резать тетрадь");
            Format = Format + 1;
        }

        public void roll_up()
        {
            System.Console.WriteLine("Свернуть тетрадь");
            Format = Format + 1;
        }
    }
}
