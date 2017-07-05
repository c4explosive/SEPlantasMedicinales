Public Class p2_área
	Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click

		opt_elegida = get_options_true(rnum_options)
		Debug.Print("Area choosed:: " & opt_elegida)

		Me.Hide()
		Dim res As New resultsopts
		get_Query_res("enfermedades_get(" & opt_elegida & ",X)", res)
		rnum_options = method_gen_options(res, p3_enfermedad)

		p3_enfermedad.Show()

	End Sub
End Class