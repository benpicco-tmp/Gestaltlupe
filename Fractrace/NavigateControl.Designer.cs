﻿namespace Fractrace {
    partial class NavigateControl {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
          this.btnLeft = new System.Windows.Forms.Button();
          this.btnRight = new System.Windows.Forms.Button();
          this.btnTop = new System.Windows.Forms.Button();
          this.btnDown = new System.Windows.Forms.Button();
          this.btnForward = new System.Windows.Forms.Button();
          this.btnBackwards = new System.Windows.Forms.Button();
          this.btnZoomX = new System.Windows.Forms.Button();
          this.btnZoomY = new System.Windows.Forms.Button();
          this.btnZoomZ = new System.Windows.Forms.Button();
          this.button1 = new System.Windows.Forms.Button();
          this.btnZoomYout = new System.Windows.Forms.Button();
          this.btnZoomZout = new System.Windows.Forms.Button();
          this.textBox1 = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.tbZoomFactor = new System.Windows.Forms.TextBox();
          this.btnRotX = new System.Windows.Forms.Button();
          this.btnRotY = new System.Windows.Forms.Button();
          this.btnRotZ = new System.Windows.Forms.Button();
          this.btnRotZneg = new System.Windows.Forms.Button();
          this.btnRotYneg = new System.Windows.Forms.Button();
          this.btnRotXneg = new System.Windows.Forms.Button();
          this.label3 = new System.Windows.Forms.Label();
          this.tbAngle = new System.Windows.Forms.TextBox();
          this.btnAllAngles0 = new System.Windows.Forms.Button();
          this.btnZoomIn = new System.Windows.Forms.Button();
          this.btnZoomOut = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // btnLeft
          // 
          this.btnLeft.Location = new System.Drawing.Point(58, 76);
          this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnLeft.Name = "btnLeft";
          this.btnLeft.Size = new System.Drawing.Size(28, 25);
          this.btnLeft.TabIndex = 0;
          this.btnLeft.Text = "<-";
          this.btnLeft.UseVisualStyleBackColor = true;
          this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
          // 
          // btnRight
          // 
          this.btnRight.Location = new System.Drawing.Point(113, 77);
          this.btnRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRight.Name = "btnRight";
          this.btnRight.Size = new System.Drawing.Size(25, 24);
          this.btnRight.TabIndex = 1;
          this.btnRight.Text = "->";
          this.btnRight.UseVisualStyleBackColor = true;
          this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
          // 
          // btnTop
          // 
          this.btnTop.Location = new System.Drawing.Point(88, 35);
          this.btnTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnTop.Name = "btnTop";
          this.btnTop.Size = new System.Drawing.Size(23, 37);
          this.btnTop.TabIndex = 2;
          this.btnTop.Text = "/\\  |";
          this.btnTop.UseVisualStyleBackColor = true;
          this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
          // 
          // btnDown
          // 
          this.btnDown.Location = new System.Drawing.Point(88, 102);
          this.btnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnDown.Name = "btnDown";
          this.btnDown.Size = new System.Drawing.Size(23, 45);
          this.btnDown.TabIndex = 3;
          this.btnDown.Text = "|   \\/";
          this.btnDown.UseVisualStyleBackColor = true;
          this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
          // 
          // btnForward
          // 
          this.btnForward.Location = new System.Drawing.Point(17, 34);
          this.btnForward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnForward.Name = "btnForward";
          this.btnForward.Size = new System.Drawing.Size(44, 28);
          this.btnForward.TabIndex = 4;
          this.btnForward.Text = ">  <";
          this.btnForward.UseVisualStyleBackColor = true;
          this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
          // 
          // btnBackwards
          // 
          this.btnBackwards.Location = new System.Drawing.Point(143, 37);
          this.btnBackwards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnBackwards.Name = "btnBackwards";
          this.btnBackwards.Size = new System.Drawing.Size(44, 24);
          this.btnBackwards.TabIndex = 5;
          this.btnBackwards.Text = "< >";
          this.btnBackwards.UseVisualStyleBackColor = true;
          this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
          // 
          // btnZoomX
          // 
          this.btnZoomX.Location = new System.Drawing.Point(9, 157);
          this.btnZoomX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnZoomX.Name = "btnZoomX";
          this.btnZoomX.Size = new System.Drawing.Size(52, 23);
          this.btnZoomX.TabIndex = 6;
          this.btnZoomX.Text = "ZoomX";
          this.btnZoomX.UseVisualStyleBackColor = true;
          this.btnZoomX.Click += new System.EventHandler(this.btnZoomX_Click);
          // 
          // btnZoomY
          // 
          this.btnZoomY.Location = new System.Drawing.Point(73, 157);
          this.btnZoomY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnZoomY.Name = "btnZoomY";
          this.btnZoomY.Size = new System.Drawing.Size(52, 23);
          this.btnZoomY.TabIndex = 7;
          this.btnZoomY.Text = "ZoomY";
          this.btnZoomY.UseVisualStyleBackColor = true;
          this.btnZoomY.Click += new System.EventHandler(this.btnZoomY_Click);
          // 
          // btnZoomZ
          // 
          this.btnZoomZ.Location = new System.Drawing.Point(136, 157);
          this.btnZoomZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnZoomZ.Name = "btnZoomZ";
          this.btnZoomZ.Size = new System.Drawing.Size(52, 22);
          this.btnZoomZ.TabIndex = 8;
          this.btnZoomZ.Text = "ZoomZ";
          this.btnZoomZ.UseVisualStyleBackColor = true;
          this.btnZoomZ.Click += new System.EventHandler(this.btnZoomZ_Click);
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(9, 193);
          this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(76, 19);
          this.button1.TabIndex = 9;
          this.button1.Text = "ZoomXOut";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // btnZoomYout
          // 
          this.btnZoomYout.Location = new System.Drawing.Point(90, 193);
          this.btnZoomYout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnZoomYout.Name = "btnZoomYout";
          this.btnZoomYout.Size = new System.Drawing.Size(76, 19);
          this.btnZoomYout.TabIndex = 10;
          this.btnZoomYout.Text = "ZoomYOut";
          this.btnZoomYout.UseVisualStyleBackColor = true;
          this.btnZoomYout.Click += new System.EventHandler(this.btnZoomYout_Click);
          // 
          // btnZoomZout
          // 
          this.btnZoomZout.Location = new System.Drawing.Point(177, 193);
          this.btnZoomZout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnZoomZout.Name = "btnZoomZout";
          this.btnZoomZout.Size = new System.Drawing.Size(68, 18);
          this.btnZoomZout.TabIndex = 11;
          this.btnZoomZout.Text = "ZoomZout";
          this.btnZoomZout.UseVisualStyleBackColor = true;
          this.btnZoomZout.Click += new System.EventHandler(this.btnZoomZout_Click);
          // 
          // textBox1
          // 
          this.textBox1.Location = new System.Drawing.Point(243, 77);
          this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.textBox1.Name = "textBox1";
          this.textBox1.Size = new System.Drawing.Size(55, 20);
          this.textBox1.TabIndex = 12;
          this.textBox1.Text = "6";
          this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(197, 77);
          this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(34, 13);
          this.label1.TabIndex = 13;
          this.label1.Text = "factor";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(231, 162);
          this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(34, 13);
          this.label2.TabIndex = 14;
          this.label2.Text = "factor";
          // 
          // tbZoomFactor
          // 
          this.tbZoomFactor.Location = new System.Drawing.Point(268, 161);
          this.tbZoomFactor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.tbZoomFactor.Name = "tbZoomFactor";
          this.tbZoomFactor.Size = new System.Drawing.Size(55, 20);
          this.tbZoomFactor.TabIndex = 15;
          this.tbZoomFactor.Text = "6";
          this.tbZoomFactor.TextChanged += new System.EventHandler(this.tbZoomFactor_TextChanged);
          // 
          // btnRotX
          // 
          this.btnRotX.Location = new System.Drawing.Point(13, 223);
          this.btnRotX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRotX.Name = "btnRotX";
          this.btnRotX.Size = new System.Drawing.Size(49, 19);
          this.btnRotX.TabIndex = 16;
          this.btnRotX.Text = "RotX+";
          this.btnRotX.UseVisualStyleBackColor = true;
          this.btnRotX.Click += new System.EventHandler(this.btnRotX_Click);
          // 
          // btnRotY
          // 
          this.btnRotY.Location = new System.Drawing.Point(66, 223);
          this.btnRotY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRotY.Name = "btnRotY";
          this.btnRotY.Size = new System.Drawing.Size(49, 19);
          this.btnRotY.TabIndex = 17;
          this.btnRotY.Text = "RotY+";
          this.btnRotY.UseVisualStyleBackColor = true;
          this.btnRotY.Click += new System.EventHandler(this.btnRotY_Click);
          // 
          // btnRotZ
          // 
          this.btnRotZ.Location = new System.Drawing.Point(119, 223);
          this.btnRotZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRotZ.Name = "btnRotZ";
          this.btnRotZ.Size = new System.Drawing.Size(49, 19);
          this.btnRotZ.TabIndex = 18;
          this.btnRotZ.Text = "RotZ+";
          this.btnRotZ.UseVisualStyleBackColor = true;
          this.btnRotZ.Click += new System.EventHandler(this.btnRotZ_Click);
          // 
          // btnRotZneg
          // 
          this.btnRotZneg.Location = new System.Drawing.Point(119, 246);
          this.btnRotZneg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRotZneg.Name = "btnRotZneg";
          this.btnRotZneg.Size = new System.Drawing.Size(49, 19);
          this.btnRotZneg.TabIndex = 21;
          this.btnRotZneg.Text = "RotZ-";
          this.btnRotZneg.UseVisualStyleBackColor = true;
          this.btnRotZneg.Click += new System.EventHandler(this.btnRotZneg_Click);
          // 
          // btnRotYneg
          // 
          this.btnRotYneg.Location = new System.Drawing.Point(66, 247);
          this.btnRotYneg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRotYneg.Name = "btnRotYneg";
          this.btnRotYneg.Size = new System.Drawing.Size(49, 19);
          this.btnRotYneg.TabIndex = 20;
          this.btnRotYneg.Text = "RotY-";
          this.btnRotYneg.UseVisualStyleBackColor = true;
          this.btnRotYneg.Click += new System.EventHandler(this.btnRotYneg_Click);
          // 
          // btnRotXneg
          // 
          this.btnRotXneg.Location = new System.Drawing.Point(13, 247);
          this.btnRotXneg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnRotXneg.Name = "btnRotXneg";
          this.btnRotXneg.Size = new System.Drawing.Size(49, 19);
          this.btnRotXneg.TabIndex = 19;
          this.btnRotXneg.Text = "RotX-";
          this.btnRotXneg.UseVisualStyleBackColor = true;
          this.btnRotXneg.Click += new System.EventHandler(this.button4_Click);
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(231, 233);
          this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(34, 13);
          this.label3.TabIndex = 22;
          this.label3.Text = "Angle";
          // 
          // tbAngle
          // 
          this.tbAngle.Location = new System.Drawing.Point(268, 233);
          this.tbAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.tbAngle.Name = "tbAngle";
          this.tbAngle.Size = new System.Drawing.Size(55, 20);
          this.tbAngle.TabIndex = 23;
          this.tbAngle.Text = "1";
          this.tbAngle.TextChanged += new System.EventHandler(this.tbAngle_TextChanged);
          // 
          // btnAllAngles0
          // 
          this.btnAllAngles0.Location = new System.Drawing.Point(179, 225);
          this.btnAllAngles0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.btnAllAngles0.Name = "btnAllAngles0";
          this.btnAllAngles0.Size = new System.Drawing.Size(53, 35);
          this.btnAllAngles0.TabIndex = 24;
          this.btnAllAngles0.Text = "All Angles 0";
          this.btnAllAngles0.UseVisualStyleBackColor = true;
          this.btnAllAngles0.Click += new System.EventHandler(this.btnAllAngles0_Click);
          // 
          // btnZoomIn
          // 
          this.btnZoomIn.Location = new System.Drawing.Point(26, 117);
          this.btnZoomIn.Name = "btnZoomIn";
          this.btnZoomIn.Size = new System.Drawing.Size(32, 29);
          this.btnZoomIn.TabIndex = 25;
          this.btnZoomIn.Text = "+";
          this.btnZoomIn.UseVisualStyleBackColor = true;
          this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
          // 
          // btnZoomOut
          // 
          this.btnZoomOut.Location = new System.Drawing.Point(146, 118);
          this.btnZoomOut.Name = "btnZoomOut";
          this.btnZoomOut.Size = new System.Drawing.Size(33, 27);
          this.btnZoomOut.TabIndex = 26;
          this.btnZoomOut.Text = "-";
          this.btnZoomOut.UseVisualStyleBackColor = true;
          this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
          // 
          // NavigateControl
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.Controls.Add(this.btnZoomOut);
          this.Controls.Add(this.btnZoomIn);
          this.Controls.Add(this.btnAllAngles0);
          this.Controls.Add(this.tbAngle);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.btnRotZneg);
          this.Controls.Add(this.btnRotYneg);
          this.Controls.Add(this.btnRotXneg);
          this.Controls.Add(this.btnRotZ);
          this.Controls.Add(this.btnRotY);
          this.Controls.Add(this.btnRotX);
          this.Controls.Add(this.tbZoomFactor);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.textBox1);
          this.Controls.Add(this.btnZoomZout);
          this.Controls.Add(this.btnZoomYout);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.btnZoomZ);
          this.Controls.Add(this.btnZoomY);
          this.Controls.Add(this.btnZoomX);
          this.Controls.Add(this.btnBackwards);
          this.Controls.Add(this.btnForward);
          this.Controls.Add(this.btnDown);
          this.Controls.Add(this.btnTop);
          this.Controls.Add(this.btnRight);
          this.Controls.Add(this.btnLeft);
          this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
          this.Name = "NavigateControl";
          this.Size = new System.Drawing.Size(326, 268);
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackwards;
        private System.Windows.Forms.Button btnZoomX;
        private System.Windows.Forms.Button btnZoomY;
        private System.Windows.Forms.Button btnZoomZ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnZoomYout;
        private System.Windows.Forms.Button btnZoomZout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZoomFactor;
        private System.Windows.Forms.Button btnRotX;
        private System.Windows.Forms.Button btnRotY;
        private System.Windows.Forms.Button btnRotZ;
        private System.Windows.Forms.Button btnRotZneg;
        private System.Windows.Forms.Button btnRotYneg;
        private System.Windows.Forms.Button btnRotXneg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Button btnAllAngles0;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
    }
}
