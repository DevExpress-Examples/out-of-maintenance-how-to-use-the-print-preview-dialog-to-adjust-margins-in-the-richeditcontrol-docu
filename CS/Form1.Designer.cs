using DevExpress.XtraReports.Design;
using System.Windows.Forms;
namespace WindowsApplication111 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnShowPrintPreview = new System.Windows.Forms.Button();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowPrintPreview
            // 
            this.btnShowPrintPreview.Location = new System.Drawing.Point(12, 12);
            this.btnShowPrintPreview.Name = "btnShowPrintPreview";
            this.btnShowPrintPreview.Size = new System.Drawing.Size(172, 29);
            this.btnShowPrintPreview.TabIndex = 2;
            this.btnShowPrintPreview.Text = "Show Print Preview";
            this.btnShowPrintPreview.UseVisualStyleBackColor = true;
            this.btnShowPrintPreview.Click += new System.EventHandler(this.btnShowPrintPreview_Click);
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 55);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(815, 324);
            this.richEditControl1.TabIndex = 4;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnShowPrintPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 55);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 46);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Click the button to invoke the Print Preview window. \r\nDrag markers to adjust the" +
                " margins. \r\nMargins are adjusted for the RichEditControl as well.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 379);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowPrintPreview;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private Panel panel1;
        private TextBox textBox1;

        //private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
    }
}

