namespace NewSoft_SolucaosInovadoras
{
    partial class Pesquisa_de_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_de_Produto));
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.produtoTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.produtoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proddescriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.Control;
            this.Button4.Location = new System.Drawing.Point(643, 363);
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
            this.Button3.Location = new System.Drawing.Point(643, 326);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 33);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Alterar";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.Button5.Location = new System.Drawing.Point(643, 402);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(88, 33);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "Voltar";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
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
            this.TextBox1.Location = new System.Drawing.Point(30, 37);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(540, 23);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(584, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar por Código";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.prodnmDataGridViewTextBoxColumn,
            this.proddescriDataGridViewTextBoxColumn,
            this.prodquantiDataGridViewTextBoxColumn,
            this.prodfornecedorDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.produtoBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(30, 101);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(580, 334);
            this.DataGridView1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "";
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(643, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "prod_cd";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodnmDataGridViewTextBoxColumn
            // 
            this.prodnmDataGridViewTextBoxColumn.DataPropertyName = "prod_nm";
            this.prodnmDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.prodnmDataGridViewTextBoxColumn.Name = "prodnmDataGridViewTextBoxColumn";
            this.prodnmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proddescriDataGridViewTextBoxColumn
            // 
            this.proddescriDataGridViewTextBoxColumn.DataPropertyName = "prod_descri";
            this.proddescriDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.proddescriDataGridViewTextBoxColumn.Name = "proddescriDataGridViewTextBoxColumn";
            this.proddescriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodquantiDataGridViewTextBoxColumn
            // 
            this.prodquantiDataGridViewTextBoxColumn.DataPropertyName = "prod_quanti";
            this.prodquantiDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.prodquantiDataGridViewTextBoxColumn.Name = "prodquantiDataGridViewTextBoxColumn";
            this.prodquantiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodfornecedorDataGridViewTextBoxColumn
            // 
            this.prodfornecedorDataGridViewTextBoxColumn.DataPropertyName = "prod_fornecedor";
            this.prodfornecedorDataGridViewTextBoxColumn.HeaderText = "Fonecedor";
            this.prodfornecedorDataGridViewTextBoxColumn.Name = "prodfornecedorDataGridViewTextBoxColumn";
            this.prodfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pesquisa_de_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_de_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produdo";
            this.Load += new System.EventHandler(this.pesquisa_de_Produdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private PadariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn prodcdDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proddescriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodfornecedorDataGridViewTextBoxColumn;
    }
}