Public Class Form1

    'Ellie Nia
    'Unit 4 Assignment- Function


    Private Sub Retailbtn_Click(sender As Object, e As EventArgs) Handles Retailbtn.Click
        'define variable
        Dim decWholesale As Decimal
        Dim decMark As Decimal
        Dim IntRetailPrice As Decimal

        'this IF check the user input the numeric and posetive number
        If IsNumeric(WholesaleCosttxt.Text) And IsNumeric(Marktxt.Text) = True Then 'if the user input are numeric put them in the variable
            decWholesale = CInt(WholesaleCosttxt.Text)
            decMark = CInt(Marktxt.Text)
            If decWholesale < 0 Or decMark < 0 Then 'if the user input are negetive show the error in label
                lblMessage.Text = "You shoul enter a posetive number, try again"
            Else
                IntRetailPrice = CalcRetailPrice(decWholesale, decMark) ' else call the function
                lblMessage.Text = "" 'clear the error 
            End If
        Else
            lblMessage.Text = ("Your Cost of item should be number, try again") 'if the input user aren't number show the error
        End If

        Retailtxt.Text = IntRetailPrice.ToString 'show the calculate numbers in the retail textbox

    End Sub
    Function CalcRetailPrice(ByVal decWholesaleCost As Decimal, ByRef Markup As Decimal) As Decimal
        'define the variable
        Dim Result As Decimal
        Result = decWholesaleCost + (decWholesaleCost * Markup / 100) 'calculate the mark up and put it in the variable

        Return Result 'return the calculation

    End Function

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        'close the project
        Me.Close()
    End Sub
End Class
