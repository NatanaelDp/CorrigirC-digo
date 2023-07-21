namespace Aula10Estacionamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFecharEstacionamento = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.txtRecebePlaca = new System.Windows.Forms.TextBox();
            this.lblDigitePlaca = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblNumeroVeiculos = new System.Windows.Forms.Label();
            this.lblVeiculos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFecharEstacionamento);
            this.groupBox1.Controls.Add(this.btnRetirar);
            this.groupBox1.Controls.Add(this.btnEstacionar);
            this.groupBox1.Controls.Add(this.txtRecebePlaca);
            this.groupBox1.Controls.Add(this.lblDigitePlaca);
            this.groupBox1.Location = new System.Drawing.Point(52, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // btnFecharEstacionamento
            // 
            this.btnFecharEstacionamento.Location = new System.Drawing.Point(19, 146);
            this.btnFecharEstacionamento.Name = "btnFecharEstacionamento";
            this.btnFecharEstacionamento.Size = new System.Drawing.Size(211, 23);
            this.btnFecharEstacionamento.TabIndex = 4;
            this.btnFecharEstacionamento.Text = "Fechar estacionamento";
            this.btnFecharEstacionamento.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(131, 96);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(99, 23);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.Location = new System.Drawing.Point(19, 96);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(91, 23);
            this.btnEstacionar.TabIndex = 2;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = true;
            this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
            // 
            // txtRecebePlaca
            // 
            this.txtRecebePlaca.Location = new System.Drawing.Point(19, 48);
            this.txtRecebePlaca.Name = "txtRecebePlaca";
            this.txtRecebePlaca.Size = new System.Drawing.Size(187, 23);
            this.txtRecebePlaca.TabIndex = 1;
            // 
            // lblDigitePlaca
            // 
            this.lblDigitePlaca.AutoSize = true;
            this.lblDigitePlaca.Location = new System.Drawing.Point(19, 30);
            this.lblDigitePlaca.Name = "lblDigitePlaca";
            this.lblDigitePlaca.Size = new System.Drawing.Size(81, 15);
            this.lblDigitePlaca.TabIndex = 0;
            this.lblDigitePlaca.Text = "Digite a placa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.lblNumeroVeiculos);
            this.groupBox2.Controls.Add(this.lblVeiculos);
            this.groupBox2.Location = new System.Drawing.Point(420, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listagem de veículos";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(36, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(134, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblNumeroVeiculos
            // 
            this.lblNumeroVeiculos.AutoSize = true;
            this.lblNumeroVeiculos.Location = new System.Drawing.Point(114, 43);
            this.lblNumeroVeiculos.Name = "lblNumeroVeiculos";
            this.lblNumeroVeiculos.Size = new System.Drawing.Size(13, 15);
            this.lblNumeroVeiculos.TabIndex = 1;
            this.lblNumeroVeiculos.Text = "0";
            // 
            // lblVeiculos
            // 
            this.lblVeiculos.AutoSize = true;
            this.lblVeiculos.Location = new System.Drawing.Point(36, 40);
            this.lblVeiculos.Name = "lblVeiculos";
            this.lblVeiculos.Size = new System.Drawing.Size(50, 15);
            this.lblVeiculos.TabIndex = 0;
            this.lblVeiculos.Text = "Veículos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFecharEstacionamento;
        private Button btnRetirar;
        private Button btnEstacionar;
        private TextBox txtRecebePlaca;
        private Label lblDigitePlaca;
        private GroupBox groupBox2;
        private ListView listView1;
        private Label lblNumeroVeiculos;
        private Label lblVeiculos;
    }
}