namespace AdapterPatternV2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_avgAccV1 = new System.Windows.Forms.TextBox();
            this.txtBox_fallAccV = new System.Windows.Forms.TextBox();
            this.txtBox_vertDistV = new System.Windows.Forms.TextBox();
            this.txtBox_horzDistV = new System.Windows.Forms.TextBox();
            this.txtBox_vertVelV = new System.Windows.Forms.TextBox();
            this.txtBox_avgAccT = new System.Windows.Forms.TextBox();
            this.txtBox_vertVelT = new System.Windows.Forms.TextBox();
            this.txtBox_horzDistT = new System.Windows.Forms.TextBox();
            this.txtBox_vertDistT = new System.Windows.Forms.TextBox();
            this.txtBox_fallAccT = new System.Windows.Forms.TextBox();
            this.txtBox_avgAccV2 = new System.Windows.Forms.TextBox();
            this.lbl_projVertVelOut = new System.Windows.Forms.Label();
            this.lbl_projHorzDistOut = new System.Windows.Forms.Label();
            this.lbl_projVertDistOut = new System.Windows.Forms.Label();
            this.lbl_fallAccOut = new System.Windows.Forms.Label();
            this.lbl_avgAccOut = new System.Windows.Forms.Label();
            this.btn_compute = new System.Windows.Forms.Button();
            this.btn_computeImperial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Acceleration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Falling Accelertion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Projectile Vertical Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projectile Horizontal Distance: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Projectile Vertical Velocity: ";
            // 
            // txtBox_avgAccV1
            // 
            this.txtBox_avgAccV1.Location = new System.Drawing.Point(242, 6);
            this.txtBox_avgAccV1.Name = "txtBox_avgAccV1";
            this.txtBox_avgAccV1.Size = new System.Drawing.Size(100, 26);
            this.txtBox_avgAccV1.TabIndex = 5;
            this.txtBox_avgAccV1.Text = "100";
            // 
            // txtBox_fallAccV
            // 
            this.txtBox_fallAccV.Location = new System.Drawing.Point(242, 43);
            this.txtBox_fallAccV.Name = "txtBox_fallAccV";
            this.txtBox_fallAccV.Size = new System.Drawing.Size(100, 26);
            this.txtBox_fallAccV.TabIndex = 6;
            this.txtBox_fallAccV.Text = "100";
            // 
            // txtBox_vertDistV
            // 
            this.txtBox_vertDistV.Location = new System.Drawing.Point(242, 80);
            this.txtBox_vertDistV.Name = "txtBox_vertDistV";
            this.txtBox_vertDistV.Size = new System.Drawing.Size(100, 26);
            this.txtBox_vertDistV.TabIndex = 7;
            this.txtBox_vertDistV.Text = "100";
            // 
            // txtBox_horzDistV
            // 
            this.txtBox_horzDistV.Location = new System.Drawing.Point(242, 117);
            this.txtBox_horzDistV.Name = "txtBox_horzDistV";
            this.txtBox_horzDistV.Size = new System.Drawing.Size(100, 26);
            this.txtBox_horzDistV.TabIndex = 8;
            this.txtBox_horzDistV.Text = "100";
            // 
            // txtBox_vertVelV
            // 
            this.txtBox_vertVelV.Location = new System.Drawing.Point(242, 154);
            this.txtBox_vertVelV.Name = "txtBox_vertVelV";
            this.txtBox_vertVelV.Size = new System.Drawing.Size(100, 26);
            this.txtBox_vertVelV.TabIndex = 9;
            this.txtBox_vertVelV.Text = "100";
            // 
            // txtBox_avgAccT
            // 
            this.txtBox_avgAccT.Location = new System.Drawing.Point(454, 6);
            this.txtBox_avgAccT.Name = "txtBox_avgAccT";
            this.txtBox_avgAccT.Size = new System.Drawing.Size(100, 26);
            this.txtBox_avgAccT.TabIndex = 10;
            this.txtBox_avgAccT.Text = "4";
            // 
            // txtBox_vertVelT
            // 
            this.txtBox_vertVelT.Location = new System.Drawing.Point(454, 153);
            this.txtBox_vertVelT.Name = "txtBox_vertVelT";
            this.txtBox_vertVelT.Size = new System.Drawing.Size(100, 26);
            this.txtBox_vertVelT.TabIndex = 15;
            this.txtBox_vertVelT.Text = "4";
            // 
            // txtBox_horzDistT
            // 
            this.txtBox_horzDistT.Location = new System.Drawing.Point(454, 116);
            this.txtBox_horzDistT.Name = "txtBox_horzDistT";
            this.txtBox_horzDistT.Size = new System.Drawing.Size(100, 26);
            this.txtBox_horzDistT.TabIndex = 14;
            this.txtBox_horzDistT.Text = "4";
            // 
            // txtBox_vertDistT
            // 
            this.txtBox_vertDistT.Location = new System.Drawing.Point(454, 79);
            this.txtBox_vertDistT.Name = "txtBox_vertDistT";
            this.txtBox_vertDistT.Size = new System.Drawing.Size(100, 26);
            this.txtBox_vertDistT.TabIndex = 13;
            this.txtBox_vertDistT.Text = "4";
            // 
            // txtBox_fallAccT
            // 
            this.txtBox_fallAccT.Location = new System.Drawing.Point(454, 42);
            this.txtBox_fallAccT.Name = "txtBox_fallAccT";
            this.txtBox_fallAccT.Size = new System.Drawing.Size(100, 26);
            this.txtBox_fallAccT.TabIndex = 12;
            this.txtBox_fallAccT.Text = "4";
            // 
            // txtBox_avgAccV2
            // 
            this.txtBox_avgAccV2.Location = new System.Drawing.Point(348, 6);
            this.txtBox_avgAccV2.Name = "txtBox_avgAccV2";
            this.txtBox_avgAccV2.Size = new System.Drawing.Size(100, 26);
            this.txtBox_avgAccV2.TabIndex = 11;
            this.txtBox_avgAccV2.Text = "12";
            // 
            // lbl_projVertVelOut
            // 
            this.lbl_projVertVelOut.AutoSize = true;
            this.lbl_projVertVelOut.Location = new System.Drawing.Point(560, 153);
            this.lbl_projVertVelOut.Name = "lbl_projVertVelOut";
            this.lbl_projVertVelOut.Size = new System.Drawing.Size(51, 20);
            this.lbl_projVertVelOut.TabIndex = 20;
            this.lbl_projVertVelOut.Text = "label6";
            // 
            // lbl_projHorzDistOut
            // 
            this.lbl_projHorzDistOut.AutoSize = true;
            this.lbl_projHorzDistOut.Location = new System.Drawing.Point(560, 117);
            this.lbl_projHorzDistOut.Name = "lbl_projHorzDistOut";
            this.lbl_projHorzDistOut.Size = new System.Drawing.Size(51, 20);
            this.lbl_projHorzDistOut.TabIndex = 19;
            this.lbl_projHorzDistOut.Text = "label7";
            // 
            // lbl_projVertDistOut
            // 
            this.lbl_projVertDistOut.AutoSize = true;
            this.lbl_projVertDistOut.Location = new System.Drawing.Point(560, 81);
            this.lbl_projVertDistOut.Name = "lbl_projVertDistOut";
            this.lbl_projVertDistOut.Size = new System.Drawing.Size(51, 20);
            this.lbl_projVertDistOut.TabIndex = 18;
            this.lbl_projVertDistOut.Text = "label8";
            // 
            // lbl_fallAccOut
            // 
            this.lbl_fallAccOut.AutoSize = true;
            this.lbl_fallAccOut.Location = new System.Drawing.Point(560, 45);
            this.lbl_fallAccOut.Name = "lbl_fallAccOut";
            this.lbl_fallAccOut.Size = new System.Drawing.Size(51, 20);
            this.lbl_fallAccOut.TabIndex = 17;
            this.lbl_fallAccOut.Text = "label9";
            // 
            // lbl_avgAccOut
            // 
            this.lbl_avgAccOut.AutoSize = true;
            this.lbl_avgAccOut.Location = new System.Drawing.Point(560, 9);
            this.lbl_avgAccOut.Name = "lbl_avgAccOut";
            this.lbl_avgAccOut.Size = new System.Drawing.Size(60, 20);
            this.lbl_avgAccOut.TabIndex = 16;
            this.lbl_avgAccOut.Text = "label10";
            // 
            // btn_compute
            // 
            this.btn_compute.Location = new System.Drawing.Point(16, 186);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(299, 90);
            this.btn_compute.TabIndex = 21;
            this.btn_compute.Text = "Compute Metric";
            this.btn_compute.UseVisualStyleBackColor = true;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // btn_computeImperial
            // 
            this.btn_computeImperial.Location = new System.Drawing.Point(321, 186);
            this.btn_computeImperial.Name = "btn_computeImperial";
            this.btn_computeImperial.Size = new System.Drawing.Size(299, 90);
            this.btn_computeImperial.TabIndex = 22;
            this.btn_computeImperial.Text = "Compute Imperial";
            this.btn_computeImperial.UseVisualStyleBackColor = true;
            this.btn_computeImperial.Click += new System.EventHandler(this.btn_computeImperial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 378);
            this.Controls.Add(this.btn_computeImperial);
            this.Controls.Add(this.btn_compute);
            this.Controls.Add(this.lbl_projVertVelOut);
            this.Controls.Add(this.lbl_projHorzDistOut);
            this.Controls.Add(this.lbl_projVertDistOut);
            this.Controls.Add(this.lbl_fallAccOut);
            this.Controls.Add(this.lbl_avgAccOut);
            this.Controls.Add(this.txtBox_vertVelT);
            this.Controls.Add(this.txtBox_horzDistT);
            this.Controls.Add(this.txtBox_vertDistT);
            this.Controls.Add(this.txtBox_fallAccT);
            this.Controls.Add(this.txtBox_avgAccV2);
            this.Controls.Add(this.txtBox_avgAccT);
            this.Controls.Add(this.txtBox_vertVelV);
            this.Controls.Add(this.txtBox_horzDistV);
            this.Controls.Add(this.txtBox_vertDistV);
            this.Controls.Add(this.txtBox_fallAccV);
            this.Controls.Add(this.txtBox_avgAccV1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_avgAccV1;
        private System.Windows.Forms.TextBox txtBox_fallAccV;
        private System.Windows.Forms.TextBox txtBox_vertDistV;
        private System.Windows.Forms.TextBox txtBox_horzDistV;
        private System.Windows.Forms.TextBox txtBox_vertVelV;
        private System.Windows.Forms.TextBox txtBox_avgAccT;
        private System.Windows.Forms.TextBox txtBox_vertVelT;
        private System.Windows.Forms.TextBox txtBox_horzDistT;
        private System.Windows.Forms.TextBox txtBox_vertDistT;
        private System.Windows.Forms.TextBox txtBox_fallAccT;
        private System.Windows.Forms.TextBox txtBox_avgAccV2;
        private System.Windows.Forms.Label lbl_projVertVelOut;
        private System.Windows.Forms.Label lbl_projHorzDistOut;
        private System.Windows.Forms.Label lbl_projVertDistOut;
        private System.Windows.Forms.Label lbl_fallAccOut;
        private System.Windows.Forms.Label lbl_avgAccOut;
        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.Button btn_computeImperial;
    }
}

