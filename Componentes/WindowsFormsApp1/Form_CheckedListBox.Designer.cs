
namespace WindowsFormsApp1
{
    partial class Form_CheckedListBox
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
            this.clb_transp = new System.Windows.Forms.CheckedListBox();
            this.btn_transp_clb = new System.Windows.Forms.Button();
            this.btn_transp_limpar_lista = new System.Windows.Forms.Button();
            this.btn_transp_resetar_lista = new System.Windows.Forms.Button();
            this.btn_transp_adicionar = new System.Windows.Forms.Button();
            this.tb_transp = new System.Windows.Forms.TextBox();
            this.lb_transp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transp
            // 
            this.clb_transp.FormattingEnabled = true;
            this.clb_transp.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trêm"});
            this.clb_transp.Location = new System.Drawing.Point(12, 12);
            this.clb_transp.Name = "clb_transp";
            this.clb_transp.Size = new System.Drawing.Size(120, 169);
            this.clb_transp.TabIndex = 0;
            // 
            // btn_transp_clb
            // 
            this.btn_transp_clb.Location = new System.Drawing.Point(159, 12);
            this.btn_transp_clb.Name = "btn_transp_clb";
            this.btn_transp_clb.Size = new System.Drawing.Size(225, 23);
            this.btn_transp_clb.TabIndex = 1;
            this.btn_transp_clb.Text = "Mostrar Selecionados";
            this.btn_transp_clb.UseVisualStyleBackColor = true;
            this.btn_transp_clb.Click += new System.EventHandler(this.btn_transp_clb_Click);
            // 
            // btn_transp_limpar_lista
            // 
            this.btn_transp_limpar_lista.Location = new System.Drawing.Point(159, 41);
            this.btn_transp_limpar_lista.Name = "btn_transp_limpar_lista";
            this.btn_transp_limpar_lista.Size = new System.Drawing.Size(225, 23);
            this.btn_transp_limpar_lista.TabIndex = 2;
            this.btn_transp_limpar_lista.Text = "Limpar";
            this.btn_transp_limpar_lista.UseVisualStyleBackColor = true;
            this.btn_transp_limpar_lista.Click += new System.EventHandler(this.btn_transp_limpar_lista_Click);
            // 
            // btn_transp_resetar_lista
            // 
            this.btn_transp_resetar_lista.Location = new System.Drawing.Point(159, 71);
            this.btn_transp_resetar_lista.Name = "btn_transp_resetar_lista";
            this.btn_transp_resetar_lista.Size = new System.Drawing.Size(225, 23);
            this.btn_transp_resetar_lista.TabIndex = 3;
            this.btn_transp_resetar_lista.Text = "Resetar";
            this.btn_transp_resetar_lista.UseVisualStyleBackColor = true;
            this.btn_transp_resetar_lista.Click += new System.EventHandler(this.btn_transp_resetar_lista_Click);
            // 
            // btn_transp_adicionar
            // 
            this.btn_transp_adicionar.Location = new System.Drawing.Point(159, 158);
            this.btn_transp_adicionar.Name = "btn_transp_adicionar";
            this.btn_transp_adicionar.Size = new System.Drawing.Size(225, 23);
            this.btn_transp_adicionar.TabIndex = 4;
            this.btn_transp_adicionar.Text = "Adicionar Transporte";
            this.btn_transp_adicionar.UseVisualStyleBackColor = true;
            this.btn_transp_adicionar.Click += new System.EventHandler(this.btn_transp_adicionar_Click);
            // 
            // tb_transp
            // 
            this.tb_transp.Location = new System.Drawing.Point(159, 132);
            this.tb_transp.Name = "tb_transp";
            this.tb_transp.Size = new System.Drawing.Size(225, 20);
            this.tb_transp.TabIndex = 5;
            // 
            // lb_transp
            // 
            this.lb_transp.AutoSize = true;
            this.lb_transp.Location = new System.Drawing.Point(207, 115);
            this.lb_transp.Name = "lb_transp";
            this.lb_transp.Size = new System.Drawing.Size(131, 13);
            this.lb_transp.TabIndex = 6;
            this.lb_transp.Text = "Digite um novo transporte.";
            // 
            // Form_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
            this.Controls.Add(this.lb_transp);
            this.Controls.Add(this.tb_transp);
            this.Controls.Add(this.btn_transp_adicionar);
            this.Controls.Add(this.btn_transp_resetar_lista);
            this.Controls.Add(this.btn_transp_limpar_lista);
            this.Controls.Add(this.btn_transp_clb);
            this.Controls.Add(this.clb_transp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transp;
        private System.Windows.Forms.Button btn_transp_clb;
        private System.Windows.Forms.Button btn_transp_limpar_lista;
        private System.Windows.Forms.Button btn_transp_resetar_lista;
        private System.Windows.Forms.Button btn_transp_adicionar;
        private System.Windows.Forms.TextBox tb_transp;
        private System.Windows.Forms.Label lb_transp;
    }
}