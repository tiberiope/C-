
namespace WindowsFormsApp1
{
    partial class Form_CheckBoxFilho
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
            this.cb_bicicleta = new System.Windows.Forms.CheckBox();
            this.cb_moto = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_bicicleta
            // 
            this.cb_bicicleta.AutoSize = true;
            this.cb_bicicleta.Location = new System.Drawing.Point(14, 90);
            this.cb_bicicleta.Name = "cb_bicicleta";
            this.cb_bicicleta.Size = new System.Drawing.Size(66, 17);
            this.cb_bicicleta.TabIndex = 10;
            this.cb_bicicleta.Text = "Bicicleta";
            this.cb_bicicleta.UseVisualStyleBackColor = true;
            this.cb_bicicleta.CheckedChanged += new System.EventHandler(this.cb_bicicleta_CheckedChanged);
            // 
            // cb_moto
            // 
            this.cb_moto.AutoSize = true;
            this.cb_moto.Location = new System.Drawing.Point(14, 66);
            this.cb_moto.Name = "cb_moto";
            this.cb_moto.Size = new System.Drawing.Size(50, 17);
            this.cb_moto.TabIndex = 9;
            this.cb_moto.Text = "Moto";
            this.cb_moto.UseVisualStyleBackColor = true;
            this.cb_moto.CheckedChanged += new System.EventHandler(this.cb_moto_CheckedChanged);
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(14, 42);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 8;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            this.cb_aviao.CheckedChanged += new System.EventHandler(this.cb_aviao_CheckedChanged);
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(14, 18);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 7;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            this.cb_carro.CheckedChanged += new System.EventHandler(this.cb_carro_CheckedChanged);
            // 
            // Form_CheckBoxFilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 200);
            this.Controls.Add(this.cb_bicicleta);
            this.Controls.Add(this.cb_moto);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.Name = "Form_CheckBoxFilho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox Filho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_bicicleta;
        private System.Windows.Forms.CheckBox cb_moto;
        private System.Windows.Forms.CheckBox cb_aviao;
        private System.Windows.Forms.CheckBox cb_carro;
    }
}