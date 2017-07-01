Public Class r1_achiote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_fin.Click
        Me.Close()
        p1_Inicio.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_nconsulta.Click
        Me.Close()
        p2_área.Show()
    End Sub
End Class