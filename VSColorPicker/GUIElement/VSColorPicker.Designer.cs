namespace bhojarajsahu88.VSColorPicker.GUIElement
{
    partial class VSColorPicker
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
            this.components = new System.ComponentModel.Container();
            this.timerMousePosition = new System.Windows.Forms.Timer(this.components);
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBoxRGB = new System.Windows.Forms.GroupBox();
            this.textBoxBRI = new System.Windows.Forms.TextBox();
            this.labelBri = new System.Windows.Forms.Label();
            this.textBoxSAT = new System.Windows.Forms.TextBox();
            this.labelSat = new System.Windows.Forms.Label();
            this.textBoxHUE = new System.Windows.Forms.TextBox();
            this.labelHue = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.labelG = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHexaCopy = new System.Windows.Forms.Button();
            this.buttonRGBCopy = new System.Windows.Forms.Button();
            this.textBoxHexa = new System.Windows.Forms.TextBox();
            this.labelHEXA = new System.Windows.Forms.Label();
            this.textBoxRGB = new System.Windows.Forms.TextBox();
            this.labelRGB = new System.Windows.Forms.Label();
            this.linkLabelLazzyCoder = new System.Windows.Forms.LinkLabel();
            this.linkLabelFeedback = new System.Windows.Forms.LinkLabel();
            this.colorDialogColor = new System.Windows.Forms.ColorDialog();
            this.buttonColorBox = new System.Windows.Forms.Button();
            this.groupBoxRGB.SuspendLayout();
            this.groupBoxPosition.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMousePosition
            // 
            this.timerMousePosition.Enabled = true;
            this.timerMousePosition.Tick += new System.EventHandler(this.timerMousePosition_Tick);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(129, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Refresh";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // groupBoxRGB
            // 
            this.groupBoxRGB.Controls.Add(this.textBoxBRI);
            this.groupBoxRGB.Controls.Add(this.labelBri);
            this.groupBoxRGB.Controls.Add(this.textBoxSAT);
            this.groupBoxRGB.Controls.Add(this.labelSat);
            this.groupBoxRGB.Controls.Add(this.textBoxHUE);
            this.groupBoxRGB.Controls.Add(this.labelHue);
            this.groupBoxRGB.Controls.Add(this.textBoxB);
            this.groupBoxRGB.Controls.Add(this.labelB);
            this.groupBoxRGB.Controls.Add(this.textBoxG);
            this.groupBoxRGB.Controls.Add(this.labelG);
            this.groupBoxRGB.Controls.Add(this.textBoxR);
            this.groupBoxRGB.Controls.Add(this.labelR);
            this.groupBoxRGB.Location = new System.Drawing.Point(3, 141);
            this.groupBoxRGB.Name = "groupBoxRGB";
            this.groupBoxRGB.Size = new System.Drawing.Size(201, 109);
            this.groupBoxRGB.TabIndex = 1;
            this.groupBoxRGB.TabStop = false;
            // 
            // textBoxBRI
            // 
            this.textBoxBRI.Location = new System.Drawing.Point(123, 69);
            this.textBoxBRI.Name = "textBoxBRI";
            this.textBoxBRI.ReadOnly = true;
            this.textBoxBRI.Size = new System.Drawing.Size(27, 20);
            this.textBoxBRI.TabIndex = 19;
            this.textBoxBRI.Text = "000";
            // 
            // labelBri
            // 
            this.labelBri.AutoSize = true;
            this.labelBri.Location = new System.Drawing.Point(89, 72);
            this.labelBri.Name = "labelBri";
            this.labelBri.Size = new System.Drawing.Size(28, 13);
            this.labelBri.TabIndex = 18;
            this.labelBri.Text = "BRI:";
            // 
            // textBoxSAT
            // 
            this.textBoxSAT.Location = new System.Drawing.Point(123, 47);
            this.textBoxSAT.Name = "textBoxSAT";
            this.textBoxSAT.ReadOnly = true;
            this.textBoxSAT.Size = new System.Drawing.Size(27, 20);
            this.textBoxSAT.TabIndex = 17;
            this.textBoxSAT.Text = "000";
            // 
            // labelSat
            // 
            this.labelSat.AutoSize = true;
            this.labelSat.Location = new System.Drawing.Point(89, 50);
            this.labelSat.Name = "labelSat";
            this.labelSat.Size = new System.Drawing.Size(31, 13);
            this.labelSat.TabIndex = 16;
            this.labelSat.Text = "SAT:";
            // 
            // textBoxHUE
            // 
            this.textBoxHUE.Location = new System.Drawing.Point(123, 25);
            this.textBoxHUE.Name = "textBoxHUE";
            this.textBoxHUE.ReadOnly = true;
            this.textBoxHUE.Size = new System.Drawing.Size(27, 20);
            this.textBoxHUE.TabIndex = 15;
            this.textBoxHUE.Text = "000";
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(89, 28);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(33, 13);
            this.labelHue.TabIndex = 14;
            this.labelHue.Text = "HUE:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(42, 69);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(32, 20);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.Text = "000";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(18, 72);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "B:";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(42, 47);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(32, 20);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.Text = "000";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(18, 50);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(18, 13);
            this.labelG.TabIndex = 2;
            this.labelG.Text = "G:";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(42, 25);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(32, 20);
            this.textBoxR.TabIndex = 1;
            this.textBoxR.Text = "000";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(18, 28);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(18, 13);
            this.labelR.TabIndex = 0;
            this.labelR.Text = "R:";
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.textBoxY);
            this.groupBoxPosition.Controls.Add(this.labelY);
            this.groupBoxPosition.Controls.Add(this.textBoxX);
            this.groupBoxPosition.Controls.Add(this.labelX);
            this.groupBoxPosition.Location = new System.Drawing.Point(3, 92);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(201, 49);
            this.groupBoxPosition.TabIndex = 20;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Enter += new System.EventHandler(this.groupBoxPosition_Enter);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(118, 17);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(32, 20);
            this.textBoxY.TabIndex = 7;
            this.textBoxY.Text = "000";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(94, 20);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(42, 17);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(32, 20);
            this.textBoxX.TabIndex = 5;
            this.textBoxX.Text = "000";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(18, 20);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X:";
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(3, 52);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(201, 36);
            this.panelColor.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHexaCopy);
            this.groupBox1.Controls.Add(this.buttonRGBCopy);
            this.groupBox1.Controls.Add(this.textBoxHexa);
            this.groupBox1.Controls.Add(this.labelHEXA);
            this.groupBox1.Controls.Add(this.textBoxRGB);
            this.groupBox1.Controls.Add(this.labelRGB);
            this.groupBox1.Location = new System.Drawing.Point(3, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 69);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // buttonHexaCopy
            // 
            this.buttonHexaCopy.Location = new System.Drawing.Point(150, 40);
            this.buttonHexaCopy.Name = "buttonHexaCopy";
            this.buttonHexaCopy.Size = new System.Drawing.Size(39, 23);
            this.buttonHexaCopy.TabIndex = 26;
            this.buttonHexaCopy.Text = "Copy";
            this.buttonHexaCopy.UseVisualStyleBackColor = true;
            this.buttonHexaCopy.Click += new System.EventHandler(this.buttonHexaCopy_Click);
            // 
            // buttonRGBCopy
            // 
            this.buttonRGBCopy.Location = new System.Drawing.Point(150, 15);
            this.buttonRGBCopy.Name = "buttonRGBCopy";
            this.buttonRGBCopy.Size = new System.Drawing.Size(39, 23);
            this.buttonRGBCopy.TabIndex = 25;
            this.buttonRGBCopy.Text = "Copy";
            this.buttonRGBCopy.UseVisualStyleBackColor = true;
            this.buttonRGBCopy.Click += new System.EventHandler(this.buttonRGBCopy_Click);
            // 
            // textBoxHexa
            // 
            this.textBoxHexa.Location = new System.Drawing.Point(51, 42);
            this.textBoxHexa.Name = "textBoxHexa";
            this.textBoxHexa.ReadOnly = true;
            this.textBoxHexa.Size = new System.Drawing.Size(93, 20);
            this.textBoxHexa.TabIndex = 7;
            this.textBoxHexa.Text = "000";
            // 
            // labelHEXA
            // 
            this.labelHEXA.AutoSize = true;
            this.labelHEXA.Location = new System.Drawing.Point(12, 45);
            this.labelHEXA.Name = "labelHEXA";
            this.labelHEXA.Size = new System.Drawing.Size(38, 13);
            this.labelHEXA.TabIndex = 6;
            this.labelHEXA.Text = "Hexa :";
            // 
            // textBoxRGB
            // 
            this.textBoxRGB.Location = new System.Drawing.Point(51, 17);
            this.textBoxRGB.Name = "textBoxRGB";
            this.textBoxRGB.ReadOnly = true;
            this.textBoxRGB.Size = new System.Drawing.Size(93, 20);
            this.textBoxRGB.TabIndex = 5;
            this.textBoxRGB.Text = "000";
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(12, 20);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(33, 13);
            this.labelRGB.TabIndex = 4;
            this.labelRGB.Text = "RGB:";
            // 
            // linkLabelLazzyCoder
            // 
            this.linkLabelLazzyCoder.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelLazzyCoder.AutoSize = true;
            this.linkLabelLazzyCoder.Location = new System.Drawing.Point(21, 325);
            this.linkLabelLazzyCoder.Name = "linkLabelLazzyCoder";
            this.linkLabelLazzyCoder.Size = new System.Drawing.Size(138, 13);
            this.linkLabelLazzyCoder.TabIndex = 22;
            this.linkLabelLazzyCoder.TabStop = true;
            this.linkLabelLazzyCoder.Text = "http://www.lazzycoder.com";
            this.linkLabelLazzyCoder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLazzyCoder_LinkClicked);
            // 
            // linkLabelFeedback
            // 
            this.linkLabelFeedback.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelFeedback.AutoSize = true;
            this.linkLabelFeedback.Location = new System.Drawing.Point(59, 343);
            this.linkLabelFeedback.Name = "linkLabelFeedback";
            this.linkLabelFeedback.Size = new System.Drawing.Size(55, 13);
            this.linkLabelFeedback.TabIndex = 23;
            this.linkLabelFeedback.TabStop = true;
            this.linkLabelFeedback.Text = "Feedback";
            this.linkLabelFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFeedback_LinkClicked);
            // 
            // buttonColorBox
            // 
            this.buttonColorBox.Location = new System.Drawing.Point(12, 12);
            this.buttonColorBox.Name = "buttonColorBox";
            this.buttonColorBox.Size = new System.Drawing.Size(75, 23);
            this.buttonColorBox.TabIndex = 24;
            this.buttonColorBox.Text = "Color Box";
            this.buttonColorBox.UseVisualStyleBackColor = true;
            this.buttonColorBox.Click += new System.EventHandler(this.buttonColorBox_Click);
            // 
            // VSColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 361);
            this.Controls.Add(this.buttonColorBox);
            this.Controls.Add(this.linkLabelFeedback);
            this.Controls.Add(this.linkLabelLazzyCoder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.groupBoxRGB);
            this.Controls.Add(this.buttonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(232, 395);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(232, 395);
            this.Name = "VSColorPicker";
            this.Text = "VSColorPicker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VSColorPicker_Load);
            this.groupBoxRGB.ResumeLayout(false);
            this.groupBoxRGB.PerformLayout();
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMousePosition;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.GroupBox groupBoxRGB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxHUE;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.TextBox textBoxBRI;
        private System.Windows.Forms.Label labelBri;
        private System.Windows.Forms.TextBox textBoxSAT;
        private System.Windows.Forms.Label labelSat;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHexa;
        private System.Windows.Forms.Label labelHEXA;
        private System.Windows.Forms.TextBox textBoxRGB;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.LinkLabel linkLabelLazzyCoder;
        private System.Windows.Forms.LinkLabel linkLabelFeedback;
        private System.Windows.Forms.ColorDialog colorDialogColor;
        private System.Windows.Forms.Button buttonColorBox;
        private System.Windows.Forms.Button buttonHexaCopy;
        private System.Windows.Forms.Button buttonRGBCopy;
    }
}