using System;
using Unosquare.RaspberryIO;
using Unosquare.WiringPi;

namespace Ryn.ChisteraPi
{
    public class ChisteraPi
    {
        private static readonly short[] Bw125Cr45Sf128 = new short[] { 0x72, 0x74, 0x00 };
        private static readonly short[] Bw500Cr45Sf128 = new short[] { 0x92, 0x74, 0x00 };
        private static readonly short[] Bw31_25Cr48Sf512 = new short[] { 0x48, 0x94, 0x00 };
        private static readonly short[] Bw125Cr48Sf4096 = new short[] { 0x78, 0xc4, 0x00 };

        public static short[][] ModemConfigTable = new short[][] { Bw125Cr45Sf128, Bw500Cr45Sf128, Bw31_25Cr48Sf512, Bw125Cr48Sf4096 };

        //private static RH_RF95* _deviceForInterrupt[];

        /// Index of next interrupt number to use in _deviceForInterrupt
        private static byte _interruptCount;

        /// The configured interrupt pin connected to this instance
        private byte _interruptPin;

        /// The index into _deviceForInterrupt[] for this device (if an interrupt is already allocated)
        /// else 0xff
        private byte _myInterruptIndex;

        /// Number of octets in the buffer
        private volatile byte _bufLen;

        /// The receiver/transmitter buffer
        private byte[] _buf = new byte[ChisteraPiConstants.MaxMessageLength];

        /// True when there is a valid message in the buffer
        private volatile bool _rxBufValid;

        public ChisteraPi() { }

        public ChisteraPi(short slaveSelectPin, short interruptPin) { }

        public bool Init()
        {
            Console.WriteLine("Initializing /dev/spidev0.0 ...");
            Pi.Spi.Channel0Frequency = SpiChannel.MinFrequency;
            var request = System.Text.Encoding.ASCII.GetBytes("HELLO!");
            var response = Pi.Spi.Channel0.SendReceive(request);
            Console.WriteLine(response.ToString());
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
