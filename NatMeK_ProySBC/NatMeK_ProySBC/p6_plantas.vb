Public Class p6_plantas
	Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click
		opt_elegida = get_options_true(rnum_options)
		plants_choose = opt_elegida
		load_dict_con()
		Dim res As New resultsopts
		Dim the_form As String = ""
		get_Query_res("get_form(X," & plants_choose & "," & preparacion_choose & ")", res)
		'Debug.Print("GET: Q::" & "get_form(X," & plants_choose & "," & preparacion_choose & ").")
		For i = 0 To res.get_num_res - 1
			the_form = res.get_opciones_txt(0)
		Next
		If (the_form IsNot "") Then
			Dim formt As Form = dict_plantas_con.Item(the_form)
			Debug.Print("Form ejecutado: " & the_form)
			formt.Show()
			Me.Hide()
		Else
			MsgBox("No se encontró este método de preparación para esta planta")

		End If
		add_finalizar()
		add_restore()

	End Sub
End Class