using ComputationalConversions.Telas;
using System.Threading;

namespace ComputationalConversions {
    public partial class TelaMenuPrincipal : Form {

        Thread th;

        public TelaMenuPrincipal() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
            th = new Thread(AbrirTelaDecToBin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AbrirTelaDecToBin(object? obj) {
            Application.Run(new DecToBin());
        }

        private void button1_Click_1(object sender, EventArgs e) {
            this.Close();
            th = new Thread(AbrirTelaBinToDec);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AbrirTelaBinToDec(object? obj) {
            Application.Run(new BinToDec());
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}