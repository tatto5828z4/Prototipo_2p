namespace CapaVista
{
    partial class Linea
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
            this.txtCodLinea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreLinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstatusLinea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.dgvLinea = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodLinea
            // 
            this.txtCodLinea.BackColor = System.Drawing.Color.PeachPuff;
            this.txtCodLinea.Location = new System.Drawing.Point(57, 109);
            this.txtCodLinea.Name = "txtCodLinea";
            this.txtCodLinea.Size = new System.Drawing.Size(100, 20);
            this.txtCodLinea.TabIndex = 0;
            this.txtCodLinea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCodLinea_MouseClick);
            this.txtCodLinea.TextChanged += new System.EventHandler(this.txtCodLinea_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Linea";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreLinea
            // 
            this.txtNombreLinea.BackColor = System.Drawing.Color.PeachPuff;
            this.txtNombreLinea.Location = new System.Drawing.Point(57, 165);
            this.txtNombreLinea.Name = "txtNombreLinea";
            this.txtNombreLinea.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLinea.TabIndex = 2;
            this.txtNombreLinea.TextChanged += new System.EventHandler(this.txtNombreLinea_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Linea";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estatus Linea";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEstatusLinea
            // 
            this.txtEstatusLinea.BackColor = System.Drawing.Color.PeachPuff;
            this.txtEstatusLinea.Location = new System.Drawing.Point(57, 224);
            this.txtEstatusLinea.Name = "txtEstatusLinea";
            this.txtEstatusLinea.Size = new System.Drawing.Size(100, 20);
            this.txtEstatusLinea.TabIndex = 5;
            this.txtEstatusLinea.TextChanged += new System.EventHandler(this.txtEstatusLinea_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mantenimiento Linea";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(266, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(389, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // btnbaja
            // 
            this.btnbaja.BackColor = System.Drawing.Color.SandyBrown;
            this.btnbaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaja.Location = new System.Drawing.Point(506, 315);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(75, 23);
            this.btnbaja.TabIndex = 9;
            this.btnbaja.Text = "Dar de baja";
            this.btnbaja.UseVisualStyleBackColor = false;
            this.btnbaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvLinea
            // 
            this.dgvLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinea.Location = new System.Drawing.Point(288, 109);
            this.dgvLinea.Name = "dgvLinea";
            this.dgvLinea.Size = new System.Drawing.Size(272, 150);
            this.dgvLinea.TabIndex = 10;
            this.dgvLinea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinea_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(763, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnLlenar
            // 
            this.btnLlenar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlenar.Location = new System.Drawing.Point(566, 165);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(92, 23);
            this.btnLlenar.TabIndex = 24;
            this.btnLlenar.Text = "Llenar Campos";
            this.btnLlenar.UseVisualStyleBackColor = false;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Location = new System.Drawing.Point(511, 315);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 25;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // Linea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLinea);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstatusLinea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreLinea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Linea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linea";
            this.Load += new System.EventHandler(this.Linea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstatusLinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.DataGridView dgvLinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnActivar;
    }
}