<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSourceFolder = New System.Windows.Forms.TextBox()
        Me.fbdSource = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnBrowseSourceFolder = New System.Windows.Forms.Button()
        Me.txtTargetFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowseTargetFolder = New System.Windows.Forms.Button()
        Me.fbdTarget = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSourceFileExtension = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudResizePercent = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.pgb1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.bgWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nudResizePercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Folder"
        '
        'txtSourceFolder
        '
        Me.txtSourceFolder.Location = New System.Drawing.Point(97, 18)
        Me.txtSourceFolder.Name = "txtSourceFolder"
        Me.txtSourceFolder.Size = New System.Drawing.Size(365, 20)
        Me.txtSourceFolder.TabIndex = 1
        '
        'fbdSource
        '
        Me.fbdSource.ShowNewFolderButton = False
        '
        'btnBrowseSourceFolder
        '
        Me.btnBrowseSourceFolder.Location = New System.Drawing.Point(468, 16)
        Me.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder"
        Me.btnBrowseSourceFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseSourceFolder.TabIndex = 2
        Me.btnBrowseSourceFolder.Text = "Browse"
        Me.btnBrowseSourceFolder.UseVisualStyleBackColor = True
        '
        'txtTargetFolder
        '
        Me.txtTargetFolder.Location = New System.Drawing.Point(97, 70)
        Me.txtTargetFolder.Name = "txtTargetFolder"
        Me.txtTargetFolder.Size = New System.Drawing.Size(365, 20)
        Me.txtTargetFolder.TabIndex = 3
        '
        'btnBrowseTargetFolder
        '
        Me.btnBrowseTargetFolder.Location = New System.Drawing.Point(468, 67)
        Me.btnBrowseTargetFolder.Name = "btnBrowseTargetFolder"
        Me.btnBrowseTargetFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseTargetFolder.TabIndex = 4
        Me.btnBrowseTargetFolder.Text = "Browse"
        Me.btnBrowseTargetFolder.UseVisualStyleBackColor = True
        '
        'fbdTarget
        '
        Me.fbdTarget.ShowNewFolderButton = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Target Folder"
        '
        'txtSourceFileExtension
        '
        Me.txtSourceFileExtension.Location = New System.Drawing.Point(97, 44)
        Me.txtSourceFileExtension.Name = "txtSourceFileExtension"
        Me.txtSourceFileExtension.Size = New System.Drawing.Size(65, 20)
        Me.txtSourceFileExtension.TabIndex = 6
        Me.txtSourceFileExtension.Text = "jpg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "File Extension"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pgb1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(740, 537)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.nudResizePercent)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Controls.Add(Me.txtSourceFolder)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSourceFileExtension)
        Me.Panel1.Controls.Add(Me.btnBrowseSourceFolder)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTargetFolder)
        Me.Panel1.Controls.Add(Me.btnBrowseTargetFolder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 194)
        Me.Panel1.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(337, 145)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(92, 36)
        Me.btnStop.TabIndex = 13
        Me.btnStop.Text = "Stop !"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Resize To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "%"
        '
        'nudResizePercent
        '
        Me.nudResizePercent.Location = New System.Drawing.Point(97, 109)
        Me.nudResizePercent.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudResizePercent.Name = "nudResizePercent"
        Me.nudResizePercent.Size = New System.Drawing.Size(120, 20)
        Me.nudResizePercent.TabIndex = 10
        Me.nudResizePercent.Value = New Decimal(New Integer() {70, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "* If Target Folder is same as source folder, resized image will be renamed"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(239, 145)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(92, 36)
        Me.btnGo.TabIndex = 8
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'pgb1
        '
        Me.pgb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb1.Location = New System.Drawing.Point(3, 510)
        Me.pgb1.Name = "pgb1"
        Me.pgb1.Size = New System.Drawing.Size(734, 24)
        Me.pgb1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbLog)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 301)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log"
        '
        'rtbLog
        '
        Me.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbLog.Location = New System.Drawing.Point(3, 16)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(728, 282)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'bgWorker1
        '
        Me.bgWorker1.WorkerReportsProgress = True
        Me.bgWorker1.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 537)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Monyet Image Resizer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudResizePercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSourceFolder As TextBox
    Friend WithEvents fbdSource As FolderBrowserDialog
    Friend WithEvents btnBrowseSourceFolder As Button
    Friend WithEvents txtTargetFolder As TextBox
    Friend WithEvents btnBrowseTargetFolder As Button
    Friend WithEvents fbdTarget As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSourceFileExtension As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pgb1 As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents nudResizePercent As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents btnStop As Button
    Friend WithEvents bgWorker1 As System.ComponentModel.BackgroundWorker
End Class
