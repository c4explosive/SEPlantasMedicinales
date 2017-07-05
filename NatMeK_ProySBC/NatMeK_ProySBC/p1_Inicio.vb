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
		Me.Hide()
		Dim res As New resultsopts
		get_Query_res("areas_get_filt(X)", res)
		rnum_options = method_gen_options(res, p2_área)
		p2_área.Show()

	End Sub

	Private Sub pb_inicio_Click(sender As Object, e As EventArgs) Handles pb_inicio.Click
		Debug.Print("My name is: " & Me.Name)
		load_dict_con()
	End Sub
End Class