Public Class p4_preparacion
	Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click
		opt_elegida = get_options_true(rnum_options)
		preparacion_choose = opt_elegida
		Debug.Print("Area choosed:: " & opt_elegida)
		Me.Hide()
		Dim res As New resultsopts
		get_Query_res("plas_prep_enf_get(X," & preparacion_choose & "," & enfermedad_choose & ")", res)
		'Debug.Print("GET Q::" & "plas_prep_enf_get(X," & preparacion_choose & "," & enfermedad_choose & ").")
		rnum_options = method_gen_options(res, p6_plantas)
		p6_plantas.Show()
	End Sub
End Class