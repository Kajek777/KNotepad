namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            label3 = new Label();
            button6 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 80);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "KNotepad GUI";
            // 
            // button1
            // 
            button1.Location = new Point(319, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "New File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(400, 144);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Open File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(713, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Credits";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 39);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 7;
            label2.Text = "Input the name of the file.";
            label2.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(358, 127);
            button4.Name = "button4";
            button4.Size = new Size(82, 23);
            button4.TabIndex = 8;
            button4.Text = "Open File";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 57);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(647, 381);
            textBox2.TabIndex = 9;
            textBox2.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(349, 13);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 10;
            button5.Text = "Save File";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 39);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 11;
            label3.Text = "File has been saved.";
            label3.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(358, 127);
            button6.Name = "button6";
            button6.Size = new Size(82, 23);
            button6.TabIndex = 12;
            button6.Text = "Create File";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 109);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 13;
            label4.Text = "Created by Kajek777";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "KNotepad GUI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button button1;
        public Button button2;
        public Button button3;
        public Label label1;
        public TextBox textBox1;
        private Label label2;
        private Button button4;
        private TextBox textBox2;
        private Button button5;
        private Label label3;
        private Button button6;
        private Label label4;
    }
}