<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInteresSimple
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
        Me.txtAniosSimp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcularSimp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTasaInteresSimp = New System.Windows.Forms.TextBox()
        Me.txtCapitalInicialSimp = New System.Windows.Forms.TextBox()
        Me.btnSalirSimp = New System.Windows.Forms.Button()
        Me.btnOtroSimp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAniosSimp
        '
        Me.txtAniosSimp.Location = New System.Drawing.Point(268, 242)
        Me.txtAniosSimp.Name = "txtAniosSimp"
        Me.txtAniosSimp.Size = New System.Drawing.Size(100, 22)
        Me.txtAniosSimp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CÁLCULO DE INTERÉS SIMPLE DE UNA INVERSIÓN"
        '
        'btnCalcularSimp
        '
        Me.btnCalcularSimp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularSimp.Location = New System.Drawing.Point(45, 326)
        Me.btnCalcularSimp.Name = "btnCalcularSimp"
        Me.btnCalcularSimp.Size = New System.Drawing.Size(94, 23)
        Me.btnCalcularSimp.TabIndex = 2
        Me.btnCalcularSimp.Text = "Calcular"
        Me.btnCalcularSimp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "años?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "¿Cuánto recibe al cabo de "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Interés Simple Anual:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Valor de la Inversión:"
        '
        'txtTasaInteresSimp
        '
        Me.txtTasaInteresSimp.Location = New System.Drawing.Point(236, 166)
        Me.txtTasaInteresSimp.Name = "txtTasaInteresSimp"
        Me.txtTasaInteresSimp.Size = New System.Drawing.Size(100, 22)
        Me.txtTasaInteresSimp.TabIndex = 8
        '
        'txtCapitalInicialSimp
        '
        Me.txtCapitalInicialSimp.Location = New System.Drawing.Point(236, 93)
        Me.txtCapitalInicialSimp.Name = "txtCapitalInicialSimp"
        Me.txtCapitalInicialSimp.Size = New System.Drawing.Size(100, 22)
        Me.txtCapitalInicialSimp.TabIndex = 9
        '
        'btnSalirSimp
        '
        Me.btnSalirSimp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirSimp.Location = New System.Drawing.Point(400, 326)
        Me.btnSalirSimp.Name = "btnSalirSimp"
        Me.btnSalirSimp.Size = New System.Drawing.Size(87, 23)
        Me.btnSalirSimp.TabIndex = 10
        Me.btnSalirSimp.Text = "Salir"
        Me.btnSalirSimp.UseVisualStyleBackColor = True
        '
        'btnOtroSimp
        '
        Me.btnOtroSimp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtroSimp.Location = New System.Drawing.Point(202, 326)
        Me.btnOtroSimp.Name = "btnOtroSimp"
        Me.btnOtroSimp.Size = New System.Drawing.Size(134, 23)
        Me.btnOtroSimp.TabIndex = 11
        Me.btnOtroSimp.Text = "Otro Cálculo"
        Me.btnOtroSimp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Finanzas.My.Resources.Resources.interes_simple_1_728
        Me.PictureBox1.Location = New System.Drawing.Point(357, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FrmInteresSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 433)
        Me.Controls.Add(Me.btnOtroSimp)
        Me.Controls.Add(Me.btnSalirSimp)
        Me.Controls.Add(Me.txtCapitalInicialSimp)
        Me.Controls.Add(Me.txtTasaInteresSimp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalcularSimp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAniosSimp)
        Me.Name = "FrmInteresSimple"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interés Simple"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAniosSimp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcularSimp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTasaInteresSimp As TextBox
    Friend WithEvents txtCapitalInicialSimp As TextBox
    Friend WithEvents btnSalirSimp As Button
    Friend WithEvents btnOtroSimp As Button
End Class
