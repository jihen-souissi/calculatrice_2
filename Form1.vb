Imports System.Reflection.Emit
Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""
    Private Sub But_0_Click(sender As Object, e As EventArgs) Handles But_0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub
    Private Sub But_1_Click(sender As Object, e As EventArgs) Handles But_1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_2_Click(sender As Object, e As EventArgs) Handles But_2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_3_Click(sender As Object, e As EventArgs) Handles But_3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_4_Click(sender As Object, e As EventArgs) Handles But_4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_5_Click(sender As Object, e As EventArgs) Handles But_5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_6_Click(sender As Object, e As EventArgs) Handles But_6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_7_Click(sender As Object, e As EventArgs) Handles But_7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_8_Click(sender As Object, e As EventArgs) Handles But_8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_9_Click(sender As Object, e As EventArgs) Handles But_9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub
    Private Sub But_plus_Click(sender As Object, e As EventArgs) Handles But_plus.Click
        If Not A = "" Then
            op = "+"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_moin_Click(sender As Object, e As EventArgs) Handles But_moin.Click
        If Not A = "" Then
            op = "-"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_foi_Click(sender As Object, e As EventArgs) Handles But_foi.Click
        If Not A = "" Then
            op = "*"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub But_rap_Click(sender As Object, e As EventArgs) Handles But_rap.Click
        If Not A = "" Then
            op = "/"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub
    Private Sub But_C_Click(sender As Object, e As EventArgs) Handles But_C.Click
        Text_affiche.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub

    Private Sub But_aq_Click(sender As Object, e As EventArgs) Handles But_aq.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else
                MessageBox.Show("Division par 0")
                test = False
            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers")
            test = False
        End If
        If test Then
            Text_affiche.Text = Text_affiche.Text + "=" + res.ToString
        End If

    End Sub
End Class