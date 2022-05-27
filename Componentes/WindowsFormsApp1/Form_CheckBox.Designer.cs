
namespace WindowsFormsApp1
{
    partial class Form_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_moto = new System.Windows.Forms.CheckBox();
            this.cb_bicicleta = new System.Windows.Forms.CheckBox();
            this.btn_transp_marcados = new System.Windows.Forms.Button();
            this.tb_transportes = new System.Windows.Forms.TextBox();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.btn_form_filho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(13, 13);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(13, 37);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_moto
            // 
            this.cb_moto.AutoSize = true;
            this.cb_moto.Location = new System.Drawing.Point(13, 61);
            this.cb_moto.Name = "cb_moto";
            this.cb_moto.Size = new System.Drawing.Size(50, 17);
            this.cb_moto.TabIndex = 2;
            this.cb_moto.Text = "Moto";
            this.cb_moto.UseVisualStyleBackColor = true;
            // 
            // cb_bicicleta
            // 
            this.cb_bicicleta.AutoSize = true;
            this.cb_bicicleta.Location = new System.Drawing.Point(13, 85);
            this.cb_bicicleta.Name = "cb_bicicleta";
            this.cb_bicicleta.Size = new System.Drawing.Size(66, 17);
            this.cb_bicicleta.TabIndex = 3;
            this.cb_bicicleta.Text = "Bicicleta";
            this.cb_bicicleta.UseVisualStyleBackColor = true;
            // 
            // btn_transp_marcados
            // 
            this.btn_transp_marcados.Location = new System.Drawing.Point(96, 7);
            this.btn_transp_marcados.Name = "btn_transp_marcados";
            this.btn_transp_marcados.Size = new System.Drawing.Size(163, 23);
            this.btn_transp_marcados.TabIndex = 4;
            this.btn_transp_marcados.Text = "Transp. Marcados";
            this.btn_transp_marcados.UseVisualStyleBackColor = true;
            this.btn_transp_marcados.Click += new System.EventHandler(this.btn_transp_marcados_Click);
            // 
            // tb_transportes
            // 
            this.tb_transportes.Location = new System.Drawing.Point(96, 37);
            this.tb_transportes.Multiline = true;
            this.tb_transportes.Name = "tb_transportes";
            this.tb_transportes.Size = new System.Drawing.Size(163, 93);
            this.tb_transportes.TabIndex = 5;
            this.tb_transportes.Visible = false;
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(12, 128);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(65, 17);
            this.cb_patinete.TabIndex = 6;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // btn_form_filho
            // 
            this.btn_form_filho.Location = new System.Drawing.Point(96, 149);
            this.btn_form_filho.Name = "btn_form_filho";
            this.btn_form_filho.Size = new System.Drawing.Size(91, 23);
            this.btn_form_filho.TabIndex = 7;
            this.btn_form_filho.Text = "Abrir Form Filho";
            this.btn_form_filho.UseVisualStyleBackColor = true;
            this.btn_form_filho.Click += new System.EventHandler(this.btn_form_filho_Click);
            // 
            // Form_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 185);
            this.Controls.Add(this.btn_form_filho);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.tb_transportes);
            this.Controls.Add(this.btn_transp_marcados);
            this.Controls.Add(this.cb_bicicleta);
            this.Controls.Add(this.cb_moto);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transp_marcados;
        private System.Windows.Forms.TextBox tb_transportes;
        private System.Windows.Forms.Button btn_form_filho;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_moto;
        public System.Windows.Forms.CheckBox cb_bicicleta;
        public System.Windows.Forms.CheckBox cb_patinete;
    }
}