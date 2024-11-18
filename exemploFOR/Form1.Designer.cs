namespace exemploFOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrar = new Button();
            btnDecremento = new Button();
            btnCalcular = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            lblTitulo = new Label();
            lsbNumeros = new ListBox();
            lsbNumeros2 = new ListBox();
            lsbMedia = new ListBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(53, 370);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(104, 46);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnDecremento
            // 
            btnDecremento.Location = new Point(221, 370);
            btnDecremento.Name = "btnDecremento";
            btnDecremento.Size = new Size(104, 46);
            btnDecremento.TabIndex = 1;
            btnDecremento.Text = "Decremento";
            btnDecremento.UseVisualStyleBackColor = true;
            btnDecremento.Click += btnDecremento_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(373, 370);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 46);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(528, 370);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(104, 46);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(675, 370);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(104, 46);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(315, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(171, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Numero de 1 à 10";
            // 
            // lsbNumeros
            // 
            lsbNumeros.FormattingEnabled = true;
            lsbNumeros.ItemHeight = 15;
            lsbNumeros.Location = new Point(95, 99);
            lsbNumeros.Name = "lsbNumeros";
            lsbNumeros.Size = new Size(171, 229);
            lsbNumeros.TabIndex = 6;
            // 
            // lsbNumeros2
            // 
            lsbNumeros2.FormattingEnabled = true;
            lsbNumeros2.ItemHeight = 15;
            lsbNumeros2.Location = new Point(312, 99);
            lsbNumeros2.Name = "lsbNumeros2";
            lsbNumeros2.Size = new Size(180, 229);
            lsbNumeros2.TabIndex = 7;
            // 
            // lsbMedia
            // 
            lsbMedia.FormattingEnabled = true;
            lsbMedia.ItemHeight = 15;
            lsbMedia.Location = new Point(554, 99);
            lsbMedia.Name = "lsbMedia";
            lsbMedia.Size = new Size(183, 229);
            lsbMedia.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbMedia);
            Controls.Add(lsbNumeros2);
            Controls.Add(lsbNumeros);
            Controls.Add(lblTitulo);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(btnDecremento);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Button btnDecremento;
        private Button btnCalcular;
        private Button btnLimpar;
        private Button btnSair;
        private Label lblTitulo;
        private ListBox lsbNumeros;
        private ListBox lsbNumeros2;
        private ListBox lsbMedia;
    }
}
