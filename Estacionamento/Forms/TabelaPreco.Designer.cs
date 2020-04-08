using System;
using System.Windows.Forms;

namespace Estacionamento
{
    partial class TabelaPreco
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
            this.components = new System.ComponentModel.Container();
            this.bancoestacionamentoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbldatainicial = new System.Windows.Forms.Label();
            this.lbldatafinal = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.txtdatainicial = new System.Windows.Forms.TextBox();
            this.txtdatafinal = new System.Windows.Forms.TextBox();
            this.txtprecohora = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.bntalterar = new System.Windows.Forms.Button();
            this.lbladicional = new System.Windows.Forms.Label();
            this.txtadicional = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lblano = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bancoestacionamentoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldatainicial
            // 
            this.lbldatainicial.AutoSize = true;
            this.lbldatainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatainicial.Location = new System.Drawing.Point(4, 216);
            this.lbldatainicial.Name = "lbldatainicial";
            this.lbldatainicial.Size = new System.Drawing.Size(85, 17);
            this.lbldatainicial.TabIndex = 1;
            this.lbldatainicial.Text = "Data Inicial: ";
            // 
            // lbldatafinal
            // 
            this.lbldatafinal.AutoSize = true;
            this.lbldatafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatafinal.Location = new System.Drawing.Point(161, 216);
            this.lbldatafinal.Name = "lbldatafinal";
            this.lbldatafinal.Size = new System.Drawing.Size(76, 17);
            this.lbldatafinal.TabIndex = 2;
            this.lbldatafinal.Text = "Data final: ";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.Location = new System.Drawing.Point(4, 238);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(86, 17);
            this.lblpreco.TabIndex = 3;
            this.lblpreco.Text = "Preço/hora: ";
            // 
            // txtdatainicial
            // 
            this.txtdatainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatainicial.Location = new System.Drawing.Point(82, 213);
            this.txtdatainicial.Name = "txtdatainicial";
            this.txtdatainicial.Size = new System.Drawing.Size(73, 21);
            this.txtdatainicial.TabIndex = 1;
            // 
            // txtdatafinal
            // 
            this.txtdatafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatafinal.Location = new System.Drawing.Point(231, 213);
            this.txtdatafinal.Name = "txtdatafinal";
            this.txtdatafinal.Size = new System.Drawing.Size(75, 21);
            this.txtdatafinal.TabIndex = 2;
            // 
            // txtprecohora
            // 
            this.txtprecohora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecohora.Location = new System.Drawing.Point(82, 237);
            this.txtprecohora.Name = "txtprecohora";
            this.txtprecohora.Size = new System.Drawing.Size(73, 21);
            this.txtprecohora.TabIndex = 4;
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(38, 275);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(85, 25);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.BtnExcluir);
            // 
            // bntalterar
            // 
            this.bntalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntalterar.Location = new System.Drawing.Point(179, 275);
            this.bntalterar.Name = "bntalterar";
            this.bntalterar.Size = new System.Drawing.Size(85, 25);
            this.bntalterar.TabIndex = 9;
            this.bntalterar.Text = "Alterar";
            this.bntalterar.UseVisualStyleBackColor = true;
            this.bntalterar.Click += new System.EventHandler(this.BtnAlterar);
            // 
            // lbladicional
            // 
            this.lbladicional.AutoSize = true;
            this.lbladicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladicional.Location = new System.Drawing.Point(161, 237);
            this.lbladicional.Name = "lbladicional";
            this.lbladicional.Size = new System.Drawing.Size(69, 17);
            this.lbladicional.TabIndex = 13;
            this.lbladicional.Text = "Adicional:";
            // 
            // txtadicional
            // 
            this.txtadicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadicional.Location = new System.Drawing.Point(231, 238);
            this.txtadicional.Name = "txtadicional";
            this.txtadicional.Size = new System.Drawing.Size(75, 21);
            this.txtadicional.TabIndex = 5;
            // 
            // txtano
            // 
            this.txtano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.Location = new System.Drawing.Point(348, 212);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(75, 21);
            this.txtano.TabIndex = 3;
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblano.Location = new System.Drawing.Point(312, 217);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(41, 17);
            this.lblano.TabIndex = 15;
            this.lblano.Text = "Ano: ";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(315, 275);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(85, 25);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.BtnExcluir);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 192);
            this.dataGridView1.TabIndex = 17;
            // 
            // TabelaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.txtadicional);
            this.Controls.Add(this.lbladicional);
            this.Controls.Add(this.bntalterar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtprecohora);
            this.Controls.Add(this.txtdatafinal);
            this.Controls.Add(this.txtdatainicial);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbldatafinal);
            this.Controls.Add(this.lbldatainicial);
            this.Name = "TabelaPreco";
            this.Text = "TabelaPreco";
            ((System.ComponentModel.ISupportInitialize)(this.bancoestacionamentoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.BindingSource bancoestacionamentoDataSetBindingSource;
        private System.Windows.Forms.Label lbldatainicial;
        private System.Windows.Forms.Label lbldatafinal;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txtdatainicial;
        private System.Windows.Forms.TextBox txtdatafinal;
        private System.Windows.Forms.TextBox txtprecohora;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button bntalterar;
        private System.Windows.Forms.Label lbladicional;
        private System.Windows.Forms.TextBox txtadicional;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Button btnexcluir;
        private DataGridView dataGridView1;
    }
}