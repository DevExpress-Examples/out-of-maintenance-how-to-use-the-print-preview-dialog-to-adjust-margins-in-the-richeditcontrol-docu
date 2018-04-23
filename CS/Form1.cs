using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Utils;

namespace WindowsApplication111 {
    public partial class Form1 : Form {
        PrintableComponentLink link; 
        public Form1() {
            InitializeComponent();
            link = new PrintableComponentLink(new PrintingSystem());
            link.Component = this.richEditControl1;
            link.PrintingSystem.AfterMarginsChange += new MarginsChangeEventHandler(PrintingSystem_AfterMarginsChange);
            link.PrintingSystem.AfterBuildPages += PrintingSystem_AfterBuildPages;
            string path = Path.Combine(Application.StartupPath, @"..\..\Document.rtf");
            this.richEditControl1.LoadDocument(path);
        }

        void PrintingSystem_AfterBuildPages(object sender, EventArgs e)
        {
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.PageMargins, CommandVisibility.All);
        }

        #region #changemargins
        void PrintingSystem_AfterMarginsChange(object sender, MarginsChangeEventArgs e) {
            // Change document margins in the source RichEditControl
            SectionMargins margins = this.richEditControl1.Document.Sections[0].Margins;
            switch (e.Side) {
                case MarginSide.Left:
                    margins.Left = Units.HundredthsOfInchToDocuments((int)e.Value);
                    break;
                case MarginSide.Right:
                    margins.Right = Units.HundredthsOfInchToDocuments((int)e.Value);
                    break;
                case MarginSide.Top:
                    margins.Top = Units.HundredthsOfInchToDocuments((int)e.Value);
                    break;
                case MarginSide.Bottom:
                    margins.Bottom = Units.HundredthsOfInchToDocuments((int)e.Value);
                    break;
                default:
                    break;
            }
            
            link.CreateDocument();
        }
        #endregion #changemargins

        private void btnShowPrintPreview_Click(object sender, EventArgs e) {
            PrintTool tool = new PrintTool(link.PrintingSystem);
            link.CreateDocument();
            tool.ShowPreviewDialog();
        }

    }
}