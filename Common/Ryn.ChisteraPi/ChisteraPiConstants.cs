using System;
using System.Collections.Generic;
using System.Text;

namespace Ryn.ChisteraPi
{
    class ChisteraPiConstants
    {
        // This is the maximum number of interrupts the driver can support
        // Most Arduinos can handle 2, Megas can handle more
        public static short NumInterrupt = 3;

        // Max number of octets the LORA Rx/Tx FIFO can hold
        public static short FifoSize = 255;

        // This is the maximum number of bytes that can be carried by the LORA.
        // We use some for headers, keeping fewer for RadioHead messages
        public static short MaxPayloadLength = FifoSize;

        // The length of the headers we add.
        // The headers are inside the LORA's payload
        public static short HeaderLength = 4;

        // This is the maximum message length that can be supported by this driver. 
        // Can be pre-defined to a smaller size (to save SRAM) prior to including this header
        // Here we allow for 1 byte message length, 4 bytes headers, user data and 2 bytes of FCS
        public static short MaxMessageLength = (short)(MaxPayloadLength - HeaderLength);

        // The crystal oscillator frequency of the module
        public static double FxOsc = 32000000.0;

        // The Frequency Synthesizer step = RH_RF95_FXOSC / 2^^19
        public static double FStep = FxOsc / 524288;


        // Register names (LoRa Mode, from table 85)
        public static short Reg00Fifo = 0x00;
        public static short Reg01OpMode = 0x01;
        public static short Reg02Reserved = 0x02;
        public static short Reg03Reserved = 0x03;
        public static short Reg04Reserved = 0x04;
        public static short Reg05Reserved = 0x05;
        public static short Reg06FrfMsb = 0x06;
        public static short Reg07FrfMid = 0x07;
        public static short Reg08FrfLsb = 0x08;
        public static short Reg09PaConfig = 0x09;
        public static short Reg0ApaRamp = 0x0a;
        public static short Reg0Bocp = 0x0b;
        public static short Reg0Clna = 0x0c;
        public static short Reg0DfifoAddrPtr = 0x0d;
        public static short Reg0EfifoTxBaseAddr = 0x0e;
        public static short Reg0FfifoRxBaseAddr = 0x0f;
        public static short Reg10FifoRxCurrentAddr = 0x10;
        public static short Reg11IrqFlagsMask = 0x11;
        public static short Reg12IrqFlags = 0x12;
        public static short Reg13RxNbBytes = 0x13;
        public static short Reg14RxHeaderCntValueMsb = 0x14;
        public static short Reg15RxHeaderCntValueLsb = 0x15;
        public static short Reg16RxPacketCntValueMsb = 0x16;
        public static short Reg17RxPacketCntValueLsb = 0x17;
        public static short Reg18ModemStat = 0x18;
        public static short Reg19PktSnrValue = 0x19;
        public static short Reg1ApktRssiValue = 0x1a;
        public static short Reg1BrssiValue = 0x1b;
        public static short Reg1ChopChannel = 0x1c;
        public static short Reg1DmodemConfig1 = 0x1d;
        public static short Reg1EmodemConfig2 = 0x1e;
        public static short Reg1FsymbTimeoutLsb = 0x1f;
        public static short Reg20PreambleMsb = 0x20;
        public static short Reg21PreambleLsb = 0x21;
        public static short Reg22PayloadLength = 0x22;
        public static short Reg23MaxPayloadLength = 0x23;
        public static short Reg24HopPeriod = 0x24;
        public static short Reg25FifoRxByteAddr = 0x25;
        public static short Reg26ModemConfig3 = 0x26;
        public static short Reg40DioMapping1 = 0x40;
        public static short Reg41DioMapping2 = 0x41;
        public static short Reg42Version = 0x42;
        public static short Reg4Btcxo = 0x4b;
        public static short Reg4DpaDac = 0x4d;
        public static short Reg5BformerTemp = 0x5b;
        public static short Reg61AgcRef = 0x61;
        public static short Reg62AgcThresh1 = 0x62;
        public static short Reg63AgcThresh2 = 0x63;
        public static short Reg64AgcThresh3 = 0x64;

        // RH_RF95_REG_01_OP_MODE                             0x01
        public static short LongRangeMode = 0x80;
        public static short AccessSharedReg = 0x40;
        public static short Mode = 0x07;
        public static short ModeSleep = 0x00;
        public static short ModeStdby = 0x01;
        public static short ModeFstx = 0x02;
        public static short ModeTx = 0x03;
        public static short ModeFsrx = 0x04;
        public static short ModeRxcontinuous = 0x05;
        public static short ModeRxsingle = 0x06;
        public static short ModeCad = 0x07;

