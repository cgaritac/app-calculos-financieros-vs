<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInteresCompuesto
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
        Me.btnCalcularComp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCapitalInicialComp = New System.Windows.Forms.TextBox()
        Me.btnOtroComp = New System.Windows.Forms.Button()
        Me.btnSalirComp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAniosComp = New System.Windows.Forms.TextBox()
        Me.txtTasaInteresComp = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcularComp
        '
        Me.btnCalcularComp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularComp.Location = New System.Drawing.Point(54, 328)
        Me.btnCalcularComp.Name = "btnCalcularComp"
        Me.btnCalcularComp.Size = New System.Drawing.Size(94, 23)
        Me.btnCalcularComp.TabIndex = 1
        Me.btnCalcularComp.Text = "Calcular"
        Me.btnCalcularComp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CÁLCULO DE INTERÉS COMPUESTO DE UNA INVERSIÓN"
        '
        'txtCapitalInicialComp
        '
        Me.txtCapitalInicialComp.Location = New System.Drawing.Point(236, 71)
        Me.txtCapitalInicialComp.Name = "txtCapitalInicialComp"
        Me.txtCapitalInicialComp.Size = New System.Drawing.Size(100, 22)
        Me.txtCapitalInicialComp.TabIndex = 3
        '
        'btnOtroComp
        '
        Me.btnOtroComp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtroComp.Location = New System.Drawing.Point(224, 328)
        Me.btnOtroComp.Name = "btnOtroComp"
        Me.btnOtroComp.Size = New System.Drawing.Size(127, 23)
        Me.btnOtroComp.TabIndex = 4
        Me.btnOtroComp.Text = "Otro Cálculo"
        Me.btnOtroComp.UseVisualStyleBackColor = True
        '
        'btnSalirComp
        '
        Me.btnSalirComp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirComp.Location = New System.Drawing.Point(444, 328)
        Me.btnSalirComp.Name = "btnSalirComp"
        Me.btnSalirComp.Size = New System.Drawing.Size(81, 23)
        Me.btnSalirComp.TabIndex = 5
        Me.btnSalirComp.Text = "Salir"
        Me.btnSalirComp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor de la Inversión:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "¿Cuánto recibe al cabo de "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Interés Compuesto Anual:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(382, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "años?"
        '
        'txtAniosComp
        '
        Me.txtAniosComp.Location = New System.Drawing.Point(263, 228)
        Me.txtAniosComp.Name = "txtAniosComp"
        Me.txtAniosComp.Size = New System.Drawing.Size(100, 22)
        Me.txtAniosComp.TabIndex = 10
        '
        'txtTasaInteresComp
        '
        Me.txtTasaInteresComp.Location = New System.Drawing.Point(263, 143)
        Me.txtTasaInteresComp.Name = "txtTasaInteresComp"
        Me.txtTasaInteresComp.Size = New System.Drawing.Size(100, 22)
        Me.txtTasaInteresComp.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Finanzas.My.Resources.Resources.Interes_Compuesto
        Me.PictureBox1.Location = New System.Drawing.Point(398, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmInteresCompuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 433)
        Me.Controls.Add(Me.txtTasaInteresComp)
        Me.Controls.Add(Me.txtAniosComp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalirComp)
        Me.Controls.Add(Me.btnOtroComp)
        Me.Controls.Add(Me.txtCapitalInicialComp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcularComp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmInteresCompuesto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interés Compuesto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCalcularComp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCapitalInicialComp As TextBox
    Friend WithEvents btnOtroComp As Button
    Friend WithEvents btnSalirComp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAniosComp As TextBox
    Friend WithEvents txtTasaInteresComp As TextBox
End Class
