namespace ScratchText
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textImage = new System.Windows.Forms.TextBox();
            this.labelImageHeight = new System.Windows.Forms.Label();
            this.labelImageWidth = new System.Windows.Forms.Label();
            this.textMaxScratch = new System.Windows.Forms.TextBox();
            this.textMinScratch = new System.Windows.Forms.TextBox();
            this.textSpacing = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBottom = new System.Windows.Forms.RadioButton();
            this.radioCentre = new System.Windows.Forms.RadioButton();
            this.radioTop = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpen);
            this.splitContainer1.Panel1.Controls.Add(this.textImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelImageHeight);
            this.splitContainer1.Panel2.Controls.Add(this.labelImageWidth);
            this.splitContainer1.Panel2.Controls.Add(this.textMaxScratch);
            this.splitContainer1.Panel2.Controls.Add(this.textMinScratch);
            this.splitContainer1.Panel2.Controls.Add(this.textSpacing);
            this.splitContainer1.Panel2.Controls.Add(this.textHeight);
            this.splitContainer1.Panel2.Controls.Add(this.textWidth);
            this.splitContainer1.Panel2.Controls.Add(this.textFile);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.radioBottom);
            this.splitContainer1.Panel2.Controls.Add(this.radioCentre);
            this.splitContainer1.Panel2.Controls.Add(this.radioTop);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(537, 176);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(118, 48);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save Image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 48);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(86, 23);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Open Image";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(12, 12);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(192, 20);
            this.textImage.TabIndex = 7;
            this.textImage.Text = "Enter Image Text";
            // 
            // labelImageHeight
            // 
            this.labelImageHeight.AutoSize = true;
            this.labelImageHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageHeight.Location = new System.Drawing.Point(89, 65);
            this.labelImageHeight.Name = "labelImageHeight";
            this.labelImageHeight.Size = new System.Drawing.Size(77, 13);
            this.labelImageHeight.TabIndex = 19;
            this.labelImageHeight.Text = "IMGHEIGHT";
            // 
            // labelImageWidth
            // 
            this.labelImageWidth.AutoSize = true;
            this.labelImageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageWidth.Location = new System.Drawing.Point(89, 48);
            this.labelImageWidth.Name = "labelImageWidth";
            this.labelImageWidth.Size = new System.Drawing.Size(72, 13);
            this.labelImageWidth.TabIndex = 18;
            this.labelImageWidth.Text = "IMGWIDTH";
            // 
            // textMaxScratch
            // 
            this.textMaxScratch.Location = new System.Drawing.Point(253, 116);
            this.textMaxScratch.Name = "textMaxScratch";
            this.textMaxScratch.Size = new System.Drawing.Size(58, 20);
            this.textMaxScratch.TabIndex = 17;
            this.textMaxScratch.Text = "300";
            // 
            // textMinScratch
            // 
            this.textMinScratch.Location = new System.Drawing.Point(253, 94);
            this.textMinScratch.Name = "textMinScratch";
            this.textMinScratch.Size = new System.Drawing.Size(58, 20);
            this.textMinScratch.TabIndex = 16;
            this.textMinScratch.Text = "200";
            // 
            // textSpacing
            // 
            this.textSpacing.Location = new System.Drawing.Point(92, 140);
            this.textSpacing.Name = "textSpacing";
            this.textSpacing.Size = new System.Drawing.Size(62, 20);
            this.textSpacing.TabIndex = 15;
            this.textSpacing.Text = "20";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(92, 117);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(62, 20);
            this.textHeight.TabIndex = 14;
            this.textHeight.Text = "400";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(92, 95);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(62, 20);
            this.textWidth.TabIndex = 13;
            this.textWidth.Text = "200";
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(53, 15);
            this.textFile.Name = "textFile";
            this.textFile.ReadOnly = true;
            this.textFile.Size = new System.Drawing.Size(101, 20);
            this.textFile.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Maximum Scratch:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Minimum Scratch:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Letter Spacing:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Letter Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Letter Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Text Position";
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.Location = new System.Drawing.Point(253, 60);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(58, 17);
            this.radioBottom.TabIndex = 5;
            this.radioBottom.TabStop = true;
            this.radioBottom.Text = "Bottom";
            this.radioBottom.UseVisualStyleBackColor = true;
            this.radioBottom.CheckedChanged += new System.EventHandler(this.radioBottom_CheckedChanged);
            // 
            // radioCentre
            // 
            this.radioCentre.AutoSize = true;
            this.radioCentre.Location = new System.Drawing.Point(253, 37);
            this.radioCentre.Name = "radioCentre";
            this.radioCentre.Size = new System.Drawing.Size(56, 17);
            this.radioCentre.TabIndex = 4;
            this.radioCentre.TabStop = true;
            this.radioCentre.Text = "Centre";
            this.radioCentre.UseVisualStyleBackColor = true;
            this.radioCentre.CheckedChanged += new System.EventHandler(this.radioCentre_CheckedChanged);
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.Location = new System.Drawing.Point(253, 14);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(44, 17);
            this.radioTop.TabIndex = 3;
            this.radioTop.TabStop = true;
            this.radioTop.Text = "Top";
            this.radioTop.UseVisualStyleBackColor = true;
            this.radioTop.CheckedChanged += new System.EventHandler(this.radioTop_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 176);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScratchText";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBottom;
        private System.Windows.Forms.RadioButton radioCentre;
        private System.Windows.Forms.RadioButton radioTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaxScratch;
        private System.Windows.Forms.TextBox textMinScratch;
        private System.Windows.Forms.TextBox textSpacing;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label labelImageHeight;
        private System.Windows.Forms.Label labelImageWidth;
    }
}

