using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void calculator_label_Click(object sender, EventArgs e)
        {

        }

        public void UpdateProgress(int progress)
        {
            progressBar1.Value = progress;
        }
    }
}
