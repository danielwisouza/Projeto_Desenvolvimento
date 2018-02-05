namespace NewSoft_SolucaosInovadoras
{
    partial class Cadastro_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_produto));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.produtoTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.fornecedorTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.fornecedorTableAdapter();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.comboBox1);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(304, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(431, 188);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cadastro de Produtos";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prod_fornecedor", true));
            this.comboBox1.DataSource = this.fornecedorBindingSource;
            this.comboBox1.DisplayMember = "forn_nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 26);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
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
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.padariaDataSet;
            // 
            // TextBox4
            // 
            this.TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prod_quanti", true));
            this.TextBox4.Location = new System.Drawing.Point(100, 140);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(296, 24);
            this.TextBox4.TabIndex = 2;
            this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.TextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // TextBox2
            // 
            this.TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prod_nm", true));
            this.TextBox2.Location = new System.Drawing.Point(65, 70);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(296, 24);
            this.TextBox2.TabIndex = 0;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Prod_cd", true));
            this.TextBox1.Location = new System.Drawing.Point(65, 35);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(131, 24);
            this.TextBox1.TabIndex = 4;
            this.TextBox1.TabStop = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(5, 140);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(93, 18);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Quantidade:*";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 18);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Fornecedor:*";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(5, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 18);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nome:*";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(5, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Código";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(195, 370);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(88, 33);
            this.Button2.TabIndex = 12;
            this.Button2.TabStop = false;
            this.Button2.Text = "Limpar";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.Control;
            this.Button1.Location = new System.Drawing.Point(38, 370);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 33);
            this.Button1.TabIndex = 11;
            this.Button1.TabStop = false;
            this.Button1.Text = "Cadastrar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox5
            // 
            this.TextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prod_descri", true));
            this.TextBox5.Location = new System.Drawing.Point(59, 23);
            this.TextBox5.Multiline = true;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(615, 107);
            this.TextBox5.TabIndex = 0;
            this.TextBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            this.TextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox5_KeyPress);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(26, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(255, 169);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 8;
            this.PictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(611, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 33);
            this.button4.TabIndex = 14;
            this.button4.TabStop = false;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(340, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 15;
            this.button3.TabStop = false;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 149);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descrição:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(482, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 33);
            this.button5.TabIndex = 37;
            this.button5.TabStop = false;
            this.button5.Text = "Ajuda";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // Cadastro_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button button4;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private PadariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private PadariaDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        // private PadariaDataSet padariaDataSet;
     //   private PadariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        //private PadariaDataSet padariaDataSet1;
        //private PadariaDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        //private PadariaDataSet padariaDataSet;
        //private PadariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
    }
}