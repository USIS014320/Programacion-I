Public Class Form1
    Private Sub Textbox1_textchanged(sender As Object, e As EventArgs) Handles txtentrada.TextChanged
        Dim tipo1, tipo2 As Int64

        tipo1 = cbo1.SelectedIndex
        tipo2 = cbo2.SelectedIndex

        Select Case cbo1.SelectedIndex
            Case 0
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text / 100
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text / 100000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 10
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 160934
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text / 91.44
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text / 30.48
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text / 2.54
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 10000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 185200
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 1
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 100
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text / 1000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 1000
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 1609
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text * 1.094
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text * 3.281
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text * 39.37
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 1000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 1852
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 2
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 100000
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text * 1000
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 1000000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 1.609
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text * 1094
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text * 3281
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text * 39370
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 1000000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 1.852
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 3
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text / 10
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text / 1000
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text / 1000000.0
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 1609000.0
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text / 914
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text / 305
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text / 25.4
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 1000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 1852000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 4
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 160934
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text * 1609
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text * 1.609
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 1609000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text * 1760
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text * 5280
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text * 63360
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 1609000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 1.151
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 5
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 91.44
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text * 91.44 / 100
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text * 91.44 / 100000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 91.44 * 10
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text * 91.44 / 160934
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text * 91.44 / 30.48
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text * 91.44 / 2.54
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 91.44 * 10000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text * 91.44 / 185200
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 6
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 30.48
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text * 3.281
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text / 3281
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 305
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 5280
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text / 3
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text * 12
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 304800
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 6076
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 7
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 2.54
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text / 3937
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text / 39370
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 25.4
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 63360
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text / 36
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text / 12
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 25400
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 72913
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 8
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text / 10000
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text / 1000000.0
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text / 1000000000.0
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text / 1000
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text / 1609000000.0
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text / 914400
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text / 304800
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text / 25400
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text / 1852000000.0
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Case 9
                If txtentrada.Text = "" Or txtentrada.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtentrada.Text * 185200
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtentrada.Text * 1852
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtentrada.Text * 1.852
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtentrada.Text * 1852000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtentrada.Text * 1.151
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtentrada.Text * 2025
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtentrada.Text * 6076
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtentrada.Text * 72913
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtentrada.Text * 1852000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtentrada.Text
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub
End Class
