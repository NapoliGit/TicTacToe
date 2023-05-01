Public Class Form1
    Dim user As Char() = New Char() {"X", "O"}
    Dim xturn As Boolean = False
    Dim result As String
    Dim check As String

    Public Sub checkbuttons()
        If (TL.Text = "O" Or TL.Text = "X") And (TM.Text = "O" Or TM.Text = "X") And (TR.Text = "O" Or TR.Text = "X") And (ML.Text = "O" Or ML.Text = "X") And (MM.Text = "O" Or MM.Text = "X") And (MR.Text = "O" Or MR.Text = "X") And (BL.Text = "O" Or BL.Text = "X") And (BM.Text = "O" Or BM.Text = "X") And (BR.Text = "O" Or BR.Text = "X") Then
            Label1.Text = "WINNER : DRAW"
            TL.Enabled = False
            TM.Enabled = False
            TR.Enabled = False
            ML.Enabled = False
            MM.Enabled = False
            MR.Enabled = False
            BL.Enabled = False
            BM.Enabled = False
            BR.Enabled = False


        End If
    End Sub
    Public Sub win()

        ' horizontal combinations :
        If TL.Text = TM.Text And TM.Text = TR.Text Then
            Label1.Text = "WINNER : " + TM.Text

        ElseIf ML.Text = MM.Text And MM.Text = MR.Text Then
            Label1.Text = "WINNER : " + MM.Text

        ElseIf BL.Text = BM.Text And BM.Text = BR.Text Then
            Label1.Text = "WINNER : " + BM.Text

            ' vertical combinations :

        ElseIf TL.Text = ML.Text And ML.Text = BL.Text Then
            Label1.Text = "WINNER : " + ML.Text
        ElseIf TM.Text = MM.Text And MM.Text = BM.Text Then
            Label1.Text = "WINNER : " + MM.Text
        ElseIf TR.Text = MR.Text And MR.Text = BR.Text Then
            Label1.Text = "WINNER : " + MR.Text

            ' diagonal combinations :

        ElseIf TL.Text = MM.Text And MM.Text = BR.Text Then
            Label1.Text = "WINNER : " + MM.Text
        ElseIf TR.Text = MM.Text And MM.Text = BL.Text Then
            Label1.Text = "WINNER : " + MM.Text
        Else Call checkbuttons()



        End If

        If Label1.Text = "WINNER : X" Or Label1.Text = "WINNER : O" Then

            TL.Enabled = False
            TM.Enabled = False
            TR.Enabled = False
            ML.Enabled = False
            MM.Enabled = False
            MR.Enabled = False
            BL.Enabled = False
            BM.Enabled = False
            BR.Enabled = False

        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TL.Click
        If xturn = False Then
            TL.Text = user(0)

            xturn = True
            TL.Enabled = False
        Else
            TL.Text = user(1)
            xturn = False
            TL.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TM.Click
        If xturn = False Then
            TM.Text = user(0)
            xturn = True
            TM.Enabled = False

        Else
            TM.Text = user(1)
            xturn = False
            TM.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles TR.Click
        If xturn = False Then
            TR.Text = user(0)
            xturn = True
            TR.Enabled = False

        Else
            TR.Text = user(1)
            xturn = False
            TR.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ML.Click
        If xturn = False Then
            ML.Text = user(0)
            xturn = True
            ML.Enabled = False

        Else
            ML.Text = user(1)
            xturn = False
            ML.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles MM.Click
        If xturn = False Then
            MM.Text = user(0)
            xturn = True
            MM.Enabled = False

        Else
            MM.Text = user(1)
            xturn = False
            MM.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles MR.Click
        If xturn = False Then
            MR.Text = user(0)
            xturn = True
            MR.Enabled = False

        Else
            MR.Text = user(1)
            xturn = False
            MR.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BL.Click
        If xturn = False Then
            BL.Text = user(0)
            xturn = True
            BL.Enabled = False

        Else
            BL.Text = user(1)
            xturn = False
            BL.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BM.Click
        If xturn = False Then
            BM.Text = user(0)
            xturn = True
            BM.Enabled = False

        Else
            BM.Text = user(1)
            xturn = False
            BM.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles BR.Click
        If xturn = False Then
            BR.Text = user(0)
            xturn = True
            BR.Enabled = False

        Else
            BR.Text = user(1)
            xturn = False
            BR.Enabled = False

        End If
        Call win()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TL.Enabled = True
        TM.Enabled = True
        TR.Enabled = True
        ML.Enabled = True
        MM.Enabled = True
        MR.Enabled = True
        BL.Enabled = True
        BM.Enabled = True
        BR.Enabled = True
        TL.Text = ""
        TM.Text = ""
        TR.Text = ""
        ML.Text = ""
        MM.Text = ""
        MR.Text = ""
        BL.Text = ""
        BM.Text = ""
        BR.Text = ""
    End Sub
End Class
