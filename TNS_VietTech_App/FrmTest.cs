using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  TNS.VietTech.App
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void Frm_Test_Load(object sender, EventArgs e)
        {
            txt_Val_1.Text = "109.708488";
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            txt_Log.Text = "";
            // ":-2.369039:9.708488;240213222133903|0.2110429:-2.440865:9.753978"
            float zVal_1 = float.Parse(txt_Val_1.Text);
            FloatToChars(zVal_1, 10);
            //IntToChars((int)zVal_1);
        }
        private void FloatToChars(float number, int Len)
        {
            char[] zArrayChar = new char[20];
            char zNegative = '+';
            if (number < 0)
            {
                number = number * (-1);
                zNegative = '-';
            }

            int intPart = (int)number;// Phần nguyên của số
            float decimalPart = number - intPart;// Phần thập phân của số
            int index = 0;

            // Chuyển phần nguyên thành chuỗi

            while (intPart > 0)
            {
                //zArrayChar[index++] = intPart % 10 + '0';
                zArrayChar[index++] = Convert.ToChar((intPart % 10).ToString());
                intPart /= 10;
            }
            // Nếu số là 0, ghi lại '0'

            if (index == 0)
            {
                zArrayChar[index++] = '0';
            }

            if (zNegative == '-')
                zArrayChar[index++] = '-';

            // Đảo ngược chuỗi phần nguyên
            for (int i = 0; i < index / 2; i++)
            {
                char temp = zArrayChar[i];
                zArrayChar[i] = zArrayChar[index - i - 1];
                zArrayChar[index - i - 1] = temp;
            }

            // Thêm dấu chấm
            zArrayChar[index++] = '.';

            // Chuyển phần thập phân thành chuỗi
            int decimalIndex = index;
            while (decimalPart > 0 && decimalIndex < Len)
            {
                decimalPart *= 10;
                int digit = (int)decimalPart;
                //zArrayChar[decimalIndex++] = digit + '0';
                zArrayChar[decimalIndex++] = Convert.ToChar(digit.ToString());
                decimalPart -= digit;
            }

            // Kết thúc chuỗi
            zArrayChar[decimalIndex] = '\0';

            for (int i = 0; i < decimalIndex; i++)
            {
                txt_Log.Text += zArrayChar[i].ToString();
            }
        }

        private void IntToChars(int number)
        {
            char[] zArrayChar = new char[20];
            char zNegative = '+';
            if (number < 0)
            {
                number = number * (-1);
                zNegative = '-';
            }
            
            int index = 0;

            // Chuyen phan nguyen thanh chuoi
            while (number > 0)
            {
                //zArrayChar[index++] = intPart % 10 + '0';
                zArrayChar[index++] = Convert.ToChar((number % 10).ToString());
                number /= 10;
            }
            // Neu so la 0, ghi lai '0'
            if (index == 0)
            {
                zArrayChar[index++] = '0';
            }

            if (zNegative == '-')
                zArrayChar[index++] = '-';
            int len = index;
            // Dao nguoc chuoi phan nguyen
            for (int i = 0; i < index / 2; i++)
            {
                char temp = zArrayChar[i];
                zArrayChar[i] = zArrayChar[index - i - 1];
                zArrayChar[index - i - 1] = temp;
            }
            // Ket thuc chuoi
            zArrayChar[len] = '\0';

            for (int i = 0; i < len; i++)
            {
                txt_Log.Text += zArrayChar[i].ToString();
            }
        }
    }
}
