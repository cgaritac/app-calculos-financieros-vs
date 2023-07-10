Public Class FrmInteresSimple
    Private Sub btnCalcularSimp_Click(sender As Object, e As EventArgs) Handles btnCalcularSimp.Click
        Dim capitalinicialsimp As Double = 0
        Dim tasaanualsimp As Double = 0.0
        Dim aniossimp As Double = 0
        Dim capitalfinalsimp As Double = 0.0

        'verificar si agregó todos los datos'

        If Len(Trim(txtCapitalInicialSimp.Text)) = 0 Then
            MessageBox.Show("Por Favor ingrese el monto del capital a invertir", "Error entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCapitalInicialSimp.Focus()
            Exit Sub
        End If

        If Len(Trim(txtTasaInteresSimp.Text)) = 0 Then
            MessageBox.Show("Por Favor ingrese la tasa de interés de la inversión", "Error entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTasaInteresSimp.Focus()
            Exit Sub
        End If

        If Len(Trim(txtAniosSimp.Text)) = 0 Then
            MessageBox.Show("Por Favor ingrese el plazo en años", "Error entrada de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAniosSimp.Focus()
            Exit Sub
        End If

        'Asignación de datos de textbox a variables'

        capitalinicialsimp = txtCapitalInicialSimp.Text
        tasaanualsimp = txtTasaInteresSimp.Text
        aniossimp = txtAniosSimp.Text

        'Fórmula de cálculo de interés simple'

        capitalfinalsimp = capitalinicialsimp * (1 + (tasaanualsimp / 100) * aniossimp)

        capitalfinalsimp = Math.Truncate(capitalfinalsimp * 100) / 100

        MessageBox.Show("El capital a recibir es de " & capitalfinalsimp, "Monto a recibir", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnOtroSimp_Click(sender As Object, e As EventArgs) Handles btnOtroSimp.Click
        txtCapitalInicialSimp.Text = ""
        txtTasaInteresSimp.Text = ""
        txtAniosSimp.Text = ""
        txtCapitalInicialSimp.Focus()
    End Sub

    Private Sub btnSalirSimp_Click(sender As Object, e As EventArgs) Handles btnSalirSimp.Click
        Me.Close()
    End Sub

End Class