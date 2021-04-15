
namespace Notaciones_Infijas_Profijas_Prefijas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Prefija_a_Infija = new System.Windows.Forms.Button();
            this.Posfija_a_Infija = new System.Windows.Forms.Button();
            this.Infija_a_Prefija = new System.Windows.Forms.Button();
            this.posfija_infija = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 27);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Prefija_a_Infija);
            this.groupBox1.Controls.Add(this.Posfija_a_Infija);
            this.groupBox1.Controls.Add(this.Infija_a_Prefija);
            this.groupBox1.Controls.Add(this.posfija_infija);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(39, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select One";
            // 
            // Prefija_a_Infija
            // 
            this.Prefija_a_Infija.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Prefija_a_Infija.Location = new System.Drawing.Point(50, 235);
            this.Prefija_a_Infija.Name = "Prefija_a_Infija";
            this.Prefija_a_Infija.Size = new System.Drawing.Size(122, 23);
            this.Prefija_a_Infija.TabIndex = 3;
            this.Prefija_a_Infija.Text = "Prefija a Infija";
            this.Prefija_a_Infija.UseVisualStyleBackColor = true;
            this.Prefija_a_Infija.Click += new System.EventHandler(this.Prefija_a_Infija_Click);
            // 
            // Posfija_a_Infija
            // 
            this.Posfija_a_Infija.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Posfija_a_Infija.Location = new System.Drawing.Point(50, 177);
            this.Posfija_a_Infija.Name = "Posfija_a_Infija";
            this.Posfija_a_Infija.Size = new System.Drawing.Size(122, 23);
            this.Posfija_a_Infija.TabIndex = 2;
            this.Posfija_a_Infija.Text = "Posfija a Infija";
            this.Posfija_a_Infija.UseVisualStyleBackColor = true;
            this.Posfija_a_Infija.Click += new System.EventHandler(this.Posfija_a_Infija_Click);
            // 
            // Infija_a_Prefija
            // 
            this.Infija_a_Prefija.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Infija_a_Prefija.Location = new System.Drawing.Point(50, 123);
            this.Infija_a_Prefija.Name = "Infija_a_Prefija";
            this.Infija_a_Prefija.Size = new System.Drawing.Size(122, 23);
            this.Infija_a_Prefija.TabIndex = 1;
            this.Infija_a_Prefija.Text = "Infija a Prefija";
            this.Infija_a_Prefija.UseVisualStyleBackColor = true;
            this.Infija_a_Prefija.Click += new System.EventHandler(this.Infija_a_Prefija_Click);
            // 
            // posfija_infija
            // 
            this.posfija_infija.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.posfija_infija.Location = new System.Drawing.Point(50, 61);
            this.posfija_infija.Name = "posfija_infija";
            this.posfija_infija.Size = new System.Drawing.Size(122, 23);
            this.posfija_infija.TabIndex = 0;
            this.posfija_infija.Text = "Infija a Posfija";
            this.posfija_infija.UseVisualStyleBackColor = true;
            this.posfija_infija.Click += new System.EventHandler(this.posfija_infija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button posfija_infija;
        private System.Windows.Forms.Button Prefija_a_Infija;
        private System.Windows.Forms.Button Posfija_a_Infija;
        private System.Windows.Forms.Button Infija_a_Prefija;
    }
}

