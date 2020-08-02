Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As SByte
        ntabla = txtntabla.Text
        LstTablas.Items.Clear()
        If ntabla <= 12 Then
            For i = 1 To 10
                LstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            LstTablas.Items.Add("Por favor ingrese solo tablas menores o igual a 12.")
        End If
    End Sub
End Class
