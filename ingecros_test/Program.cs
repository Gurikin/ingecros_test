using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ingecros_test.ModbusSystem;

namespace ingecros_test
{
    class Program
    {
        static void Main(string[] args)
        {            
            Register modbusReg = new Register();
            while (true)
            {
                byte[] data = modbusReg.modbusFunction04(20);
                for (int i = 1; i < 20; i += 2)
                {
                    Console.WriteLine(i + ":>\t" + data[i]);
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }      
    }
}
