﻿
namespace Notaciones_Infijas_Profijas_Prefijas
{
    partial class Posfija_a_Infija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posfija_a_Infija));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_posfija_a_Infija = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosfija = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_posfija_a_Infija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 32);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 5);
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
            this.groupBox1.Controls.Add(this.btn_posfija_a_Infija);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPosfija);
            this.groupBox1.Location = new System.Drawing.Point(81, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 267);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_posfija_a_Infija
            // 
            this.btn_posfija_a_Infija.Image = ((System.Drawing.Image)(resources.GetObject("btn_posfija_a_Infija.Image")));
            this.btn_posfija_a_Infija.Location = new System.Drawing.Point(64, 157);
            this.btn_posfija_a_Infija.Name = "btn_posfija_a_Infija";
            this.btn_posfija_a_Infija.Size = new System.Drawing.Size(74, 27);
            this.btn_posfija_a_Infija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_posfija_a_Infija.TabIndex = 3;
            this.btn_posfija_a_Infija.TabStop = false;
            this.btn_posfija_a_Infija.Click += new System.EventHandler(this.btn_posfija_a_Infija_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precione para Convertir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Notacion Posfija";
            // 
            // txtPosfija
            // 
            this.txtPosfija.Location = new System.Drawing.Point(52, 77);
            this.txtPosfija.Name = "txtPosfija";
            this.txtPosfija.Size = new System.Drawing.Size(100, 23);
            this.txtPosfija.TabIndex = 0;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.v});
            this.dgv1.Location = new System.Drawing.Point(318, 52);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(244, 267);
            this.dgv1.TabIndex = 8;
            // 
            // x
            // 
            this.x.HeaderText = "Notacion Posfija";
            this.x.Name = "x";
            // 
            // v
            // 
            this.v.HeaderText = "Notacion Infija";
            this.v.Name = "v";
            // 
            // Posfija_a_Infija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Posfija_a_Infija";
            this.Text = "Posfija_a_Infija";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_posfija_a_Infija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btn_posfija_a_Infija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosfija;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn v;
    }
}