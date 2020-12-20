using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SplitStringWithoutUsingSplit
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "This,is,a,program,for,splitting,string,without,using,split";
            ArrayList arrayList = new ArrayList();
            string Temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',')
                {
                    Temp = Temp + str[i];
                    continue;
                }
                arrayList.Add(Temp);
                Temp = "";
            }
            Console.WriteLine("Enter the no 1 to " + arrayList.Count);
            int option = Convert.ToInt32(Console.ReadLine());
            if (option < arrayList.Count && option > 0)
            {
                Console.WriteLine(option + " position is  = " + arrayList[option - 1]);
            }
            else
            {
                Console.WriteLine("Enter only 1 to " + arrayList.Count);
            }
            Console.ReadLine();
        }
    }
}

