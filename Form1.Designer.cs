namespace PRJAgenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.btnCopTarefa = new System.Windows.Forms.Button();
            this.btnExcTarefa = new System.Windows.Forms.Button();
            this.boxTarefa = new System.Windows.Forms.GroupBox();
            this.txtDescricaoS = new System.Windows.Forms.TextBox();
            this.txtTituloS = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDataI = new System.Windows.Forms.Label();
            this.lblDataF = new System.Windows.Forms.Label();
            this.boxTarefa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.Location = new System.Drawing.Point(475, 19);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(93, 27);
            this.btnCriarTarefa.TabIndex = 0;
            this.btnCriarTarefa.Text = "Criar tarefa";
            this.btnCriarTarefa.UseVisualStyleBackColor = true;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            // 
            // btnCopTarefa
            // 
            this.btnCopTarefa.Location = new System.Drawing.Point(574, 19);
            this.btnCopTarefa.Name = "btnCopTarefa";
            this.btnCopTarefa.Size = new System.Drawing.Size(93, 27);
            this.btnCopTarefa.TabIndex = 1;
            this.btnCopTarefa.Text = "Duplicar tarefa";
            this.btnCopTarefa.UseVisualStyleBackColor = true;
            // 
            // btnExcTarefa
            // 
            this.btnExcTarefa.Location = new System.Drawing.Point(673, 19);
            this.btnExcTarefa.Name = "btnExcTarefa";
            this.btnExcTarefa.Size = new System.Drawing.Size(93, 27);
            this.btnExcTarefa.TabIndex = 2;
            this.btnExcTarefa.Text = "Excluir tarefa";
            this.btnExcTarefa.UseVisualStyleBackColor = true;
            // 
            // boxTarefa
            // 
            this.boxTarefa.Controls.Add(this.lblDataF);
            this.boxTarefa.Controls.Add(this.lblDataI);
            this.boxTarefa.Controls.Add(this.dateTimePicker2);
            this.boxTarefa.Controls.Add(this.dateTimePicker1);
            this.boxTarefa.Controls.Add(this.txtTituloS);
            this.boxTarefa.Controls.Add(this.txtDescricaoS);
            this.boxTarefa.Location = new System.Drawing.Point(12, 52);
            this.boxTarefa.Name = "boxTarefa";
            this.boxTarefa.Size = new System.Drawing.Size(776, 121);
            this.boxTarefa.TabIndex = 3;
            this.boxTarefa.TabStop = false;
            this.boxTarefa.Text = "Tarefa";
            // 
            // txtDescricaoS
            // 
            this.txtDescricaoS.Location = new System.Drawing.Point(6, 54);
            this.txtDescricaoS.Multiline = true;
            this.txtDescricaoS.Name = "txtDescricaoS";
            this.txtDescricaoS.Size = new System.Drawing.Size(764, 61);
            this.txtDescricaoS.TabIndex = 0;
            // 
            // txtTituloS
            // 
            this.txtTituloS.Location = new System.Drawing.Point(15, 28);
            this.txtTituloS.Name = "txtTituloS";
            this.txtTituloS.Size = new System.Drawing.Size(235, 20);
            this.txtTituloS.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(671, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(494, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // lblDataI
            // 
            this.lblDataI.AutoSize = true;
            this.lblDataI.Location = new System.Drawing.Point(429, 31);
            this.lblDataI.Name = "lblDataI";
            this.lblDataI.Size = new System.Drawing.Size(59, 13);
            this.lblDataI.TabIndex = 4;
            this.lblDataI.Text = "Data inicial";
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.Location = new System.Drawing.Point(613, 31);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(52, 13);
            this.lblDataF.TabIndex = 5;
            this.lblDataF.Text = "Data final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxTarefa);
            this.Controls.Add(this.btnExcTarefa);
            this.Controls.Add(this.btnCopTarefa);
            this.Controls.Add(this.btnCriarTarefa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxTarefa.ResumeLayout(false);
            this.boxTarefa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.Button btnCopTarefa;
        private System.Windows.Forms.Button btnExcTarefa;
        private System.Windows.Forms.GroupBox boxTarefa;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.Label lblDataI;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTituloS;
        private System.Windows.Forms.TextBox txtDescricaoS;
    }
}

