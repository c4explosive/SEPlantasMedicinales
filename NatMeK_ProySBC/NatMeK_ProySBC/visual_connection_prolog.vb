Imports SbsSW.SwiPlCs

Module visual_connection_prolog
	Private home As String
	Private Sub get_home_path()
		Debug.Print(Environment.GetEnvironmentVariable("userprofile"))
		home = Environment.GetEnvironmentVariable("userprofile")
	End Sub

	Public Sub connect_to_base()
		Dim p As String()
		get_home_path()
		Environment.SetEnvironmentVariable("Path", "C:\Program Files (x86)\swipl\bin")
		p = {"-q", "-f", home + "\Desktop\hyperclass\" + "avescorredoras.pl"}
		'Debug.Print(Environment.GetEnvironmentVariable("Path"))
		For Each x As String In p
			Debug.Print(x)
		Next
		PlEngine.Initialize(p)
	End Sub

	'Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
	'	lstResponse.Items.Clear()
	'	Dim loadr As PlQuery = New PlQuery("cargar('avescorredoras.bd')")
	'	loadr.NextSolution()
	'	Dim avescorr As PlQuery = New PlQuery("son_aves_corredoras(X)")
	'	For Each z As PlQueryVariables In avescorr.SolutionVariables
	'		lstResponse.Items.Add(z("X").ToString)
	'	Next

	'End Sub
End Module
