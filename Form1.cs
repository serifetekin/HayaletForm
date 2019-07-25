using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayaletForm
{ // formlara böyle bir animasyon eklenebilir.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = 1 - trackBar1.Value / 100.0; // scrollu kaydırdıkça opacity sıfıra gelecek.
            this.Opacity = 1 - trackBar1.Value / 100.0; // scrollu kaydırdıkça opacity sıfıra gelecek.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            for (int i = 0; i < 100; i++)
            {
                this.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(10); // uygulamayı 100ms durdurur, yazılım bekler.
                Refresh(); // döngü içerisinde ekranın ve üzerindeki bileşenlerin son görünümünü gösterir.
            }
        }
    }
}
