namespace exBD
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_contatos = new DataGridView();
            label1 = new Label();
            txt_nome = new TextBox();
            label2 = new Label();
            txt_num = new MaskedTextBox();
            bt_add = new Button();
            bt_remover = new Button();
            bt_salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).BeginInit();
            SuspendLayout();
            // 
            // dgv_contatos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_contatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contatos.EnableHeadersVisualStyles = false;
            dgv_contatos.Location = new Point(53, 49);
            dgv_contatos.MultiSelect = false;
            dgv_contatos.Name = "dgv_contatos";
            dgv_contatos.RowHeadersVisible = false;
            dgv_contatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_contatos.Size = new Size(362, 264);
            dgv_contatos.TabIndex = 0;
            dgv_contatos.SelectionChanged += dgv_contatos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 346);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome contato:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(137, 343);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 346);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Número:";
            // 
            // txt_num
            // 
            txt_num.Location = new Point(315, 343);
            txt_num.Mask = "(99) 99999-9999";
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(100, 23);
            txt_num.TabIndex = 5;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(53, 407);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 6;
            bt_add.Text = "Adicionar";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_remover
            // 
            bt_remover.Location = new Point(194, 407);
            bt_remover.Name = "bt_remover";
            bt_remover.Size = new Size(75, 23);
            bt_remover.TabIndex = 7;
            bt_remover.Text = "Remover";
            bt_remover.UseVisualStyleBackColor = true;
            bt_remover.Click += bt_remover_Click;
            // 
            // bt_salvar
            // 
            bt_salvar.Location = new Point(340, 407);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(75, 23);
            bt_salvar.TabIndex = 8;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 505);
            Controls.Add(bt_salvar);
            Controls.Add(bt_remover);
            Controls.Add(bt_add);
            Controls.Add(txt_num);
            Controls.Add(label2);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Controls.Add(dgv_contatos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_contatos;
        private Label label1;
        private TextBox txt_nome;
        private Label label2;
        private MaskedTextBox txt_num;
        private Button bt_add;
        private Button bt_remover;
        private Button bt_salvar;
    }
}
