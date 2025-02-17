﻿
namespace QuestEyes_Server
{
    partial class DiagnosticsPanel
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
            this.rightX = new System.Windows.Forms.Label();
            this.rightY = new System.Windows.Forms.Label();
            this.leftX = new System.Windows.Forms.Label();
            this.leftY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decodeErrorMessage = new System.Windows.Forms.Label();
            this.truepic = new System.Windows.Forms.PictureBox();
            this.leftImage = new System.Windows.Forms.PictureBox();
            this.rightImage = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.truepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rightX
            // 
            this.rightX.AutoSize = true;
            this.rightX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightX.ForeColor = System.Drawing.SystemColors.Control;
            this.rightX.Location = new System.Drawing.Point(419, 358);
            this.rightX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightX.Name = "rightX";
            this.rightX.Size = new System.Drawing.Size(114, 13);
            this.rightX.TabIndex = 17;
            this.rightX.Text = "Right eye X: Unknown";
            // 
            // rightY
            // 
            this.rightY.AutoSize = true;
            this.rightY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightY.ForeColor = System.Drawing.SystemColors.Control;
            this.rightY.Location = new System.Drawing.Point(419, 342);
            this.rightY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightY.Name = "rightY";
            this.rightY.Size = new System.Drawing.Size(114, 13);
            this.rightY.TabIndex = 16;
            this.rightY.Text = "Right eye Y: Unknown";
            // 
            // leftX
            // 
            this.leftX.AutoSize = true;
            this.leftX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftX.ForeColor = System.Drawing.SystemColors.Control;
            this.leftX.Location = new System.Drawing.Point(273, 358);
            this.leftX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftX.Name = "leftX";
            this.leftX.Size = new System.Drawing.Size(107, 13);
            this.leftX.TabIndex = 15;
            this.leftX.Text = "Left eye X: Unknown";
            // 
            // leftY
            // 
            this.leftY.AutoSize = true;
            this.leftY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftY.ForeColor = System.Drawing.SystemColors.Control;
            this.leftY.Location = new System.Drawing.Point(273, 342);
            this.leftY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftY.Name = "leftY";
            this.leftY.Size = new System.Drawing.Size(107, 13);
            this.leftY.TabIndex = 14;
            this.leftY.Text = "Left eye Y: Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(247, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Note: stream may have a slight delay while diagnostics are open";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decodeErrorMessage
            // 
            this.decodeErrorMessage.AutoSize = true;
            this.decodeErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.decodeErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decodeErrorMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decodeErrorMessage.Location = new System.Drawing.Point(339, 140);
            this.decodeErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodeErrorMessage.Name = "decodeErrorMessage";
            this.decodeErrorMessage.Size = new System.Drawing.Size(128, 26);
            this.decodeErrorMessage.TabIndex = 19;
            this.decodeErrorMessage.Text = "Could not decode stream.\r\nIs the device connected?\r\n";
            this.decodeErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // truepic
            // 
            this.truepic.BackColor = System.Drawing.SystemColors.Control;
            this.truepic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.truepic.Location = new System.Drawing.Point(14, 14);
            this.truepic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.truepic.Name = "truepic";
            this.truepic.Size = new System.Drawing.Size(778, 301);
            this.truepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.truepic.TabIndex = 21;
            this.truepic.TabStop = false;
            // 
            // leftImage
            // 
            this.leftImage.BackColor = System.Drawing.SystemColors.Control;
            this.leftImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftImage.Location = new System.Drawing.Point(77, 287);
            this.leftImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leftImage.Name = "leftImage";
            this.leftImage.Size = new System.Drawing.Size(140, 86);
            this.leftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftImage.TabIndex = 22;
            this.leftImage.TabStop = false;
            // 
            // rightImage
            // 
            this.rightImage.BackColor = System.Drawing.SystemColors.Control;
            this.rightImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightImage.Location = new System.Drawing.Point(582, 287);
            this.rightImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rightImage.Name = "rightImage";
            this.rightImage.Size = new System.Drawing.Size(140, 86);
            this.rightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightImage.TabIndex = 23;
            this.rightImage.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 414);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 414);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 23);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "65";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "cannyThreshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "circleAccumulatorThreshold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "maxRad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "minRadius";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(494, 414);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 23);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "100";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 414);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 23);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "1";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(635, 414);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 23);
            this.textBox5.TabIndex = 32;
            this.textBox5.Text = "17";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "blur";
            // 
            // DiagnosticsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(65)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rightImage);
            this.Controls.Add(this.leftImage);
            this.Controls.Add(this.decodeErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightX);
            this.Controls.Add(this.rightY);
            this.Controls.Add(this.leftX);
            this.Controls.Add(this.leftY);
            this.Controls.Add(this.truepic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "DiagnosticsPanel";
            this.Text = "QuestEyes Diagnostics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Diagnostics_FormClosing);
            this.Load += new System.EventHandler(this.Diagnostics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rightX;
        private System.Windows.Forms.Label rightY;
        private System.Windows.Forms.Label leftX;
        private System.Windows.Forms.Label leftY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label decodeErrorMessage;
        private System.Windows.Forms.PictureBox truepic;
        private System.Windows.Forms.PictureBox leftImage;
        private System.Windows.Forms.PictureBox rightImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
    }
}