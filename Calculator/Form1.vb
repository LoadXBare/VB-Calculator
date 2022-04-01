Public Class Calculator
    Dim storedResult As Integer = 0

    Sub Add_Text_To_Screen(screen As Label, textToAdd As String)
        If (screen.Text = "Enter number(s)") Then
            screen.Text = textToAdd
        Else
            screen.Text &= textToAdd
        End If
    End Sub

    Sub Calculate_Stored_Result(screen As Label, operation As String)
        If (operation = "+") Then
            storedResult += screen.Text
        ElseIf (operation = "-") Then
            storedResult -= screen.Text
        ElseIf (operation = "*") Then
            storedResult *= screen.Text
        ElseIf (operation = "/") Then
            storedResult /= screen.Text
        Else
            storedResult = screen.Text
        End If
    End Sub

    Private Sub Keypad_0_Click(sender As Object, e As EventArgs) Handles Keypad_0.Click
        Add_Text_To_Screen(Screen, "0")
    End Sub

    Private Sub Keypad_1_Click(sender As Object, e As EventArgs) Handles Keypad_1.Click
        Add_Text_To_Screen(Screen, "1")
    End Sub

    Private Sub Keypad_2_Click(sender As Object, e As EventArgs) Handles Keypad_2.Click
        Add_Text_To_Screen(Screen, "2")
    End Sub

    Private Sub Keypad_3_Click(sender As Object, e As EventArgs) Handles Keypad_3.Click
        Add_Text_To_Screen(Screen, "3")
    End Sub

    Private Sub Keypad_4_Click(sender As Object, e As EventArgs) Handles Keypad_4.Click
        Add_Text_To_Screen(Screen, "4")
    End Sub

    Private Sub Keypad_5_Click(sender As Object, e As EventArgs) Handles Keypad_5.Click
        Add_Text_To_Screen(Screen, "5")
    End Sub

    Private Sub Keypad_6_Click(sender As Object, e As EventArgs) Handles Keypad_6.Click
        Add_Text_To_Screen(Screen, "6")
    End Sub

    Private Sub Keypad_7_Click(sender As Object, e As EventArgs) Handles Keypad_7.Click
        Add_Text_To_Screen(Screen, "7")
    End Sub

    Private Sub Keypad_8_Click(sender As Object, e As EventArgs) Handles Keypad_8.Click
        Add_Text_To_Screen(Screen, "8")
    End Sub

    Private Sub Keypad_9_Click(sender As Object, e As EventArgs) Handles Keypad_9.Click
        Add_Text_To_Screen(Screen, "9")
    End Sub

    Private Sub Keypad_div_Click(sender As Object, e As EventArgs) Handles Keypad_div.Click
        Calculate_Stored_Result(Screen, Screen_Operator.Text)
        Screen.Text = ""
        Screen_Operator.Text = "/"
        Screen_Prev.Text = storedResult
    End Sub

    Private Sub Keypad_multi_Click(sender As Object, e As EventArgs) Handles Keypad_multi.Click
        Calculate_Stored_Result(Screen, Screen_Operator.Text)
        Screen.Text = ""
        Screen_Operator.Text = "*"
        Screen_Prev.Text = storedResult
    End Sub

    Private Sub Keypad_minus_Click(sender As Object, e As EventArgs) Handles Keypad_minus.Click
        Calculate_Stored_Result(Screen, Screen_Operator.Text)
        Screen.Text = ""
        Screen_Operator.Text = "-"
        Screen_Prev.Text = storedResult
    End Sub

    Private Sub Keypad_plus_Click(sender As Object, e As EventArgs) Handles Keypad_plus.Click
        Calculate_Stored_Result(Screen, Screen_Operator.Text)
        Screen.Text = ""
        Screen_Operator.Text = "+"
        Screen_Prev.Text = storedResult
    End Sub

    Private Sub Keypad_clear_Click(sender As Object, e As EventArgs) Handles Keypad_clear.Click, Keypad_clear.Click
        Screen.Text = ""
        Screen_Prev.Text = ""
        Screen_Operator.Text = ""
        storedResult = 0
    End Sub

    Private Sub Keypad_equal_Click(sender As Object, e As EventArgs) Handles Keypad_equal.Click
        Dim result As Integer = storedResult
        If (Screen_Operator.Text = "+") Then
            result += Screen.Text
        ElseIf (Screen_Operator.Text = "-") Then
            result -= Screen.Text
        ElseIf (Screen_Operator.Text = "*") Then
            result *= Screen.Text
        ElseIf (Screen_Operator.Text = "/") Then
            result /= Screen.Text
        Else
            result = Screen.Text
        End If
        Screen.Text = result
        Screen_Operator.Text = ""
        Screen_Prev.Text = ""

        storedResult = 0
    End Sub
End Class
