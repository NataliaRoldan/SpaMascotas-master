namespace SpaMascotas
{
    partial class SpaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameMascot = new System.Windows.Forms.TextBox();
            this.textNameOwner = new System.Windows.Forms.TextBox();
            this.Service2 = new System.Windows.Forms.RadioButton();
            this.Service1 = new System.Windows.Forms.RadioButton();
            this.Service3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.StateShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del propietario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Mascota";
            // 
            // textNameMascot
            // 
            this.textNameMascot.Location = new System.Drawing.Point(294, 48);
            this.textNameMascot.Name = "textNameMascot";
            this.textNameMascot.PlaceholderText = "Ingrese el nombre";
            this.textNameMascot.Size = new System.Drawing.Size(131, 23);
            this.textNameMascot.TabIndex = 3;
            // 
            // textNameOwner
            // 
            this.textNameOwner.BackColor = System.Drawing.SystemColors.Window;
            this.textNameOwner.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textNameOwner.Location = new System.Drawing.Point(100, 48);
            this.textNameOwner.Name = "textNameOwner";
            this.textNameOwner.PlaceholderText = "Ingrese el nombre";
            this.textNameOwner.Size = new System.Drawing.Size(131, 23);
            this.textNameOwner.TabIndex = 4;
            this.textNameOwner.UseWaitCursor = true;
            // 
            // Service2
            // 
            this.Service2.AutoSize = true;
            this.Service2.Location = new System.Drawing.Point(6, 47);
            this.Service2.Name = "Service2";
            this.Service2.Size = new System.Drawing.Size(213, 19);
            this.Service2.TabIndex = 6;
            this.Service2.TabStop = true;
            this.Service2.Text = "Baño, corte y vacuna antigarrapatas";
            this.Service2.UseVisualStyleBackColor = true;
            // 
            // Service1
            // 
            this.Service1.AutoSize = true;
            this.Service1.Location = new System.Drawing.Point(6, 22);
            this.Service1.Name = "Service1";
            this.Service1.Size = new System.Drawing.Size(91, 19);
            this.Service1.TabIndex = 9;
            this.Service1.TabStop = true;
            this.Service1.Text = "Baño y corte";
            this.Service1.UseVisualStyleBackColor = true;
            // 
            // Service3
            // 
            this.Service3.AutoSize = true;
            this.Service3.Location = new System.Drawing.Point(6, 72);
            this.Service3.Name = "Service3";
            this.Service3.Size = new System.Drawing.Size(293, 19);
            this.Service3.TabIndex = 10;
            this.Service3.TabStop = true;
            this.Service3.Text = "Baño, corte, Vacunas antigarrapatas y Antiparásitos";
            this.Service3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Service1);
            this.groupBox1.Controls.Add(this.Service2);
            this.groupBox1.Controls.Add(this.Service3);
            this.groupBox1.Location = new System.Drawing.Point(100, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios Disponibles";
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1 - 2",
            "3 - 4",
            "5 - 6"});
            this.cmbEstrato.Location = new System.Drawing.Point(100, 227);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(121, 23);
            this.cmbEstrato.TabIndex = 10;
            this.cmbEstrato.Text = "Estrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Identificacion";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(488, 48);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.PlaceholderText = "Ingrese identificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(129, 23);
            this.textIdentificacion.TabIndex = 21;
            // 
            // StateShow
            // 
            this.StateShow.Enabled = false;
            this.StateShow.Location = new System.Drawing.Point(218, 281);
            this.StateShow.Name = "StateShow";
            this.StateShow.Size = new System.Drawing.Size(75, 23);
            this.StateShow.TabIndex = 22;
            this.StateShow.Text = "Mostrar";
            this.StateShow.UseVisualStyleBackColor = true;
            this.StateShow.Click += new System.EventHandler(this.StateShow_Click);
            // 
            // SpaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StateShow);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNameOwner);
            this.Controls.Add(this.textNameMascot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SpaForm";
            this.Text = "Servicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textNameMascot;
        private RadioButton Service2;
        private RadioButton Service1;
        private RadioButton Service3;
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox cmbEstrato;
        private Label label2;
        private TextBox textIdentificacion;
        private Button StateShow;
        public TextBox textNameOwner;
    }
}