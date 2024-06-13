namespace WinFormsApp2
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
            showBTN = new Button();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            showTP = new TabPage();
            testTP = new TabPage();
            testBTN = new Button();
            testRTB = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            showTP.SuspendLayout();
            testTP.SuspendLayout();
            SuspendLayout();
            // 
            // showBTN
            // 
            showBTN.Location = new Point(27, 19);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(130, 80);
            showBTN.TabIndex = 0;
            showBTN.Text = "show";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(413, 377);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 246);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(showTP);
            tabControl1.Controls.Add(testTP);
            tabControl1.Location = new Point(22, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1102, 675);
            tabControl1.TabIndex = 2;
            // 
            // showTP
            // 
            showTP.Controls.Add(showBTN);
            showTP.Controls.Add(pictureBox1);
            showTP.Location = new Point(4, 24);
            showTP.Name = "showTP";
            showTP.Padding = new Padding(3);
            showTP.Size = new Size(1094, 647);
            showTP.TabIndex = 0;
            showTP.Text = "show page";
            showTP.UseVisualStyleBackColor = true;
            // 
            // testTP
            // 
            testTP.Controls.Add(testRTB);
            testTP.Controls.Add(testBTN);
            testTP.Location = new Point(4, 24);
            testTP.Name = "testTP";
            testTP.Padding = new Padding(3);
            testTP.Size = new Size(1094, 647);
            testTP.TabIndex = 1;
            testTP.Text = "test page";
            testTP.UseVisualStyleBackColor = true;
            // 
            // testBTN
            // 
            testBTN.Location = new Point(26, 32);
            testBTN.Name = "testBTN";
            testBTN.Size = new Size(89, 47);
            testBTN.TabIndex = 0;
            testBTN.Text = "test";
            testBTN.UseVisualStyleBackColor = true;
            testBTN.Click += testBTN_Click;
            // 
            // testRTB
            // 
            testRTB.Location = new Point(183, 30);
            testRTB.Name = "testRTB";
            testRTB.Size = new Size(871, 522);
            testRTB.TabIndex = 1;
            testRTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 699);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            showTP.ResumeLayout(false);
            testTP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button showBTN;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage showTP;
        private TabPage testTP;
        private RichTextBox testRTB;
        private Button testBTN;
    }
}
