using System;
namespace RF95
{
    public class Rf95
    {
        private static readonly short[] Bw125Cr45Sf128 = new short[] { 0x72, 0x74, 0x00 };
        private static readonly short[] Bw500Cr45Sf128 = new short[] { 0x92, 0x74, 0x00 };
        private static readonly short[] Bw31_25Cr48Sf512 = new short[] { 0x48, 0x94, 0x00 };
        private static readonly short[] Bw125Cr48Sf4096 = new short[] { 0x78, 0xc4, 0x00 };

        public static short[][] ModemConfigTable = new short[][] { Bw125Cr45Sf128, Bw500Cr45Sf128, Bw31_25Cr48Sf512, Bw125Cr48Sf4096 };

        public Rf95() { }

        public Rf95(short slaveSelectPin, short interruptPin) { }

        public bool Init()
        {
            return true;
        }

        public void HandleInterrupt()
        {

        }

        public void Isr0()
        {

        }

        public void Isr1()
        {

        }

        public void Isr2()
        {

        }

        public void ValidateRxBuf()
        {

        }

        public void Available()
        {

        }

        public void ClearRxBuf()
        {

        }

        public void Recv()
        {

        }

        public void Send()
        {

        }

        public void PrintRegisters()
        {

        }

        public void MaxMessageLength()
        {

        }

        public void SetFrequency(double center)
        {

        }

        public void SetModeIdle()
        {

        }

        public void Sleep()
        {

        }

        public void SetModeRx()
        {

        }

        public void SetModeTx()
        {

        }

        public void SetTxPower(short power)
        {

        }

        public void SetModemRegisters()
        {

        }

        public void SetModemConfig()
        {

        }

        public void SetPreambleLength(short bytes)
        {

        }
    }
}
