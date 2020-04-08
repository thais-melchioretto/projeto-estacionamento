using System;
using System.Windows.Forms;

namespace Estacionamento
{
    partial class Estacionamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estacionamento));
            this.bancoestacionamentoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnentrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsaida = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.btnano = new System.Windows.Forms.Button();
            this.btnmes = new System.Windows.Forms.Button();
            this.btnsemana = new System.Windows.Forms.Button();
            this.btndia = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bancoestacionamentoDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OpenSymbol", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(345, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "EstacionaBlu";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDePreçosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem1.Text = "Configurações";
            // 
            // tabelaDePreçosToolStripMenuItem
            // 
            this.tabelaDePreçosToolStripMenuItem.Name = "tabelaDePreçosToolStripMenuItem";
            this.tabelaDePreçosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tabelaDePreçosToolStripMenuItem.Text = "Tabela de Preços";
            this.tabelaDePreçosToolStripMenuItem.Click += new System.EventHandler(this.TabelaDePrecos);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnentrada
            // 
            this.btnentrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnentrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(65)))));
            this.btnentrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnentrada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnentrada.FlatAppearance.BorderSize = 0;
            this.btnentrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrada.ForeColor = System.Drawing.Color.White;
            this.btnentrada.Location = new System.Drawing.Point(9, 19);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(122, 34);
            this.btnentrada.TabIndex = 1;
            this.btnentrada.Text = "ENTRADA";
            this.btnentrada.UseVisualStyleBackColor = false;
            this.btnentrada.Click += new System.EventHandler(this.BtnEntrada);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 51);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnsaida
            // 
            this.btnsaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(54)))), ((int)(((byte)(35)))));
            this.btnsaida.FlatAppearance.BorderSize = 0;
            this.btnsaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaida.ForeColor = System.Drawing.Color.White;
            this.btnsaida.Location = new System.Drawing.Point(9, 59);
            this.btnsaida.Name = "btnsaida";
            this.btnsaida.Size = new System.Drawing.Size(122, 34);
            this.btnsaida.TabIndex = 2;
            this.btnsaida.Text = "Saída";
            this.btnsaida.UseVisualStyleBackColor = false;
            this.btnsaida.Click += new System.EventHandler(this.BtnSaida);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(48)))));
            this.btnalterar.FlatAppearance.BorderSize = 0;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.ForeColor = System.Drawing.Color.White;
            this.btnalterar.Location = new System.Drawing.Point(9, 99);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(122, 34);
            this.btnalterar.TabIndex = 7;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.BntAlterar);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(609, 378);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnentrada);
            this.groupBox1.Controls.Add(this.btnalterar);
            this.groupBox1.Controls.Add(this.btnsaida);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada\\Saída";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnconsulta);
            this.groupBox2.Controls.Add(this.btnano);
            this.groupBox2.Controls.Add(this.btnmes);
            this.groupBox2.Controls.Add(this.btnsemana);
            this.groupBox2.Controls.Add(this.btndia);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 229);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnconsulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.Color.DimGray;
            this.btnconsulta.Location = new System.Drawing.Point(9, 179);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(122, 34);
            this.btnconsulta.TabIndex = 4;
            this.btnconsulta.Text = "Consulta";
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.BtnConsulta);
            // 
            // btnano
            // 
            this.btnano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnano.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnano.ForeColor = System.Drawing.Color.DimGray;
            this.btnano.Location = new System.Drawing.Point(9, 139);
            this.btnano.Name = "btnano";
            this.btnano.Size = new System.Drawing.Size(122, 34);
            this.btnano.TabIndex = 3;
            this.btnano.Text = "Ano";
            this.btnano.UseVisualStyleBackColor = false;
            this.btnano.Click += new System.EventHandler(this.BtnAno);
            // 
            // btnmes
            // 
            this.btnmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmes.ForeColor = System.Drawing.Color.DimGray;
            this.btnmes.Location = new System.Drawing.Point(9, 99);
            this.btnmes.Name = "btnmes";
            this.btnmes.Size = new System.Drawing.Size(122, 34);
            this.btnmes.TabIndex = 2;
            this.btnmes.Text = "Mês";
            this.btnmes.UseVisualStyleBackColor = false;
            this.btnmes.Click += new System.EventHandler(this.BtnMes);
            // 
            // btnsemana
            // 
            this.btnsemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsemana.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsemana.ForeColor = System.Drawing.Color.DimGray;
            this.btnsemana.Location = new System.Drawing.Point(9, 59);
            this.btnsemana.Name = "btnsemana";
            this.btnsemana.Size = new System.Drawing.Size(122, 34);
            this.btnsemana.TabIndex = 1;
            this.btnsemana.Text = "Semana";
            this.btnsemana.UseVisualStyleBackColor = false;
            this.btnsemana.Click += new System.EventHandler(this.BtnSemana);
            // 
            // btndia
            // 
            this.btndia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndia.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btndia.FlatAppearance.BorderSize = 0;
            this.btndia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndia.ForeColor = System.Drawing.Color.DimGray;
            this.btndia.Location = new System.Drawing.Point(9, 19);
            this.btndia.Name = "btndia";
            this.btndia.Size = new System.Drawing.Size(122, 34);
            this.btndia.TabIndex = 0;
            this.btndia.Text = "Dia";
            this.btndia.UseVisualStyleBackColor = false;
            this.btndia.Click += new System.EventHandler(this.BtnDia);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(778, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Estacionamento";
            ((System.ComponentModel.ISupportInitialize)(this.bancoestacionamentoDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.BindingSource bancoestacionamentoDataSetBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabelaDePreçosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnentrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsaida;
        private System.Windows.Forms.Button btnalterar;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ImageList imageList2;
        private Button btnconsulta;
        private Button btnano;
        private Button btnmes;
        private Button btnsemana;
        private Button btndia;
    }
}

