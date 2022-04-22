namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sassoButton = new System.Windows.Forms.Button();
            this.forbiciButton = new System.Windows.Forms.Button();
            this.cartaButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEsito = new System.Windows.Forms.Label();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.picturePc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 243);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(911, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 243);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // sassoButton
            // 
            this.sassoButton.Location = new System.Drawing.Point(16, 183);
            this.sassoButton.Name = "sassoButton";
            this.sassoButton.Size = new System.Drawing.Size(143, 38);
            this.sassoButton.TabIndex = 2;
            this.sassoButton.Tag = "sasso";
            this.sassoButton.Text = "Sasso";
            this.sassoButton.UseVisualStyleBackColor = true;
            this.sassoButton.Click += new System.EventHandler(this.sassoButton_Click);
            // 
            // forbiciButton
            // 
            this.forbiciButton.Location = new System.Drawing.Point(16, 319);
            this.forbiciButton.Name = "forbiciButton";
            this.forbiciButton.Size = new System.Drawing.Size(143, 38);
            this.forbiciButton.TabIndex = 3;
            this.forbiciButton.Tag = "forbici";
            this.forbiciButton.Text = "Forbici";
            this.forbiciButton.UseVisualStyleBackColor = true;
            this.forbiciButton.Click += new System.EventHandler(this.forbiciButton_Click);
            // 
            // cartaButton
            // 
            this.cartaButton.Location = new System.Drawing.Point(16, 250);
            this.cartaButton.Name = "cartaButton";
            this.cartaButton.Size = new System.Drawing.Size(143, 38);
            this.cartaButton.TabIndex = 4;
            this.cartaButton.Tag = "carta";
            this.cartaButton.Text = "Carta";
            this.cartaButton.UseVisualStyleBackColor = true;
            this.cartaButton.Click += new System.EventHandler(this.cartaButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(16, 474);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(143, 38);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Conferma";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(359, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "ESITO PARTITA:";
            // 
            // labelEsito
            // 
            this.labelEsito.AutoSize = true;
            this.labelEsito.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEsito.Location = new System.Drawing.Point(652, 601);
            this.labelEsito.Name = "labelEsito";
            this.labelEsito.Size = new System.Drawing.Size(35, 37);
            this.labelEsito.TabIndex = 7;
            this.labelEsito.Text = "...";
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(359, 30);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(270, 245);
            this.pictureProfile.TabIndex = 8;
            this.pictureProfile.TabStop = false;
            // 
            // picturePc
            // 
            this.picturePc.Location = new System.Drawing.Point(911, 30);
            this.picturePc.Name = "picturePc";
            this.picturePc.Size = new System.Drawing.Size(270, 245);
            this.picturePc.TabIndex = 9;
            this.picturePc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 665);
            this.Controls.Add(this.picturePc);
            this.Controls.Add(this.pictureProfile);
            this.Controls.Add(this.labelEsito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.cartaButton);
            this.Controls.Add(this.forbiciButton);
            this.Controls.Add(this.sassoButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button sassoButton;
        private Button forbiciButton;
        private Button cartaButton;
        private Button ConfirmButton;
        private Label label1;
        private Label labelEsito;
        private PictureBox pictureProfile;
        private PictureBox picturePc;
    }
}