namespace Gestion_Taller
{
    partial class ABM_Cliente
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
            button4 = new Button();
            dataGridCliente = new DataGridView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Fecha = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            Button2 = new Button();
            Label6 = new Label();
            TextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(15, 467);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(220, 44);
            button4.TabIndex = 54;
            button4.Text = "Baja Cliente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // dataGridCliente
            // 
            dataGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCliente.Location = new Point(15, 308);
            dataGridCliente.Margin = new Padding(4, 4, 4, 4);
            dataGridCliente.Name = "dataGridCliente";
            dataGridCliente.RowHeadersWidth = 51;
            dataGridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCliente.Size = new Size(545, 152);
            dataGridCliente.TabIndex = 56;
            dataGridCliente.CellClick += dataGridCliente_RowEnter;
            dataGridCliente.CellContentClick += dataGridCliente_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(Fecha);
            groupBox2.Controls.Add(dataGridCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(Button2);
            groupBox2.Controls.Add(Label6);
            groupBox2.Controls.Add(TextBox1);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(-4, 14);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(1180, 519);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(582, 209);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(220, 44);
            button1.TabIndex = 66;
            button1.Text = "Agregar Vehiculo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(582, 50);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(545, 152);
            dataGridView1.TabIndex = 65;
            dataGridView1.CellClick += dataGridView1_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(577, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 64;
            label1.Text = "Vehiculos";
            label1.Click += label1_Click;
            // 
            // Fecha
            // 
            Fecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Fecha.Location = new Point(172, 146);
            Fecha.Margin = new Padding(3, 2, 3, 2);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(164, 26);
            Fecha.TabIndex = 63;
            Fecha.Value = new DateTime(2023, 11, 19, 0, 0, 0, 0);
            Fecha.ValueChanged += Fecha_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 281);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 52;
            label4.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 17);
            label2.TabIndex = 33;
            label2.Text = "Mail";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 180);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 23);
            textBox3.TabIndex = 32;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 30;
            label3.Text = "Fecha de Nacimiento";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(273, 229);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(220, 44);
            button3.TabIndex = 29;
            button3.Text = "Modificar Cliente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(168, 114);
            textBox6.Margin = new Padding(4, 4, 4, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(297, 23);
            textBox6.TabIndex = 22;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(104, 119);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(31, 17);
            label10.TabIndex = 21;
            label10.Text = "DNI";
            label10.Click += label10_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 86);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 20;
            label5.Text = "Apellido";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 80);
            textBox5.Margin = new Padding(4, 4, 4, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(297, 23);
            textBox5.TabIndex = 19;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Button2
            // 
            Button2.Location = new Point(46, 229);
            Button2.Margin = new Padding(4, 4, 4, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(220, 44);
            Button2.TabIndex = 18;
            Button2.Text = "Agregar Cliente";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(74, 46);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(58, 17);
            Label6.TabIndex = 8;
            Label6.Text = "Nombre";
            Label6.Click += Label6_Click;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(167, 45);
            TextBox1.Margin = new Padding(4, 4, 4, 4);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(298, 23);
            TextBox1.TabIndex = 11;
            TextBox1.TextChanged += TextBox1_TextChanged;
            // 
            // ABM_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 544);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ABM_Cliente";
            Text = "ABM_Cliente";
            Load += ABM_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal Button button4;
        public DataGridView dataGridCliente;
        private GroupBox groupBox2;
        internal Label label4;
        internal Label label2;
        internal TextBox textBox3;
        internal Label label3;
        internal Button button3;
        internal TextBox textBox6;
        internal Label label10;
        internal Label label5;
        internal TextBox textBox5;
        internal Button Button2;
        internal Label Label6;
        internal TextBox TextBox1;
        private DateTimePicker Fecha;
        public DataGridView dataGridView1;
        internal Label label1;
        internal Button button1;
    }
}