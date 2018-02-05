namespace NewSoft_SolucaosInovadoras
{
    partial class estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estoque));
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padariaDataSet = new NewSoft_SolucaosInovadoras.PadariaDataSet();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.estoqueTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.estoqueTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.produtoTableAdapter = new NewSoft_SolucaosInovadoras.PadariaDataSetTableAdapters.produtoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.Control;
            this.Button3.Location = new System.Drawing.Point(538, 412);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 33);
            this.Button3.TabIndex = 24;
            this.Button3.TabStop = false;
            this.Button3.Text = "Sair";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(278, 412);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(88, 33);
            this.Button2.TabIndex = 23;
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
            this.Button1.Location = new System.Drawing.Point(148, 412);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 33);
            this.Button1.TabIndex = 22;
            this.Button1.TabStop = false;
            this.Button1.Text = "Cadastrar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(30, 30);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(242, 174);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.comboBox1);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(287, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(448, 215);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Estoque";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "estoq_produ", true));
            this.comboBox1.DataSource = this.produtoBindingSource;
            this.comboBox1.DisplayMember = "prod_nm";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 26);
            this.comboBox1.TabIndex = 7;
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
            // TextBox1
            // 
            this.TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "estoq_cd", true));
            this.TextBox1.Location = new System.Drawing.Point(91, 35);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(181, 24);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.TabStop = false;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            this.estoqueBindingSource.DataSource = this.padariaDataSet;
            // 
            // TextBox4
            // 
            this.TextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "estoq_quanti", true));
            this.TextBox4.Location = new System.Drawing.Point(115, 145);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(180, 24);
            this.TextBox4.TabIndex = 5;
            this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.TextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(21, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Codígo:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(20, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(93, 18);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Quantidade:*";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(20, 95);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 18);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nome:*";
            // 
            // TextBox3
            // 
            this.TextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "estoq_descri", true));
            this.TextBox3.Location = new System.Drawing.Point(67, 31);
            this.TextBox3.Multiline = true;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(620, 95);
            this.TextBox3.TabIndex = 20;
            this.TextBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.TextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(408, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 33);
            this.button4.TabIndex = 27;
            this.button4.TabStop = false;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 138);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descrição:*";
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frn8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox3;
        private PadariaDataSet padariaDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private PadariaDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private PadariaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
    }
}