        // RH_RF95_REG_09_PA_CONFIG                           0x09
        public static short RhRf95PaSelect = 0x80;
        public static short RhRf95OutputPower = 0x0f;

        // RH_RF95_REG_0A_PA_RAMP                             0x0a
        public static short LowPnTxPllOff = 0x10;
        public static short PaRamp = 0x0f;
        public static short PaRamp_3_4Ms = 0x00;
        public static short PaRamp_2Ms = 0x01;
        public static short PaRamp_1Ms = 0x02;
        public static short PaRamp_500Us = 0x03;
        public static short PaRamp_250Us = 0x0;
        public static short PaRamp_125Us = 0x05;
        public static short PaRamp_100Us = 0x06;
        public static short PaRamp_62Us = 0x07;
        public static short PaRamp_50Us = 0x08;
        public static short PaRamp_40Us = 0x09;
        public static short PaRamp_31Us = 0x0a;
        public static short PaRamp_25Us = 0x0b;
        public static short PaRamp_20Us = 0x0c;
        public static short PaRamp_15Us = 0x0d;
        public static short PaRamp_12Us = 0x0e;
        public static short PaRamp_10Us = 0x0f;

        // RH_RF95_REG_0B_OCP                                 0x0b
        public static short OcpOn = 0x20;
        public static short OcpTrim = 0x1f;

        // RH_RF95_REG_0C_LNA                                 0x0c
        public static short LnaGain = 0xe0;
        public static short LnaBoost = 0x03;
        public static short LnaBoostDefault = 0x00;
        public static short LnaBoost_150Pc = 0x11;

        // RH_RF95_REG_11_IRQ_FLAGS_MASK                      0x11
        public static short RxTimeoutMask = 0x80;
        public static short RxDoneMask = 0x40;
        public static short PayloadCrcErrorMask = 0x20;
        public static short ValidHeaderMask = 0x10;
        public static short TxDoneMask = 0x08;
        public static short CadDoneMask = 0x04;
        public static short FhssChangeChannelMask = 0x02;
        public static short CadDetectedMask = 0x01;

        // RH_RF95_REG_12_IRQ_FLAGS                           0x12
        public static short RxTimeout = 0x80;
        public static short RxDone = 0x40;
        public static short PayloadCrcError = 0x20;
        public static short ValidHeader = 0x10;
        public static short TxDone = 0x08;
        public static short CadDone = 0x04;
        public static short FhssChangeChannel = 0x02;
        public static short CadDetected = 0x01;

        // RH_RF95_REG_18_MODEM_STAT                          0x18
        public static short RxCodingRate = 0xe0;
        public static short ModemStatusClear = 0x10;
        public static short ModemStatusHeaderInfoValid = 0x08;
        public static short ModemStatusRxOngoing = 0x04;
        public static short ModemStatusSignalSynchronized = 0x02;
        public static short ModemStatusSignalDetected = 0x01;

        // RH_RF95_REG_1C_HOP_CHANNEL                         0x1c
        public static short PllTimeout = 0x80;
        public static short RxPayloadCrcIsOn = 0x40;
        public static short FhssPresentChannel = 0x3f;

        // RH_RF95_REG_1D_MODEM_CONFIG1                       0x1d
        public static short Bw = 0xc0;
        public static short Bw_125Khz = 0x00;
        public static short Bw_250Khz = 0x40;
        public static short Bw_500Khz = 0x80;
        public static short BwReserved = 0xc0;
        public static short CodingRate = 0x38;
        public static short CodingRate_4_5 = 0x00;
        public static short CodingRate_4_6 = 0x08;
        public static short CodingRate_4_7 = 0x10;
        public static short CodingRate_4_8 = 0x18;
        public static short ImplicitHeaderModeOn = 0x04;
        public static short RxPayloadCrcOn = 0x02;
        public static short LowDataRateOptimize = 0x01;

        // RH_RF95_REG_1E_MODEM_CONFIG2                       0x1e
        public static short SpreadingFactor = 0xf0;
        public static short SpreadingFactor_64Cps = 0x60;
        public static short SpreadingFactor_128Cps = 0x70;
        public static short SpreadingFactor_256Cps = 0x80;
        public static short SpreadingFactor_512Cps = 0x90;
        public static short SpreadingFactor_1024Cps = 0xa0;
        public static short SpreadingFactor_2048Cps = 0xb0;
        public static short SpreadingFactor_4096Cps = 0xc0;
        public static short TxContinuousMoe = 0x08;
        public static short AgcAutoOn = 0x04;
        public static short SymTimeoutMsb = 0x03;

        // RH_RF95_REG_4D_PA_DAC                              0x4d
        public static short PaDacDisable = 0x04;
        public static short PaDacEnable = 0x07;

    }
}
