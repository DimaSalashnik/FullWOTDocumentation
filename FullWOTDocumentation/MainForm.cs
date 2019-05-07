using Microsoft.Office.Interop.Excel;
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
        public MainForm() { InitializeComponent(); }

        //изменение размера окна
        private void MainForm_SizeChanged(object sender, EventArgs e){
            panelTreeTanks.Height = ClientSize.Height;
            panelTreeTanks.Width = ClientSize.Width;
        }

        ComponentResourceManager resources = new ComponentResourceManager(typeof(Image));
        private void PictureBoxUSSRNation_Click(object sender, EventArgs e){
            try {if (pictureBoxUSSRNation.Image == (Image)resources.GetObject("USSR_False.png"))
                    pictureBoxUSSRNation.Image = (Image)resources.GetObject("USSR_True.png");
                else pictureBoxUSSRNation.Image = (Image)resources.GetObject("USSR_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxGermanyNation_Click(object sender, EventArgs e){
            try {if (pictureBoxGermanyNation.Image == (Image)resources.GetObject("Germany_False.png"))
                    pictureBoxGermanyNation.Image = (Image)resources.GetObject("Germany_True.png");
                 else pictureBoxGermanyNation.Image = (Image)resources.GetObject("Germany_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxUSANation_Click(object sender, EventArgs e){
            try {if (pictureBoxUSANation.Image == (Image)resources.GetObject("USA_False.png"))
                    pictureBoxUSANation.Image = (Image)resources.GetObject("USA_True.png");
                else pictureBoxUSANation.Image = (Image)resources.GetObject("USA_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxFranceNation_Click(object sender, EventArgs e){
            try {if (pictureBoxFranceNation.Image == (Image)resources.GetObject("France_False.png"))
                    pictureBoxFranceNation.Image = (Image)resources.GetObject("France_True.png");
                else pictureBoxFranceNation.Image = (Image)resources.GetObject("France_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxEnglandNation_Click(object sender, EventArgs e){
            try {if (pictureBoxEnglandNation.Image == (Image)resources.GetObject("England_False.png"))
                    pictureBoxEnglandNation.Image = (Image)resources.GetObject("England_True.png");
                else pictureBoxEnglandNation.Image = (Image)resources.GetObject("England_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxCzehoslovakiaNation_Click(object sender, EventArgs e){
            try {if (pictureBoxCzehoslovakiaNation.Image == (Image)resources.GetObject("Czehoslovakia_False.png"))
                    pictureBoxCzehoslovakiaNation.Image = (Image)resources.GetObject("Czehoslovakia_True.png");
                else pictureBoxCzehoslovakiaNation.Image = (Image)resources.GetObject("Czehoslovakia_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxChinaNation_Click(object sender, EventArgs e){
            try {if (pictureBoxChinaNation.Image == (Image)resources.GetObject("China_False.png"))
                    pictureBoxChinaNation.Image = (Image)resources.GetObject("China_True.png");
                else pictureBoxChinaNation.Image = (Image)resources.GetObject("China_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxJapanNation_Click(object sender, EventArgs e){
            try {if (pictureBoxJapanNation.Image == (Image)resources.GetObject("Japan_False.png"))
                    pictureBoxJapanNation.Image = (Image)resources.GetObject("Japan_True.png");
                else pictureBoxJapanNation.Image = (Image)resources.GetObject("Japan_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxPolandNation_Click(object sender, EventArgs e){
            try {if (pictureBoxPolandNation.Image == (Image)resources.GetObject("Poland_False.png"))
                    pictureBoxPolandNation.Image = (Image)resources.GetObject("Poland_True.png");
                else pictureBoxPolandNation.Image = (Image)resources.GetObject("Poland_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxSwedenNation_Click(object sender, EventArgs e){
            try {if (pictureBoxSwedenNation.Image == (Image)resources.GetObject("Sweden_False.png"))
                    pictureBoxSwedenNation.Image = (Image)resources.GetObject("Sweden_True.png");
                else pictureBoxSwedenNation.Image = (Image)resources.GetObject("Sweden_False.png");}
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
        private void PictureBoxItalyNation_Click(object sender, EventArgs e){
           try {if (pictureBoxItalyNation.Image == (Image)resources.GetObject("Italy_False.png"))
                    pictureBoxItalyNation.Image = (Image)resources.GetObject("Italy_True.png");
                else pictureBoxItalyNation.Image = (Image)resources.GetObject("Italy_False.png");}
           catch (Exception error) { MessageBox.Show(error.ToString()); }
        }
    }
}
