Public Class Form1
    Public tc As Integer
    Public ct As Integer
    Dim num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11 As Integer
    Dim labnum As Integer = 0
    Dim infnum As Integer = 0
    Public sm10, sm11, tda, rssm2, jho, resultado1 As Integer
    Public tda2, sca2, resultado2, aqui As Integer
    Dim rssm, jho2 As Decimal
    Dim sca As Decimal
    Public cpf, cpfc As String




    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        TextBox2.Text = sm10
        TextBox3.Text = sm11
        If tc = 11 Then

            tda = (num1 * 10) + (9 * num2) + (8 * num3) + (7 * num4) + (6 * num5) + (5 * num6) + (4 * num7) + (3 * num8) + (2 * num9)

            rssm = tda / 11
            rssm2 = rssm
            ct += 1
            tc = 0
        End If
        utimo = resultado1

        Exit Sub
    End Sub
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If ct = 1 Then

            tda2 = ((11 * num1) + (num2 * 10) + (num3 * 9) + (num4 * 8) + (num5 * 7) + (num6 * 6) + (num7 * 5) + (num8 * 4) + (num9 * 3) + (num10 * 2))

            sca = tda2 / 11
            sca2 = sca
            ct += 1
        End If

        If sca2 > sca Then
            jho2 = ((sca - (sca2 - 1)) * 11)
        ElseIf sca2 <= sca Then
            jho2 = ((sca - sca2) * 11)
            If sca2 = 0 Or sca2 = 1 Then
                sm11 = 0
            End If
        End If

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        If jho = 0 Or jho = 1 Then
            sm10 = 0
        ElseIf jho > 1 Then
            sm10 = 11 - jho
        End If
        resultado1 = sm10
        utimo = sm10
        If jho2 = 0 Or jho2 = 1 Then
            sm11 = 0
        ElseIf jho2 > 1 Then
            sm11 = (11 - jho2)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        labnum = 0
        infnum = 0
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        tc = labnum
        If tc = 1 Then
            num1 = infnum
        ElseIf tc = 2 Then
            num2 = infnum
        ElseIf tc = 3 Then
            num3 = infnum
        ElseIf tc = 4 Then
            num4 = infnum
        ElseIf tc = 5 Then
            num5 = infnum
        ElseIf tc = 6 Then
            num6 = infnum
        ElseIf tc = 7 Then
            num7 = infnum
        ElseIf tc = 8 Then
            num8 = infnum
        ElseIf tc = 9 Then
            num9 = infnum
        ElseIf tc = 10 Then
            num10 = infnum
        ElseIf tc = 11 Then
            num11 = infnum

        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TextBox1.Text = TextBox1.Text & "1"
        infnum = 0
        infnum = 1
        labnum += 1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox1.Text = TextBox1.Text & "2"
        infnum = 0
        infnum = 2
        labnum += 1
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox1.Text = TextBox1.Text & "3"
        infnum = 0
        infnum = 3
        labnum += 1
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Text = TextBox1.Text & "4"
        infnum = 0
        infnum = 4
        labnum += 1
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Text = TextBox1.Text & "5"
        infnum = 0
        infnum = 5
        labnum += 1
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TextBox1.Text = TextBox1.Text & "6"
        infnum = 0
        infnum = 6
        labnum += 1
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TextBox1.Text = TextBox1.Text & "7"
        infnum = 0
        infnum = 7
        labnum += 1
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TextBox1.Text = TextBox1.Text & "8"
        infnum = 0
        infnum = 8
        labnum += 1
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TextBox1.Text = TextBox1.Text & "9"
        infnum = 0
        infnum = 9
        labnum += 1
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        TextBox1.Text = TextBox1.Text & "0"
        infnum = 0
        labnum += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If labnum = 3 Then
            TextBox1.Text = TextBox1.Text & "."
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If labnum = 6 Then
            TextBox1.Text = TextBox1.Text & "."
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If labnum = 9 Then
            TextBox1.Text = TextBox1.Text & "-"
            Timer3.Enabled = False
        End If
    End Sub

    
    
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If rssm2 > rssm Then
            jho = ((rssm - (rssm2 - 1)) * 11)
        ElseIf rssm2 <= rssm Then
            jho = ((rssm - rssm2) * 11)
        ElseIf rssm2 = 0 Or rssm2 = 1 Then
            sm10 = 0
        End If


    End Sub

    

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick

        If ct = 2 And sm10 = num10 And sm11 = num11 Then
            MsgBox("Pronto")
            ct = 0

        End If
    End Sub
End Class
