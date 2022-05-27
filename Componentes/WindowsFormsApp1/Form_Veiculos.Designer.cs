
namespace WindowsFormsApp1
{
    partial class Form_Veiculos
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
            this.listb_veiculo2 = new System.Windows.Forms.ListBox();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listb_veiculo2
            // 
            this.listb_veiculo2.FormattingEnabled = true;
            this.listb_veiculo2.Location = new System.Drawing.Point(12, 12);
            this.listb_veiculo2.Name = "listb_veiculo2";
            this.listb_veiculo2.Size = new System.Drawing.Size(224, 160);
            this.listb_veiculo2.TabIndex = 0;
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(261, 12);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(100, 20);
            this.tb_veiculo.TabIndex = 1;
            // 
            // Form_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 249);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.listb_veiculo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listb_veiculo2;
        private System.Windows.Forms.TextBox tb_veiculo;
    }
}