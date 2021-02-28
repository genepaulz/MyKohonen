namespace SOFM_ZafraTamadVariant
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.alphaBox = new System.Windows.Forms.TextBox();
            this.loadNRunBtn = new System.Windows.Forms.Button();
            this.numberOfCardsBox = new System.Windows.Forms.TextBox();
            this.discreteRBtn = new System.Windows.Forms.RadioButton();
            this.gaussRBtn = new System.Windows.Forms.RadioButton();
            this.mexicanRBtn = new System.Windows.Forms.RadioButton();
            this.frenchRBtn = new System.Windows.Forms.RadioButton();
            this.kohonenMap = new System.Windows.Forms.PictureBox();
            this.labelsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputVectorsGroupBox = new System.Windows.Forms.GroupBox();
            this.inputVectorsListBox = new System.Windows.Forms.ListBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.perimeterBox = new System.Windows.Forms.TextBox();
            this.compactnessBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.kernelGrooveBox = new System.Windows.Forms.TextBox();
            this.coefficentBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kohonenMap)).BeginInit();
            this.inputVectorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(145, 371);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(100, 20);
            this.iterationsBox.TabIndex = 1;
            this.iterationsBox.TextChanged += new System.EventHandler(this.iterationsBox_TextChanged);
            // 
            // alphaBox
            // 
            this.alphaBox.Location = new System.Drawing.Point(251, 371);
            this.alphaBox.Name = "alphaBox";
            this.alphaBox.Size = new System.Drawing.Size(100, 20);
            this.alphaBox.TabIndex = 2;
            this.alphaBox.TextChanged += new System.EventHandler(this.alphaBox_TextChanged);
            // 
            // loadNRunBtn
            // 
            this.loadNRunBtn.Enabled = false;
            this.loadNRunBtn.Location = new System.Drawing.Point(107, 426);
            this.loadNRunBtn.Name = "loadNRunBtn";
            this.loadNRunBtn.Size = new System.Drawing.Size(178, 23);
            this.loadNRunBtn.TabIndex = 7;
            this.loadNRunBtn.Text = "Load data and Form Map";
            this.loadNRunBtn.UseVisualStyleBackColor = true;
            this.loadNRunBtn.Click += new System.EventHandler(this.loadNRunBtn_Click);
            // 
            // numberOfCardsBox
            // 
            this.numberOfCardsBox.Location = new System.Drawing.Point(39, 371);
            this.numberOfCardsBox.Name = "numberOfCardsBox";
            this.numberOfCardsBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfCardsBox.TabIndex = 0;
            this.numberOfCardsBox.TextChanged += new System.EventHandler(this.numberOfCardsBox_TextChanged);
            // 
            // discreteRBtn
            // 
            this.discreteRBtn.AutoSize = true;
            this.discreteRBtn.Location = new System.Drawing.Point(12, 397);
            this.discreteRBtn.Name = "discreteRBtn";
            this.discreteRBtn.Size = new System.Drawing.Size(108, 17);
            this.discreteRBtn.TabIndex = 3;
            this.discreteRBtn.TabStop = true;
            this.discreteRBtn.Text = "Discrete Function";
            this.discreteRBtn.UseVisualStyleBackColor = true;
            this.discreteRBtn.CheckedChanged += new System.EventHandler(this.discreteRBtn_CheckedChanged);
            // 
            // gaussRBtn
            // 
            this.gaussRBtn.AutoSize = true;
            this.gaussRBtn.Location = new System.Drawing.Point(121, 397);
            this.gaussRBtn.Name = "gaussRBtn";
            this.gaussRBtn.Size = new System.Drawing.Size(99, 17);
            this.gaussRBtn.TabIndex = 4;
            this.gaussRBtn.TabStop = true;
            this.gaussRBtn.Text = "Gauss Function";
            this.gaussRBtn.UseVisualStyleBackColor = true;
            this.gaussRBtn.CheckedChanged += new System.EventHandler(this.gaussRBtn_CheckedChanged);
            // 
            // mexicanRBtn
            // 
            this.mexicanRBtn.AutoSize = true;
            this.mexicanRBtn.Location = new System.Drawing.Point(223, 397);
            this.mexicanRBtn.Name = "mexicanRBtn";
            this.mexicanRBtn.Size = new System.Drawing.Size(85, 17);
            this.mexicanRBtn.TabIndex = 5;
            this.mexicanRBtn.TabStop = true;
            this.mexicanRBtn.Text = "Mexican Hat";
            this.mexicanRBtn.UseVisualStyleBackColor = true;
            this.mexicanRBtn.CheckedChanged += new System.EventHandler(this.mexicanRBtn_CheckedChanged);
            // 
            // frenchRBtn
            // 
            this.frenchRBtn.AutoSize = true;
            this.frenchRBtn.Location = new System.Drawing.Point(311, 397);
            this.frenchRBtn.Name = "frenchRBtn";
            this.frenchRBtn.Size = new System.Drawing.Size(78, 17);
            this.frenchRBtn.TabIndex = 6;
            this.frenchRBtn.TabStop = true;
            this.frenchRBtn.Text = "French Hat";
            this.frenchRBtn.UseVisualStyleBackColor = true;
            this.frenchRBtn.CheckedChanged += new System.EventHandler(this.frenchRBtn_CheckedChanged);
            // 
            // kohonenMap
            // 
            this.kohonenMap.Location = new System.Drawing.Point(32, 21);
            this.kohonenMap.Name = "kohonenMap";
            this.kohonenMap.Size = new System.Drawing.Size(300, 300);
            this.kohonenMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kohonenMap.TabIndex = 8;
            this.kohonenMap.TabStop = false;
            // 
            // labelsPanel
            // 
            this.labelsPanel.Location = new System.Drawing.Point(394, 13);
            this.labelsPanel.Name = "labelsPanel";
            this.labelsPanel.Size = new System.Drawing.Size(168, 111);
            this.labelsPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Output Layer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Iterations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alpha";
            // 
            // inputVectorsGroupBox
            // 
            this.inputVectorsGroupBox.Controls.Add(this.inputVectorsListBox);
            this.inputVectorsGroupBox.Location = new System.Drawing.Point(617, 13);
            this.inputVectorsGroupBox.Name = "inputVectorsGroupBox";
            this.inputVectorsGroupBox.Size = new System.Drawing.Size(205, 436);
            this.inputVectorsGroupBox.TabIndex = 999;
            this.inputVectorsGroupBox.TabStop = false;
            this.inputVectorsGroupBox.Text = "Input Vectors";
            // 
            // inputVectorsListBox
            // 
            this.inputVectorsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputVectorsListBox.FormattingEnabled = true;
            this.inputVectorsListBox.Location = new System.Drawing.Point(3, 16);
            this.inputVectorsListBox.Name = "inputVectorsListBox";
            this.inputVectorsListBox.Size = new System.Drawing.Size(199, 417);
            this.inputVectorsListBox.TabIndex = 9999;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(503, 425);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 15;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "area A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "perimeter P:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "compactness C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "length:";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(511, 247);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(100, 20);
            this.areaBox.TabIndex = 8;
            // 
            // perimeterBox
            // 
            this.perimeterBox.Location = new System.Drawing.Point(511, 272);
            this.perimeterBox.Name = "perimeterBox";
            this.perimeterBox.Size = new System.Drawing.Size(100, 20);
            this.perimeterBox.TabIndex = 9;
            // 
            // compactnessBox
            // 
            this.compactnessBox.Location = new System.Drawing.Point(511, 298);
            this.compactnessBox.Name = "compactnessBox";
            this.compactnessBox.Size = new System.Drawing.Size(100, 20);
            this.compactnessBox.TabIndex = 10;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(511, 324);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 11;
            // 
            // kernelGrooveBox
            // 
            this.kernelGrooveBox.Location = new System.Drawing.Point(511, 402);
            this.kernelGrooveBox.Name = "kernelGrooveBox";
            this.kernelGrooveBox.Size = new System.Drawing.Size(100, 20);
            this.kernelGrooveBox.TabIndex = 14;
            // 
            // coefficentBox
            // 
            this.coefficentBox.Location = new System.Drawing.Point(511, 376);
            this.coefficentBox.Name = "coefficentBox";
            this.coefficentBox.Size = new System.Drawing.Size(100, 20);
            this.coefficentBox.TabIndex = 13;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(511, 350);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "kernel groove:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "asymmetry coefficient:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 458);
            this.Controls.Add(this.kernelGrooveBox);
            this.Controls.Add(this.coefficentBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.compactnessBox);
            this.Controls.Add(this.perimeterBox);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.inputVectorsGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelsPanel);
            this.Controls.Add(this.kohonenMap);
            this.Controls.Add(this.frenchRBtn);
            this.Controls.Add(this.mexicanRBtn);
            this.Controls.Add(this.gaussRBtn);
            this.Controls.Add(this.discreteRBtn);
            this.Controls.Add(this.numberOfCardsBox);
            this.Controls.Add(this.loadNRunBtn);
            this.Controls.Add(this.alphaBox);
            this.Controls.Add(this.iterationsBox);
            this.Name = "Form1";
            this.Text = "Kohonen ZafraTamad NewVariant";
            ((System.ComponentModel.ISupportInitialize)(this.kohonenMap)).EndInit();
            this.inputVectorsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.TextBox alphaBox;
        private System.Windows.Forms.Button loadNRunBtn;
        private System.Windows.Forms.TextBox numberOfCardsBox;
        private System.Windows.Forms.RadioButton discreteRBtn;
        private System.Windows.Forms.RadioButton gaussRBtn;
        private System.Windows.Forms.RadioButton mexicanRBtn;
        private System.Windows.Forms.RadioButton frenchRBtn;
        private System.Windows.Forms.PictureBox kohonenMap;
        private System.Windows.Forms.Panel labelsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox inputVectorsGroupBox;
        private System.Windows.Forms.ListBox inputVectorsListBox;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.TextBox perimeterBox;
        private System.Windows.Forms.TextBox compactnessBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox kernelGrooveBox;
        private System.Windows.Forms.TextBox coefficentBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

