namespace WinFormsApp5
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
            numInp = new TextBox();
            appName = new Label();
            lblOut = new Label();
            btnCal = new Button();
            SuspendLayout();
            // 
            // numInp
            // 
            numInp.Location = new Point(27, 66);
            numInp.Name = "numInp";
            numInp.Size = new Size(156, 27);
            numInp.TabIndex = 0;
            numInp.TextChanged += numInp_TextChanged;
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.Location = new Point(27, 34);
            appName.Name = "appName";
            appName.Size = new Size(156, 20);
            appName.TabIndex = 1;
            appName.Text = "Factorial of a Number:";
            // 
            // lblOut
            // 
            lblOut.AutoSize = true;
            lblOut.Location = new Point(27, 110);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(0, 20);
            lblOut.TabIndex = 2;
            lblOut.Click += lblOut_Click;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(27, 151);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(81, 29);
            btnCal.TabIndex = 3;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCal);
            Controls.Add(lblOut);
            Controls.Add(appName);
            Controls.Add(numInp);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numInp;
        private Label appName;
        private Label lblOut;
        private Button btnCal;
    }
}
