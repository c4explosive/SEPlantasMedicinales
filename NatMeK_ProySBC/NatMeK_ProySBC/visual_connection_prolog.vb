Imports SbsSW.SwiPlCs


Module visual_connection_prolog

	Public zBase As String = "enfermedades.bd"
	Private home As String

	Public can_connect = 1
	Public opt_elegida = ""

	Private Sub get_home_path()
		Debug.Print(Environment.GetEnvironmentVariable("userprofile"))
		home = Environment.GetEnvironmentVariable("userprofile")
	End Sub

	Public Sub connect_to_base()
		Dim p As String()
		get_home_path()
		Environment.SetEnvironmentVariable("Path", "C:\Program Files (x86)\swipl\bin")
		p = {"-q", "-f", home + "\Desktop\hyperclass\" + "enfermedades.pl"}
		'Debug.Print(Environment.GetEnvironmentVariable("Path"))
		For Each x As String In p
			Debug.Print(x)
		Next
		PlEngine.Initialize(p)
	End Sub

	Private Sub prepareQuery(ByVal zQuery As String, ByRef zoptions As resultsopts)
		Dim nStrings As Integer = 0
		Dim i As Integer = 0
		Dim strings_array As String()
		ReDim strings_array(900)
		Dim loadr As PlQuery = New PlQuery("cargar('" & zBase & "')")
		loadr.NextSolution()
		Dim avescorr As PlQuery = New PlQuery(zQuery)
		For Each z As PlQueryVariables In avescorr.SolutionVariables
			'Debug.Print(z("X").ToString)
			strings_array(nStrings) = z("X").ToString
			nStrings += 1
		Next
		zoptions.set_num_res(nStrings)
		zoptions.dimension_opciones_txt(nStrings)
		For i = 0 To nStrings
			zoptions.add_opciones_txt(strings_array(i), i)
		Next

	End Sub

	Public Sub get_Query_res(ByVal zQuery As String, ByRef zoptions As resultsopts)
		If (can_connect) Then
			connect_to_base()
			can_connect = 0
		End If
		prepareQuery(zQuery, zoptions)
	End Sub

	Private Function convert_under_tospace(ByVal name As String) As String
		Dim name_alt As String = ""
		Dim i As Integer = 0
		Dim space As Integer = 0
		Dim ant As Char = ""
		For Each ch In name
			If (ant = "_") Then
				ch = UCase(ch)
				ant = ch
			End If
			If (i = 0) Then
				ch = UCase(ch)
			End If
			If (ch = "_") Then
				ant = ch
				ch = " "
			End If
			name_alt += ch
			i += 1
		Next
		name = name_alt
		Return name
	End Function

	Public Function method_gen_options(ByRef zoptions As resultsopts,
								  ByRef zform As Form) As RadioButton()
		Dim rad_array As RadioButton()
		ReDim rad_array(zoptions.get_num_res())
		Dim i As Integer = 0
		Dim y As Integer = 190
		Dim como_estaba As String = ""
		For i = 0 To zoptions.get_num_res - 1
			rad_array(i) = New RadioButton
			rad_array(i).AutoSize = True
			como_estaba = zoptions.get_opciones_txt(i)
			rad_array(i).Text = convert_under_tospace(zoptions.get_opciones_txt(i))
			rad_array(i).Location = New Point(10, y)
			If (i = 0) Then
				rad_array(i).Checked = True
			End If
			zform.Controls.Add(rad_array(i))
			rad_array(i).Tag = como_estaba
			y += 20
		Next
		Return rad_array
	End Function

	Public Function get_options_true(ByRef ropts As RadioButton()) As String
		For Each r In ropts
			If (r.Checked) Then
				Return r.Tag
			End If
		Next
		Return ""
	End Function

	Public Sub finalizar()
		'Debug.Print("Finalizando")
		p1_Inicio.Close()
	End Sub

	Public Sub reset_consulta()
		For Each form In dict_plantas_con.Values
			form.Hide()
		Next
		p2_área.Close()
		p3_enfermedad.Close()
		p4_preparacion.Close()
		p6_plantas.Close()
		dict_plantas_con = New Dictionary(Of String, Form)
		plants_choose = ""
		preparacion_choose = ""
		enfermedad_choose = ""
		p1_Inicio.Show()
	End Sub

	Public btn As Button

	Public Sub add_finalizar()

		Dim ctrls As Control()
		For Each form In dict_plantas_con.Values
			ctrls = form.Controls.Find("btn_fin", False)
			btn = CType(ctrls(0), Button)
			AddHandler btn.Click, AddressOf finalizar
		Next

	End Sub

	Public Sub add_restore()

		Dim ctrls As Control()
		For Each form In dict_plantas_con.Values
			ctrls = form.Controls.Find("btn_nconsulta", False)
			btn = CType(ctrls(0), Button)
			AddHandler btn.Click, AddressOf reset_consulta
		Next

	End Sub

End Module
