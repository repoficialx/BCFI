namespace BCFI
{
    partial class Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            pictureBoxProducto = new PictureBox();
            pictureBoxNutriScore = new PictureBox();
            pictureBoxEcoScore = new PictureBox();
            labelMarca = new Label();
            labelNombre = new Label();
            textBoxIngredientes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxAditivos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNutriScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEcoScore).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Location = new Point(12, 12);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(138, 135);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducto.TabIndex = 0;
            pictureBoxProducto.TabStop = false;
            // 
            // pictureBoxNutriScore
            // 
            pictureBoxNutriScore.Image = Properties.Resources.NutriScore_A;
            pictureBoxNutriScore.Location = new Point(12, 153);
            pictureBoxNutriScore.Name = "pictureBoxNutriScore";
            pictureBoxNutriScore.Size = new Size(138, 73);
            pictureBoxNutriScore.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNutriScore.TabIndex = 1;
            pictureBoxNutriScore.TabStop = false;
            // 
            // pictureBoxEcoScore
            // 
            pictureBoxEcoScore.Image = Properties.Resources.EcoScore_A;
            pictureBoxEcoScore.Location = new Point(12, 232);
            pictureBoxEcoScore.Name = "pictureBoxEcoScore";
            pictureBoxEcoScore.Size = new Size(138, 73);
            pictureBoxEcoScore.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEcoScore.TabIndex = 2;
            pictureBoxEcoScore.TabStop = false;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(156, 35);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(50, 20);
            labelMarca.TabIndex = 3;
            labelMarca.Text = "label1";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(156, 78);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(50, 20);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "label1";
            // 
            // textBoxIngredientes
            // 
            textBoxIngredientes.Location = new Point(156, 121);
            textBoxIngredientes.Multiline = true;
            textBoxIngredientes.Name = "textBoxIngredientes";
            textBoxIngredientes.ReadOnly = true;
            textBoxIngredientes.ScrollBars = ScrollBars.Vertical;
            textBoxIngredientes.Size = new Size(157, 184);
            textBoxIngredientes.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 12);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 6;
            label1.Text = "Marca del producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 58);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 98);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 8;
            label3.Text = "Ingredientes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 98);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "Aditivos:";
            // 
            // textBoxAditivos
            // 
            textBoxAditivos.Location = new Point(320, 121);
            textBoxAditivos.Multiline = true;
            textBoxAditivos.Name = "textBoxAditivos";
            textBoxAditivos.ReadOnly = true;
            textBoxAditivos.Size = new Size(157, 184);
            textBoxAditivos.TabIndex = 9;
            // 
            // Datos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 321);
            Controls.Add(label4);
            Controls.Add(textBoxAditivos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxIngredientes);
            Controls.Add(labelNombre);
            Controls.Add(labelMarca);
            Controls.Add(pictureBoxEcoScore);
            Controls.Add(pictureBoxNutriScore);
            Controls.Add(pictureBoxProducto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Datos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Datos";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNutriScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEcoScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProducto;
        private PictureBox pictureBoxNutriScore;
        private PictureBox pictureBoxEcoScore;
        private Label labelMarca;
        private Label labelNombre;
        private TextBox textBoxIngredientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAditivos;
    }
}