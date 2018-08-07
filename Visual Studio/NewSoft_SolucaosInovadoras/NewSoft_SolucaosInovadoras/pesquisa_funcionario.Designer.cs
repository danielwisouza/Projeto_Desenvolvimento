namespace NewSoft_SolucaosInovadoras
{
    partial class pesquisa_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisa_funcionario));
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.funcionariosTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.funcionariosTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.funccdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcsexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcbairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcsenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funccargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcObsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.Button5.Location = new System.Drawing.Point(650, 379);
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
            this.Button4.Location = new System.Drawing.Point(650, 337);
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
            this.Button3.Location = new System.Drawing.Point(650, 300);
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
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funccdDataGridViewTextBoxColumn,
            this.funcnomeDataGridViewTextBoxColumn,
            this.funcsexoDataGridViewTextBoxColumn,
            this.funccpfDataGridViewTextBoxColumn,
            this.funcrgDataGridViewTextBoxColumn,
            this.funcendDataGridViewTextBoxColumn,
            this.funcbairroDataGridViewTextBoxColumn,
            this.funccepDataGridViewTextBoxColumn,
            this.funccidDataGridViewTextBoxColumn,
            this.functelDataGridViewTextBoxColumn,
            this.funcemailDataGridViewTextBoxColumn,
            this.funcloginDataGridViewTextBoxColumn,
            this.funcsenhaDataGridViewTextBoxColumn,
            this.funccargoDataGridViewTextBoxColumn,
            this.funcObsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 305);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.padariaDataSet;
            // 
            // padariaDataSet
            // 
            this.padariaDataSet.DataSetName = "PadariaDataSet";
            this.padariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.AccessibleDescription = "";
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(650, 261);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // funccdDataGridViewTextBoxColumn
            // 
            this.funccdDataGridViewTextBoxColumn.DataPropertyName = "func_cd";
            this.funccdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.funccdDataGridViewTextBoxColumn.Name = "funccdDataGridViewTextBoxColumn";
            this.funccdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcnomeDataGridViewTextBoxColumn
            // 
            this.funcnomeDataGridViewTextBoxColumn.DataPropertyName = "func_nome";
            this.funcnomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.funcnomeDataGridViewTextBoxColumn.Name = "funcnomeDataGridViewTextBoxColumn";
            this.funcnomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcsexoDataGridViewTextBoxColumn
            // 
            this.funcsexoDataGridViewTextBoxColumn.DataPropertyName = "func_sexo";
            this.funcsexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.funcsexoDataGridViewTextBoxColumn.Name = "funcsexoDataGridViewTextBoxColumn";
            this.funcsexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funccpfDataGridViewTextBoxColumn
            // 
            this.funccpfDataGridViewTextBoxColumn.DataPropertyName = "func_cpf";
            this.funccpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.funccpfDataGridViewTextBoxColumn.Name = "funccpfDataGridViewTextBoxColumn";
            this.funccpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcrgDataGridViewTextBoxColumn
            // 
            this.funcrgDataGridViewTextBoxColumn.DataPropertyName = "func_rg";
            this.funcrgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.funcrgDataGridViewTextBoxColumn.Name = "funcrgDataGridViewTextBoxColumn";
            this.funcrgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcendDataGridViewTextBoxColumn
            // 
            this.funcendDataGridViewTextBoxColumn.DataPropertyName = "func_end";
            this.funcendDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.funcendDataGridViewTextBoxColumn.Name = "funcendDataGridViewTextBoxColumn";
            this.funcendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcbairroDataGridViewTextBoxColumn
            // 
            this.funcbairroDataGridViewTextBoxColumn.DataPropertyName = "func_bairro";
            this.funcbairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.funcbairroDataGridViewTextBoxColumn.Name = "funcbairroDataGridViewTextBoxColumn";
            this.funcbairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funccepDataGridViewTextBoxColumn
            // 
            this.funccepDataGridViewTextBoxColumn.DataPropertyName = "func_cep";
            this.funccepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.funccepDataGridViewTextBoxColumn.Name = "funccepDataGridViewTextBoxColumn";
            this.funccepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funccidDataGridViewTextBoxColumn
            // 
            this.funccidDataGridViewTextBoxColumn.DataPropertyName = "func_cid";
            this.funccidDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.funccidDataGridViewTextBoxColumn.Name = "funccidDataGridViewTextBoxColumn";
            this.funccidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // functelDataGridViewTextBoxColumn
            // 
            this.functelDataGridViewTextBoxColumn.DataPropertyName = "func_tel";
            this.functelDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.functelDataGridViewTextBoxColumn.Name = "functelDataGridViewTextBoxColumn";
            this.functelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcemailDataGridViewTextBoxColumn
            // 
            this.funcemailDataGridViewTextBoxColumn.DataPropertyName = "func_email";
            this.funcemailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.funcemailDataGridViewTextBoxColumn.Name = "funcemailDataGridViewTextBoxColumn";
            this.funcemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcloginDataGridViewTextBoxColumn
            // 
            this.funcloginDataGridViewTextBoxColumn.DataPropertyName = "func_login";
            this.funcloginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.funcloginDataGridViewTextBoxColumn.Name = "funcloginDataGridViewTextBoxColumn";
            this.funcloginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcsenhaDataGridViewTextBoxColumn
            // 
            this.funcsenhaDataGridViewTextBoxColumn.DataPropertyName = "func_senha";
            this.funcsenhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.funcsenhaDataGridViewTextBoxColumn.Name = "funcsenhaDataGridViewTextBoxColumn";
            this.funcsenhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funccargoDataGridViewTextBoxColumn
            // 
            this.funccargoDataGridViewTextBoxColumn.DataPropertyName = "func_cargo";
            this.funccargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.funccargoDataGridViewTextBoxColumn.Name = "funccargoDataGridViewTextBoxColumn";
            this.funccargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcObsDataGridViewTextBoxColumn
            // 
            this.funcObsDataGridViewTextBoxColumn.DataPropertyName = "func_Obs";
            this.funcObsDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.funcObsDataGridViewTextBoxColumn.Name = "funcObsDataGridViewTextBoxColumn";
            this.funcObsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesquisa_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisa_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Funcionario";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private PadariaDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        internal System.Windows.Forms.Button button6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcsobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcsexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcbairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcsenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcObsDataGridViewTextBoxColumn;
       // private PadariaDataSet padariaDataSet;
        //private PadariaDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funccdDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcnomeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcsobrenomeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcsexoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funccpfDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcrgDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcendDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcbairroDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funccepDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funccidDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn functelDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn funcemailDataGridViewTextBoxColumn;
    }
}