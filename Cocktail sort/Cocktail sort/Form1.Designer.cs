﻿namespace Cocktail_sort
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lbNum = new System.Windows.Forms.ListBox();
            this.lbOrdenar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTiempoGenerar = new System.Windows.Forms.Label();
            this.lblTiempoOrdenar = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(97, 73);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 0;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(13, 77);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(62, 17);
            this.lblNumeros.TabIndex = 1;
            this.lblNumeros.Text = "Numero:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(111, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label2";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(97, 132);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(97, 197);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lbNum
            // 
            this.lbNum.FormattingEnabled = true;
            this.lbNum.ItemHeight = 16;
            this.lbNum.Location = new System.Drawing.Point(328, 87);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(120, 132);
            this.lbNum.TabIndex = 6;
            // 
            // lbOrdenar
            // 
            this.lbOrdenar.FormattingEnabled = true;
            this.lbOrdenar.ItemHeight = 16;
            this.lbOrdenar.Location = new System.Drawing.Point(496, 88);
            this.lbOrdenar.Name = "lbOrdenar";
            this.lbOrdenar.Size = new System.Drawing.Size(120, 132);
            this.lbOrdenar.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblO);
            this.groupBox1.Controls.Add(this.lblG);
            this.groupBox1.Controls.Add(this.lblTiempoOrdenar);
            this.groupBox1.Controls.Add(this.lblTiempoGenerar);
            this.groupBox1.Location = new System.Drawing.Point(43, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo de ejecucion";
            // 
            // lblTiempoGenerar
            // 
            this.lblTiempoGenerar.AutoSize = true;
            this.lblTiempoGenerar.Location = new System.Drawing.Point(130, 35);
            this.lblTiempoGenerar.Name = "lblTiempoGenerar";
            this.lblTiempoGenerar.Size = new System.Drawing.Size(28, 17);
            this.lblTiempoGenerar.TabIndex = 0;
            this.lblTiempoGenerar.Text = "0:0";
            // 
            // lblTiempoOrdenar
            // 
            this.lblTiempoOrdenar.AutoSize = true;
            this.lblTiempoOrdenar.Location = new System.Drawing.Point(94, 69);
            this.lblTiempoOrdenar.Name = "lblTiempoOrdenar";
            this.lblTiempoOrdenar.Size = new System.Drawing.Size(28, 17);
            this.lblTiempoOrdenar.TabIndex = 1;
            this.lblTiempoOrdenar.Text = "0:0";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(20, 35);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(104, 17);
            this.lblG.TabIndex = 10;
            this.lblG.Text = "Generar datos:";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(23, 69);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(65, 17);
            this.lblO.TabIndex = 11;
            this.lblO.Text = "Ordenar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOrdenar);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lbNum;
        private System.Windows.Forms.ListBox lbOrdenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTiempoOrdenar;
        private System.Windows.Forms.Label lblTiempoGenerar;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblG;
    }
}
