Public Class FrmMP

    Sub RealizaCalculo()
        Dim aux As Double
        Dim angulo As Integer

        If CInt(txtBoxAngulo.Text) < 0 Then
            angulo = CInt(txtBoxAngulo.Text) * -1
        Else
            angulo = CInt(txtBoxAngulo.Text)
        End If

        txtBoxCiclos.Text = CDbl(angulo / txtBoxPassos.Text)
        aux = angulo / txtBoxPassos.Text

        If (angulo / txtBoxPassos.Text) - Int(angulo / txtBoxPassos.Text) > 0.5 Then
            txtBoxCiclos.Text = txtBoxCiclos.Text * 1 + 1
        Else
            txtBoxCiclos.Text = txtBoxCiclos.Text * 1
        End If
    End Sub

    Dim motor As Integer

    Private Sub FrmMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Serial.IsOpen = False Then
            Serial.Open()
        End If

        cmbMotor.SelectedIndex = 0
        motor = 1000
        lblAngulo.Text = "Ângulo (-180 a 180):"
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        RealizaCalculo()

        If (Serial.IsOpen() = True) Then
            If CInt(txtBoxAngulo.Text) < 0 Then
                Serial.Write(Str(motor + txtBoxCiclos.Text) + "\inv/")
                txtBoxEnviado.Text = motor + (txtBoxCiclos.Text * 1) & "\inv/"
            Else
                Serial.Write(Str(motor + txtBoxCiclos.Text) + "\nor/")
                txtBoxEnviado.Text = motor + (txtBoxCiclos.Text * 1) & "\nor/"
            End If
        End If

    End Sub

    Private Sub btnInverteSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -0.9 * 1
        Else
            txtBoxAngulo.Text = 0.9 * 1
        End If
    End Sub

    Private Sub btnAng18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng18.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -1.8 * 1
        Else
            txtBoxAngulo.Text = 1.8 * 1
        End If
    End Sub

    Private Sub btnAng15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng15.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -15 * 1
        Else
            txtBoxAngulo.Text = 15 * 1
        End If
    End Sub

    Private Sub btnAng30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng30.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -30 * 1
        Else
            txtBoxAngulo.Text = 30 * 1
        End If
    End Sub

    Private Sub btnAng45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng45.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -45 * 1
        Else
            txtBoxAngulo.Text = 45 * 1
        End If
    End Sub

    Private Sub btnAng60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng60.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -60 * 1
        Else
            txtBoxAngulo.Text = 60 * 1
        End If
    End Sub

    Private Sub btnAng90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng90.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -90 * 1
        Else
            txtBoxAngulo.Text = 90 * 1
        End If
    End Sub

    Private Sub btnAng180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng180.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -180 * 1
        Else
            txtBoxAngulo.Text = 180 * 1
        End If
    End Sub

    Private Sub cmbMotor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMotor.SelectedIndexChanged
        If cmbMotor.SelectedIndex = 0 Then
            motor = 1000
            lblAngulo.Text = "Ângulo (-180 a 180):"
        ElseIf cmbMotor.SelectedIndex = 1 Then
            motor = 2000
            lblAngulo.Text = "Ângulo (-190 a 110):"
        ElseIf cmbMotor.SelectedIndex = 2 Then
            motor = 3000
            lblAngulo.Text = "Ângulo (-230 a 50):"
        ElseIf cmbMotor.SelectedIndex = 3 Then
            motor = 4000
            lblAngulo.Text = "Ângulo (-200 a 200):"
        ElseIf cmbMotor.SelectedIndex = 4 Then
            motor = 5000
            lblAngulo.Text = "Ângulo (-120 a 120):"
        ElseIf cmbMotor.SelectedIndex = 5 Then
            motor = 6000
            lblAngulo.Text = "Ângulo (-400 a 400):"
        End If
    End Sub
End Class
