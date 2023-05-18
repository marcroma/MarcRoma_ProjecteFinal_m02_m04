namespace ProjecteFinal_m02_m04
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnLoadXML = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Sans Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(159, 31);
            label1.TabIndex = 0;
            label1.Text = "Load XML File";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(32, 80);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(248, 31);
            textBox1.TabIndex = 1;
            // 
            // btnLoadXML
            // 
            btnLoadXML.Font = new Font("Source Sans Pro", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadXML.Location = new Point(32, 129);
            btnLoadXML.Name = "btnLoadXML";
            btnLoadXML.Size = new Size(112, 34);
            btnLoadXML.TabIndex = 2;
            btnLoadXML.Text = "Load";
            btnLoadXML.UseVisualStyleBackColor = true;
            btnLoadXML.Click += btnLoadXML_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadXML);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CRM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnLoadXML;
        private OpenFileDialog openFileDialog1;
    }
}