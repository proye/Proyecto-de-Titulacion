Public Class Form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Select Case ComboBox2.SelectedIndex
            Case 0
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\MATEMATICA_8.PDF")
            Case 1
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\MATEMATICA_9.PDF")
            Case 2
                Process.Start("C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\LIBROS\MATEMATICA_10.PDF")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = ("FACTORIZACION") Then
            ListBox1.Items.Add("CASO DE FACTORIZACION 1")
            ListBox1.Items.Add("CASO DE FACTORIZACION 2")
            ListBox1.Items.Add("CASO DE FACTORIZACION 3")
            ListBox1.Items.Add("CASO DE FACTORIZACION 4")
            ListBox1.Items.Add("CASO DE FACTORIZACION 5")
            ListBox1.Items.Add("CASO DE FACTORIZACION 6")
            ListBox1.Items.Add("CASO DE FACTORIZACION 7")
            ListBox1.Items.Add("CASO DE FACTORIZACION 8")
            ListBox1.Items.Add("CASO DE FACTORIZACION 9")
            ListBox1.Items.Add("CASO DE FACTORIZACION 10")
        ElseIf ComboBox1.Text = ("PRODUCTOS NOTABLES") Then
            ListBox1.Items.Add("BINOMIO")
            ListBox1.Items.Add("DIFERENCIA")
            ListBox1.Items.Add("CUBO")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox5.SendToBack()


        If ListBox1.SelectedItem = ("CASO DE FACTORIZACION 1") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 1.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 2") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 2.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 3") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 3.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 4") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 4.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 5") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 5.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 6") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 6.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 7") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 7.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 8") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 8.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 9") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 9.mp4"
        ElseIf ListBox1.SelectedItem = ("CASO DE FACTORIZACION 10") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\Factorización Caso 10.mp4"
        ElseIf ListBox1.SelectedItem = ("BINOMIO") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\BINOMIO.mp4"
        ElseIf ListBox1.SelectedItem = ("DIFERENCIA") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\DIFERENCIA.mp4"
        ElseIf ListBox1.SelectedItem = ("CUBO") Then
            Player.URL = "C:\Users\pc\Desktop\PROYECTO BIBLIOTECA VIRTUAL\VIDEOS\matematicas\CUBO.mp4"

        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class