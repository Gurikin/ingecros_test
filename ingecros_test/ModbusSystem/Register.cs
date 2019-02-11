using ingecros_test.Base;
using Modbus.Net;
using Modbus.Net.Modbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingecros_test.ModbusSystem
{
    class Register : IRegister
    {
        private IUtilityProperty utility;
        private byte[] data;            
    public Register()
        {
            this.utility = new ModbusUtility(ModbusType.Tcp, "127.0.0.1:502", 17, 0, Endian.BigEndianMsb);
            this.utility.Connect();
        }
        public byte[] modbusFunction01(int byteCount)
        {
            throw new NotImplementedException();
        }

        public byte[] modbusFunction02(int byteCount)
        {
            throw new NotImplementedException();
        }

        public byte[] modbusFunction03(int byteCount)
        {
            throw new NotImplementedException();
        }

        public async byte[] modbusFunction04(int byteCount)
        {
            this.data = await this.utility.GetUtilityMethods<IUtilityMethodData>().GetDatasAsync("4x 1", byteCount);
            return this.data;            
        }

        public void modbusFunction05()
        {
            throw new NotImplementedException();
        }

        public void modbusFunction06()
        {
            throw new NotImplementedException();
        }
    }
}
