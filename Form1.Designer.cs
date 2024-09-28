namespace Validaciones_C_Sharp
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
            BTN_Modificar = new Button();
            BTN_Eliminar = new Button();
            BTN_Agregar = new Button();
            textBox1 = new TextBox();
            DGV_1 = new DataGridView();
            label1 = new Label();
            Label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            DUP1 = new DomainUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Modificar
            // 
            BTN_Modificar.Location = new Point(84, 167);
            BTN_Modificar.Name = "BTN_Modificar";
            BTN_Modificar.Size = new Size(75, 23);
            BTN_Modificar.TabIndex = 0;
            BTN_Modificar.Text = "Modificar";
            BTN_Modificar.UseVisualStyleBackColor = true;
            BTN_Modificar.Click += BTN_Modificar_Click;
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.Location = new Point(246, 167);
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.Size = new Size(75, 23);
            BTN_Eliminar.TabIndex = 1;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.UseVisualStyleBackColor = true;
            BTN_Eliminar.Click += BTN_Eliminar_Click;
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.Location = new Point(165, 167);
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.Size = new Size(75, 23);
            BTN_Agregar.TabIndex = 2;
            BTN_Agregar.Text = "Agregar";
            BTN_Agregar.UseVisualStyleBackColor = true;
            BTN_Agregar.Click += BTN_Agregar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // DGV_1
            // 
            DGV_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_1.Location = new Point(84, 196);
            DGV_1.Name = "DGV_1";
            DGV_1.Size = new Size(240, 150);
            DGV_1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 54);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(84, 81);
            Label2.Name = "Label2";
            Label2.Size = new Size(38, 15);
            Label2.TabIndex = 6;
            Label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // DUP1
            // 
            DUP1.Location = new Point(141, 104);
            DUP1.Name = "DUP1";
            DUP1.Size = new Size(120, 23);
            DUP1.TabIndex = 8;
            DUP1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 112);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "DUP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(DUP1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Label2);
            Controls.Add(label1);
            Controls.Add(DGV_1);
            Controls.Add(textBox1);
            Controls.Add(BTN_Agregar);
            Controls.Add(BTN_Eliminar);
            Controls.Add(BTN_Modificar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Modificar;
        private Button BTN_Eliminar;
        private Button BTN_Agregar;
        private TextBox textBox1;
        private DataGridView DGV_1;
        private Label label1;
        private Label Label2;
        private DateTimePicker dateTimePicker1;
        private DomainUpDown DUP1;
        private Label label3;
    }
}
