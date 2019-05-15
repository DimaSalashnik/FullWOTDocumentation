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
            panelTreeTanksUSSR.Height = ClientSize.Height;
            panelTreeTanksUSSR.Width = ClientSize.Width - 85;
        }
        //метод для сброса нажатых кнопок
        private void ResetOfPressetButtons()
        {
            buttonUSSRNation.ImageIndex = 0;
            buttonGermanyNation.ImageIndex = 2;
            buttonUSANation.ImageIndex = 4;
            buttonEnglandNation.ImageIndex = 6;
            buttonCzehoslovakiaNation.ImageIndex = 8;
            buttonChinaNation.ImageIndex = 10;
            buttonJapanNation.ImageIndex = 12;
            buttonFranceNation.ImageIndex = 14;
            buttonPolandNation.ImageIndex = 16;
            buttonSwedenNation.ImageIndex = 18;
            buttonItalyNation.ImageIndex = 20;
        }
        private void ButtonUSSRNation_Click(object sender, EventArgs e)
        {
            ResetOfPressetButtons();
            if (buttonUSSRNation.ImageIndex == 0) { buttonUSSRNation.ImageIndex = 1; }
            else { buttonUSSRNation.ImageIndex = 0; }
        }
        private void ButtonGermanyNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonGermanyNation.ImageIndex == 2) { buttonGermanyNation.ImageIndex = 3; }
            //else { buttonGermanyNation.ImageIndex = 2; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonUSANation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonUSANation.ImageIndex == 4) { buttonUSANation.ImageIndex = 5; }
            //else { buttonUSANation.ImageIndex = 4; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonEnglandNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonEnglandNation.ImageIndex == 6) { buttonEnglandNation.ImageIndex = 7; }
            //else { buttonEnglandNation.ImageIndex = 6; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonCzehoslovakiaNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonCzehoslovakiaNation.ImageIndex == 8)
            //{ buttonCzehoslovakiaNation.ImageIndex = 9; }
            //else
            //{ buttonCzehoslovakiaNation.ImageIndex = 8; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonChinaNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonChinaNation.ImageIndex == 10) { buttonChinaNation.ImageIndex = 11; }
            //else { buttonChinaNation.ImageIndex = 10; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonJapanNation_Click(object sender, EventArgs e)
        {
        //    ResetOfPressetButtons();
        //    if (buttonJapanNation.ImageIndex == 12) { buttonJapanNation.ImageIndex = 13; }
        //    else { buttonJapanNation.ImageIndex = 12; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonFranceNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonFranceNation.ImageIndex == 14) { buttonFranceNation.ImageIndex = 15; }
            //else { buttonFranceNation.ImageIndex = 14; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonPolandNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonPolandNation.ImageIndex == 16) { buttonPolandNation.ImageIndex = 17; }
            //else { buttonPolandNation.ImageIndex = 16; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonSwedenNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonSwedenNation.ImageIndex == 18) { buttonSwedenNation.ImageIndex = 19; }
            //else { buttonSwedenNation.ImageIndex = 18; }
            MessageBox.Show("Эта нация еще в разработке");
        }
        private void ButtonItalyNation_Click(object sender, EventArgs e)
        {
            //ResetOfPressetButtons();
            //if (buttonItalyNation.ImageIndex == 20) { buttonItalyNation.ImageIndex = 21; }
            //else { buttonItalyNation.ImageIndex = 20; }
            MessageBox.Show("Эта нация еще в разработке");
        }
    }
}