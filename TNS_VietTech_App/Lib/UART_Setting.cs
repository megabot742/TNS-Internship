using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS.VietTech.App.Lib
{
    public class UART_Setting
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public int Parity { get; set; }
        public int StopBits { get; set; }
        public bool DtrEnable { get; set; }
        public bool RtsEnable { get; set; }
        public string Message { get; set; }
        public UART_Setting()
        {
            Read();
        }
        private void Read()
        {
            FileStream zStream;
            string[] zData = new string[4];
            try
            {
                zStream = new FileStream(@"Data/UART.txt", FileMode.Open);
                StreamReader zReader = new StreamReader(zStream, Encoding.UTF8);
                string zName;
                string[] zDataLine;
                while (!zReader.EndOfStream)
                {
                    zName = zReader.ReadLine();
                    zDataLine = zName.Split(';');
                    if (zDataLine.Length == 5)
                    {
                        int zBaudRate = 0;
                        int zDataBits = 0;
                        int zParity = 0;
                        int zStopBits = 0;
                        int.TryParse(zDataLine[1], out zBaudRate);
                        int.TryParse(zDataLine[2], out zDataBits);
                        int.TryParse(zDataLine[3], out zParity);
                        int.TryParse(zDataLine[4], out zStopBits);

                        PortName = zDataLine[0];
                        BaudRate = zBaudRate;
                        DataBits = zDataBits;
                        Parity = zParity;
                        StopBits = zStopBits;

                    }
                }

                zReader.Close();
                zStream.Close();
            }
            catch (Exception ex)
            {
                Message = ex.ToString();
            }
        }

        public void Save()
        {
            string zUART_Info = "";
            zUART_Info += PortName + ";";
            zUART_Info += BaudRate.ToString() + ";";
            zUART_Info += DataBits.ToString() + ";";
            zUART_Info += Parity.ToString() + ";";
            zUART_Info += StopBits.ToString() + "";

            string zResult = "";
            FileStream zStream;
            try
            {

                StringBuilder zContent = new StringBuilder();
                zStream = new FileStream(@"Data/UART.txt", FileMode.Create);
                StreamWriter zWrite = new StreamWriter(zStream, Encoding.UTF8);
                zWrite.Write(zUART_Info);
                zWrite.Flush();
                zWrite.Close();

                zResult = "OK";

            }
            catch (Exception ex)
            {
                Message = "ER" + ex.ToString();
            }
        }
    }
}
