
namespace Lab04
{
    partial class frmConDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbasedatos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkautenticacion = new System.Windows.Forms.CheckBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.btnestado = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.btnpersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtservidor
            // 
            this.txtservidor.Location = new System.Drawing.Point(50, 55);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(308, 20);
            this.txtservidor.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(399, 55);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(313, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtbasedatos
            // 
            this.txtbasedatos.Location = new System.Drawing.Point(50, 128);
            this.txtbasedatos.Name = "txtbasedatos";
            this.txtbasedatos.Size = new System.Drawing.Size(308, 20);
            this.txtbasedatos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base de Datos";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(399, 128);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(313, 20);
            this.txtcontraseña.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // chkautenticacion
            // 
            this.chkautenticacion.AutoSize = true;
            this.chkautenticacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkautenticacion.Location = new System.Drawing.Point(50, 205);
            this.chkautenticacion.Name = "chkautenticacion";
            this.chkautenticacion.Size = new System.Drawing.Size(193, 25);
            this.chkautenticacion.TabIndex = 8;
            this.chkautenticacion.Text = "Autenticación integrada";
            this.chkautenticacion.UseVisualStyleBackColor = true;
            this.chkautenticacion.CheckedChanged += new System.EventHandler(this.chkautenticacion_CheckedChanged);
            // 
            // btnconectar
            // 
            this.btnconectar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconectar.Location = new System.Drawing.Point(112, 254);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(131, 33);
            this.btnconectar.TabIndex = 9;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btnestado
            // 
            this.btnestado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestado.Location = new System.Drawing.Point(274, 254);
            this.btnestado.Name = "btnestado";
            this.btnestado.Size = new System.Drawing.Size(116, 33);
            this.btnestado.TabIndex = 10;
            this.btnestado.Text = "Estado";
            this.btnestado.UseVisualStyleBackColor = true;
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // btndesconectar
            // 
            this.btndesconectar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesconectar.Location = new System.Drawing.Point(416, 254);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(104, 33);
            this.btndesconectar.TabIndex = 11;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // btnpersona
            // 
            this.btnpersona.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpersona.Location = new System.Drawing.Point(131, 328);
            this.btnpersona.Name = "btnpersona";
            this.btnpersona.Size = new System.Drawing.Size(88, 30);
            this.btnpersona.TabIndex = 12;
            this.btnpersona.Text = "Persona";
            this.btnpersona.UseVisualStyleBackColor = true;
            this.btnpersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.btnpersona);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnestado);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.chkautenticacion);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbasedatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.label1);
            this.Name = "frmConDB";
            this.Text = "Conexión a un origen de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbasedatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkautenticacion;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btnestado;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Button btnpersona;
    }
}

