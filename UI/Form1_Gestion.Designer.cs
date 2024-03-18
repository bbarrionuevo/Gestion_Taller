namespace Gestion_Taller
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            Fecha = new DateTimePicker();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            comboBox4 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            label10 = new Label();
            Button2 = new Button();
            Label9 = new Label();
            dataGridVehiculo = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(802, 82);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(629, 220);
            dataGridView1.TabIndex = 66;
            dataGridView1.CellClick += dataGridView1__RowEnter;
            dataGridView1.CellContentClick += dataGridView1__RowEnter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(399, 40);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 64;
            label4.Text = "Fecha de Servicio";
            label4.Click += label4_Click;
            // 
            // Fecha
            // 
            Fecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Fecha.Location = new Point(403, 81);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(187, 30);
            Fecha.TabIndex = 62;
            Fecha.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 393);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 59;
            label3.Text = "Servicios";
            label3.Click += label3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(43, 428);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 24;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(651, 228);
            dataGridView3.TabIndex = 58;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button7
            // 
            button7.Location = new Point(806, 312);
            button7.Name = "button7";
            button7.Size = new Size(131, 61);
            button7.TabIndex = 55;
            button7.Text = "ABM Cliente";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(800, 48);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 67;
            label1.Text = "Clientes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(802, 398);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 68;
            label2.Text = "Vehiculos";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(387, 304);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(335, 71);
            button3.TabIndex = 84;
            button3.Text = "Modificar Servicio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Basico", "Premium" });
            comboBox4.Location = new Point(200, 203);
            comboBox4.Margin = new Padding(5);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(175, 33);
            comboBox4.TabIndex = 81;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 211);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 80;
            label6.Text = "Tipo de Servicio";
            label6.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Semisintetico", "Sintetico" });
            comboBox1.Location = new Point(199, 75);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 33);
            comboBox1.TabIndex = 79;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(201, 131);
            textBox6.Margin = new Padding(5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(377, 30);
            textBox6.TabIndex = 78;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(7, 135);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(170, 25);
            label10.TabIndex = 77;
            label10.Text = "Cantidad de Litros";
            label10.Click += label10_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Location = new Point(43, 304);
            Button2.Margin = new Padding(5);
            Button2.Name = "Button2";
            Button2.Size = new Size(335, 71);
            Button2.TabIndex = 74;
            Button2.Text = "Agregar Servicio";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label9.Location = new Point(43, 81);
            Label9.Margin = new Padding(5, 0, 5, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(138, 25);
            Label9.TabIndex = 72;
            Label9.Text = "Tipo de Aceite";
            Label9.Click += Label9_Click;
            // 
            // dataGridVehiculo
            // 
            dataGridVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVehiculo.Location = new Point(804, 428);
            dataGridVehiculo.Margin = new Padding(5);
            dataGridVehiculo.Name = "dataGridVehiculo";
            dataGridVehiculo.RowHeadersWidth = 51;
            dataGridVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVehiculo.Size = new Size(629, 228);
            dataGridVehiculo.TabIndex = 85;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(43, 664);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(280, 43);
            button1.TabIndex = 86;
            button1.Text = "Baja de Servicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 749);
            Controls.Add(button1);
            Controls.Add(dataGridVehiculo);
            Controls.Add(button3);
            Controls.Add(comboBox4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(Button2);
            Controls.Add(Label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(Fecha);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(button7);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label4;
        private DateTimePicker Fecha;
        private Label label3;
        private DataGridView dataGridView3;
        private Button button7;
        private Label label1;
        private Label label2;
        internal Button button3;
        internal ComboBox comboBox4;
        internal Label label6;
        internal ComboBox comboBox1;
        internal TextBox textBox6;
        internal Label label10;
        internal Button Button2;
        internal Label Label9;
        private DataGridView dataGridVehiculo;
        internal Button button1;
    }
}

