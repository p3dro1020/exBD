namespace exBD
{
    partial class Form_AddContato
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
            label1 = new Label();
            txt_nome = new TextBox();
            label2 = new Label();
            txt_num = new MaskedTextBox();
            bt_adicionar = new Button();
            bt_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(67, 24);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 27);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            // 
            // txt_num
            // 
            txt_num.Location = new Point(257, 24);
            txt_num.Mask = "(99) 99999-9999";
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(118, 23);
            txt_num.TabIndex = 3;
            // 
            // bt_adicionar
            // 
            bt_adicionar.Location = new Point(101, 77);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(75, 23);
            bt_adicionar.TabIndex = 4;
            bt_adicionar.Text = "Adicionar";
            bt_adicionar.UseVisualStyleBackColor = true;
            bt_adicionar.Click += bt_adicionar_Click;
            // 
            // bt_voltar
            // 
            bt_voltar.Location = new Point(207, 77);
            bt_voltar.Name = "bt_voltar";
            bt_voltar.Size = new Size(75, 23);
            bt_voltar.TabIndex = 5;
            bt_voltar.Text = "Voltar";
            bt_voltar.UseVisualStyleBackColor = true;
            bt_voltar.Click += bt_voltar_Click;
            // 
            // Form_AddContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 124);
            Controls.Add(bt_voltar);
            Controls.Add(bt_adicionar);
            Controls.Add(txt_num);
            Controls.Add(label2);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Name = "Form_AddContato";
            Text = "Form_AddContato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nome;
        private Label label2;
        private MaskedTextBox txt_num;
        private Button bt_adicionar;
        private Button bt_voltar;
    }
}