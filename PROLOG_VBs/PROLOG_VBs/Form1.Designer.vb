<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnQuery = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lstResponse = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnQuery
		'
		Me.btnQuery.Location = New System.Drawing.Point(34, 12)
		Me.btnQuery.Name = "btnQuery"
		Me.btnQuery.Size = New System.Drawing.Size(75, 23)
		Me.btnQuery.TabIndex = 0
		Me.btnQuery.Text = "Print"
		Me.btnQuery.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(31, 59)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(58, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Response:"
		'
		'lstResponse
		'
		Me.lstResponse.FormattingEnabled = True
		Me.lstResponse.Location = New System.Drawing.Point(34, 89)
		Me.lstResponse.Name = "lstResponse"
		Me.lstResponse.Size = New System.Drawing.Size(259, 95)
		Me.lstResponse.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(321, 204)
		Me.Controls.Add(Me.lstResponse)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnQuery)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnQuery As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents lstResponse As ListBox
End Class
