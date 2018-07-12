namespace ExemploBancoDados01
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbCores = new System.Windows.Forms.RichTextBox();
            this.lblCores = new System.Windows.Forms.Label();
            this.Atualizar = new System.Windows.Forms.Button();
            this.cbxApagar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(38, 49);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbCores
            // 
            this.rtbCores.Location = new System.Drawing.Point(16, 129);
            this.rtbCores.Name = "rtbCores";
            this.rtbCores.Size = new System.Drawing.Size(330, 342);
            this.rtbCores.TabIndex = 3;
            this.rtbCores.Text = "";
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(13, 108);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(49, 18);
            this.lblCores.TabIndex = 4;
            this.lblCores.Text = "Cores";
            this.lblCores.Click += new System.EventHandler(this.lblCores_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(260, 99);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(86, 27);
            this.Atualizar.TabIndex = 5;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // cbxApagar
            // 
            this.cbxApagar.FormattingEnabled = true;
            this.cbxApagar.Location = new System.Drawing.Point(351, 129);
            this.cbxApagar.Name = "cbxApagar";
            this.cbxApagar.Size = new System.Drawing.Size(237, 26);
            this.cbxApagar.TabIndex = 6;
            this.cbxApagar.DropDown += new System.EventHandler(this.cbxApagar_DropDown);
            this.cbxApagar.SelectedIndexChanged += new System.EventHandler(this.cbxApagar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(514, 97);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(74, 30);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(351, 198);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(185, 24);
            this.txtNovoNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Novo Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(542, 198);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(72, 34);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 512);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxApagar);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.lblCores);
            this.Controls.Add(this.rtbCores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbCores;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.ComboBox cbxApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterar;
    }
}

