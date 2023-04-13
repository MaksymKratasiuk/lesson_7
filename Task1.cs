using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessom_7
{
    interface IOutput
    {
        void Show();
        void ShowInfo(string info);

    }

    class Array : IOutput
    {
        
        int[] Arr {get;}

        public Array()
        {
            Console.WriteLine("Enter array size ->");
           Random random = new Random();
            int size = int.Parse(Console.ReadLine());
            Arr = new int[size];
            for(int i = 0;i<size;i++)
            {
                Arr[i] = random.Next(-10,10);
            }

        }

        public void Show()
        {
            foreach (var item in Arr)
            {
                Console.Write(item + " ");
            }
        }

        public void ShowInfo(string info)
        {
            Show();
            Console.WriteLine("\nInformation : "+info);
        }

    }
    
}
