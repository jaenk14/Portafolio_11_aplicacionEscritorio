
namespace ProyectoEscritorio
{
    partial class Frm_Notas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnVerResultado = new System.Windows.Forms.Button();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.btnEliminarrSeleccionado = new System.Windows.Forms.Button();
            this.txtNotaSeleccionada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNotas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDigitarLaNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.btnVerResultado);
            this.groupBox1.Controls.Add(this.btnEliminarLista);
            this.groupBox1.Controls.Add(this.btnEliminarrSeleccionado);
            this.groupBox1.Controls.Add(this.txtNotaSeleccionada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstNotas);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDigitarLaNota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Notas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(6, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 1);
            this.panel4.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 1);
            this.panel3.TabIndex = 11;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.DarkGray;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(6, 240);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(269, 54);
            this.txtResultado.TabIndex = 9;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerResultado
            // 
            this.btnVerResultado.Location = new System.Drawing.Point(175, 206);
            this.btnVerResultado.Name = "btnVerResultado";
            this.btnVerResultado.Size = new System.Drawing.Size(100, 28);
            this.btnVerResultado.TabIndex = 8;
            this.btnVerResultado.Text = "Ver Resultado";
            this.btnVerResultado.UseVisualStyleBackColor = true;
            this.btnVerResultado.Click += new System.EventHandler(this.btnVerResultado_Click);
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.Location = new System.Drawing.Point(8, 149);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(176, 30);
            this.btnEliminarLista.TabIndex = 7;
            this.btnEliminarLista.Text = "Eliminar Lista de Notas";
            this.btnEliminarLista.UseVisualStyleBackColor = true;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // btnEliminarrSeleccionado
            // 
            this.btnEliminarrSeleccionado.Location = new System.Drawing.Point(8, 113);
            this.btnEliminarrSeleccionado.Name = "btnEliminarrSeleccionado";
            this.btnEliminarrSeleccionado.Size = new System.Drawing.Size(176, 30);
            this.btnEliminarrSeleccionado.TabIndex = 6;
            this.btnEliminarrSeleccionado.Text = "Eliminar Seleccionado";
            this.btnEliminarrSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarrSeleccionado.Click += new System.EventHandler(this.btnEliminarrSeleccionado_Click);
            // 
            // txtNotaSeleccionada
            // 
            this.txtNotaSeleccionada.Enabled = false;
            this.txtNotaSeleccionada.Location = new System.Drawing.Point(175, 72);
            this.txtNotaSeleccionada.Name = "txtNotaSeleccionada";
            this.txtNotaSeleccionada.Size = new System.Drawing.Size(100, 23);
            this.txtNotaSeleccionada.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota Seleccionada:";
            // 
            // lstNotas
            // 
            this.lstNotas.FormattingEnabled = true;
            this.lstNotas.ItemHeight = 15;
            this.lstNotas.Location = new System.Drawing.Point(281, 22);
            this.lstNotas.Name = "lstNotas";
            this.lstNotas.Size = new System.Drawing.Size(168, 274);
            this.lstNotas.TabIndex = 3;
            this.lstNotas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstNotas_MouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(200, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDigitarLaNota
            // 
            this.txtDigitarLaNota.Location = new System.Drawing.Point(94, 22);
            this.txtDigitarLaNota.Name = "txtDigitarLaNota";
            this.txtDigitarLaNota.Size = new System.Drawing.Size(100, 23);
            this.txtDigitarLaNota.TabIndex = 1;
            this.txtDigitarLaNota.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDigitarLaNota_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite la nota:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(386, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Frm_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Notas";
            this.Text = "Registro de Notas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDigitarLaNota;
        private System.Windows.Forms.ListBox lstNotas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNotaSeleccionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.Button btnEliminarLista;
        private System.Windows.Forms.Button btnEliminarrSeleccionado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}