﻿namespace Estacionamento
{
    partial class Entrada
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
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldadosentrada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntsalvar = new System.Windows.Forms.Button();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txthentrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(117, 46);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(191, 23);
            this.txtplaca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa: ";
            // 
            // lbldadosentrada
            // 
            this.lbldadosentrada.AutoSize = true;
            this.lbldadosentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldadosentrada.Location = new System.Drawing.Point(59, 9);
            this.lbldadosentrada.Name = "lbldadosentrada";
            this.lbldadosentrada.Size = new System.Drawing.Size(187, 26);
            this.lbldadosentrada.TabIndex = 2;
            this.lbldadosentrada.Text = "Dados de Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora\\Entrada: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição: ";
            // 
            // bntsalvar
            // 
            this.bntsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsalvar.Location = new System.Drawing.Point(107, 150);
            this.bntsalvar.Name = "bntsalvar";
            this.bntsalvar.Size = new System.Drawing.Size(90, 31);
            this.bntsalvar.TabIndex = 4;
            this.bntsalvar.Text = "Salvar";
            this.bntsalvar.UseVisualStyleBackColor = true;
            this.bntsalvar.Click += new System.EventHandler(this.BntSalvar);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(118, 105);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(190, 24);
            this.txtdesc.TabIndex = 3;
            // 
            // txthentrada
            // 
            this.txthentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthentrada.Location = new System.Drawing.Point(117, 75);
            this.txthentrada.Margin = new System.Windows.Forms.Padding(4);
            this.txthentrada.Name = "txthentrada";
            this.txthentrada.Size = new System.Drawing.Size(191, 23);
            this.txthentrada.TabIndex = 2;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.txthentrada);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.bntsalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldadosentrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldadosentrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntsalvar;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txthentrada;
    }
}