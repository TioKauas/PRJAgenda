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
            this.lblDataF = new System.Windows.Forms.Label();
            this.lblDataI = new System.Windows.Forms.Label();
            this.dateDataInicialS = new System.Windows.Forms.DateTimePicker();
            this.dateDataFinalS = new System.Windows.Forms.DateTimePicker();
            this.txtTituloS = new System.Windows.Forms.TextBox();
            this.txtDescricaoS = new System.Windows.Forms.TextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.BoxVazio = new System.Windows.Forms.GroupBox();
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
            this.boxTarefa.Controls.Add(this.dateDataInicialS);
            this.boxTarefa.Controls.Add(this.dateDataFinalS);
            this.boxTarefa.Controls.Add(this.txtTituloS);
            this.boxTarefa.Controls.Add(this.txtDescricaoS);
            this.boxTarefa.Location = new System.Drawing.Point(12, 52);
            this.boxTarefa.Name = "boxTarefa";
            this.boxTarefa.Size = new System.Drawing.Size(776, 121);
            this.boxTarefa.TabIndex = 3;
            this.boxTarefa.TabStop = false;
            this.boxTarefa.Text = "Tarefa";
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
            // lblDataI
            // 
            this.lblDataI.AutoSize = true;
            this.lblDataI.Location = new System.Drawing.Point(429, 31);
            this.lblDataI.Name = "lblDataI";
            this.lblDataI.Size = new System.Drawing.Size(59, 13);
            this.lblDataI.TabIndex = 4;
            this.lblDataI.Text = "Data inicial";
            // 
            // dateDataInicialS
            // 
            this.dateDataInicialS.Enabled = false;
            this.dateDataInicialS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicialS.Location = new System.Drawing.Point(494, 28);
            this.dateDataInicialS.Name = "dateDataInicialS";
            this.dateDataInicialS.Size = new System.Drawing.Size(99, 20);
            this.dateDataInicialS.TabIndex = 3;
            // 
            // dateDataFinalS
            // 
            this.dateDataFinalS.Enabled = false;
            this.dateDataFinalS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinalS.Location = new System.Drawing.Point(671, 28);
            this.dateDataFinalS.Name = "dateDataFinalS";
            this.dateDataFinalS.Size = new System.Drawing.Size(99, 20);
            this.dateDataFinalS.TabIndex = 2;
            // 
            // txtTituloS
            // 
            this.txtTituloS.Enabled = false;
            this.txtTituloS.Location = new System.Drawing.Point(15, 28);
            this.txtTituloS.Name = "txtTituloS";
            this.txtTituloS.Size = new System.Drawing.Size(235, 20);
            this.txtTituloS.TabIndex = 1;
            // 
            // txtDescricaoS
            // 
            this.txtDescricaoS.Enabled = false;
            this.txtDescricaoS.Location = new System.Drawing.Point(6, 54);
            this.txtDescricaoS.Multiline = true;
            this.txtDescricaoS.Name = "txtDescricaoS";
            this.txtDescricaoS.Size = new System.Drawing.Size(764, 61);
            this.txtDescricaoS.TabIndex = 0;
            // 
            // lblTexto1
            // 
            this.lblTexto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(269, 198);
            this.lblTexto1.Margin = new System.Windows.Forms.Padding(0);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(245, 13);
            this.lblTexto1.TabIndex = 6;
            this.lblTexto1.Text = "Puxa, parece que você não tem nenhuma tarefa :(";
            // 
            // lblTexto2
            // 
            this.lblTexto2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(336, 211);
            this.lblTexto2.Margin = new System.Windows.Forms.Padding(0);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(110, 13);
            this.lblTexto2.TabIndex = 6;
            this.lblTexto2.Text = "Vamos criar algumas?";
            // 
            // BoxVazio
            // 
            this.BoxVazio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxVazio.Location = new System.Drawing.Point(262, 179);
            this.BoxVazio.Name = "BoxVazio";
            this.BoxVazio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxVazio.Size = new System.Drawing.Size(257, 60);
            this.BoxVazio.TabIndex = 7;
            this.BoxVazio.TabStop = false;
            this.BoxVazio.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.boxTarefa);
            this.Controls.Add(this.btnExcTarefa);
            this.Controls.Add(this.btnCopTarefa);
            this.Controls.Add(this.btnCriarTarefa);
            this.Controls.Add(this.BoxVazio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxTarefa.ResumeLayout(false);
            this.boxTarefa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.Button btnCopTarefa;
        private System.Windows.Forms.Button btnExcTarefa;
        private System.Windows.Forms.GroupBox boxTarefa;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.Label lblDataI;
        private System.Windows.Forms.DateTimePicker dateDataInicialS;
        private System.Windows.Forms.DateTimePicker dateDataFinalS;
        private System.Windows.Forms.TextBox txtTituloS;
        private System.Windows.Forms.TextBox txtDescricaoS;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.GroupBox BoxVazio;
    }
}

