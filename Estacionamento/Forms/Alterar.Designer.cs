namespace Estacionamento
{
    partial class Alterar
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
            this.txthentrada = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblhentrada = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.txthsaida = new System.Windows.Forms.TextBox();
            this.lblhsaida = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtvlrpagar = new System.Windows.Forms.TextBox();
            this.lblvalorpagar = new System.Windows.Forms.Label();
            this.txttempo = new System.Windows.Forms.TextBox();
            this.lbltempo = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.cbplaca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txthentrada
            // 
            this.txthentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthentrada.Location = new System.Drawing.Point(79, 55);
            this.txthentrada.Margin = new System.Windows.Forms.Padding(4);
            this.txthentrada.Name = "txthentrada";
            this.txthentrada.Size = new System.Drawing.Size(124, 23);
            this.txthentrada.TabIndex = 19;
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(211, 22);
            this.lbldescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(79, 17);
            this.lbldescricao.TabIndex = 17;
            this.lbldescricao.Text = "Descrição: ";
            // 
            // lblhentrada
            // 
            this.lblhentrada.AutoSize = true;
            this.lblhentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhentrada.Location = new System.Drawing.Point(0, 58);
            this.lblhentrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhentrada.Name = "lblhentrada";
            this.lblhentrada.Size = new System.Drawing.Size(80, 17);
            this.lblhentrada.TabIndex = 16;
            this.lblhentrada.Text = "H\\Entrada: ";
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.Location = new System.Drawing.Point(2, 22);
            this.lblplaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(51, 17);
            this.lblplaca.TabIndex = 15;
            this.lblplaca.Text = "Placa: ";
            // 
            // txthsaida
            // 
            this.txthsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthsaida.Location = new System.Drawing.Point(79, 87);
            this.txthsaida.Margin = new System.Windows.Forms.Padding(4);
            this.txthsaida.Name = "txthsaida";
            this.txthsaida.Size = new System.Drawing.Size(124, 23);
            this.txthsaida.TabIndex = 23;
            // 
            // lblhsaida
            // 
            this.lblhsaida.AutoSize = true;
            this.lblhsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhsaida.Location = new System.Drawing.Point(0, 93);
            this.lblhsaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhsaida.Name = "lblhsaida";
            this.lblhsaida.Size = new System.Drawing.Size(62, 17);
            this.lblhsaida.TabIndex = 22;
            this.lblhsaida.Text = "H\\Saída:";
            // 
            // btnalterar
            // 
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(79, 128);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(128, 31);
            this.btnalterar.TabIndex = 26;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.BtnAlterar);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(291, 22);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(128, 23);
            this.txtdescricao.TabIndex = 27;
            // 
            // txtvlrpagar
            // 
            this.txtvlrpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvlrpagar.Location = new System.Drawing.Point(291, 84);
            this.txtvlrpagar.Margin = new System.Windows.Forms.Padding(4);
            this.txtvlrpagar.Name = "txtvlrpagar";
            this.txtvlrpagar.Size = new System.Drawing.Size(128, 23);
            this.txtvlrpagar.TabIndex = 31;
            // 
            // lblvalorpagar
            // 
            this.lblvalorpagar.AutoSize = true;
            this.lblvalorpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorpagar.Location = new System.Drawing.Point(211, 87);
            this.lblvalorpagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalorpagar.Name = "lblvalorpagar";
            this.lblvalorpagar.Size = new System.Drawing.Size(86, 17);
            this.lblvalorpagar.TabIndex = 30;
            this.lblvalorpagar.Text = "Vlr a pagar: ";
            // 
            // txttempo
            // 
            this.txttempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttempo.Location = new System.Drawing.Point(291, 52);
            this.txttempo.Margin = new System.Windows.Forms.Padding(4);
            this.txttempo.Name = "txttempo";
            this.txttempo.Size = new System.Drawing.Size(128, 23);
            this.txttempo.TabIndex = 29;
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempo.Location = new System.Drawing.Point(211, 58);
            this.lbltempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(60, 17);
            this.lbltempo.TabIndex = 28;
            this.lbltempo.Text = "Tempo: ";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(291, 128);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(128, 31);
            this.btnexcluir.TabIndex = 32;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.BtnExcluir);
            // 
            // cbplaca
            // 
            this.cbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbplaca.FormattingEnabled = true;
            this.cbplaca.Location = new System.Drawing.Point(79, 19);
            this.cbplaca.Name = "cbplaca";
            this.cbplaca.Size = new System.Drawing.Size(124, 24);
            this.cbplaca.TabIndex = 33;
            this.cbplaca.Tag = "1";
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 173);
            this.Controls.Add(this.cbplaca);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.txtvlrpagar);
            this.Controls.Add(this.lblvalorpagar);
            this.Controls.Add(this.txttempo);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txthsaida);
            this.Controls.Add(this.lblhsaida);
            this.Controls.Add(this.txthentrada);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblhentrada);
            this.Controls.Add(this.lblplaca);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthentrada;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblhentrada;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txthsaida;
        private System.Windows.Forms.Label lblhsaida;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtvlrpagar;
        private System.Windows.Forms.Label lblvalorpagar;
        private System.Windows.Forms.TextBox txttempo;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.ComboBox cbplaca;
    }
}