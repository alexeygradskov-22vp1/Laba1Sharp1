namespace Laba1Sharp1
{
    partial class Test
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
            this.listViewTests = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listViewTests
            // 
            this.listViewTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTests.HideSelection = false;
            this.listViewTests.Location = new System.Drawing.Point(0, 0);
            this.listViewTests.Margin = new System.Windows.Forms.Padding(10);
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(800, 450);
            this.listViewTests.TabIndex = 0;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            this.listViewTests.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(778, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 450);
            this.panel2.TabIndex = 2;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewTests);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}