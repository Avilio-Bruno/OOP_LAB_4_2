namespace OOP_LAB_4_2
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
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            label1 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            trackBarA = new TrackBar();
            trackBarC = new TrackBar();
            trackBarB = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(80, 286);
            numericUpDownA.Margin = new Padding(3, 4, 3, 4);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(137, 27);
            numericUpDownA.TabIndex = 0;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(390, 286);
            numericUpDownB.Margin = new Padding(3, 4, 3, 4);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(137, 27);
            numericUpDownB.TabIndex = 1;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(690, 286);
            numericUpDownC.Margin = new Padding(3, 4, 3, 4);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(137, 27);
            numericUpDownC.TabIndex = 2;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 68);
            label1.Name = "label1";
            label1.Size = new Size(747, 159);
            label1.TabIndex = 3;
            label1.Text = "A <= B <= C";
            label1.Click += label1_Click;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(80, 231);
            textBoxA.Margin = new Padding(3, 4, 3, 4);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(137, 27);
            textBoxA.TabIndex = 8;
            textBoxA.KeyUp += textBoxA_KeyUp;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(390, 231);
            textBoxB.Margin = new Padding(3, 4, 3, 4);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(137, 27);
            textBoxB.TabIndex = 9;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(690, 231);
            textBoxC.Margin = new Padding(3, 4, 3, 4);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(137, 27);
            textBoxC.TabIndex = 10;
            // 
            // trackBarA
            // 
            trackBarA.LargeChange = 10;
            trackBarA.Location = new Point(80, 363);
            trackBarA.Margin = new Padding(3, 4, 3, 4);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(137, 56);
            trackBarA.TabIndex = 11;
            trackBarA.Scroll += trackBarA_Scroll;
            // 
            // trackBarC
            // 
            trackBarC.LargeChange = 10;
            trackBarC.Location = new Point(690, 363);
            trackBarC.Margin = new Padding(3, 4, 3, 4);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(137, 56);
            trackBarC.TabIndex = 12;
            trackBarC.Scroll += trackBarC_Scroll;
            // 
            // trackBarB
            // 
            trackBarB.LargeChange = 10;
            trackBarB.Location = new Point(385, 363);
            trackBarB.Margin = new Padding(3, 4, 3, 4);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(142, 56);
            trackBarB.TabIndex = 13;
            trackBarB.Scroll += trackBarB_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(trackBarB);
            Controls.Add(trackBarC);
            Controls.Add(trackBarA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label1);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private Label label1;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private TrackBar trackBarA;
        private TrackBar trackBarC;
        private TrackBar trackBarB;
    }
}