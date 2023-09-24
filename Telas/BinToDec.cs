using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputationalConversions {
    public partial class BinToDec : Form {
        public BinToDec() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                string numBin = textBoxBin.Text;
                char[] vetNumBin = numBin.ToCharArray();
                Array.Reverse(vetNumBin);
                double numDec = 0;

                for (int i = 0; i < vetNumBin.Length; i++) {
                    numDec += int.Parse(vetNumBin[i].ToString()) * Math.Pow(2, i);
                }


                textBoxDecimal.Text = numDec.ToString();
            } 
            catch (Exception erro){
                MessageBox.Show("Ocorreu um erro : " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
