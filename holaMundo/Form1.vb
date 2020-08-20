Public Class Form1
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click

        Dim m1, m2 As Int64
        Dim tipo1, tipo2 As Int64
        Dim almacenamiento1, almacenamiento2 As Int64

        tipo1 = cbo1.SelectedIndex
        tipo2 = cbo2.SelectedIndex

        almacenamiento1 = cboalmacenamientoentrada.SelectedIndex
        almacenamiento2 = cboalmacenamientosalida.SelectedIndex

        m1 = cboDe.SelectedIndex
        m2 = cboA.SelectedIndex

        Select Case cbo1.SelectedIndex
            Case 0
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 100
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 100000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 10
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 160934
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 91.44
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 30.48
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 2.54
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 10000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 185200
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 100
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1609
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1.094
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 3.281
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 39.37
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1852
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 100000
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1.609
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1094
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 3281
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 39370
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1.852
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text / 10
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000000.0
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1609000.0
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 914
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 305
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 25.4
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1852000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 160934
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1609
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1.609
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1609000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1760
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 5280
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 63360
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1609000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1.151
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 91.44
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 91.44 / 100
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 91.44 / 100000
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 91.44 * 10
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 91.44 / 160934
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 91.44 / 30.48
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 91.44 / 2.54
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 91.44 * 10000
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text * 91.44 / 185200
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 30.48
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 3.281
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 3281
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 305
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 5280
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 3
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 12
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 304800
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 6076
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 2.54
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 3937
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 39370
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 25.4
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 63360
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 36
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 12
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 25400
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 72913
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text / 10000
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000000.0
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1000
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1609000000.0
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 914400
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 304800
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 25400
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1852000000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If tipo2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 185200
                    Else
                        If tipo2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1852
                        Else
                            If tipo2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1.852
                            Else
                                If tipo2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1852000.0
                                Else
                                    If tipo2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1.151
                                    Else
                                        If tipo2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 2025
                                        Else
                                            If tipo2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 6076
                                            Else
                                                If tipo2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 72913
                                                Else
                                                    If tipo2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1852000000.0
                                                    Else
                                                        If tipo2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text
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

        If m1 = 0 And m2 = 1 Then
            txtrespuesta.Text = txtEntradab.Text * 2.205
        Else
            If m1 = 0 And m2 = 2 Then
                txtrespuesta.Text = txtEntradab.Text * 35.274
            Else
                If m1 = 0 And m2 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 100
                Else
                    If m1 = 0 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 1000
                    Else
                        If m1 = 0 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m1 = 0 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000
                            Else
                                If m1 = 0 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                Else
                                    If m1 = 0 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                    Else
                                        If m1 = 0 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5000
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 1 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 2.205
        Else
            If m1 = 1 And m2 = 2 Then
                txtrespuesta.Text = txtEntradab.Text * 16
            Else
                If m1 = 1 And m2 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 100
                Else
                    If m1 = 1 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 2205
                    Else
                        If m1 = 1 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m1 = 1 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 454
                            Else
                                If m1 = 1 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 453592
                                Else
                                    If m1 = 1 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 453600000.0
                                    Else
                                        If m1 = 1 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 2268
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 2 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 35.274
        Else
            If m1 = 2 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 16
            Else
                If m1 = 2 And m2 = 3 Then
                    txtrespuesta.Text = txtEntradab.Text / 3527
                Else
                    If m1 = 2 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 35274
                    Else
                        If m1 = 2 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m1 = 2 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 28.35
                            Else
                                If m1 = 2 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 28350
                                Else
                                    If m1 = 2 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 28350000.0
                                    Else
                                        If m1 = 2 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 142
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 3 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 100
        Else
            If m1 = 3 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 100
            Else
                If m1 = 3 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 3527
                Else
                    If m1 = 3 And m2 = 4 Then
                        txtrespuesta.Text = txtEntradab.Text / 10
                    Else
                        If m1 = 3 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m1 = 3 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 100000
                            Else
                                If m1 = 3 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 100000000.0
                                Else
                                    If m1 = 3 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 100000000000.0
                                    Else
                                        If m1 = 3 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 142
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 4 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 1000
        Else
            If m1 = 4 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 2205
            Else
                If m1 = 4 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 35274
                Else
                    If m1 = 4 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10
                    Else
                        If m1 = 4 And m2 = 5 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m1 = 4 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                            Else
                                If m1 = 4 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                Else
                                    If m1 = 4 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                                    Else
                                        If m1 = 4 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5000000.0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 5 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text * 1000
        Else
            If m1 = 5 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text * 2205
            Else
                If m1 = 5 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text * 35274
                Else
                    If m1 = 5 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10
                    Else
                        If m1 = 5 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 25
                        Else
                            If m1 = 5 And m2 = 6 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                            Else
                                If m1 = 5 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                Else
                                    If m1 = 5 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                                    Else
                                        If m1 = 5 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5000000.0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 6 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 1000
        Else
            If m1 = 6 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 454
            Else
                If m1 = 6 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 28.35
                Else
                    If m1 = 6 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text * 10
                    Else
                        If m1 = 6 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 10
                        Else
                            If m1 = 6 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text / 25
                            Else
                                If m1 = 6 And m2 = 7 Then
                                    txtrespuesta.Text = txtEntradab.Text * 100000000.0
                                Else
                                    If m1 = 6 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 100000000000.0
                                    Else
                                        If m1 = 6 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text * 5
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 7 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 1000000.0
        Else
            If m1 = 7 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 453592
            Else
                If m1 = 7 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 28350
                Else
                    If m1 = 7 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text / 100000000.0
                    Else
                        If m1 = 7 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                        Else
                            If m1 = 7 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text / 11.3398
                            Else
                                If m1 = 7 And m2 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1000
                                Else
                                    If m1 = 7 And m2 = 8 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                    Else
                                        If m1 = 7 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 200
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 8 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 1000000000.0
        Else
            If m1 = 8 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 453600000.0
            Else
                If m1 = 8 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 28350000.0
                Else
                    If m1 = 8 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text / 100000000000.0
                    Else
                        If m1 = 8 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 1000000000000.0
                        Else
                            If m1 = 8 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 453600000.0
                            Else
                                If m1 = 8 And m2 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1000000.0

                                Else
                                    If m1 = 8 And m2 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1000
                                    Else
                                        If m1 = 8 And m2 = 9 Then
                                            txtrespuesta.Text = txtEntradab.Text / 200000
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If m1 = 9 And m2 = 0 Then
            txtrespuesta.Text = txtEntradab.Text / 5000
        Else
            If m1 = 9 And m2 = 1 Then
                txtrespuesta.Text = txtEntradab.Text / 2268
            Else
                If m1 = 9 And m2 = 2 Then
                    txtrespuesta.Text = txtEntradab.Text / 142
                Else
                    If m1 = 9 And m2 = 3 Then
                        txtrespuesta.Text = txtEntradab.Text / 500000
                    Else
                        If m1 = 9 And m2 = 4 Then
                            txtrespuesta.Text = txtEntradab.Text / 5000000.0
                        Else
                            If m1 = 9 And m2 = 5 Then
                                txtrespuesta.Text = txtEntradab.Text * 2268
                            Else
                                If m1 = 9 And m2 = 6 Then
                                    txtrespuesta.Text = txtEntradab.Text / 5
                                Else
                                    If m1 = 9 And m2 = 7 Then
                                        txtrespuesta.Text = txtEntradab.Text * 200
                                    Else
                                        If m1 = 9 And m2 = 8 Then
                                            txtrespuesta.Text = txtEntradab.Text * 200000
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Select Case cboalmacenamientoentrada.SelectedIndex
            Case 0
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text / 8
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 8000
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 8192
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 8000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 8389000.0
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 8000000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 8590000000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 8000000000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 8.0E+15
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text / 1000
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1024
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1049000.0
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1074000000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000000000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1.0E+15
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text / 1024
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 1000
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1049
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1074000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000000000000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8192
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1024
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1.024
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text / 977
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1024
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 976562
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1049000.0
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 976600000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 976600000000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 977
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text / 1.049
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 1000
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1074
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000000.0
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000000000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8389000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1049000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1049
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1024
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1.049
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text / 954
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1024
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 953674
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 953700000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 976563
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 954
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text / 1.074
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 1000
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000000.0
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8590000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1074000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1074000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 1049000.0
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1074
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 1024
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 1.074
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text / 931
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 931323
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8000000000000.0
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 976600000.0
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 953674
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 1000
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 931
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text / 1000
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
                If txtEntradab.Text = "" Or txtEntradab.Text = "." Then
                    txtrespuesta.Text = 0
                Else
                    If almacenamiento2 = 0 Then
                        txtrespuesta.Text = txtEntradab.Text * 8.0E+15
                    Else
                        If almacenamiento2 = 1 Then
                            txtrespuesta.Text = txtEntradab.Text * 1.0E+15
                        Else
                            If almacenamiento2 = 2 Then
                                txtrespuesta.Text = txtEntradab.Text * 1000000000000.0
                            Else
                                If almacenamiento2 = 3 Then
                                    txtrespuesta.Text = txtEntradab.Text * 976600000000.0
                                Else
                                    If almacenamiento2 = 4 Then
                                        txtrespuesta.Text = txtEntradab.Text * 1000000000.0
                                    Else
                                        If almacenamiento2 = 5 Then
                                            txtrespuesta.Text = txtEntradab.Text * 953700000.0
                                        Else
                                            If almacenamiento2 = 6 Then
                                                txtrespuesta.Text = txtEntradab.Text * 1000000.0
                                            Else
                                                If almacenamiento2 = 7 Then
                                                    txtrespuesta.Text = txtEntradab.Text * 931323
                                                Else
                                                    If almacenamiento2 = 8 Then
                                                        txtrespuesta.Text = txtEntradab.Text * 1000
                                                    Else
                                                        If almacenamiento2 = 9 Then
                                                            txtrespuesta.Text = txtEntradab.Text
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
