namespace GeradorDeSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1Senhas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Gerar = new System.Windows.Forms.Button();
            this.count_char = new System.Windows.Forms.NumericUpDown();
            this.checkBox1Maius = new System.Windows.Forms.CheckBox();
            this.checkBox2Alga = new System.Windows.Forms.CheckBox();
            this.checkBox3Simbol = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.count_char)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1Senhas
            // 
            this.listBox1Senhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.listBox1Senhas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1Senhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1Senhas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1Senhas.FormattingEnabled = true;
            this.listBox1Senhas.ItemHeight = 29;
            this.listBox1Senhas.Location = new System.Drawing.Point(12, 29);
            this.listBox1Senhas.Name = "listBox1Senhas";
            this.listBox1Senhas.Size = new System.Drawing.Size(297, 348);
            this.listBox1Senhas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(348, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Caracteres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1Gerar
            // 
            this.button1Gerar.BackColor = System.Drawing.SystemColors.Window;
            this.button1Gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Gerar.ForeColor = System.Drawing.Color.Black;
            this.button1Gerar.Location = new System.Drawing.Point(351, 331);
            this.button1Gerar.Name = "button1Gerar";
            this.button1Gerar.Size = new System.Drawing.Size(147, 46);
            this.button1Gerar.TabIndex = 2;
            this.button1Gerar.Text = "Gerar";
            this.button1Gerar.UseVisualStyleBackColor = false;
            this.button1Gerar.Click += new System.EventHandler(this.button1Gerar_Click);
            // 
            // count_char
            // 
            this.count_char.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.count_char.Location = new System.Drawing.Point(351, 60);
            this.count_char.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.count_char.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_char.Name = "count_char";
            this.count_char.Size = new System.Drawing.Size(134, 22);
            this.count_char.TabIndex = 3;
            this.count_char.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // checkBox1Maius
            // 
            this.checkBox1Maius.AutoSize = true;
            this.checkBox1Maius.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1Maius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1Maius.ForeColor = System.Drawing.Color.Black;
            this.checkBox1Maius.Location = new System.Drawing.Point(351, 118);
            this.checkBox1Maius.Name = "checkBox1Maius";
            this.checkBox1Maius.Size = new System.Drawing.Size(147, 21);
            this.checkBox1Maius.TabIndex = 4;
            this.checkBox1Maius.Text = "Utilizar Maiúsculas";
            this.checkBox1Maius.UseVisualStyleBackColor = false;
            // 
            // checkBox2Alga
            // 
            this.checkBox2Alga.AutoSize = true;
            this.checkBox2Alga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2Alga.ForeColor = System.Drawing.Color.Black;
            this.checkBox2Alga.Location = new System.Drawing.Point(351, 155);
            this.checkBox2Alga.Name = "checkBox2Alga";
            this.checkBox2Alga.Size = new System.Drawing.Size(145, 21);
            this.checkBox2Alga.TabIndex = 5;
            this.checkBox2Alga.Text = "Utilizar algarismos";
            this.checkBox2Alga.UseVisualStyleBackColor = true;
            // 
            // checkBox3Simbol
            // 
            this.checkBox3Simbol.AutoSize = true;
            this.checkBox3Simbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3Simbol.ForeColor = System.Drawing.Color.Black;
            this.checkBox3Simbol.Location = new System.Drawing.Point(351, 191);
            this.checkBox3Simbol.Name = "checkBox3Simbol";
            this.checkBox3Simbol.Size = new System.Drawing.Size(134, 21);
            this.checkBox3Simbol.TabIndex = 6;
            this.checkBox3Simbol.Text = "Utilizar Simbolos";
            this.checkBox3Simbol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(141)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(546, 429);
            this.Controls.Add(this.checkBox3Simbol);
            this.Controls.Add(this.checkBox2Alga);
            this.Controls.Add(this.checkBox1Maius);
            this.Controls.Add(this.count_char);
            this.Controls.Add(this.button1Gerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1Senhas);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador De Senha";
            ((System.ComponentModel.ISupportInitialize)(this.count_char)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1Senhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Gerar;
        private System.Windows.Forms.NumericUpDown count_char;
        private System.Windows.Forms.CheckBox checkBox1Maius;
        private System.Windows.Forms.CheckBox checkBox2Alga;
        private System.Windows.Forms.CheckBox checkBox3Simbol;
    }
}

