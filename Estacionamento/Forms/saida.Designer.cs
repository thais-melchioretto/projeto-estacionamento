﻿namespace Estacionamento
{
    partial class Saida
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
            this.txthsaida = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblhorasaida = new System.Windows.Forms.Label();
            this.lblsaidaveiculos = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.cbplaca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txthsaida
            // 
            this.txthsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthsaida.Location = new System.Drawing.Point(117, 77);
            this.txthsaida.Margin = new System.Windows.Forms.Padding(4);
            this.txthsaida.Name = "txthsaida";
            this.txthsaida.Size = new System.Drawing.Size(191, 23);
            this.txthsaida.TabIndex = 2;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(117, 145);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(90, 31);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.BtnSalvar);
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.Location = new System.Drawing.Point(13, 52);
            this.lblplaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(51, 17);
            this.lblplaca.TabIndex = 18;
            this.lblplaca.Text = "Placa: ";
            // 
            // lblhorasaida
            // 
            this.lblhorasaida.AutoSize = true;
            this.lblhorasaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorasaida.Location = new System.Drawing.Point(14, 79);
            this.lblhorasaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhorasaida.Name = "lblhorasaida";
            this.lblhorasaida.Size = new System.Drawing.Size(83, 17);
            this.lblhorasaida.TabIndex = 17;
            this.lblhorasaida.Text = "Hora\\Saída:";
            // 
            // lblsaidaveiculos
            // 
            this.lblsaidaveiculos.AutoSize = true;
            this.lblsaidaveiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaidaveiculos.Location = new System.Drawing.Point(71, 9);
            this.lblsaidaveiculos.Name = "lblsaidaveiculos";
            this.lblsaidaveiculos.Size = new System.Drawing.Size(187, 26);
            this.lblsaidaveiculos.TabIndex = 16;
            this.lblsaidaveiculos.Text = "Saída de Veículos";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(14, 109);
            this.lbldescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(79, 17);
            this.lbldescricao.TabIndex = 15;
            this.lbldescricao.Text = "Descrição: ";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(117, 104);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(191, 23);
            this.txtdescricao.TabIndex = 3;
            // 
            // cbplaca
            // 
            this.cbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbplaca.FormattingEnabled = true;
            this.cbplaca.Location = new System.Drawing.Point(117, 49);
            this.cbplaca.Name = "cbplaca";
            this.cbplaca.Size = new System.Drawing.Size(191, 24);
            this.cbplaca.TabIndex = 1;
            this.cbplaca.Tag = "1";
            this.cbplaca.SelectedIndexChanged += new System.EventHandler(this.CbPlaca);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.cbplaca);
            this.Controls.Add(this.txthsaida);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.lblhorasaida);
            this.Controls.Add(this.lblsaidaveiculos);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.txtdescricao);
            this.Name = "Saida";
            this.Text = "saida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthsaida;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblhorasaida;
        private System.Windows.Forms.Label lblsaidaveiculos;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.ComboBox cbplaca;
    }
}