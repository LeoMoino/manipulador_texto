namespace manipulador_texto
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
            btncontarpalavras = new Button();
            btncontarletras = new Button();
            btnmaiuscula = new Button();
            button1 = new Button();
            btnembaralharletras = new Button();
            btnembaralharpalavras = new Button();
            btnminuscula = new Button();
            btninverterletras = new Button();
            btnquebralinha = new Button();
            btninverterpalavras = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btncontarpalavras
            // 
            btncontarpalavras.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btncontarpalavras.Location = new Point(95, 121);
            btncontarpalavras.Margin = new Padding(2);
            btncontarpalavras.Name = "btncontarpalavras";
            btncontarpalavras.Size = new Size(78, 44);
            btncontarpalavras.TabIndex = 4;
            btncontarpalavras.Text = "Contar Palavras";
            btncontarpalavras.UseVisualStyleBackColor = true;
            btncontarpalavras.Click += btncontarpalavras_Click;
            // 
            // btncontarletras
            // 
            btncontarletras.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btncontarletras.Location = new Point(177, 121);
            btncontarletras.Margin = new Padding(2);
            btncontarletras.Name = "btncontarletras";
            btncontarletras.Size = new Size(78, 44);
            btncontarletras.TabIndex = 5;
            btncontarletras.Text = "Contar Letras";
            btncontarletras.UseVisualStyleBackColor = true;
            btncontarletras.Click += btncontarletras_Click;
            // 
            // btnmaiuscula
            // 
            btnmaiuscula.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnmaiuscula.Location = new Point(259, 121);
            btnmaiuscula.Margin = new Padding(2);
            btnmaiuscula.Name = "btnmaiuscula";
            btnmaiuscula.Size = new Size(78, 44);
            btnmaiuscula.TabIndex = 6;
            btnmaiuscula.Text = "Maiúscula";
            btnmaiuscula.UseVisualStyleBackColor = true;
            btnmaiuscula.Click += btnmaiuscula_Click;
            // 
            // button1
            // 
            button1.Location = new Point(362, 72);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(62, 28);
            button1.TabIndex = 19;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnembaralharletras
            // 
            btnembaralharletras.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnembaralharletras.Location = new Point(259, 217);
            btnembaralharletras.Margin = new Padding(2);
            btnembaralharletras.Name = "btnembaralharletras";
            btnembaralharletras.Size = new Size(78, 44);
            btnembaralharletras.TabIndex = 18;
            btnembaralharletras.Text = "Embaralhar Letras";
            btnembaralharletras.UseVisualStyleBackColor = true;
            btnembaralharletras.Click += btnembaralharletras_Click;
            // 
            // btnembaralharpalavras
            // 
            btnembaralharpalavras.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnembaralharpalavras.Location = new Point(177, 217);
            btnembaralharpalavras.Margin = new Padding(2);
            btnembaralharpalavras.Name = "btnembaralharpalavras";
            btnembaralharpalavras.Size = new Size(78, 44);
            btnembaralharpalavras.TabIndex = 17;
            btnembaralharpalavras.Text = "Embaralhar Palavras";
            btnembaralharpalavras.UseVisualStyleBackColor = true;
            btnembaralharpalavras.Click += btnembaralharpalavras_Click;
            // 
            // btnminuscula
            // 
            btnminuscula.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnminuscula.Location = new Point(94, 169);
            btnminuscula.Margin = new Padding(2);
            btnminuscula.Name = "btnminuscula";
            btnminuscula.Size = new Size(78, 44);
            btnminuscula.TabIndex = 16;
            btnminuscula.Text = "Minúscula";
            btnminuscula.UseVisualStyleBackColor = true;
            btnminuscula.Click += btnminuscula_Click;
            // 
            // btninverterletras
            // 
            btninverterletras.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btninverterletras.Location = new Point(259, 169);
            btninverterletras.Margin = new Padding(2);
            btninverterletras.Name = "btninverterletras";
            btninverterletras.Size = new Size(78, 44);
            btninverterletras.TabIndex = 15;
            btninverterletras.Text = "Inverter Letras";
            btninverterletras.UseVisualStyleBackColor = true;
            btninverterletras.Click += btninverterletras_Click;
            // 
            // btnquebralinha
            // 
            btnquebralinha.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnquebralinha.Location = new Point(94, 217);
            btnquebralinha.Margin = new Padding(2);
            btnquebralinha.Name = "btnquebralinha";
            btnquebralinha.Size = new Size(78, 44);
            btnquebralinha.TabIndex = 14;
            btnquebralinha.Text = "Quebra de Linha";
            btnquebralinha.UseVisualStyleBackColor = true;
            btnquebralinha.Click += btnquebralinha_Click;
            // 
            // btninverterpalavras
            // 
            btninverterpalavras.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btninverterpalavras.Location = new Point(177, 169);
            btninverterpalavras.Margin = new Padding(2);
            btninverterpalavras.Name = "btninverterpalavras";
            btninverterpalavras.Size = new Size(78, 44);
            btninverterpalavras.TabIndex = 13;
            btninverterpalavras.Text = "Inverter Palavras";
            btninverterpalavras.UseVisualStyleBackColor = true;
            btninverterpalavras.Click += btninverterpalavras_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(67, 279);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(299, 49);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(59, 71);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 29);
            textBox1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 22;
            label1.Text = "Insira seu Texto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 341);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(btnembaralharletras);
            Controls.Add(btnembaralharpalavras);
            Controls.Add(btnminuscula);
            Controls.Add(btninverterletras);
            Controls.Add(btnquebralinha);
            Controls.Add(btninverterpalavras);
            Controls.Add(btnmaiuscula);
            Controls.Add(btncontarletras);
            Controls.Add(btncontarpalavras);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btncontarpalavras;
        private Button btncontarletras;
        private Button btnmaiuscula;
        private Button button1;
        private Button btnembaralharletras;
        private Button btnembaralharpalavras;
        private Button btnminuscula;
        private Button btninverterletras;
        private Button btnquebralinha;
        private Button btninverterpalavras;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}
