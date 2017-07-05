Module Entities_classes

	Public rnum_options As RadioButton()
	Public dict_plantas_con As New Dictionary(Of String, Form)
	Public plants_choose As String
	Public preparacion_choose As String
	Public enfermedad_choose As String

	Public Class resultsopts
		Dim num_res As Integer
		Dim opciones_txt As String()

		Public Sub set_num_res(ByVal n As Integer)
			num_res = n
		End Sub

		Public Function get_num_res() As Integer
			Return num_res
		End Function

		Public Sub dimension_opciones_txt(ByVal dime As Integer)
			ReDim opciones_txt(num_res)
		End Sub

		Public Sub add_opciones_txt(ByVal elem As String, ByVal e As Integer)
			opciones_txt(e) = elem
		End Sub

		Public Function get_opciones_txt(ByVal e As Integer) As String
			Return opciones_txt(e)
		End Function

		Public Sub Reset_All()
			For Each s In opciones_txt
				s = ""
			Next s
			num_res = 0
			ReDim opciones_txt(0)
		End Sub

	End Class

	Public Sub load_dict_con()
		Dim sPlantas As Form() = {
			r1_achiote, r1_aloevera, r1_anis, r1_arnica, r1_boldo, r1_canela, r1_cidron, r1_eucalipto,
			r1_jengibre, r1_laurel, r1_llanten, r1_manzanilla, r1_oregano, r1_ortiga, r1_paico, r1_perejil,
			r1_romero, r1_ruda, r1_salvia, r1_tamarindo, r1_tilo, r1_toronjil, r1_valeriana, r1_yerbabuena,
			r2_achiote, r2_aloevera, r2_anis, r2_arnica, r2_boldo, r2_canela, r2_cidron, r2_eucalipto, r2_laurel,
			r2_llanten, r2_manzanilla, r2_oregano, r2_ortiga, r2_paico, r2_perejil, r2_romero, r2_ruda, r2_salvia,
			r2_tamarindo, r2_tilo, r2_valeriana, r2_yerbabuena, r3_aloevera, r3_boldo, r3_canela, r3_cidron, r3_laurel,
			r3_llanten, r3_manzanilla, r3_oregano, r3_ortiga, r3_paico, r3_perejil, r3_salvia, r3_tamarindo, r3_yerbabuena,
			r4_aloevera, r4_boldo, r4_canela, r4_laurel, r4_llanten, r4_oregano, r4_ortiga}
		For Each frm In sPlantas
			With dict_plantas_con
				.Add(frm.Name, frm)
			End With
		Next
		Dim i As Integer = 0
		'For i = 0 To sPlantas.Length - 1
		'	Debug.Print("form(" & dict_plantas_con.Keys(i).ToString & ",Y,Z) :- planta(la_planta,tipo_preparacion).")
		'Next

	End Sub

End Module
