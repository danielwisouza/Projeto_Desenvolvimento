namespace NewSoft_SolucaosInovadoras
{
    partial class pesquisa_preco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisa_preco));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.precoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.precoTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.PrecoTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.precocdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preconmprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoquantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precolucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precototLucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.precocdDataGridViewTextBoxColumn,
            this.preconmprodDataGridViewTextBoxColumn,
            this.precoquantDataGridViewTextBoxColumn,
            this.precocompDataGridViewTextBoxColumn,
            this.precovendDataGridViewTextBoxColumn,
            this.precolucroDataGridViewTextBoxColumn,
            this.precototLucroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.precoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 326);
            this.dataGridView1.TabIndex = 3;
            // 
            // precoBindingSource
            // 
            this.precoBindingSource.DataMember = "Preco";
            this.precoBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.Button5.Location = new System.Drawing.Point(659, 396);
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
            this.Button4.Location = new System.Drawing.Point(659, 354);
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
            this.Button3.Location = new System.Drawing.Point(659, 317);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 33);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Alterar";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(584, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar por Código";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.TextBox1.Location = new System.Drawing.Point(12, 36);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(550, 23);
            this.TextBox1.TabIndex = 0;
            // 
            // precoTableAdapter
            // 
            this.precoTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "";
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(659, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // precocdDataGridViewTextBoxColumn
            // 
            this.precocdDataGridViewTextBoxColumn.DataPropertyName = "preco_cd";
            this.precocdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.precocdDataGridViewTextBoxColumn.Name = "precocdDataGridViewTextBoxColumn";
            this.precocdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preconmprodDataGridViewTextBoxColumn
            // 
            this.preconmprodDataGridViewTextBoxColumn.DataPropertyName = "preco_nmprod";
            this.preconmprodDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.preconmprodDataGridViewTextBoxColumn.Name = "preconmprodDataGridViewTextBoxColumn";
            this.preconmprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoquantDataGridViewTextBoxColumn
            // 
            this.precoquantDataGridViewTextBoxColumn.DataPropertyName = "preco_quant";
            this.precoquantDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.precoquantDataGridViewTextBoxColumn.Name = "precoquantDataGridViewTextBoxColumn";
            this.precoquantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precocompDataGridViewTextBoxColumn
            // 
            this.precocompDataGridViewTextBoxColumn.DataPropertyName = "preco_comp";
            this.precocompDataGridViewTextBoxColumn.HeaderText = "Preço de compra";
            this.precocompDataGridViewTextBoxColumn.Name = "precocompDataGridViewTextBoxColumn";
            this.precocompDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precovendDataGridViewTextBoxColumn
            // 
            this.precovendDataGridViewTextBoxColumn.DataPropertyName = "Preco_vend";
            this.precovendDataGridViewTextBoxColumn.HeaderText = "Preço de venda";
            this.precovendDataGridViewTextBoxColumn.Name = "precovendDataGridViewTextBoxColumn";
            this.precovendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precolucroDataGridViewTextBoxColumn
            // 
            this.precolucroDataGridViewTextBoxColumn.DataPropertyName = "preco_lucro";
            this.precolucroDataGridViewTextBoxColumn.HeaderText = "Lucro";
            this.precolucroDataGridViewTextBoxColumn.Name = "precolucroDataGridViewTextBoxColumn";
            this.precolucroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precototLucroDataGridViewTextBoxColumn
            // 
            this.precototLucroDataGridViewTextBoxColumn.DataPropertyName = "preco_totLucro";
            this.precototLucroDataGridViewTextBoxColumn.HeaderText = "Lucro total";
            this.precototLucroDataGridViewTextBoxColumn.Name = "precototLucroDataGridViewTextBoxColumn";
            this.precototLucroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesquisa_preco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisa_preco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Preço";
            this.Load += new System.EventHandler(this.pesquisa_preco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource precoBindingSource;
        private PadariaDataSetTableAdapters.PrecoTableAdapter precoTableAdapter;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preconmprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoquantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precolucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precototLucroDataGridViewTextBoxColumn;
    }
}