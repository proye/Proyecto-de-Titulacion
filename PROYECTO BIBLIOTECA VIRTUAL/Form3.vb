Public Class Form3

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case ComboBox2.SelectedIndex
            Case 0
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\LENGUA_8.PDF")
            Case 1
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\LENGUA_9.PDF")
            Case 2
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\LENGUA_10.PDF")
        End Select
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            System.Diagnostics.Process.Start("http://www.canstockphoto.es/imagenes-fotos/matem%C3%A1ticas.html")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("TECNICAS DE ESTUDIO") Then
            ListBox1.Items.Add("ANALIZAR TEXTO")
            ListBox1.Items.Add("RESUMEN")
            ListBox1.Items.Add("SUBRAYADO")
        ElseIf ComboBox1.Text = ("GUIA DE LENGUA Y LITERATURA") Then
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox5.SendToBack()


        If ListBox1.SelectedItem = ("ANALIZAR TEXTO") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\lenguaje\ANALIZAR TEXTO.mp4"
        ElseIf ListBox1.SelectedItem = ("RESUMEN") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\lenguaje\RESUMEN.mp4"
        ElseIf ListBox1.SelectedItem = ("SUBRAYADO") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\lenguaje\SUBRAYADO.mp4"
        End If
    End Sub

    Private Sub Player_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Player.Enter

    End Sub
End Class