Public Class FrmMP

    Sub RealizaCalculo()
        Dim aux As Integer

        txtBoxCiclos.Text = Int(txtBoxAngulo.Text / txtBoxPassos.Text)
        aux = txtBoxAngulo.Text / txtBoxPassos.Text

        If (txtBoxAngulo.Text / txtBoxPassos.Text) - Int(txtBoxAngulo.Text / txtBoxPassos.Text) >= 0.5 Then
            txtBoxCiclos.Text = txtBoxCiclos.Text * 1 + 1
        End If
    End Sub

    Private Sub FrmMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Serial.IsOpen = False Then
            Serial.Open()
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        RealizaCalculo()

        If (Serial.IsOpen() = True) Then
            Serial.Write(Str(txtBoxCiclos.Text) + "/")
        End If

        txtBoxEnviado.Text = (txtBoxCiclos.Text * 1) & "/"
    End Sub

    Private Sub btnInverteSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInverteSent.Click
        If Serial.IsOpen() = True Then
            Serial.Write("1000/")
        End If
        txtBoxEnviado.Text = "1000/"
    End Sub

    Private Sub btnWH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWH.Click
        If Serial.IsOpen() = True Then
            Serial.Write("1002/")
        End If
        txtBoxEnviado.Text = "1002/"
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        RealizaCalculo()
    End Sub

    Private Sub btnAng09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng09.Click
        txtBoxAngulo.Text = 0.9 * 1
    End Sub

    Private Sub btnAng18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng18.Click
        txtBoxAngulo.Text = 1.8 * 1
    End Sub

    Private Sub btnAng15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng15.Click
        txtBoxAngulo.Text = 15 * 1
    End Sub

    Private Sub btnAng30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng30.Click
        txtBoxAngulo.Text = 30 * 1
    End Sub

    Private Sub btnAng45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng45.Click
        txtBoxAngulo.Text = 45 * 1
    End Sub

    Private Sub btnAng60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng60.Click
        txtBoxAngulo.Text = 60 * 1
    End Sub

    Private Sub btnAng90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng90.Click
        txtBoxAngulo.Text = 90 * 1
    End Sub

    Private Sub btnAng180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng180.Click
        txtBoxAngulo.Text = 180 * 1
    End Sub
End Class
