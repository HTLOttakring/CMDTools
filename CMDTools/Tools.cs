using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDTools
{
    public class Tools
    {
        /// <summary>
        /// Liest eine Integer-Zahl von der Konsole
        /// </summary>
        /// <param name="Message">Die Nachricht die angezeigt werden soll</param>
        /// <returns></returns>
        public static int ReadInt(string Message)
        {
            int retValue = 0;
            do
            {
                if(!string.IsNullOrEmpty(Message))
                    Console.WriteLine(Message);
            } while (!int.TryParse(Console.ReadLine(), out retValue));
            return retValue;
        }

        /// <summary>
        /// Liest eine Double-Zahl von der Konsole
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public static double ReadDouble(string Message)
        {
            double retValue = 0;
            do
            {
                if (!string.IsNullOrEmpty(Message))
                    Console.WriteLine(Message);
            } while (!double.TryParse(Console.ReadLine(), out retValue));
            return retValue;

        }

    }
}
