Imports DevExpress.XtraReports.Design
Imports System.Windows.Forms
Namespace WindowsApplication111
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnShowPrintPreview = New System.Windows.Forms.Button()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' btnShowPrintPreview
            ' 
            Me.btnShowPrintPreview.Location = New System.Drawing.Point(12, 12)
            Me.btnShowPrintPreview.Name = "btnShowPrintPreview"
            Me.btnShowPrintPreview.Size = New System.Drawing.Size(172, 29)
            Me.btnShowPrintPreview.TabIndex = 2
            Me.btnShowPrintPreview.Text = "Show Print Preview"
            Me.btnShowPrintPreview.UseVisualStyleBackColor = True
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 55)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(815, 324)
            Me.richEditControl1.TabIndex = 4
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Controls.Add(Me.btnShowPrintPreview)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(815, 55)
            Me.panel1.TabIndex = 6
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(220, 3)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(453, 46)
            Me.textBox1.TabIndex = 4
            Me.textBox1.Text = "Click the button to invoke the Print Preview window. " & ControlChars.CrLf & "Drag markers to adjust the" & " margins. " & ControlChars.CrLf & "Margins are adjusted for the RichEditControl as well."
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(815, 379)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.IsMdiContainer = True
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents btnShowPrintPreview As Button
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private panel1 As Panel
        Private textBox1 As TextBox

        'private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
    End Class
End Namespace

