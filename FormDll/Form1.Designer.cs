namespace FormDll
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
            textBox1 = new TextBox();
            label1 = new Label();
            seqNumLabel = new Label();
            label3 = new Label();
            CountSeqLabel = new Label();
            label5 = new Label();
            FibSeqLabel = new Label();
            label7 = new Label();
            FactorialSeqLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 11);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Sequence Number";
            // 
            // seqNumLabel
            // 
            seqNumLabel.AutoSize = true;
            seqNumLabel.Location = new Point(148, 53);
            seqNumLabel.Name = "seqNumLabel";
            seqNumLabel.Size = new Size(13, 15);
            seqNumLabel.TabIndex = 3;
            seqNumLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Counting";
            // 
            // CountSeqLabel
            // 
            CountSeqLabel.AutoSize = true;
            CountSeqLabel.Location = new Point(148, 83);
            CountSeqLabel.Name = "CountSeqLabel";
            CountSeqLabel.Size = new Size(13, 15);
            CountSeqLabel.TabIndex = 5;
            CountSeqLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 6;
            label5.Text = "Fibonacci";
            // 
            // FibSeqLabel
            // 
            FibSeqLabel.AutoSize = true;
            FibSeqLabel.Location = new Point(148, 113);
            FibSeqLabel.Name = "FibSeqLabel";
            FibSeqLabel.Size = new Size(13, 15);
            FibSeqLabel.TabIndex = 7;
            FibSeqLabel.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 143);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 8;
            label7.Text = "Factorial";
            // 
            // FactorialSeqLabel
            // 
            FactorialSeqLabel.AutoSize = true;
            FactorialSeqLabel.Location = new Point(148, 143);
            FactorialSeqLabel.Name = "FactorialSeqLabel";
            FactorialSeqLabel.Size = new Size(13, 15);
            FactorialSeqLabel.TabIndex = 9;
            FactorialSeqLabel.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 190);
            Controls.Add(FactorialSeqLabel);
            Controls.Add(label7);
            Controls.Add(FibSeqLabel);
            Controls.Add(label5);
            Controls.Add(CountSeqLabel);
            Controls.Add(label3);
            Controls.Add(seqNumLabel);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label seqNumLabel;
        private Label label3;
        private Label CountSeqLabel;
        private Label label5;
        private Label FibSeqLabel;
        private Label label7;
        private Label FactorialSeqLabel;
    }
}
