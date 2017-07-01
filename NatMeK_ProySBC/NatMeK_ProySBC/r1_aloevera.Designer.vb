<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class r1_aloevera
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
        Me.btn_nconsulta = New System.Windows.Forms.Button()
        Me.btn_fin = New System.Windows.Forms.Button()
        Me.lb_t2 = New System.Windows.Forms.Label()
        Me.lb_t1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_nconsulta
        '
        Me.btn_nconsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nconsulta.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nconsulta.Location = New System.Drawing.Point(331, 420)
        Me.btn_nconsulta.Name = "btn_nconsulta"
        Me.btn_nconsulta.Size = New System.Drawing.Size(132, 29)
        Me.btn_nconsulta.TabIndex = 36
        Me.btn_nconsulta.Text = "NUEVA CONSULTA"
        Me.btn_nconsulta.UseVisualStyleBackColor = False
        '
        'btn_fin
        '
        Me.btn_fin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_fin.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fin.Location = New System.Drawing.Point(512, 420)
        Me.btn_fin.Name = "btn_fin"
        Me.btn_fin.Size = New System.Drawing.Size(132, 29)
        Me.btn_fin.TabIndex = 35
        Me.btn_fin.Text = "FINALIZAR"
        Me.btn_fin.UseVisualStyleBackColor = False
        '
        'lb_t2
        '
        Me.lb_t2.AutoSize = True
        Me.lb_t2.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_t2.ForeColor = System.Drawing.Color.Maroon
        Me.lb_t2.Location = New System.Drawing.Point(420, 87)
        Me.lb_t2.Name = "lb_t2"
        Me.lb_t2.Size = New System.Drawing.Size(196, 45)
        Me.lb_t2.TabIndex = 31
        Me.lb_t2.Text = "NatMeK"
        '
        'lb_t1
        '
        Me.lb_t1.AutoSize = True
        Me.lb_t1.Font = New System.Drawing.Font("Hobo Std", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_t1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_t1.Location = New System.Drawing.Point(102, 33)
        Me.lb_t1.Name = "lb_t1"
        Me.lb_t1.Size = New System.Drawing.Size(462, 54)
        Me.lb_t1.TabIndex = 30
        Me.lb_t1.Text = "NATURAL MEDICINE KIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(382, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 36)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Nombres Comunes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sábila, Aloe de Barbados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(343, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 75)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Precauciones:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No usar por tiempo prolongados, puede " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "resultar tóxico al trast" &
    "ornar la circulación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y provocar congestión cerebral."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 72)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Preparación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Licuar la pulpa del aloe vera y la mezclamos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "con un jugo de cualqui" &
    "er fruta y un poco " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de miel."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NatMeK_ProySBC.My.Resources.Resources.sabila
        Me.PictureBox1.Location = New System.Drawing.Point(21, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'r1_aloevera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_nconsulta)
        Me.Controls.Add(Me.btn_fin)
        Me.Controls.Add(Me.lb_t2)
        Me.Controls.Add(Me.lb_t1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "r1_aloevera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NatMeK"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_nconsulta As Button
    Friend WithEvents btn_fin As Button
    Friend WithEvents lb_t2 As Label
    Friend WithEvents lb_t1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
