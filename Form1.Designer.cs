namespace JuegoPokemon_Clases
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPokemon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPokemonelegido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeleccionalo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona tipo de Pokemon";
            // 
            // cmbPokemon
            // 
            this.cmbPokemon.FormattingEnabled = true;
            this.cmbPokemon.Items.AddRange(new object[] {
            "Fuego",
            "Agua",
            "Electricidad"});
            this.cmbPokemon.Location = new System.Drawing.Point(55, 54);
            this.cmbPokemon.Name = "cmbPokemon";
            this.cmbPokemon.Size = new System.Drawing.Size(112, 24);
            this.cmbPokemon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pokemon que elegiste: ";
            // 
            // lblPokemonelegido
            // 
            this.lblPokemonelegido.AutoSize = true;
            this.lblPokemonelegido.Location = new System.Drawing.Point(226, 102);
            this.lblPokemonelegido.Name = "lblPokemonelegido";
            this.lblPokemonelegido.Size = new System.Drawing.Size(19, 16);
            this.lblPokemonelegido.TabIndex = 3;
            this.lblPokemonelegido.Text = "---";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ataque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vida";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Location = new System.Drawing.Point(134, 145);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(24, 20);
            this.lblAtaque.TabIndex = 7;
            this.lblAtaque.Text = "---";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(134, 182);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(19, 16);
            this.lblVida.TabIndex = 8;
            this.lblVida.Text = "---";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeleccionalo);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 302);
            this.panel1.TabIndex = 9;
            // 
            // btnSeleccionalo
            // 
            this.btnSeleccionalo.Location = new System.Drawing.Point(76, 221);
            this.btnSeleccionalo.Name = "btnSeleccionalo";
            this.btnSeleccionalo.Size = new System.Drawing.Size(121, 23);
            this.btnSeleccionalo.TabIndex = 10;
            this.btnSeleccionalo.Text = "Seleccionalo";
            this.btnSeleccionalo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 547);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPokemonelegido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPokemon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPokemonelegido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeleccionalo;
    }
}

