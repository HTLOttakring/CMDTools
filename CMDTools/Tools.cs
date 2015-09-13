using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDTools
{
    public class Tools
    {
        public static int ReadInt(string Message)
        {
            int retValue = 0;
            do
            {
                Console.WriteLine(Message);
            } while (!int.TryParse(Console.ReadLine(), out retValue));
            return retValue;
        }

        public static double ReadDouble(string Message)
        {
            //lkjflajds lakdfsj
            double retValue = 0;
            do
            {
                Console.WriteLine(Message);
            } while (!double.TryParse(Console.ReadLine(), out retValue));
            return retValue;

        }

    }
}
