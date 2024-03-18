namespace UI
{
    partial class FrmVehiculo
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            Button2 = new Button();
            Label6 = new Label();
            TextBox1 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(480, 41);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(545, 152);
            dataGridView1.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(475, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 79;
            label1.Text = "Vehiculos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 77;
            label2.Text = "Kilometraje";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 168);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 23);
            textBox3.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 75;
            label3.Text = "Categoría";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(127, 102);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(297, 23);
            textBox6.TabIndex = 73;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 107);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 72;
            label10.Text = "Patente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 76);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 71;
            label5.Text = "Modelo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 68);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(297, 23);
            textBox5.TabIndex = 70;
            // 
            // Button2
            // 
            Button2.Location = new Point(131, 220);
            Button2.Margin = new Padding(4);
            Button2.Name = "Button2";
            Button2.Size = new Size(220, 44);
            Button2.TabIndex = 69;
            Button2.Text = "Agregar Cliente";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(67, 41);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(43, 15);
            Label6.TabIndex = 67;
            Label6.Text = "Marca ";
            Label6.Click += Label6_Click;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(126, 33);
            TextBox1.Margin = new Padding(4);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(298, 23);
            TextBox1.TabIndex = 68;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "Camioneta", "Camion" });
            comboBox1.Location = new Point(131, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 81;
            // 
            // FrmVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 459);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(Button2);
            Controls.Add(Label6);
            Controls.Add(TextBox1);
            Name = "FrmVehiculo";
            Text = "FrmVehiculo";
            Load += FrmVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridView1;
        internal Label label1;
        internal Label label2;
        internal TextBox textBox3;
        internal Label label3;
        internal TextBox textBox6;
        internal Label label10;
        internal Label label5;
        internal TextBox textBox5;
        internal Button Button2;
        internal Label Label6;
        internal TextBox TextBox1;
        private ComboBox comboBox1;
    }
}