namespace NewSoft_SolucaosInovadoras
{
    partial class Pesquisa_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_cliente));
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.clienteTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.ClienteTableAdapter();
            this.clicdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clisexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clirgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clibairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(584, 13);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(163, 35);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Pesquisar Nomes";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(25, 25);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(550, 23);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.Control;
            this.Button4.Location = new System.Drawing.Point(650, 355);
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
            this.Button3.Location = new System.Drawing.Point(650, 310);
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
            this.Button5.Location = new System.Drawing.Point(650, 394);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(88, 33);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "Voltar";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(584, 57);
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
            this.button6.Location = new System.Drawing.Point(650, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clicdDataGridViewTextBoxColumn,
            this.clinmDataGridViewTextBoxColumn,
            this.clisexoDataGridViewTextBoxColumn,
            this.clirgDataGridViewTextBoxColumn,
            this.clicepDataGridViewTextBoxColumn,
            this.clibairroDataGridViewTextBoxColumn,
            this.clicidadeDataGridViewTextBoxColumn,
            this.cliendDataGridViewTextBoxColumn,
            this.cliemailDataGridViewTextBoxColumn,
            this.clitelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 370);
            this.dataGridView1.TabIndex = 9;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clicdDataGridViewTextBoxColumn
            // 
            this.clicdDataGridViewTextBoxColumn.DataPropertyName = "cli_cd";
            this.clicdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.clicdDataGridViewTextBoxColumn.Name = "clicdDataGridViewTextBoxColumn";
            this.clicdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clinmDataGridViewTextBoxColumn
            // 
            this.clinmDataGridViewTextBoxColumn.DataPropertyName = "cli_nm";
            this.clinmDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.clinmDataGridViewTextBoxColumn.Name = "clinmDataGridViewTextBoxColumn";
            this.clinmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clisexoDataGridViewTextBoxColumn
            // 
            this.clisexoDataGridViewTextBoxColumn.DataPropertyName = "cli_sexo";
            this.clisexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.clisexoDataGridViewTextBoxColumn.Name = "clisexoDataGridViewTextBoxColumn";
            this.clisexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clirgDataGridViewTextBoxColumn
            // 
            this.clirgDataGridViewTextBoxColumn.DataPropertyName = "Cli_rg";
            this.clirgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.clirgDataGridViewTextBoxColumn.Name = "clirgDataGridViewTextBoxColumn";
            this.clirgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicepDataGridViewTextBoxColumn
            // 
            this.clicepDataGridViewTextBoxColumn.DataPropertyName = "cli_cep";
            this.clicepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.clicepDataGridViewTextBoxColumn.Name = "clicepDataGridViewTextBoxColumn";
            this.clicepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clibairroDataGridViewTextBoxColumn
            // 
            this.clibairroDataGridViewTextBoxColumn.DataPropertyName = "cli_bairro";
            this.clibairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.clibairroDataGridViewTextBoxColumn.Name = "clibairroDataGridViewTextBoxColumn";
            this.clibairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clicidadeDataGridViewTextBoxColumn
            // 
            this.clicidadeDataGridViewTextBoxColumn.DataPropertyName = "Cli_cidade";
            this.clicidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.clicidadeDataGridViewTextBoxColumn.Name = "clicidadeDataGridViewTextBoxColumn";
            this.clicidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliendDataGridViewTextBoxColumn
            // 
            this.cliendDataGridViewTextBoxColumn.DataPropertyName = "cli_end";
            this.cliendDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.cliendDataGridViewTextBoxColumn.Name = "cliendDataGridViewTextBoxColumn";
            this.cliendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliemailDataGridViewTextBoxColumn
            // 
            this.cliemailDataGridViewTextBoxColumn.DataPropertyName = "cli_email";
            this.cliemailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cliemailDataGridViewTextBoxColumn.Name = "cliemailDataGridViewTextBoxColumn";
            this.cliemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clitelDataGridViewTextBoxColumn
            // 
            this.clitelDataGridViewTextBoxColumn.DataPropertyName = "cli_tel";
            this.clitelDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.clitelDataGridViewTextBoxColumn.Name = "clitelDataGridViewTextBoxColumn";
            this.clitelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pesquisa_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Cliente";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clicpfDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PadariaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clisexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clirgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clibairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitelDataGridViewTextBoxColumn;
       // private PadariaDataSet padariaDataSet;
        //private PadariaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clicdDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clisexoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clirgDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clicepDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clibairroDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clinmDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clicpfDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clicidadeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cliendDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cliemailDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clitelDataGridViewTextBoxColumn;
    }
}