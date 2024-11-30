namespace ColorReducer
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
            splitContainer1 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            label6 = new Label();
            mainPictureBox = new PictureBox();
            totalScaleLabel = new Label();
            label10 = new Label();
            blueScaleLabel = new Label();
            blueScaleTrackBar = new TrackBar();
            label9 = new Label();
            greenScaleLabel = new Label();
            greenScaleTrackBar = new TrackBar();
            label11 = new Label();
            redScaleLabel = new Label();
            label13 = new Label();
            redScaleTrackBar = new TrackBar();
            label5 = new Label();
            maxIterationsValueLabel = new Label();
            maxIterationsTrackbar = new TrackBar();
            label8 = new Label();
            epsilonValueLabel = new Label();
            label7 = new Label();
            epsilonTrackBar = new TrackBar();
            colorAmountLabel = new Label();
            label4 = new Label();
            clusterImageButton = new Button();
            colorsAmountTrackBar = new TrackBar();
            loadImageButton = new Button();
            saveImageButton = new Button();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            propagationOfUncertaintyPictureBox = new PictureBox();
            splitContainer3 = new SplitContainer();
            label2 = new Label();
            popularityAlgorithmPictureBox = new PictureBox();
            label3 = new Label();
            kMeansAlgorithmPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueScaleTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenScaleTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redScaleTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxIterationsTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epsilonTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorsAmountTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propagationOfUncertaintyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popularityAlgorithmPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kMeansAlgorithmPictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1132, 647);
            splitContainer1.SplitterDistance = 345;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.BorderStyle = BorderStyle.Fixed3D;
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label6);
            splitContainer4.Panel1.Controls.Add(mainPictureBox);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(totalScaleLabel);
            splitContainer4.Panel2.Controls.Add(label10);
            splitContainer4.Panel2.Controls.Add(blueScaleLabel);
            splitContainer4.Panel2.Controls.Add(blueScaleTrackBar);
            splitContainer4.Panel2.Controls.Add(label9);
            splitContainer4.Panel2.Controls.Add(greenScaleLabel);
            splitContainer4.Panel2.Controls.Add(greenScaleTrackBar);
            splitContainer4.Panel2.Controls.Add(label11);
            splitContainer4.Panel2.Controls.Add(redScaleLabel);
            splitContainer4.Panel2.Controls.Add(label13);
            splitContainer4.Panel2.Controls.Add(redScaleTrackBar);
            splitContainer4.Panel2.Controls.Add(label5);
            splitContainer4.Panel2.Controls.Add(maxIterationsValueLabel);
            splitContainer4.Panel2.Controls.Add(maxIterationsTrackbar);
            splitContainer4.Panel2.Controls.Add(label8);
            splitContainer4.Panel2.Controls.Add(epsilonValueLabel);
            splitContainer4.Panel2.Controls.Add(label7);
            splitContainer4.Panel2.Controls.Add(epsilonTrackBar);
            splitContainer4.Panel2.Controls.Add(colorAmountLabel);
            splitContainer4.Panel2.Controls.Add(label4);
            splitContainer4.Panel2.Controls.Add(clusterImageButton);
            splitContainer4.Panel2.Controls.Add(colorsAmountTrackBar);
            splitContainer4.Panel2.Controls.Add(loadImageButton);
            splitContainer4.Panel2.Controls.Add(saveImageButton);
            splitContainer4.Size = new Size(1132, 345);
            splitContainer4.SplitterDistance = 756;
            splitContainer4.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(312, 7);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 3;
            label6.Text = "Original image";
            // 
            // mainPictureBox
            // 
            mainPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPictureBox.BackColor = SystemColors.Control;
            mainPictureBox.Location = new Point(12, 37);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(727, 301);
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;
            // 
            // totalScaleLabel
            // 
            totalScaleLabel.AutoSize = true;
            totalScaleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            totalScaleLabel.Location = new Point(291, 277);
            totalScaleLabel.Name = "totalScaleLabel";
            totalScaleLabel.Size = new Size(54, 15);
            totalScaleLabel.TabIndex = 24;
            totalScaleLabel.Text = "Total: 64";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.Location = new Point(11, 247);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 23;
            label10.Text = "B scale cols.:";
            // 
            // blueScaleLabel
            // 
            blueScaleLabel.AutoSize = true;
            blueScaleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            blueScaleLabel.Location = new Point(331, 247);
            blueScaleLabel.Name = "blueScaleLabel";
            blueScaleLabel.Size = new Size(14, 15);
            blueScaleLabel.TabIndex = 22;
            blueScaleLabel.Text = "4";
            // 
            // blueScaleTrackBar
            // 
            blueScaleTrackBar.Location = new Point(85, 247);
            blueScaleTrackBar.Maximum = 8;
            blueScaleTrackBar.Minimum = 2;
            blueScaleTrackBar.Name = "blueScaleTrackBar";
            blueScaleTrackBar.Size = new Size(231, 45);
            blueScaleTrackBar.TabIndex = 21;
            blueScaleTrackBar.TickFrequency = 14;
            blueScaleTrackBar.Value = 4;
            blueScaleTrackBar.Scroll += blueScaleTrackBar_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(11, 222);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 20;
            label9.Text = "G scale cols.:";
            // 
            // greenScaleLabel
            // 
            greenScaleLabel.AutoSize = true;
            greenScaleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            greenScaleLabel.Location = new Point(331, 222);
            greenScaleLabel.Name = "greenScaleLabel";
            greenScaleLabel.Size = new Size(14, 15);
            greenScaleLabel.TabIndex = 19;
            greenScaleLabel.Text = "4";
            // 
            // greenScaleTrackBar
            // 
            greenScaleTrackBar.Location = new Point(85, 222);
            greenScaleTrackBar.Maximum = 8;
            greenScaleTrackBar.Minimum = 2;
            greenScaleTrackBar.Name = "greenScaleTrackBar";
            greenScaleTrackBar.Size = new Size(231, 45);
            greenScaleTrackBar.TabIndex = 18;
            greenScaleTrackBar.TickFrequency = 14;
            greenScaleTrackBar.Value = 4;
            greenScaleTrackBar.Scroll += greenScaleTrackBar_Scroll;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.Location = new Point(11, 196);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 17;
            label11.Text = "R scale cols.:";
            // 
            // redScaleLabel
            // 
            redScaleLabel.AutoSize = true;
            redScaleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            redScaleLabel.Location = new Point(331, 196);
            redScaleLabel.Name = "redScaleLabel";
            redScaleLabel.Size = new Size(14, 15);
            redScaleLabel.TabIndex = 16;
            redScaleLabel.Text = "4";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label13.Location = new Point(11, 178);
            label13.Name = "label13";
            label13.Size = new Size(226, 15);
            label13.TabIndex = 15;
            label13.Text = "Propagation of uncertainty parameters:";
            // 
            // redScaleTrackBar
            // 
            redScaleTrackBar.Location = new Point(85, 196);
            redScaleTrackBar.Maximum = 8;
            redScaleTrackBar.Minimum = 2;
            redScaleTrackBar.Name = "redScaleTrackBar";
            redScaleTrackBar.Size = new Size(231, 45);
            redScaleTrackBar.TabIndex = 14;
            redScaleTrackBar.TickFrequency = 14;
            redScaleTrackBar.Value = 4;
            redScaleTrackBar.Scroll += redScaleTrackBar_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(11, 147);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 13;
            label5.Text = "Max. iters.:";
            // 
            // maxIterationsValueLabel
            // 
            maxIterationsValueLabel.AutoSize = true;
            maxIterationsValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            maxIterationsValueLabel.Location = new Point(331, 147);
            maxIterationsValueLabel.Name = "maxIterationsValueLabel";
            maxIterationsValueLabel.Size = new Size(21, 15);
            maxIterationsValueLabel.TabIndex = 12;
            maxIterationsValueLabel.Text = "10";
            // 
            // maxIterationsTrackbar
            // 
            maxIterationsTrackbar.Location = new Point(85, 147);
            maxIterationsTrackbar.Maximum = 30;
            maxIterationsTrackbar.Minimum = 1;
            maxIterationsTrackbar.Name = "maxIterationsTrackbar";
            maxIterationsTrackbar.Size = new Size(231, 45);
            maxIterationsTrackbar.TabIndex = 11;
            maxIterationsTrackbar.TickFrequency = 14;
            maxIterationsTrackbar.Value = 10;
            maxIterationsTrackbar.Scroll += maxIterationsTrackbar_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.Location = new Point(11, 121);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 10;
            label8.Text = "Epsilon:";
            // 
            // epsilonValueLabel
            // 
            epsilonValueLabel.AutoSize = true;
            epsilonValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            epsilonValueLabel.Location = new Point(331, 121);
            epsilonValueLabel.Name = "epsilonValueLabel";
            epsilonValueLabel.Size = new Size(21, 15);
            epsilonValueLabel.TabIndex = 9;
            epsilonValueLabel.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(11, 103);
            label7.Name = "label7";
            label7.Size = new Size(183, 15);
            label7.TabIndex = 8;
            label7.Text = "K-means algorithm parameters:";
            // 
            // epsilonTrackBar
            // 
            epsilonTrackBar.Location = new Point(85, 121);
            epsilonTrackBar.Maximum = 30;
            epsilonTrackBar.Minimum = 1;
            epsilonTrackBar.Name = "epsilonTrackBar";
            epsilonTrackBar.Size = new Size(231, 45);
            epsilonTrackBar.TabIndex = 7;
            epsilonTrackBar.TickFrequency = 14;
            epsilonTrackBar.Value = 10;
            epsilonTrackBar.Scroll += epsilonTrackBar_Scroll;
            // 
            // colorAmountLabel
            // 
            colorAmountLabel.AutoSize = true;
            colorAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            colorAmountLabel.Location = new Point(329, 70);
            colorAmountLabel.Name = "colorAmountLabel";
            colorAmountLabel.Size = new Size(21, 15);
            colorAmountLabel.TabIndex = 6;
            colorAmountLabel.Text = "64";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(9, 52);
            label4.Name = "label4";
            label4.Size = new Size(321, 15);
            label4.TabIndex = 5;
            label4.Text = "Number of colors for popularity and k-means algorithms:";
            // 
            // clusterImageButton
            // 
            clusterImageButton.Location = new Point(134, 310);
            clusterImageButton.Name = "clusterImageButton";
            clusterImageButton.Size = new Size(107, 28);
            clusterImageButton.TabIndex = 3;
            clusterImageButton.Text = "Cluster image";
            clusterImageButton.UseVisualStyleBackColor = true;
            clusterImageButton.Click += clusterImageButton_Click;
            // 
            // colorsAmountTrackBar
            // 
            colorsAmountTrackBar.Location = new Point(7, 70);
            colorsAmountTrackBar.Maximum = 256;
            colorsAmountTrackBar.Minimum = 2;
            colorsAmountTrackBar.Name = "colorsAmountTrackBar";
            colorsAmountTrackBar.Size = new Size(307, 45);
            colorsAmountTrackBar.TabIndex = 4;
            colorsAmountTrackBar.TickFrequency = 14;
            colorsAmountTrackBar.Value = 64;
            colorsAmountTrackBar.Scroll += colorsAmountTrackBar_Scroll;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(65, 12);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(101, 28);
            loadImageButton.TabIndex = 1;
            loadImageButton.Text = "Load image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // saveImageButton
            // 
            saveImageButton.Location = new Point(218, 12);
            saveImageButton.Name = "saveImageButton";
            saveImageButton.Size = new Size(101, 28);
            saveImageButton.TabIndex = 2;
            saveImageButton.Text = "Save image";
            saveImageButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(propagationOfUncertaintyPictureBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1132, 298);
            splitContainer2.SplitterDistance = 375;
            splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(333, 21);
            label1.TabIndex = 1;
            label1.Text = "Reduced using propagation of uncertainty";
            // 
            // propagationOfUncertaintyPictureBox
            // 
            propagationOfUncertaintyPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            propagationOfUncertaintyPictureBox.Location = new Point(12, 47);
            propagationOfUncertaintyPictureBox.Name = "propagationOfUncertaintyPictureBox";
            propagationOfUncertaintyPictureBox.Size = new Size(352, 239);
            propagationOfUncertaintyPictureBox.TabIndex = 0;
            propagationOfUncertaintyPictureBox.TabStop = false;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.Fixed3D;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label2);
            splitContainer3.Panel1.Controls.Add(popularityAlgorithmPictureBox);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(label3);
            splitContainer3.Panel2.Controls.Add(kMeansAlgorithmPictureBox);
            splitContainer3.Size = new Size(753, 298);
            splitContainer3.SplitterDistance = 376;
            splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(45, 10);
            label2.Name = "label2";
            label2.Size = new Size(286, 21);
            label2.TabIndex = 2;
            label2.Text = "Reduced using popularity algorithm";
            // 
            // popularityAlgorithmPictureBox
            // 
            popularityAlgorithmPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            popularityAlgorithmPictureBox.Location = new Point(12, 47);
            popularityAlgorithmPictureBox.Name = "popularityAlgorithmPictureBox";
            popularityAlgorithmPictureBox.Size = new Size(352, 239);
            popularityAlgorithmPictureBox.TabIndex = 1;
            popularityAlgorithmPictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(61, 10);
            label3.Name = "label3";
            label3.Size = new Size(270, 21);
            label3.TabIndex = 3;
            label3.Text = "Reduced using k-means algorithm";
            // 
            // kMeansAlgorithmPictureBox
            // 
            kMeansAlgorithmPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kMeansAlgorithmPictureBox.Location = new Point(8, 47);
            kMeansAlgorithmPictureBox.Name = "kMeansAlgorithmPictureBox";
            kMeansAlgorithmPictureBox.Size = new Size(352, 239);
            kMeansAlgorithmPictureBox.TabIndex = 2;
            kMeansAlgorithmPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 647);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1148, 686);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueScaleTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenScaleTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)redScaleTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxIterationsTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)epsilonTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorsAmountTrackBar).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)propagationOfUncertaintyPictureBox).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)popularityAlgorithmPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kMeansAlgorithmPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private PictureBox mainPictureBox;
        private PictureBox propagationOfUncertaintyPictureBox;
        private PictureBox popularityAlgorithmPictureBox;
        private PictureBox kMeansAlgorithmPictureBox;
        private Button saveImageButton;
        private Button loadImageButton;
        private TrackBar colorsAmountTrackBar;
        private Button clusterImageButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label colorAmountLabel;
        private Label label6;
        private Label label8;
        private Label epsilonValueLabel;
        private Label label7;
        private TrackBar epsilonTrackBar;
        private Label label5;
        private Label maxIterationsValueLabel;
        private TrackBar maxIterationsTrackbar;
        private Label label9;
        private Label greenScaleLabel;
        private TrackBar greenScaleTrackBar;
        private Label label11;
        private Label redScaleLabel;
        private Label label13;
        private TrackBar redScaleTrackBar;
        private Label totalScaleLabel;
        private Label label10;
        private Label blueScaleLabel;
        private TrackBar blueScaleTrackBar;
    }
}
