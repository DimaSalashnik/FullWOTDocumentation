using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWOTDocumentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            panelTreeTanks.Height = ClientSize.Height;
            panelTreeTanks.Width = ClientSize.Width;
        }
    }
}
