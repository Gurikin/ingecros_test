namespace ingecros_test.Base
{
    interface IRegister
    {
        byte[] modbusFunction01(int byteCount);
        byte[] modbusFunction02(int byteCount);
        byte[] modbusFunction03(int byteCount);
        byte[] modbusFunction04(int byteCount);
        void modbusFunction05();
        void modbusFunction06();
    }
}
