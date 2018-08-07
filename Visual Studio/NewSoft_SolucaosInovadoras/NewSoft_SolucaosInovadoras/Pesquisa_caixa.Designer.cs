namespace NewSoft_SolucaosInovadoras
{
    partial class Pesquisa_caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_caixa));
            this.Button4 = new System.Windows.Forms.Button();
            this.caixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.caixaTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.caixaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caixacdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçototDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.Control;
            this.Button4.Location = new System.Drawing.Point(640, 360);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(88, 33);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "Remover";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // caixaBindingSource
            // 
            this.caixaBindingSource.DataMember = "caixa";
            this.caixaBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button3
            // 
            this.Button3.AccessibleDescription = "";
            this.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.Control;
            this.Button3.Location = new System.Drawing.Point(640, 321);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 33);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Alterar";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(585, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(163, 35);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Pesquisar Nomes";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(25, 24);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(516, 23);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // caixaTableAdapter
            // 
            this.caixaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(640, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(585, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 35);
            this.button5.TabIndex = 2;
            this.button5.Text = "Pesquisar por Código";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "";
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(640, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caixacdDataGridViewTextBoxColumn,
            this.funccdDataGridViewTextBoxColumn,
            this.clinmDataGridViewTextBoxColumn,
            this.descrprodDataGridViewTextBoxColumn,
            this.quantcdDataGridViewTextBoxColumn,
            this.preçototDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.caixaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 355);
            this.dataGridView1.TabIndex = 8;
            // 
            // caixacdDataGridViewTextBoxColumn
            // 
            this.caixacdDataGridViewTextBoxColumn.DataPropertyName = "Caixa_cd";
            this.caixacdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.caixacdDataGridViewTextBoxColumn.Name = "caixacdDataGridViewTextBoxColumn";
            this.caixacdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funccdDataGridViewTextBoxColumn
            // 
            this.funccdDataGridViewTextBoxColumn.DataPropertyName = "Func_cd";
            this.funccdDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.funccdDataGridViewTextBoxColumn.Name = "funccdDataGridViewTextBoxColumn";
            // 
            // clinmDataGridViewTextBoxColumn
            // 
            this.clinmDataGridViewTextBoxColumn.DataPropertyName = "cli_nm";
            this.clinmDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clinmDataGridViewTextBoxColumn.Name = "clinmDataGridViewTextBoxColumn";
            // 
            // descrprodDataGridViewTextBoxColumn
            // 
            this.descrprodDataGridViewTextBoxColumn.DataPropertyName = "Descr_prod";
            this.descrprodDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.descrprodDataGridViewTextBoxColumn.Name = "descrprodDataGridViewTextBoxColumn";
            // 
            // quantcdDataGridViewTextBoxColumn
            // 
            this.quantcdDataGridViewTextBoxColumn.DataPropertyName = "Quant_cd";
            this.quantcdDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantcdDataGridViewTextBoxColumn.Name = "quantcdDataGridViewTextBoxColumn";
            // 
            // preçototDataGridViewTextBoxColumn
            // 
            this.preçototDataGridViewTextBoxColumn.DataPropertyName = "preço_tot";
            this.preçototDataGridViewTextBoxColumn.HeaderText = "Preço Total";
            this.preçototDataGridViewTextBoxColumn.Name = "preçototDataGridViewTextBoxColumn";
            // 
            // Pesquisa_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Caixa";
            this.Load += new System.EventHandler(this.Pesquisa_caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource caixaBindingSource;
        private PadariaDataSetTableAdapters.caixaTableAdapter caixaTableAdapter;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixacdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçototDataGridViewTextBoxColumn;
    }
}