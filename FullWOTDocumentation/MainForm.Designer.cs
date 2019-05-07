using System.Windows.Forms;

namespace FullWOTDocumentation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTreeTanks = new System.Windows.Forms.Panel();
            this.pictureBoxItalyNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxSwedenNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxPolandNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxJapanNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxChinaNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxCzehoslovakiaNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnglandNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxFranceNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxUSANation = new System.Windows.Forms.PictureBox();
            this.pictureBoxGermanyNation = new System.Windows.Forms.PictureBox();
            this.pictureBoxUSSRNation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItalyNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwedenNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolandNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJapanNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChinaNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCzehoslovakiaNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnglandNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFranceNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSANation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGermanyNation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSSRNation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTreeTanks
            // 
            this.panelTreeTanks.AutoScroll = true;
            this.panelTreeTanks.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelTreeTanks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTreeTanks.BackgroundImage")));
            this.panelTreeTanks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTreeTanks.Location = new System.Drawing.Point(88, 61);
            this.panelTreeTanks.Name = "panelTreeTanks";
            this.panelTreeTanks.Size = new System.Drawing.Size(1175, 596);
            this.panelTreeTanks.TabIndex = 0;
            // 
            // pictureBoxItalyNation
            // 
            this.pictureBoxItalyNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.Italy_False;
            this.pictureBoxItalyNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxItalyNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxItalyNation.ErrorImage = null;
            this.pictureBoxItalyNation.Location = new System.Drawing.Point(12, 583);
            this.pictureBoxItalyNation.Name = "pictureBoxItalyNation";
            this.pictureBoxItalyNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxItalyNation.TabIndex = 10;
            this.pictureBoxItalyNation.TabStop = false;
            this.pictureBoxItalyNation.Click += new System.EventHandler(this.PictureBoxItalyNation_Click);
            // 
            // pictureBoxSwedenNation
            // 
            this.pictureBoxSwedenNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.Sweden_False;
            this.pictureBoxSwedenNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSwedenNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSwedenNation.ErrorImage = null;
            this.pictureBoxSwedenNation.Location = new System.Drawing.Point(12, 532);
            this.pictureBoxSwedenNation.Name = "pictureBoxSwedenNation";
            this.pictureBoxSwedenNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxSwedenNation.TabIndex = 9;
            this.pictureBoxSwedenNation.TabStop = false;
            this.pictureBoxSwedenNation.Click += new System.EventHandler(this.PictureBoxSwedenNation_Click);
            // 
            // pictureBoxPolandNation
            // 
            this.pictureBoxPolandNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.Poland_False;
            this.pictureBoxPolandNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPolandNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPolandNation.ErrorImage = null;
            this.pictureBoxPolandNation.Location = new System.Drawing.Point(12, 481);
            this.pictureBoxPolandNation.Name = "pictureBoxPolandNation";
            this.pictureBoxPolandNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxPolandNation.TabIndex = 8;
            this.pictureBoxPolandNation.TabStop = false;
            this.pictureBoxPolandNation.Click += new System.EventHandler(this.PictureBoxPolandNation_Click);
            // 
            // pictureBoxJapanNation
            // 
            this.pictureBoxJapanNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.Japan_False;
            this.pictureBoxJapanNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxJapanNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxJapanNation.ErrorImage = null;
            this.pictureBoxJapanNation.Location = new System.Drawing.Point(12, 430);
            this.pictureBoxJapanNation.Name = "pictureBoxJapanNation";
            this.pictureBoxJapanNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxJapanNation.TabIndex = 7;
            this.pictureBoxJapanNation.TabStop = false;
            this.pictureBoxJapanNation.Click += new System.EventHandler(this.PictureBoxJapanNation_Click);
            // 
            // pictureBoxChinaNation
            // 
            this.pictureBoxChinaNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.China_False;
            this.pictureBoxChinaNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxChinaNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxChinaNation.ErrorImage = null;
            this.pictureBoxChinaNation.Location = new System.Drawing.Point(12, 379);
            this.pictureBoxChinaNation.Name = "pictureBoxChinaNation";
            this.pictureBoxChinaNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxChinaNation.TabIndex = 6;
            this.pictureBoxChinaNation.TabStop = false;
            this.pictureBoxChinaNation.Click += new System.EventHandler(this.PictureBoxChinaNation_Click);
            // 
            // pictureBoxCzehoslovakiaNation
            // 
            this.pictureBoxCzehoslovakiaNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.Czechohoslovakia_False;
            this.pictureBoxCzehoslovakiaNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCzehoslovakiaNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCzehoslovakiaNation.ErrorImage = null;
            this.pictureBoxCzehoslovakiaNation.Location = new System.Drawing.Point(12, 328);
            this.pictureBoxCzehoslovakiaNation.Name = "pictureBoxCzehoslovakiaNation";
            this.pictureBoxCzehoslovakiaNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxCzehoslovakiaNation.TabIndex = 5;
            this.pictureBoxCzehoslovakiaNation.TabStop = false;
            this.pictureBoxCzehoslovakiaNation.Click += new System.EventHandler(this.PictureBoxCzehoslovakiaNation_Click);
            // 
            // pictureBoxEnglandNation
            // 
            this.pictureBoxEnglandNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.England_False;
            this.pictureBoxEnglandNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEnglandNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEnglandNation.ErrorImage = null;
            this.pictureBoxEnglandNation.Location = new System.Drawing.Point(12, 277);
            this.pictureBoxEnglandNation.Name = "pictureBoxEnglandNation";
            this.pictureBoxEnglandNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxEnglandNation.TabIndex = 4;
            this.pictureBoxEnglandNation.TabStop = false;
            this.pictureBoxEnglandNation.Click += new System.EventHandler(this.PictureBoxEnglandNation_Click);
            // 
            // pictureBoxFranceNation
            // 
            this.pictureBoxFranceNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.France_False;
            this.pictureBoxFranceNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFranceNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFranceNation.ErrorImage = null;
            this.pictureBoxFranceNation.Location = new System.Drawing.Point(12, 226);
            this.pictureBoxFranceNation.Name = "pictureBoxFranceNation";
            this.pictureBoxFranceNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxFranceNation.TabIndex = 3;
            this.pictureBoxFranceNation.TabStop = false;
            this.pictureBoxFranceNation.Click += new System.EventHandler(this.PictureBoxFranceNation_Click);
            // 
            // pictureBoxUSANation
            // 
            this.pictureBoxUSANation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.USA_False;
            this.pictureBoxUSANation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUSANation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUSANation.ErrorImage = null;
            this.pictureBoxUSANation.Location = new System.Drawing.Point(12, 175);
            this.pictureBoxUSANation.Name = "pictureBoxUSANation";
            this.pictureBoxUSANation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxUSANation.TabIndex = 2;
            this.pictureBoxUSANation.TabStop = false;
            this.pictureBoxUSANation.Click += new System.EventHandler(this.PictureBoxUSANation_Click);
            // 
            // pictureBoxGermanyNation
            // 
            this.pictureBoxGermanyNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.Germany_False;
            this.pictureBoxGermanyNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGermanyNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGermanyNation.ErrorImage = null;
            this.pictureBoxGermanyNation.Location = new System.Drawing.Point(12, 124);
            this.pictureBoxGermanyNation.Name = "pictureBoxGermanyNation";
            this.pictureBoxGermanyNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxGermanyNation.TabIndex = 1;
            this.pictureBoxGermanyNation.TabStop = false;
            this.pictureBoxGermanyNation.Click += new System.EventHandler(this.PictureBoxGermanyNation_Click);
            // 
            // pictureBoxUSSRNation
            // 
            this.pictureBoxUSSRNation.BackgroundImage = global::FullWOTDocumentation.Properties.Resources.USSR_False;
            this.pictureBoxUSSRNation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUSSRNation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUSSRNation.ErrorImage = null;
            this.pictureBoxUSSRNation.Location = new System.Drawing.Point(12, 73);
            this.pictureBoxUSSRNation.Name = "pictureBoxUSSRNation";
            this.pictureBoxUSSRNation.Size = new System.Drawing.Size(70, 45);
            this.pictureBoxUSSRNation.TabIndex = 0;
            this.pictureBoxUSSRNation.TabStop = false;
            this.pictureBoxUSSRNation.Click += new System.EventHandler(this.PictureBoxUSSRNation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTreeTanks);
            this.Controls.Add(this.pictureBoxItalyNation);
            this.Controls.Add(this.pictureBoxSwedenNation);
            this.Controls.Add(this.pictureBoxPolandNation);
            this.Controls.Add(this.pictureBoxUSSRNation);
            this.Controls.Add(this.pictureBoxJapanNation);
            this.Controls.Add(this.pictureBoxGermanyNation);
            this.Controls.Add(this.pictureBoxChinaNation);
            this.Controls.Add(this.pictureBoxUSANation);
            this.Controls.Add(this.pictureBoxCzehoslovakiaNation);
            this.Controls.Add(this.pictureBoxFranceNation);
            this.Controls.Add(this.pictureBoxEnglandNation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Документация по игре World Of Tanks";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItalyNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwedenNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolandNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJapanNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChinaNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCzehoslovakiaNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnglandNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFranceNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSANation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGermanyNation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUSSRNation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTreeTanks;
        private System.Windows.Forms.PictureBox pictureBoxUSSRNation;
        private System.Windows.Forms.PictureBox pictureBoxGermanyNation;
        private System.Windows.Forms.PictureBox pictureBoxItalyNation;
        private System.Windows.Forms.PictureBox pictureBoxSwedenNation;
        private System.Windows.Forms.PictureBox pictureBoxPolandNation;
        private System.Windows.Forms.PictureBox pictureBoxJapanNation;
        private System.Windows.Forms.PictureBox pictureBoxChinaNation;
        private System.Windows.Forms.PictureBox pictureBoxCzehoslovakiaNation;
        private System.Windows.Forms.PictureBox pictureBoxEnglandNation;
        private System.Windows.Forms.PictureBox pictureBoxFranceNation;
        private System.Windows.Forms.PictureBox pictureBoxUSANation;
    }
}

