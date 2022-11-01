namespace RadioButton_kontrola
{
    partial class Form1
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
            this.avion = new System.Windows.Forms.RadioButton();
            this.autobus = new System.Windows.Forms.RadioButton();
            this.vlastitiPrijevoz = new System.Windows.Forms.RadioButton();
            this.rezerviraj = new System.Windows.Forms.Button();
            this.prikaz = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vlastitiPrijevoz);
            this.groupBox1.Controls.Add(this.autobus);
            this.groupBox1.Controls.Add(this.avion);
            this.groupBox1.Location = new System.Drawing.Point(60, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoda";
            // 
            // avion
            // 
            this.avion.AutoSize = true;
            this.avion.Location = new System.Drawing.Point(7, 22);
            this.avion.Name = "avion";
            this.avion.Size = new System.Drawing.Size(62, 20);
            this.avion.TabIndex = 0;
            this.avion.TabStop = true;
            this.avion.Text = "Avion";
            this.avion.UseVisualStyleBackColor = true;
            // 
            // autobus
            // 
            this.autobus.AutoSize = true;
            this.autobus.Location = new System.Drawing.Point(7, 49);
            this.autobus.Name = "autobus";
            this.autobus.Size = new System.Drawing.Size(77, 20);
            this.autobus.TabIndex = 1;
            this.autobus.TabStop = true;
            this.autobus.Text = "Autobus";
            this.autobus.UseVisualStyleBackColor = true;
            // 
            // vlastitiPrijevoz
            // 
            this.vlastitiPrijevoz.AutoSize = true;
            this.vlastitiPrijevoz.Location = new System.Drawing.Point(7, 74);
            this.vlastitiPrijevoz.Name = "vlastitiPrijevoz";
            this.vlastitiPrijevoz.Size = new System.Drawing.Size(117, 20);
            this.vlastitiPrijevoz.TabIndex = 2;
            this.vlastitiPrijevoz.TabStop = true;
            this.vlastitiPrijevoz.Text = "Vlastiti prijevoz";
            this.vlastitiPrijevoz.UseVisualStyleBackColor = true;
            // 
            // rezerviraj
            // 
            this.rezerviraj.Location = new System.Drawing.Point(77, 188);
            this.rezerviraj.Name = "rezerviraj";
            this.rezerviraj.Size = new System.Drawing.Size(93, 23);
            this.rezerviraj.TabIndex = 1;
            this.rezerviraj.Text = "Rezerviraj";
            this.rezerviraj.UseVisualStyleBackColor = true;
            this.rezerviraj.Click += new System.EventHandler(this.rezerviraj_Click);
            // 
            // prikaz
            // 
            this.prikaz.Location = new System.Drawing.Point(60, 247);
            this.prikaz.Name = "prikaz";
            this.prikaz.ReadOnly = true;
            this.prikaz.Size = new System.Drawing.Size(268, 96);
            this.prikaz.TabIndex = 2;
            this.prikaz.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.rezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton vlastitiPrijevoz;
        private System.Windows.Forms.RadioButton autobus;
        private System.Windows.Forms.RadioButton avion;
        private System.Windows.Forms.Button rezerviraj;
        private System.Windows.Forms.RichTextBox prikaz;
    }
}

