using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputationalConversions.Telas {
    public partial class DecToBin : Form {
        public DecToBin() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            string inputNumDec = textBoxDecimalInput.Text;
            string resultadoBin = "";
            int temp = 0;
            int div = int.Parse(inputNumDec);
            while (div >= 1) {
                temp = div%2;
                resultadoBin += temp.ToString();
                div = div/2;
            }

            if (int.Parse(inputNumDec) >= 10) {
                resultadoBin += div.ToString();
            }
            char[] chars = resultadoBin.ToCharArray();
            Array.Reverse(chars);

            string binInvertido = "";

            for (int i = 0; i < chars.Length; i++) {
                binInvertido += chars[i].ToString();
            }



            textBoxBinarioOutput.Text = binInvertido;
        }
    }
}
