<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.itemFormulas = New System.Windows.Forms.ToolStripMenuItem()
        Me.subitemInteresSimple = New System.Windows.Forms.ToolStripMenuItem()
        Me.subitemInteresCompuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.mnuMenuPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemFormulas, Me.itemAyuda, Me.itemSalir})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(652, 28)
        Me.mnuMenuPrincipal.TabIndex = 0
        Me.mnuMenuPrincipal.Text = "Menú Programas"
        '
        'itemFormulas
        '
        Me.itemFormulas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subitemInteresSimple, Me.subitemInteresCompuesto})
        Me.itemFormulas.Image = Global.Finanzas.My.Resources.Resources.Finanzas
        Me.itemFormulas.Name = "itemFormulas"
        Me.itemFormulas.Size = New System.Drawing.Size(174, 24)
        Me.itemFormulas.Text = "Cálculos Financieros"
        '
        'subitemInteresSimple
        '
        Me.subitemInteresSimple.Image = Global.Finanzas.My.Resources.Resources.tasa_interes_simple
        Me.subitemInteresSimple.Name = "subitemInteresSimple"
        Me.subitemInteresSimple.Size = New System.Drawing.Size(216, 26)
        Me.subitemInteresSimple.Text = "Interés Simple"
        '
        'subitemInteresCompuesto
        '
        Me.subitemInteresCompuesto.Image = Global.Finanzas.My.Resources.Resources.interescompuesto
        Me.subitemInteresCompuesto.Name = "subitemInteresCompuesto"
        Me.subitemInteresCompuesto.Size = New System.Drawing.Size(216, 26)
        Me.subitemInteresCompuesto.Text = "Interés Compuesto"
        '
        'itemAyuda
        '
        Me.itemAyuda.Image = Global.Finanzas.My.Resources.Resources.ayuda
        Me.itemAyuda.Name = "itemAyuda"
        Me.itemAyuda.Size = New System.Drawing.Size(83, 24)
        Me.itemAyuda.Text = "Ayuda"
        '
        'itemSalir
        '
        Me.itemSalir.Image = Global.Finanzas.My.Resources.Resources.salir
        Me.itemSalir.Name = "itemSalir"
        Me.itemSalir.Size = New System.Drawing.Size(70, 24)
        Me.itemSalir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(102, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sistemas de Cálculos Financieros"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Finanzas.My.Resources.Resources.CalculosFinancieros
        Me.PictureBox1.Location = New System.Drawing.Point(42, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'tbDescripcion
        '
        Me.tbDescripcion.BackColor = System.Drawing.SystemColors.Info
        Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.Location = New System.Drawing.Point(60, 308)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.ReadOnly = True
        Me.tbDescripcion.Size = New System.Drawing.Size(533, 81)
        Me.tbDescripcion.TabIndex = 3
        Me.tbDescripcion.Text = "Esta aplicación le permitirá realizar diferentes cálculos financieros, de una for" &
    "ma muy sencilla utilizando varios formularios."
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 433)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuMenuPrincipal)
        Me.MainMenuStrip = Me.mnuMenuPrincipal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal Finanzas"
        Me.mnuMenuPrincipal.ResumeLayout(False)
        Me.mnuMenuPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuPrincipal As MenuStrip
    Friend WithEvents itemFormulas As ToolStripMenuItem
    Friend WithEvents subitemInteresSimple As ToolStripMenuItem
    Friend WithEvents subitemInteresCompuesto As ToolStripMenuItem
    Friend WithEvents itemAyuda As ToolStripMenuItem
    Friend WithEvents itemSalir As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbDescripcion As TextBox
End Class
