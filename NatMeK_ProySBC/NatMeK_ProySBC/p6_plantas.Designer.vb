<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p6_plantas
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
		Me.btn_continuar = New System.Windows.Forms.Button()
		Me.lb_indica = New System.Windows.Forms.Label()
		Me.lb_t2 = New System.Windows.Forms.Label()
		Me.lb_t1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btn_continuar
		'
		Me.btn_continuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btn_continuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_continuar.Location = New System.Drawing.Point(530, 400)
		Me.btn_continuar.Name = "btn_continuar"
		Me.btn_continuar.Size = New System.Drawing.Size(127, 33)
		Me.btn_continuar.TabIndex = 16
		Me.btn_continuar.Text = "CONTINUAR"
		Me.btn_continuar.UseVisualStyleBackColor = False
		'
		'lb_indica
		'
		Me.lb_indica.AutoSize = True
		Me.lb_indica.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_indica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lb_indica.Location = New System.Drawing.Point(53, 149)
		Me.lb_indica.Name = "lb_indica"
		Me.lb_indica.Size = New System.Drawing.Size(539, 36)
		Me.lb_indica.TabIndex = 15
		Me.lb_indica.Text = "Seleccione una planta para información adicional como los pasos de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "preparación " &
	"y dosificación"
		'
		'lb_t2
		'
		Me.lb_t2.AutoSize = True
		Me.lb_t2.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_t2.ForeColor = System.Drawing.Color.Maroon
		Me.lb_t2.Location = New System.Drawing.Point(420, 87)
		Me.lb_t2.Name = "lb_t2"
		Me.lb_t2.Size = New System.Drawing.Size(196, 45)
		Me.lb_t2.TabIndex = 14
		Me.lb_t2.Text = "NatMeK"
		'
		'lb_t1
		'
		Me.lb_t1.AutoSize = True
		Me.lb_t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_t1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lb_t1.Location = New System.Drawing.Point(102, 33)
		Me.lb_t1.Name = "lb_t1"
		Me.lb_t1.Size = New System.Drawing.Size(456, 44)
		Me.lb_t1.TabIndex = 13
		Me.lb_t1.Text = "NATURAL MEDICINE KIT"
		'
		'p6_plantas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(684, 461)
		Me.Controls.Add(Me.btn_continuar)
		Me.Controls.Add(Me.lb_indica)
		Me.Controls.Add(Me.lb_t2)
		Me.Controls.Add(Me.lb_t1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "p6_plantas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatMeK"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btn_continuar As Button
    Friend WithEvents lb_indica As Label
    Friend WithEvents lb_t2 As Label
    Friend WithEvents lb_t1 As Label
End Class
