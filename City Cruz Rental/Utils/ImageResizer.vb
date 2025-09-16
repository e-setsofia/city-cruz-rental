Imports System.IO

Public Class ImageUtils

    Public Shared Sub PictureBoxCropFill_Paint(sender As Object, e As PaintEventArgs)
        Dim pb As Guna.UI2.WinForms.Guna2PictureBox = DirectCast(sender, Guna.UI2.WinForms.Guna2PictureBox)
        If pb.Image Is Nothing Then Exit Sub

        Dim img As Image = pb.Image
        Dim pbRect As Rectangle = pb.ClientRectangle

        ' Calculate aspect ratios
        Dim imgRatio As Double = img.Width / img.Height
        Dim boxRatio As Double = pbRect.Width / pbRect.Height

        Dim srcRect As Rectangle

        If imgRatio > boxRatio Then
            ' Image is wider than PictureBox → crop width
            Dim newWidth As Integer = CInt(img.Height * boxRatio)
            Dim xOffset As Integer = (img.Width - newWidth) \ 2
            srcRect = New Rectangle(xOffset, 0, newWidth, img.Height)
        Else
            ' Image is taller than PictureBox → crop height
            Dim newHeight As Integer = CInt(img.Width / boxRatio)
            Dim yOffset As Integer = (img.Height - newHeight) \ 2
            srcRect = New Rectangle(0, yOffset, img.Width, newHeight)
        End If

        ' Draw cropped image
        e.Graphics.DrawImage(img, pbRect, srcRect, GraphicsUnit.Pixel)

        pb.BorderRadius = 16 ' Add border radius
    End Sub

    Public Shared Function SelectImageAndConvertToBytes(pictureBox As Guna.UI2.WinForms.Guna2PictureBox) As Byte()
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Select Vehicle Image"

            If ofd.ShowDialog() = DialogResult.OK Then
                ' Load image into PictureBox
                pictureBox.Image = Image.FromFile(ofd.FileName)

                ' Convert to byte array
                Using ms As New MemoryStream()
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat)
                    Return ms.ToArray()
                End Using
            End If
        End Using

        ' Return Nothing if user cancels or no image selected
        Return Nothing
    End Function


End Class
