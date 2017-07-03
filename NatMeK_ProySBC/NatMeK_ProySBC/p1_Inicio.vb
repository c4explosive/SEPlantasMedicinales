Imports SbsSW.SwiPlCs

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
		'Me.Hide()
		Dim rad_array As RadioButton()
		ReDim rad_array(990)
		Dim i As Integer
		i = 0
		Dim y As Integer = 10
		connect_to_base()
		Dim loadr As PlQuery = New PlQuery("cargar('avescorredoras.bd')")
		loadr.NextSolution()
		Dim avescorr As PlQuery = New PlQuery("son_aves_corredoras(X)")
		For Each z As PlQueryVariables In avescorr.SolutionVariables
			rad_array(i) = New RadioButton
			'lstResponse.Items.Add(z("X").ToString)
			rad_array(i).Text = z("X").ToString
			rad_array(i).Location = New Point(0, y)
			Me.Controls.Add(rad_array(i))
			i += 1
			y += 100
			Debug.Print(z("X").ToString)
		Next
		'p2_área.Show()

	End Sub

	Private Sub pb_inicio_Click(sender As Object, e As EventArgs) Handles pb_inicio.Click

	End Sub
End Class