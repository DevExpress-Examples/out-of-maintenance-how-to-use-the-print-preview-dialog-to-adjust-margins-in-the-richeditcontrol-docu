Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.Utils

Namespace WindowsApplication111
    Partial Public Class Form1
        Inherits Form

        Private link As PrintableComponentLink
        Public Sub New()
            InitializeComponent()
            link = New PrintableComponentLink(New PrintingSystem())
            link.Component = Me.richEditControl1
            AddHandler link.PrintingSystem.AfterMarginsChange, AddressOf PrintingSystem_AfterMarginsChange
            AddHandler link.PrintingSystem.AfterBuildPages, AddressOf PrintingSystem_AfterBuildPages
            Dim path As String = System.IO.Path.Combine(Application.StartupPath, "..\..\Document.rtf")
            Me.richEditControl1.LoadDocument(path)
        End Sub

        Private Sub PrintingSystem_AfterBuildPages(ByVal sender As Object, ByVal e As EventArgs)
            link.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.PageMargins, CommandVisibility.All)
        End Sub

        #Region "#changemargins"
        Private Sub PrintingSystem_AfterMarginsChange(ByVal sender As Object, ByVal e As MarginsChangeEventArgs)
            ' Change document margins in the source RichEditControl
            Dim margins As SectionMargins = Me.richEditControl1.Document.Sections(0).Margins
            Select Case e.Side
                Case MarginSide.Left
                    margins.Left = Units.HundredthsOfInchToDocuments(CInt((e.Value)))
                Case MarginSide.Right
                    margins.Right = Units.HundredthsOfInchToDocuments(CInt((e.Value)))
                Case MarginSide.Top
                    margins.Top = Units.HundredthsOfInchToDocuments(CInt((e.Value)))
                Case MarginSide.Bottom
                    margins.Bottom = Units.HundredthsOfInchToDocuments(CInt((e.Value)))
                Case Else
            End Select

            link.CreateDocument()
        End Sub
        #End Region ' #changemargins

        Private Sub btnShowPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowPrintPreview.Click
            Dim tool As New PrintTool(link.PrintingSystem)
            link.CreateDocument()
            tool.ShowPreviewDialog()
        End Sub

    End Class
End Namespace