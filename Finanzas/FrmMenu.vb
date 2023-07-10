Public Class FrmMenu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub itemSalir_Click(sender As Object, e As EventArgs) Handles itemSalir.Click
        End
    End Sub

    Private Sub subitemInteresSimple_Click(sender As Object, e As EventArgs) Handles subitemInteresSimple.Click
        FrmInteresSimple.Show()
    End Sub

    Private Sub subitemInteresCompuesto_Click(sender As Object, e As EventArgs) Handles subitemInteresCompuesto.Click
        FrmInteresCompuesto.Show()
    End Sub

    Private Sub itemAyuda_Click(sender As Object, e As EventArgs) Handles itemAyuda.Click
        MessageBox.Show("Laboratorio N°1. Creado por Carlos Garita Campos para el Curso Programación Orientada a Objetos II")
    End Sub

End Class
