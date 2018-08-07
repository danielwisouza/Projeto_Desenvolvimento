namespace NewSoft_SolucaosInovadoras
{
    partial class Pesquisa_de_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_de_Fornecedor));
            this.Button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.fornecedorTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.fornecedorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.forncdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forncnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forncepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forntelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forncidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(584, 10);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(163, 35);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Pesquisar Nomes";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.Button5.Location = new System.Drawing.Point(659, 408);
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
            this.Button4.Location = new System.Drawing.Point(659, 369);
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
            this.Button3.Location = new System.Drawing.Point(659, 330);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 33);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Alterar";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(27, 22);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(545, 23);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forncdDataGridViewTextBoxColumn,
            this.fornnomeDataGridViewTextBoxColumn,
            this.fornemailDataGridViewTextBoxColumn,
            this.forncnpjDataGridViewTextBoxColumn,
            this.fornendDataGridViewTextBoxColumn,
            this.forncepDataGridViewTextBoxColumn,
            this.forntelDataGridViewTextBoxColumn,
            this.forncidadeDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.fornecedorBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(27, 100);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(605, 345);
            this.DataGridView1.TabIndex = 3;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(584, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar por Código";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "";
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(659, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // forncdDataGridViewTextBoxColumn
            // 
            this.forncdDataGridViewTextBoxColumn.DataPropertyName = "forn_cd";
            this.forncdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.forncdDataGridViewTextBoxColumn.Name = "forncdDataGridViewTextBoxColumn";
            this.forncdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornnomeDataGridViewTextBoxColumn
            // 
            this.fornnomeDataGridViewTextBoxColumn.DataPropertyName = "forn_nome";
            this.fornnomeDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornnomeDataGridViewTextBoxColumn.Name = "fornnomeDataGridViewTextBoxColumn";
            this.fornnomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornemailDataGridViewTextBoxColumn
            // 
            this.fornemailDataGridViewTextBoxColumn.DataPropertyName = "forn_email";
            this.fornemailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.fornemailDataGridViewTextBoxColumn.Name = "fornemailDataGridViewTextBoxColumn";
            this.fornemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forncnpjDataGridViewTextBoxColumn
            // 
            this.forncnpjDataGridViewTextBoxColumn.DataPropertyName = "forn_cnpj";
            this.forncnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.forncnpjDataGridViewTextBoxColumn.Name = "forncnpjDataGridViewTextBoxColumn";
            this.forncnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornendDataGridViewTextBoxColumn
            // 
            this.fornendDataGridViewTextBoxColumn.DataPropertyName = "forn_end";
            this.fornendDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.fornendDataGridViewTextBoxColumn.Name = "fornendDataGridViewTextBoxColumn";
            this.fornendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forncepDataGridViewTextBoxColumn
            // 
            this.forncepDataGridViewTextBoxColumn.DataPropertyName = "forn_cep";
            this.forncepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.forncepDataGridViewTextBoxColumn.Name = "forncepDataGridViewTextBoxColumn";
            this.forncepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forntelDataGridViewTextBoxColumn
            // 
            this.forntelDataGridViewTextBoxColumn.DataPropertyName = "forn_tel";
            this.forntelDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.forntelDataGridViewTextBoxColumn.Name = "forntelDataGridViewTextBoxColumn";
            this.forntelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forncidadeDataGridViewTextBoxColumn
            // 
            this.forncidadeDataGridViewTextBoxColumn.DataPropertyName = "forn_cidade";
            this.forncidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.forncidadeDataGridViewTextBoxColumn.Name = "forncidadeDataGridViewTextBoxColumn";
            this.forncidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pesquisa_de_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_de_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Fornecedor";
            this.Load += new System.EventHandler(this.Pesquisa_de_Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private PadariaDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn forncdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forncnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forncepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forntelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forncidadeDataGridViewTextBoxColumn;
    }
}