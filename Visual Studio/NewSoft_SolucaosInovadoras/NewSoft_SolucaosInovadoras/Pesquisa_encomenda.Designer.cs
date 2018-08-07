namespace NewSoft_SolucaosInovadoras
{
    partial class Pesquisa_encomenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_encomenda));
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.encomendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.encomendaTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.encomendaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.enccdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encdescprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encomquantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precototDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verifdadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.Button5.Location = new System.Drawing.Point(641, 387);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(88, 33);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "Voltar";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.Control;
            this.Button4.Location = new System.Drawing.Point(641, 350);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(88, 33);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "Remover";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.AccessibleDescription = "";
            this.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.Control;
            this.Button3.Location = new System.Drawing.Point(641, 313);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 33);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Alterar";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enccdDataGridViewTextBoxColumn,
            this.clicdDataGridViewTextBoxColumn,
            this.encdescprodDataGridViewTextBoxColumn,
            this.encomquantDataGridViewTextBoxColumn,
            this.precototDataGridViewTextBoxColumn,
            this.verifdadosDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.encomendaBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(26, 93);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(580, 344);
            this.DataGridView1.TabIndex = 3;
            // 
            // encomendaBindingSource
            // 
            this.encomendaBindingSource.DataMember = "encomenda";
            this.encomendaBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(584, 12);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(163, 35);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Pesquisar Nomes";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(26, 36);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(508, 23);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // encomendaTableAdapter
            // 
            this.encomendaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(584, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar por Código";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "";
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(641, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // enccdDataGridViewTextBoxColumn
            // 
            this.enccdDataGridViewTextBoxColumn.DataPropertyName = "Enc_cd";
            this.enccdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.enccdDataGridViewTextBoxColumn.Name = "enccdDataGridViewTextBoxColumn";
            this.enccdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicdDataGridViewTextBoxColumn
            // 
            this.clicdDataGridViewTextBoxColumn.DataPropertyName = "Cli_cd";
            this.clicdDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clicdDataGridViewTextBoxColumn.Name = "clicdDataGridViewTextBoxColumn";
            this.clicdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encdescprodDataGridViewTextBoxColumn
            // 
            this.encdescprodDataGridViewTextBoxColumn.DataPropertyName = "Enc_desc_prod";
            this.encdescprodDataGridViewTextBoxColumn.HeaderText = "Descrição ";
            this.encdescprodDataGridViewTextBoxColumn.Name = "encdescprodDataGridViewTextBoxColumn";
            this.encdescprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encomquantDataGridViewTextBoxColumn
            // 
            this.encomquantDataGridViewTextBoxColumn.DataPropertyName = "Encom_quant";
            this.encomquantDataGridViewTextBoxColumn.HeaderText = "Quantidade ";
            this.encomquantDataGridViewTextBoxColumn.Name = "encomquantDataGridViewTextBoxColumn";
            this.encomquantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precototDataGridViewTextBoxColumn
            // 
            this.precototDataGridViewTextBoxColumn.DataPropertyName = "Preco_tot";
            this.precototDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precototDataGridViewTextBoxColumn.Name = "precototDataGridViewTextBoxColumn";
            this.precototDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verifdadosDataGridViewTextBoxColumn
            // 
            this.verifdadosDataGridViewTextBoxColumn.DataPropertyName = "Verif_dados";
            this.verifdadosDataGridViewTextBoxColumn.HeaderText = "Verificação de Dados";
            this.verifdadosDataGridViewTextBoxColumn.Name = "verifdadosDataGridViewTextBoxColumn";
            this.verifdadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pesquisa_encomenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_encomenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Encomenda";
            this.Load += new System.EventHandler(this.Pesquisa_encomenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource encomendaBindingSource;
        private PadariaDataSetTableAdapters.encomendaTableAdapter encomendaTableAdapter;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn enccdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encdescprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encomquantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precototDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verifdadosDataGridViewTextBoxColumn;
    }
}