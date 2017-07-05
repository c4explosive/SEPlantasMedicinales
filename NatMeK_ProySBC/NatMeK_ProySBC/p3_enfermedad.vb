Public Class p3_enfermedad
    Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click
		Me.Hide()

		opt_elegida = get_options_true(rnum_options)
		Debug.Print("Area choosed:: " & opt_elegida)
		enfermedad_choose = opt_elegida

		Dim res As New resultsopts
		get_Query_res("preparacion_get(X," & opt_elegida & ")", res)
		rnum_options = method_gen_options(res, p4_preparacion)

		p4_preparacion.Show()

    End Sub

End Class