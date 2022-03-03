namespace Part_3___Chapter_Problem
{
    partial class BasicInput
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHight = new System.Windows.Forms.Label();
            this.lblMeasurement = new System.Windows.Forms.Label();
            this.numup1 = new System.Windows.Forms.NumericUpDown();
            this.lblOutput = new System.Windows.Forms.RichTextBox();
            this.txtHight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numup1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(12, 125);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(276, 82);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Click me";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 29);
            this.txtName.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 39);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(134, 24);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Enter your age";
            // 
            // lblHight
            // 
            this.lblHight.AutoSize = true;
            this.lblHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHight.Location = new System.Drawing.Point(12, 74);
            this.lblHight.Name = "lblHight";
            this.lblHight.Size = new System.Drawing.Size(143, 24);
            this.lblHight.TabIndex = 5;
            this.lblHight.Text = "Enter your hight";
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.AutoSize = true;
            this.lblMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasurement.Location = new System.Drawing.Point(33, 98);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(99, 24);
            this.lblMeasurement.TabIndex = 6;
            this.lblMeasurement.Text = "(In Meters)";
            // 
            // numup1
            // 
            this.numup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numup1.Location = new System.Drawing.Point(168, 39);
            this.numup1.Name = "numup1";
            this.numup1.Size = new System.Drawing.Size(120, 29);
            this.numup1.TabIndex = 10;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 213);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(276, 77);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "";
            // 
            // txtHight
            // 
            this.txtHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHight.Location = new System.Drawing.Point(168, 74);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(120, 29);
            this.txtHight.TabIndex = 7;
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 307);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.numup1);
            this.Controls.Add(this.txtHight);
            this.Controls.Add(this.lblMeasurement);
            this.Controls.Add(this.lblHight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCompute);
            this.Name = "BasicInput";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHight;
        private System.Windows.Forms.Label lblMeasurement;
        private System.Windows.Forms.NumericUpDown numup1;
        private System.Windows.Forms.RichTextBox lblOutput;
        private System.Windows.Forms.TextBox txtHight;
    }
}

