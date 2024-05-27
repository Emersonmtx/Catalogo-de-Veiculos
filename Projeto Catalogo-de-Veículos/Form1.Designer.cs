namespace Projeto_Catalogo_de_Veículos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAno = new Label();
            txtMarca = new Label();
            lblModelo = new Label();
            lblTipo = new Label();
            txtAno = new TextBox();
            textBox3 = new TextBox();
            txtModelo = new TextBox();
            cbTipo = new ComboBox();
            gbData = new GroupBox();
            dtVeiculos = new DataGridView();
            gpCadastro = new GroupBox();
            btnAtualizar = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            txtId = new TextBox();
            lblId = new Label();
            gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtVeiculos).BeginInit();
            gpCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.BackColor = SystemColors.GradientActiveCaption;
            lblAno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.ForeColor = SystemColors.ButtonHighlight;
            lblAno.Location = new Point(11, 33);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(46, 21);
            lblAno.TabIndex = 6;
            lblAno.Text = "ANO";
            lblAno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMarca
            // 
            txtMarca.AutoSize = true;
            txtMarca.BackColor = SystemColors.GradientActiveCaption;
            txtMarca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMarca.ForeColor = SystemColors.ButtonHighlight;
            txtMarca.Location = new Point(11, 126);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(67, 21);
            txtMarca.TabIndex = 7;
            txtMarca.Text = "MARCA";
            txtMarca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = SystemColors.GradientActiveCaption;
            lblModelo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelo.ForeColor = SystemColors.ButtonHighlight;
            lblModelo.Location = new Point(11, 79);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(78, 21);
            lblModelo.TabIndex = 8;
            lblModelo.Text = "MODELO";
            lblModelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.GradientActiveCaption;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.ButtonHighlight;
            lblTipo.Location = new Point(11, 179);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(46, 21);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "TIPO";
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(108, 30);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(80, 29);
            txtAno.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 29);
            textBox3.TabIndex = 12;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(108, 76);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(226, 29);
            txtModelo.TabIndex = 13;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Carro", "Moto", "Caminhão", "Utilitário" });
            cbTipo.Location = new Point(108, 176);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(180, 29);
            cbTipo.TabIndex = 14;
            // 
            // gbData
            // 
            gbData.BackColor = SystemColors.GradientActiveCaption;
            gbData.Controls.Add(dtVeiculos);
            gbData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbData.ForeColor = SystemColors.ButtonHighlight;
            gbData.Location = new Point(12, 302);
            gbData.Name = "gbData";
            gbData.Size = new Size(468, 249);
            gbData.TabIndex = 15;
            gbData.TabStop = false;
            gbData.Text = "Dados Cadastrados";
            // 
            // dtVeiculos
            // 
            dtVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtVeiculos.Location = new Point(6, 28);
            dtVeiculos.Name = "dtVeiculos";
            dtVeiculos.Size = new Size(456, 215);
            dtVeiculos.TabIndex = 0;
            // 
            // gpCadastro
            // 
            gpCadastro.BackColor = SystemColors.GradientActiveCaption;
            gpCadastro.Controls.Add(btnAtualizar);
            gpCadastro.Controls.Add(textBox3);
            gpCadastro.Controls.Add(txtAno);
            gpCadastro.Controls.Add(cbTipo);
            gpCadastro.Controls.Add(lblTipo);
            gpCadastro.Controls.Add(txtMarca);
            gpCadastro.Controls.Add(txtModelo);
            gpCadastro.Controls.Add(lblModelo);
            gpCadastro.Controls.Add(lblAno);
            gpCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gpCadastro.ForeColor = SystemColors.ButtonHighlight;
            gpCadastro.Location = new Point(18, 81);
            gpCadastro.Name = "gpCadastro";
            gpCadastro.Size = new Size(456, 215);
            gpCadastro.TabIndex = 16;
            gpCadastro.TabStop = false;
            gpCadastro.Text = "Cadastrar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(348, 16);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(98, 43);
            btnAtualizar.TabIndex = 15;
            btnAtualizar.Text = "Alterar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(389, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(201, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(213, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(63, 23);
            txtId.TabIndex = 22;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.GradientActiveCaption;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ButtonHighlight;
            lblId.Location = new Point(160, 54);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 21);
            lblId.TabIndex = 23;
            lblId.Text = "ID";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(492, 563);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(gbData);
            Controls.Add(gpCadastro);
            Name = "Form1";
            Text = "Catalogo-de-Veículos";
            Load += Form1_Load;
            gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtVeiculos).EndInit();
            gpCadastro.ResumeLayout(false);
            gpCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAno;
        private Label txtMarca;
        private Label lblModelo;
        private Label lblTipo;
        private TextBox txtAno;
        private TextBox textBox3;
        private TextBox txtModelo;
        private ComboBox cbTipo;
        private GroupBox gbData;
        private DataGridView dtVeiculos;
        private GroupBox gpCadastro;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSalvar;
        private TextBox txtId;
        private Label lblId;
        private Button btnAtualizar;
    }
}
