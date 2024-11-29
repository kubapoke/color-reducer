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
            clusterImageButton = new Button();
            mainPictureBox = new PictureBox();
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
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
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
            splitContainer4.Panel1.Controls.Add(clusterImageButton);
            splitContainer4.Panel1.Controls.Add(mainPictureBox);
            splitContainer4.Panel1.Controls.Add(colorsAmountTrackBar);
            splitContainer4.Panel1.Controls.Add(loadImageButton);
            splitContainer4.Panel1.Controls.Add(saveImageButton);
            splitContainer4.Size = new Size(1132, 345);
            splitContainer4.SplitterDistance = 756;
            splitContainer4.TabIndex = 0;
            // 
            // clusterImageButton
            // 
            clusterImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clusterImageButton.Location = new Point(570, 309);
            clusterImageButton.Name = "clusterImageButton";
            clusterImageButton.Size = new Size(169, 28);
            clusterImageButton.TabIndex = 3;
            clusterImageButton.Text = "Cluster image to 16 colors";
            clusterImageButton.UseVisualStyleBackColor = true;
            clusterImageButton.Click += clusterImageButton_Click;
            // 
            // mainPictureBox
            // 
            mainPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPictureBox.BackColor = SystemColors.Control;
            mainPictureBox.Location = new Point(12, 12);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(727, 280);
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;
            // 
            // colorsAmountTrackBar
            // 
            colorsAmountTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            colorsAmountTrackBar.Location = new Point(236, 298);
            colorsAmountTrackBar.Maximum = 256;
            colorsAmountTrackBar.Minimum = 2;
            colorsAmountTrackBar.Name = "colorsAmountTrackBar";
            colorsAmountTrackBar.Size = new Size(328, 45);
            colorsAmountTrackBar.TabIndex = 4;
            colorsAmountTrackBar.TickFrequency = 14;
            colorsAmountTrackBar.Value = 16;
            colorsAmountTrackBar.Scroll += colorsAmountTrackBar_Scroll;
            // 
            // loadImageButton
            // 
            loadImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            loadImageButton.Location = new Point(12, 309);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(101, 28);
            loadImageButton.TabIndex = 1;
            loadImageButton.Text = "Load image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // saveImageButton
            // 
            saveImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveImageButton.Location = new Point(129, 309);
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
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(339, 21);
            label1.TabIndex = 1;
            label1.Text = "Reducing using propagation of uncertainty";
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
            label2.Location = new Point(44, 10);
            label2.Name = "label2";
            label2.Size = new Size(292, 21);
            label2.TabIndex = 2;
            label2.Text = "Reducing using popularity algorithm";
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
            label3.Location = new Point(44, 10);
            label3.Name = "label3";
            label3.Size = new Size(276, 21);
            label3.TabIndex = 3;
            label3.Text = "Reducing using k-means algorithm";
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
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
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
    }
}
