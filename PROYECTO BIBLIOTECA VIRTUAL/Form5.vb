Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case ComboBox2.SelectedIndex
            Case 0
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\ESTUDIOS SOCIALES_8.PDF")
            Case 1
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\ESTUDIOS SOCIALES_9.PDF")
            Case 2
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\ESTUDIOS SOCIALES_10.PDF")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("HISTORIA DEL ECUADOR") Then
            ListBox1.Items.Add("HISTORIA DEL ECUADOR-1")
            ListBox1.Items.Add("HISTORIA DEL ECUADOR-2")
            ListBox1.Items.Add("ECONOMIA ECUADOR-1")
            ListBox1.Items.Add("ECONOMIA ECUADOR-2")
            ListBox1.Items.Add("MATRIZ PRODUCTIVA")
        ElseIf ComboBox1.Text = ("HISTORIA GENERAL") Then
            ListBox1.Items.Add("EPOCA ABORIGEN DEL ECUADOR-1")
            ListBox1.Items.Add("EPOCA ABORIGEN DEL ECUADOR-2")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox5.SendToBack()


        If ListBox1.SelectedItem = ("HISTORIA DEL ECUADOR-1") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\HISTORIA DEL ECUADOR-1.mp4"
        ElseIf ListBox1.SelectedItem = ("HISTORIA DEL ECUADOR-2") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\HISTORIA DEL ECUADOR-2.mp4"
        ElseIf ListBox1.SelectedItem = ("ECONOMIA ECUADOR-1") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\ECONOMIA ECUADOR-1.mp4"
        ElseIf ListBox1.SelectedItem = ("ECONOMIA ECUADOR-2") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\ECONOMIA ECUADOR-2.mp4"
        ElseIf ListBox1.SelectedItem = ("MATRIZ PRODUCTIVA") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\MATRIZ PRODUCTIVA.mp4"
        ElseIf ListBox1.SelectedItem = ("EPOCA ABORIGEN DEL ECUADOR-1") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\EPOCA ABORIGEN DEL ECUADOR-1.mp4"
        ElseIf ListBox1.SelectedItem = ("EPOCA ABORIGEN DEL ECUADOR-2") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\sociales\EPOCA ABORIGEN DEL ECUADOR-2.mp4"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            System.Diagnostics.Process.Start("http://www.santillana.com.ar/01_tit2.asp?anio=4%BA%20a%F1o&level=ciclo2")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCSSlekSYRoyQo8uQGHvq4qQ")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            System.Diagnostics.Process.Start("http://www.canstockphoto.es/imagenes-fotos/matem%C3%A1ticas.html")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class