Imports System.IO
Imports System.Drawing
Imports System.ComponentModel

Public Class Form1

    Dim FileCount As Integer = 0
    Dim di As DirectoryInfo

    Private Sub btnBrowseSourceFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFolder.Click
        If fbdSource.ShowDialog = DialogResult.OK Then
            txtSourceFolder.Text = fbdSource.SelectedPath
        End If
    End Sub

    Private Sub btnBrowseTargetFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseTargetFolder.Click
        If fbdTarget.ShowDialog = DialogResult.OK Then
            txtTargetFolder.Text = fbdTarget.SelectedPath
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        If txtSourceFolder.Text = "" Then
            MessageBox.Show("Please Choose Source Folder!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtTargetFolder.Text = "" Then
            MessageBox.Show("Please Choose Target Folder!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        di = New DirectoryInfo(txtSourceFolder.Text)

        'Count File with provided extension (for progressbar)
        For Each f As FileInfo In di.GetFiles
            If f.Extension.ToUpper = "." & txtSourceFileExtension.Text.ToUpper Then
                Me.FileCount += 1
            End If
        Next

        pgb1.Maximum = 100
        pgb1.Value = 0




        txtSourceFolder.Enabled = False
        txtSourceFileExtension.Enabled = False
        txtTargetFolder.Enabled = False

        btnBrowseSourceFolder.Enabled = False
        btnBrowseTargetFolder.Enabled = False

        btnGo.Enabled = False
        btnStop.Enabled = True
        ClearText()
        rtbLog.Select()
        bgWorker1.RunWorkerAsync()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        bgWorker1.CancelAsync()

    End Sub


#Region " Status Messages "

    Private Sub AppendText(ByVal pText As String, ByVal pColor As Color)



        If rtbLog.InvokeRequired Then
            Dim d As New AppendTextDelegate(AddressOf AppendText)
            Me.Invoke(d, New Object() {pText, pColor})
        Else

            rtbLog.SelectionStart = rtbLog.TextLength
            rtbLog.SelectionLength = 0

            rtbLog.SelectionColor = pColor
            rtbLog.AppendText(pText)
            rtbLog.SelectionColor = rtbLog.ForeColor

        End If

    End Sub

    Private Sub ClearText()

        If rtbLog.InvokeRequired Then
            Dim d As New ClearTextDelegate(AddressOf ClearText)
            Me.Invoke(d, New Object() {})
        Else
            rtbLog.Clear()
        End If

    End Sub


    Delegate Sub AppendTextDelegate(pText As String, pColor As Color)
    Delegate Sub ClearTextDelegate()

    Private Sub rtblog_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtbLog.KeyPress
        e.Handled = True
    End Sub


#End Region




#Region " Background Worker Stuff"

    Private Sub bgWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker1.DoWork





        'Convert File
        Dim i As Integer = 0

        For Each f As FileInfo In di.GetFiles

            If bgWorker1.CancellationPending Then
                e.Cancel = True
                Exit Sub
            End If

            If f.Extension.ToUpper = "." & txtSourceFileExtension.Text.ToUpper Then

                Dim NewFileName As String = ""

                If txtSourceFolder.Text = txtTargetFolder.Text Then
                    NewFileName = txtSourceFolder.Text & Path.DirectorySeparatorChar & f.Name.Substring(0, f.Name.Length - 4) & "_resized" & f.Extension
                Else
                    NewFileName = txtTargetFolder.Text & Path.DirectorySeparatorChar & f.Name
                End If

                i += 1

                Try
                    AppendText("Converting " & f.FullName & " To " & NewFileName, Color.Black)
                    ResizeImage(f.FullName, NewFileName, nudResizePercent.Value)
                    AppendText("...Success.", Color.Green)
                Catch ex As Exception
                    AppendText("...Failed : " & ex.Message, Color.Red)
                Finally
                    AppendText(ControlChars.NewLine, Color.Black)
                End Try


                bgWorker1.ReportProgress(Math.Round((i / Me.FileCount) * 100))

                'System.Threading.Thread.Sleep(50)
            End If
        Next



    End Sub

    Private Sub bgWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker1.ProgressChanged
        If e.ProgressPercentage <= 100 Then
            pgb1.Value = e.ProgressPercentage
        End If
    End Sub

    Private Sub bgWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker1.RunWorkerCompleted

        If Not e.Error Is Nothing Then
            AppendText(e.Error.Message, Color.Red)
        End If

        If e.Cancelled = True Then
            AppendText("Operation Cancelled !", Color.Red)
        Else
            AppendText("Operation Success !", Color.Green)
        End If



        txtSourceFolder.Enabled = True
        txtSourceFileExtension.Enabled = True
        txtTargetFolder.Enabled = True

        btnBrowseSourceFolder.Enabled = True
        btnBrowseTargetFolder.Enabled = True

        btnGo.Enabled = True
        btnStop.Enabled = False

    End Sub

#End Region


#Region " Resizing Image"


    Private Sub ResizeImage(sSourcePath As String, sTargetPath As String, ratio As Double)

        Using OriginalStream As New FileStream(sSourcePath, FileMode.Open, FileAccess.Read)
            Using srcImage As System.Drawing.Image = System.Drawing.Image.FromStream(OriginalStream)

                Dim newWidth As Integer = srcImage.Width * (ratio / 100)
                Dim newHeight As Integer = srcImage.Height * (ratio / 100)
                Dim newimage As New System.Drawing.Bitmap(newWidth, newHeight)

                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(newimage)

                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality


                    g.DrawImage(srcImage, 0, 0, newWidth, newHeight)

                End Using



                newimage.Save(sTargetPath, Imaging.ImageFormat.Jpeg)

            End Using

        End Using

    End Sub



#End Region


End Class
