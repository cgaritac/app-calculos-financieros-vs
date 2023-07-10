Public Class FrmInteresCompuesto
    Private Sub btnCalcularComp_Click(sender As Object, e As EventArgs) Handles btnCalcularComp.Click
        Dim capitalinicialcomp As Double = 0
        Dim tasaanualcomp As Double = 0.0
        Dim anioscomp As Double = 0
        Dim capitalfinalcomp As Double = 0.0

        'verificar si agregó todos los datos'

        If Len(Trim(txtCapitalInicialComp.Text)) = 0 Then
            MessageBox.Show("Por Favor ingrese el monto del capital a invertir", "Error entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCapitalInicialComp.Focus()
            Exit Sub
        End If

        If Len(Trim(txtTasaInteresComp.Text)) = 0 Then
            MessageBox.Show("Por Favor ingrese la tasa de interés de la inversión", "Error entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTasaInteresComp.Focus()
            Exit Sub
        End If

        If Len(Trim(txtAniosComp.Text)) = 0 Then
            MessageBox.Show("Por Favor ingrese el plazo en años", "Error entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAniosComp.Focus()
            Exit Sub
        End If

        'Asignación de datos de textbox a variables'

        capitalinicialcomp = txtCapitalInicialComp.Text
        tasaanualcomp = txtTasaInteresComp.Text
        anioscomp = txtAniosComp.Text

        'Fórmula de cálculo de interés compuesto'

        capitalfinalcomp = capitalinicialcomp * (1 + tasaanualcomp) ^ anioscomp

        capitalfinalcomp = Math.Truncate(capitalfinalcomp * 100) / 100

        MessageBox.Show("El capital a recibir es de " & capitalfinalcomp, "Monto a recibir", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnOtroComp_Click(sender As Object, e As EventArgs) Handles btnOtroComp.Click
        txtCapitalInicialComp.Text = ""
        txtTasaInteresComp.Text = ""
        txtAniosComp.Text = ""
        txtCapitalInicialComp.Focus()
    End Sub

    Private Sub btnSalirComp_Click(sender As Object, e As EventArgs) Handles btnSalirComp.Click
        Me.Close()
    End Sub

    Private Sub txtCapitalInicialComp_TextChanged(sender As Object, e As EventArgs) Handles txtCapitalInicialComp.TextChanged

    End Sub
End Class