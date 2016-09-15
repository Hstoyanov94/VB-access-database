Public Class Библиотека

    Private Sub Библиотека_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Библиотека_КурсоваDataSet.Читатели' table. You can move, or remove it, as needed.
        Me.ЧитателиTableAdapter.Fill(Me.Библиотека_КурсоваDataSet.Читатели)
        'TODO: This line of code loads data into the 'Библиотека_КурсоваDataSet.Книги' table. You can move, or remove it, as needed.
        Me.КнигиTableAdapter.Fill(Me.Библиотека_КурсоваDataSet.Книги)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        КнигиBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        КнигиBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        КнигиBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        КнигиBindingSource.EndEdit()
        КнигиTableAdapter.Update(Библиотека_КурсоваDataSet.Книги)
        MessageBox.Show("Промените са запазени")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Наистина ли искате да изтриете записа?", MsgBoxStyle.YesNo, "Съобщение")
        If ask = MsgBoxResult.Yes Then
            КнигиBindingSource.RemoveCurrent()
        ElseIf ask = MsgBoxResult.No Then

        End If




    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    'Dim ask As MsgBoxResult
    ' ask = MsgBox("Наистина ли искате да излезете?", MsgBoxStyle.YesNo, "Съобщение")
    ' If ask = MsgBoxResult.Yes Then
    '  MessageBox.Show("Довиждане")
    ' Me.Close()
    'ElseIf ask = MsgBoxResult.No Then

    ' End If'


    'End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ЧитателиBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ЧитателиBindingSource.AddNew()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ЧитателиBindingSource.MoveNext()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error GoTo SaveErr
        ЧитателиBindingSource.EndEdit()
        ЧитателиTableAdapter.Update(Библиотека_КурсоваDataSet.Читатели)
        MessageBox.Show("Промените са запазени")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Наистина ли искате да изтриете записа?", MsgBoxStyle.YesNo, "Съобщение")
        If ask = MsgBoxResult.Yes Then
            ЧитателиBindingSource.RemoveCurrent()
        ElseIf ask = MsgBoxResult.No Then

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Dim ask As MsgBoxResult
        ask = MsgBox("Наистина ли искате да излезете?", MsgBoxStyle.YesNo, "Съобщение")
        If ask = MsgBoxResult.Yes Then
            MessageBox.Show("Довиждане")
            Me.Close()
        ElseIf ask = MsgBoxResult.No Then

        End If


    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
