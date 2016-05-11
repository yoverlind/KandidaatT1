using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DLL_K8055_LC
{
    public class api8055
    {       
            [DllImport("k8055d.dll")]
            public static extern int OpenDevice(int devNumber);

            [DllImport("k8055d.dll")]
            public static extern void CloseDevice();

            [DllImport("k8055d.dll")]
            public static extern int ReadAnalogChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void ReadAllAnalog(ref int Data1, ref int Data2);

            [DllImport("k8055d.dll")]
            public static extern void OutputAnalogChannel(int Channel, int Data);

            [DllImport("k8055d.dll")]
            public static extern void OutputAllAnalog(int Data1, int Data2);

            [DllImport("k8055d.dll")]
            public static extern void ClearAnalogChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void SetAllAnalog();

            [DllImport("k8055d.dll")]
            public static extern void ClearAllAnalog();

            [DllImport("k8055d.dll")]
            public static extern void SetAnalogChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void WriteAllDigital(int Data);

            [DllImport("k8055d.dll")]
            public static extern void ClearDigitalChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void ClearAllDigital();

            [DllImport("k8055d.dll")]
            public static extern void SetDigitalChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern void SetAllDigital();

            [DllImport("k8055d.dll")]
            public static extern bool ReadDigitalChannel(int Channel);

            [DllImport("k8055d.dll")]
            public static extern int ReadAllDigital();

            [DllImport("k8055d.dll")]
            public static extern int ReadCounter(int CounterNr);

            [DllImport("k8055d.dll")]
            public static extern void ResetCounter(int CounterNr);

            [DllImport("k8055d.dll")]
            public static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);

            [DllImport("k8055d.dll")]
            public static extern void Version();

            [DllImport("k8055d.dll")]
            public static extern int SearchDevices();

            [DllImport("k8055d.dll")]
            public static extern int SetCurrentDevice(int lngCardAddress);
        
    // Code uit VB:
    //Public Declare Function OpenDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    //Public Declare Sub CloseDevice Lib "k8055d.dll" ()
    //Public Declare Function ReadAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Integer
    //Public Declare Sub ReadAllAnalog Lib "k8055d.dll" (ByVal Data1 As Integer, ByVal Data2 As Integer)
    //Public Declare Sub OutputAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer, ByVal Data As Integer)
    //Public Declare Sub OutputAllAnalog Lib "k8055d.dll" (ByVal Data1 As Integer, ByVal Data2 As Integer)
    //Public Declare Sub ClearAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    //Public Declare Sub SetAllAnalog Lib "k8055d.dll" ()
    //Public Declare Sub ClearAllAnalog Lib "k8055d.dll" ()
    //Public Declare Sub SetAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    //Public Declare Sub WriteAllDigital Lib "k8055d.dll" (ByVal Data As Integer)
    //Public Declare Sub ClearDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    //Public Declare Sub ClearAllDigital Lib "k8055d.dll" ()
    //Public Declare Sub SetDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    //Public Declare Sub SetAllDigital Lib "k8055d.dll" ()
    //Public Declare Function ReadDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Boolean
    //Public Declare Function ReadAllDigital Lib "k8055d.dll" () As Integer
    //Public Declare Function ReadCounter Lib "k8055d.dll" (ByVal CounterNr As Integer) As Integer
    //Public Declare Sub ResetCounter Lib "k8055d.dll" (ByVal CounterNr As Integer)
    //Public Declare Sub SetCounterDebounceTime Lib "k8055d.dll" (ByVal CounterNr As Integer, ByVal DebounceTime As Integer)
    }
}
