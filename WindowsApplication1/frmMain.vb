Public Class frmMain
    Dim CalcVar1, CalcVar2 As Double : Dim CalcOp, CalcHistory As String : Dim hasDecimal, inputStatus As Boolean
    Private Sub ButtonNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        'Check the inputStatus
        If inputStatus Then 'Its True
            'Append values to the value
            'in the input box
            If txtInput.Text = "0" Then txtInput.Text = sender.Text Else txtInput.Text += sender.Text
        Else   'Value is False
            'Set the value to the value of the button
            txtInput.Text = sender.Text
            'Toggle inputStatus to True
            inputStatus = True
        End If
    End Sub
     Private Sub btnNokta_Click(sender As Object, e As EventArgs) Handles btnNokta.Click
        If inputStatus Then
            'Check if it already has a decimal (if it does then do nothing)
            If Not hasDecimal Then
                'Check to make sure the length is > than 1
                'Dont want user to add decimal as first character
                If txtInput.Text.Length > 0 Then
                    'Make sure 0 isnt the first number
                    'It met all our requirements so add the zero
                    txtInput.Text += sender.Text
                    'Toggle the flag to true (only 1 decimal per calculation)
                    hasDecimal = True
            Else
                'Since the length isnt > 1
                'make the text 0.
                txtInput.Text = "0."
            End If
        End If
        End If
    End Sub
      Private Sub btnBackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSil.Click
        'Declare locals needed
        Dim str As String
        Dim loc As Integer
        'Make sure the text length is > 1
        If txtInput.Text.Length > 0 Then
            'Get the next to last character
            str = txtInput.Text.Chars(txtInput.Text.Length - 1)
            'Check if its a decimal
            If str = "." Then
                'If it is toggle the hasDecimal flag
                hasDecimal = False
            End If
            'Get the length of the string
            loc = txtInput.Text.Length
            'Remove the last character, incrementing by 1
            txtInput.Text = txtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub
    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInput.GotFocus, TextBox2.GotFocus
        btnEsittir.Focus() 'textboxa tıklanmasın diye....
    End Sub
     Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        'eğer textbox2deki yazı çok uzamışsa uzayan kısmı silinir
        If Len(TextBox2.Text) > 25 Then TextBox2.Text = Microsoft.VisualBasic.Right(TextBox2.Text, 25)
        If TextBox2.Text = "0" Then TextBox2.Text = ""
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        CalcHistory = "" : CalcOp = "" : inputStatus = True
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnArti.Click, btnEksi.Click, btnCarpi.Click, btnBolu.Click
        'Make sure out input box has a value
        If txtInput.Text.Length <> 0 Then
            'Check the value of our function flag
            If CalcOp = String.Empty Then 'Flag is empty
                'Assign the value in our input
                'box to our holder
                CalcVar1 = CType(txtInput.Text, Double)
                'Empty the input box
                txtInput.Text = "0"
            Else 'Flag isnt empty
                'Call our calculate totals method
                CalculateTotals()
            End If
            'Assign a value to our calc function flag
            CalcOp = sender.text
            'Toggle the decimal flag
            hasDecimal = False
        End If
    End Sub
    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsittir.Click
        'Make sure theres a value in the input box
        'And that our temp value isnt 0
        If txtInput.Text.Length <> 0 AndAlso CalcVar1 <> 0 Then
            'Call the calculate totals method
            CalculateTotals()
            'Clear the calcFunction value
            CalcOp = String.Empty
            'Toggle the decimal flag
            hasDecimal = False
        End If
    End Sub
    Private Sub CalculateTotals()
        CalcVar2 = CType(txtInput.Text, Double)
        Select Case CalcOp
            Case "+"
                CalcVar1 = CalcVar1 + CalcVar2
            Case "-"
                CalcVar1 = CalcVar1 - CalcVar2
            Case "/"
                CalcVar1 = CalcVar1 / CalcVar2
            Case "*"
                CalcVar1 = CalcVar1 * CalcVar2
        End Select
        txtInput.Text = CType(CalcVar1, String)
        inputStatus = False
    End Sub
End Class
