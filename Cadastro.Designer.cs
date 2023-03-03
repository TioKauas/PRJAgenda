namespace PRJAgenda
{
    partial class Cadastro
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
            this.lblDataF = new System.Windows.Forms.Label();
            this.lblDataI = new System.Windows.Forms.Label();
            this.dateDataI = new System.Windows.Forms.DateTimePicker();
            this.dateDataF = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnSalvarTarefa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.Location = new System.Drawing.Point(363, 48);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(52, 13);
            this.lblDataF.TabIndex = 11;
            this.lblDataF.Text = "Data final";
            // 
            // lblDataI
            // 
            this.lblDataI.AutoSize = true;
            this.lblDataI.Location = new System.Drawing.Point(363, 23);
            this.lblDataI.Name = "lblDataI";
            this.lblDataI.Size = new System.Drawing.Size(59, 13);
            this.lblDataI.TabIndex = 10;
            this.lblDataI.Text = "Data inicial";
            // 
            // dateDataI
            // 
            this.dateDataI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataI.Location = new System.Drawing.Point(428, 16);
            this.dateDataI.Name = "dateDataI";
            this.dateDataI.Size = new System.Drawing.Size(99, 20);
            this.dateDataI.TabIndex = 9;
            // 
            // dateDataF
            // 
            this.dateDataF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataF.Location = new System.Drawing.Point(428, 42);
            this.dateDataF.Name = "dateDataF";
            this.dateDataF.Size = new System.Drawing.Size(99, 20);
            this.dateDataF.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(51, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(235, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 68);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(557, 155);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 52);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(476, 229);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(93, 27);
            this.btnLimparCampos.TabIndex = 15;
            this.btnLimparCampos.Text = "Limpar campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnSalvarTarefa
            // 
            this.btnSalvarTarefa.Location = new System.Drawing.Point(377, 229);
            this.btnSalvarTarefa.Name = "btnSalvarTarefa";
            this.btnSalvarTarefa.Size = new System.Drawing.Size(93, 27);
            this.btnSalvarTarefa.TabIndex = 14;
            this.btnSalvarTarefa.Text = "Salvar tarefa";
            this.btnSalvarTarefa.UseVisualStyleBackColor = true;
            this.btnSalvarTarefa.Click += new System.EventHandler(this.btnSalvarTarefa_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 262);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnSalvarTarefa);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDataF);
            this.Controls.Add(this.lblDataI);
            this.Controls.Add(this.dateDataI);
            this.Controls.Add(this.dateDataF);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDescricao);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.Label lblDataI;
        private System.Windows.Forms.DateTimePicker dateDataI;
        private System.Windows.Forms.DateTimePicker dateDataF;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnSalvarTarefa;
    }
}