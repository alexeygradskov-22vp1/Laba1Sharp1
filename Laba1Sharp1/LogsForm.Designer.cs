namespace Laba1Sharp1
{
    partial class LogsForm
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
            this.LogsLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LogsLV
            // 
            this.LogsLV.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LogsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LogsLV.HideSelection = false;
            this.LogsLV.Location = new System.Drawing.Point(12, 12);
            this.LogsLV.Name = "LogsLV";
            this.LogsLV.Size = new System.Drawing.Size(776, 426);
            this.LogsLV.TabIndex = 0;
            this.LogsLV.UseCompatibleStateImageBehavior = false;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogsLV);
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LogsLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}