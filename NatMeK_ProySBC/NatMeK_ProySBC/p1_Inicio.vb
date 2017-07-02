Public Class p1_Inicio
    Private Sub p1_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_descripción.Text = " " & vbCrLf &
                              "NatMek es un sistema que orienta" & vbCrLf &
                              "en  la  utilización  de  plantas" & vbCrLf &
                              "medicinales en el tratamiento de" & vbCrLf &
                              "padecimientos comunes, es decir," & vbCrLf &
                              "que no son de carácter crónico." & vbCrLf &
                              " " & vbCrLf &
                              " " & vbCrLf &
                              " " & vbCrLf &
                              "Para empezar, elija una de las" & vbCrLf &
                              "siguientes opciones:"
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Me.Hide()
        p2_área.Show()

    End Sub
End Class