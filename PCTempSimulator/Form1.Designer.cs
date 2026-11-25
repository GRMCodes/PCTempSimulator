namespace PCTempSimulator
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
            button1 = new Button();
            progressBar1 = new ProgressBar();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(544, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Random";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 197);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(601, 40);
            progressBar1.TabIndex = 1;
            //progressBar1.Click += progressBar1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(312, 41);
            numericUpDown1.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(97, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 50, 0, 0, 0 });
            //numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(440, 39);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Evaluar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Name = "label1";
            label1.Size = new Size(229, 20);
            label1.TabIndex = 4;
            label1.Text = "Temperatura del procesador (°C):\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 167);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 5;
            label2.Text = "Velocidad del ventilador: 0%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 97);
            label3.Name = "label3";
            label3.Size = new Size(325, 38);
            label3.TabIndex = 6;
            label3.Text = "Esperando evaluacion...";
            //label3.Click += label3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(33, 257);
            listView1.Name = "listView1";
            listView1.Size = new Size(605, 290);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            //listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "#";
            columnHeader0.Width = 57;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Temp.";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Vel.";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Duracion";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Alerta";
            columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha";
            columnHeader6.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 559);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Temperatura - Simulacion";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        //private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
