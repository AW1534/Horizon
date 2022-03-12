using System;
using System.Drawing;
using System.Windows.Forms;

namespace Launcher {
    public partial class Form1 : Form {

        protected override void OnPaintBackground(PaintEventArgs e) {
            e.Graphics.FillRectangle(Brushes.SeaGreen, e.ClipRectangle);
        }

        public Form1() {
            InitializeComponent();
            Console.WriteLine("Form Initialized");
        }

        private void Form1_Ready(object sender, EventArgs e) {
            Invis();
            Program.Start();
        }

        public void Invis() {
            Opacity = 0;
        }

        public void Vis() {
            Opacity = 1;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e) {

        }
    }
}
