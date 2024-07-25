
namespace Dice_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P1D1 = new System.Windows.Forms.PictureBox();
            this.P1D2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.P2D1 = new System.Windows.Forms.PictureBox();
            this.P2D2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.P1D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2D2)).BeginInit();
            this.SuspendLayout();
            // 
            // P1D1
            // 
            this.P1D1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P1D1.Image = global::Dice_Game.Properties.Resources.SIde_1;
            this.P1D1.Location = new System.Drawing.Point(12, 12);
            this.P1D1.Name = "P1D1";
            this.P1D1.Size = new System.Drawing.Size(191, 170);
            this.P1D1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1D1.TabIndex = 5;
            this.P1D1.TabStop = false;
            this.P1D1.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // P1D2
            // 
            this.P1D2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P1D2.Image = global::Dice_Game.Properties.Resources.SIde_1;
            this.P1D2.Location = new System.Drawing.Point(12, 218);
            this.P1D2.Name = "P1D2";
            this.P1D2.Size = new System.Drawing.Size(191, 170);
            this.P1D2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1D2.TabIndex = 11;
            this.P1D2.TabStop = false;
            this.P1D2.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(292, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(12, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Login ?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(219, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Press the button to roll the dice";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // P2D1
            // 
            this.P2D1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P2D1.Image = global::Dice_Game.Properties.Resources.SIde_1;
            this.P2D1.Location = new System.Drawing.Point(500, 12);
            this.P2D1.Name = "P2D1";
            this.P2D1.Size = new System.Drawing.Size(191, 170);
            this.P2D1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2D1.TabIndex = 19;
            this.P2D1.TabStop = false;
            this.P2D1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // P2D2
            // 
            this.P2D2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P2D2.Image = global::Dice_Game.Properties.Resources.SIde_1;
            this.P2D2.Location = new System.Drawing.Point(500, 218);
            this.P2D2.Name = "P2D2";
            this.P2D2.Size = new System.Drawing.Size(191, 170);
            this.P2D2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2D2.TabIndex = 20;
            this.P2D2.TabStop = false;
            this.P2D2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 394);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(715, 503);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.P2D2);
            this.Controls.Add(this.P2D1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P1D2);
            this.Controls.Add(this.P1D1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2D2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox P1D1;
        private System.Windows.Forms.PictureBox P1D2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox P2D1;
        private System.Windows.Forms.PictureBox P2D2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

