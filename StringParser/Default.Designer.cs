namespace StringParserApplication
{
    partial class StringParser
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.lblMethodOneTime = new System.Windows.Forms.Label();
            this.lblMethodTwoTime = new System.Windows.Forms.Label();
            this.lblMethodTwo = new System.Windows.Forms.Label();
            this.lblMethodOne = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnThree = new System.Windows.Forms.Button();
            this.lblMethodThree = new System.Windows.Forms.Label();
            this.lblMethodThreeTime = new System.Windows.Forms.Label();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            this.lblMethodOneAnswer = new System.Windows.Forms.Label();
            this.lblMethodTwoAnswer = new System.Windows.Forms.Label();
            this.lblMethodThreeAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(265, 151);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "Method 1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(265, 215);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "Method 2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // lblMethodOneTime
            // 
            this.lblMethodOneTime.AutoSize = true;
            this.lblMethodOneTime.Location = new System.Drawing.Point(262, 181);
            this.lblMethodOneTime.Name = "lblMethodOneTime";
            this.lblMethodOneTime.Size = new System.Drawing.Size(0, 13);
            this.lblMethodOneTime.TabIndex = 2;
            // 
            // lblMethodTwoTime
            // 
            this.lblMethodTwoTime.AutoSize = true;
            this.lblMethodTwoTime.Location = new System.Drawing.Point(262, 245);
            this.lblMethodTwoTime.Name = "lblMethodTwoTime";
            this.lblMethodTwoTime.Size = new System.Drawing.Size(0, 13);
            this.lblMethodTwoTime.TabIndex = 3;
            // 
            // lblMethodTwo
            // 
            this.lblMethodTwo.AutoSize = true;
            this.lblMethodTwo.Location = new System.Drawing.Point(161, 245);
            this.lblMethodTwo.Name = "lblMethodTwo";
            this.lblMethodTwo.Size = new System.Drawing.Size(89, 13);
            this.lblMethodTwo.TabIndex = 4;
            this.lblMethodTwo.Text = "Method Call Time";
            // 
            // lblMethodOne
            // 
            this.lblMethodOne.AutoSize = true;
            this.lblMethodOne.Location = new System.Drawing.Point(161, 181);
            this.lblMethodOne.Name = "lblMethodOne";
            this.lblMethodOne.Size = new System.Drawing.Size(89, 13);
            this.lblMethodOne.TabIndex = 5;
            this.lblMethodOne.Text = "Method Call Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 68);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "2, 5, 1, 7, 3, -63";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(13, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(67, 13);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Integer Array";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(36, 97);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(211, 13);
            this.lblDirections.TabIndex = 8;
            this.lblDirections.Text = "Please enter numbers using \",\" as  delimiter";
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(265, 282);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 23);
            this.btnThree.TabIndex = 9;
            this.btnThree.Text = "Method 3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // lblMethodThree
            // 
            this.lblMethodThree.AutoSize = true;
            this.lblMethodThree.Location = new System.Drawing.Point(161, 313);
            this.lblMethodThree.Name = "lblMethodThree";
            this.lblMethodThree.Size = new System.Drawing.Size(89, 13);
            this.lblMethodThree.TabIndex = 10;
            this.lblMethodThree.Text = "Method Call Time";
            // 
            // lblMethodThreeTime
            // 
            this.lblMethodThreeTime.AutoSize = true;
            this.lblMethodThreeTime.Location = new System.Drawing.Point(262, 313);
            this.lblMethodThreeTime.Name = "lblMethodThreeTime";
            this.lblMethodThreeTime.Size = new System.Drawing.Size(0, 13);
            this.lblMethodThreeTime.TabIndex = 11;
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.AutoSize = true;
            this.lblErrorOutput.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOutput.Location = new System.Drawing.Point(39, 130);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(0, 13);
            this.lblErrorOutput.TabIndex = 15;
            // 
            // lblMethodOneAnswer
            // 
            this.lblMethodOneAnswer.AutoSize = true;
            this.lblMethodOneAnswer.Location = new System.Drawing.Point(161, 156);
            this.lblMethodOneAnswer.Name = "lblMethodOneAnswer";
            this.lblMethodOneAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblMethodOneAnswer.TabIndex = 16;
            // 
            // lblMethodTwoAnswer
            // 
            this.lblMethodTwoAnswer.AutoSize = true;
            this.lblMethodTwoAnswer.Location = new System.Drawing.Point(161, 220);
            this.lblMethodTwoAnswer.Name = "lblMethodTwoAnswer";
            this.lblMethodTwoAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblMethodTwoAnswer.TabIndex = 17;
            // 
            // lblMethodThreeAnswer
            // 
            this.lblMethodThreeAnswer.AutoSize = true;
            this.lblMethodThreeAnswer.Location = new System.Drawing.Point(161, 287);
            this.lblMethodThreeAnswer.Name = "lblMethodThreeAnswer";
            this.lblMethodThreeAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblMethodThreeAnswer.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Method 1 Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Method 2 Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Method 3 Answer";
            // 
            // StringParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMethodThreeAnswer);
            this.Controls.Add(this.lblMethodTwoAnswer);
            this.Controls.Add(this.lblMethodOneAnswer);
            this.Controls.Add(this.lblErrorOutput);
            this.Controls.Add(this.lblMethodThreeTime);
            this.Controls.Add(this.lblMethodThree);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMethodOne);
            this.Controls.Add(this.lblMethodTwo);
            this.Controls.Add(this.lblMethodTwoTime);
            this.Controls.Add(this.lblMethodOneTime);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "StringParser";
            this.Text = "String Parser Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Label lblMethodOneTime;
        private System.Windows.Forms.Label lblMethodTwoTime;
        private System.Windows.Forms.Label lblMethodTwo;
        private System.Windows.Forms.Label lblMethodOne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Label lblMethodThree;
        private System.Windows.Forms.Label lblMethodThreeTime;
        private System.Windows.Forms.Label lblErrorOutput;
        private System.Windows.Forms.Label lblMethodOneAnswer;
        private System.Windows.Forms.Label lblMethodTwoAnswer;
        private System.Windows.Forms.Label lblMethodThreeAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

