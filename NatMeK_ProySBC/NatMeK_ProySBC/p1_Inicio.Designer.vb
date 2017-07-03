<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class p1_Inicio
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
		Me.pb_inicio = New System.Windows.Forms.PictureBox()
		Me.lb_descripción = New System.Windows.Forms.Label()
		Me.btn_consultar = New System.Windows.Forms.Button()
		Me.btn_adm = New System.Windows.Forms.Button()
		Me.lb_t2 = New System.Windows.Forms.Label()
		Me.lb_t1 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.pb_inicio, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pb_inicio
		'
		Me.pb_inicio.Image = Global.NatMeK_ProySBC.My.Resources.Resources.imageninicio
		Me.pb_inicio.Location = New System.Drawing.Point(43, 152)
		Me.pb_inicio.Name = "pb_inicio"
		Me.pb_inicio.Size = New System.Drawing.Size(316, 250)
		Me.pb_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pb_inicio.TabIndex = 2
		Me.pb_inicio.TabStop = False
		'
		'lb_descripción
		'
		Me.lb_descripción.AutoSize = True
		Me.lb_descripción.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_descripción.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lb_descripción.Location = New System.Drawing.Point(387, 168)
		Me.lb_descripción.Name = "lb_descripción"
		Me.lb_descripción.Size = New System.Drawing.Size(0, 18)
		Me.lb_descripción.TabIndex = 3
		Me.lb_descripción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btn_consultar
		'
		Me.btn_consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btn_consultar.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_consultar.ForeColor = System.Drawing.Color.Black
		Me.btn_consultar.Location = New System.Drawing.Point(390, 400)
		Me.btn_consultar.Name = "btn_consultar"
		Me.btn_consultar.Size = New System.Drawing.Size(127, 33)
		Me.btn_consultar.TabIndex = 4
		Me.btn_consultar.Text = "CONSULTAR"
		Me.btn_consultar.UseVisualStyleBackColor = False
		'
		'btn_adm
		'
		Me.btn_adm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btn_adm.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_adm.ForeColor = System.Drawing.Color.Black
		Me.btn_adm.Location = New System.Drawing.Point(530, 400)
		Me.btn_adm.Name = "btn_adm"
		Me.btn_adm.Size = New System.Drawing.Size(127, 33)
		Me.btn_adm.TabIndex = 5
		Me.btn_adm.Text = "ADMINISTRAR"
		Me.btn_adm.UseVisualStyleBackColor = False
		'
		'lb_t2
		'
		Me.lb_t2.AutoSize = True
		Me.lb_t2.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lb_t2.ForeColor = System.Drawing.Color.Maroon
		Me.lb_t2.Location = New System.Drawing.Point(420, 87)
		Me.lb_t2.Name = "lb_t2"
		Me.lb_t2.Size = New System.Drawing.Size(196, 45)
		Me.lb_t2.TabIndex = 7
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
		Me.lb_t1.TabIndex = 6
		Me.lb_t1.Text = "NATURAL MEDICINE KIT"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(22, 441)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(467, 12)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Elaborado por: Espinosa, Angel; González, Yorlenis; León, Valdir; Ojo, Karina"
		'
		'p1_Inicio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(684, 461)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lb_t2)
		Me.Controls.Add(Me.lb_t1)
		Me.Controls.Add(Me.btn_adm)
		Me.Controls.Add(Me.btn_consultar)
		Me.Controls.Add(Me.lb_descripción)
		Me.Controls.Add(Me.pb_inicio)
		Me.ForeColor = System.Drawing.Color.Green
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "p1_Inicio"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "BIENVENIDO"
		CType(Me.pb_inicio, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents pb_inicio As PictureBox
    Friend WithEvents lb_descripción As Label
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_adm As Button
    Friend WithEvents lb_t2 As Label
    Friend WithEvents lb_t1 As Label
    Friend WithEvents Label1 As Label
End Class
