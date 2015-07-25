Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case ComboBox2.SelectedIndex
            Case 0
                Process.Start("C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\LIBROS\CIENCIAS NATURALES_8.PDF")
            Case 1
                Process.Start("C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\LIBROS\CIENCIAS NATURALES_9.PDF")
            Case 2
                Process.Start("C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\LIBROS\CIENCIAS NATURALES_10.PDF")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("EL AGUA") Then
            ListBox1.Items.Add("CICLO DEL AGUA-1")
            ListBox1.Items.Add("CICLO DEL AGUA-2")
        ElseIf ComboBox1.Text = ("MEDIO AMBIENTE") Then
            ListBox1.Items.Add("GESTION AMBIENTAL")
            ListBox1.Items.Add("LAS ENERGIAS RENOVABLES")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        PictureBox5.SendToBack()

        If ListBox1.SelectedItem = ("CICLO DEL AGUA-1") Then
            Player.URL = "C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\VIDEOS\c.naturales\CICLO DEL AGUA-1.mp4"
        ElseIf ListBox1.SelectedItem = ("CICLO DEL AGUA-2") Then
            Player.URL = "C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\VIDEOS\c.naturales\CICLO DEL AGUA-2.mp4"
        ElseIf ListBox1.SelectedItem = ("GESTION AMBIENTAL") Then
            Player.URL = "C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\VIDEOS\c.naturales\GESTION AMBIENTAL.mp4"
        ElseIf ListBox1.SelectedItem = ("LAS ENERGIAS RENOVABLES") Then
            Player.URL = "C:\Users\pc\Desktop\BIBLIOTECA VIRTUAL-proyecto\VIDEOS\c.naturales\LAS ENERGIAS RENOVABLES.mp4"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
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
End Class