Public Class Form1
    Dim CalcVar As Double : Dim CalcOp As String : Dim WillBeCleaned As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CalcOp = "" : WillBeCleaned = False
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "1" : WillBeCleaned = False
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "2" : WillBeCleaned = False
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "3" : WillBeCleaned = False
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + "4" : WillBeCleaned = False
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + "5" : WillBeCleaned = False
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "6" : WillBeCleaned = False
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text + "7" : WillBeCleaned = False
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text + "8" : WillBeCleaned = False
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "9" : WillBeCleaned = False
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "0" : WillBeCleaned = False
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "." : WillBeCleaned = False
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox1.Text = (Microsoft.VisualBasic.Left(TextBox1.Text, Len(TextBox1.Text) - 1)) : WillBeCleaned = False
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If WillBeCleaned = True Then TextBox1.Text = Microsoft.VisualBasic.Right(TextBox1.Text, 1)
        TextBox1.Text = Val(TextBox1.Text)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CalcVar = Val(TextBox1.Text) : CalcOp = "+" : WillBeCleaned = True
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CalcVar = Val(TextBox1.Text) : CalcOp = "-" : WillBeCleaned = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CalcVar = Val(TextBox1.Text) : CalcOp = "*" : WillBeCleaned = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CalcVar = Val(TextBox1.Text) : CalcOp = "/" : WillBeCleaned = True
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case CalcOp
            Case "+"
                TextBox1.Text = CalcVar + Val(TextBox1.Text)
            Case "-"
                TextBox1.Text = CalcVar - Val(TextBox1.Text)
            Case "*"
                TextBox1.Text = CalcVar * Val(TextBox1.Text)
            Case "/"
                TextBox1.Text = CalcVar / Val(TextBox1.Text)
            Case ""
        End Select : CalcOp = "" : WillBeCleaned = True
    End Sub
End Class
