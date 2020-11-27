Public Class FrmMP

    Sub RealizaCalculo()
        Dim aux As Integer
        Dim angulo As Integer

        If CInt(txtBoxAngulo.Text) < 0 Then
            angulo = CInt(txtBoxAngulo.Text) * -1
        Else
            angulo = CInt(txtBoxAngulo.Text)
        End If

        txtBoxCiclos.Text = CInt(angulo / txtBoxPassos.Text)
        aux = angulo / txtBoxPassos.Text

        If (angulo / txtBoxPassos.Text) - Int(angulo / txtBoxPassos.Text) > 0.5 Then
            txtBoxCiclos.Text = txtBoxCiclos.Text * 1 + 1
        Else
            txtBoxCiclos.Text = txtBoxCiclos.Text * 1
        End If
    End Sub

    Sub alteraVisibilidade(
            ByVal btn1 As Boolean,
            ByVal btn2 As Boolean,
            ByVal btn3 As Boolean,
            ByVal btn4 As Boolean,
            ByVal btn5 As Boolean,
            ByVal btn6 As Boolean,
            ByVal btn7 As Boolean,
            ByVal btn8 As Boolean,
            ByVal btn9 As Boolean,
            ByVal btn10 As Boolean,
            ByVal btn11 As Boolean,
            ByVal btn12 As Boolean,
            ByVal btn13 As Boolean,
            ByVal btn14 As Boolean,
            ByVal btn15 As Boolean
        )
        btnAng09.Visible = btn1
        btnAng18.Visible = btn2
        btnAng15.Visible = btn3
        btnAng30.Visible = btn4
        btnAng45.Visible = btn5
        btnAng60.Visible = btn6
        btnAng90.Visible = btn7
        btnAng180.Visible = btn8
        btnAng200.Visible = btn9
        btnAng230.Visible = btn10
        btnAng270.Visible = btn11
        btnAng300.Visible = btn12
        btnAng330.Visible = btn13
        btnAng360.Visible = btn14
        btnAng400.Visible = btn15
    End Sub

    Dim reset As Boolean
    Dim motor As Integer

    Private Sub FrmMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Serial.IsOpen = False Then
            Serial.Open()
        End If
        If Serial2.IsOpen = False Then
            Serial2.Open()
        End If
        If Serial3.IsOpen = False Then
            Serial3.Open()
        End If

        cmbMotor.SelectedIndex = 0
        reset = False
        motor = 1000
        txtTamanho.Text = txtFila.Text.Length
        alteraVisibilidade(True, True, True, True, True, True, True, True, False, False, False, False, False, False, False)
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        RealizaCalculo()
        Dim texto As String
        Dim valor As Integer

        valor = motor + (txtBoxCiclos.Text * 1)

        If (Serial.IsOpen() = True) And (Serial2.IsOpen() = True) And (Serial3.IsOpen() = True) Then
            If txtFila.Text.Length <= 1 Then
                If CInt(txtBoxAngulo.Text) < 0 Then
                    If valor = 1000 Or valor = 2000 Or valor = 3000 Or valor = 4000 Or valor = 5000 Or valor = 6000 Then
                        texto = valor & "\und/"
                    Else
                        texto = valor & "\inv/"
                    End If

                    If (motor >= 1000) And (motor < 3000) Then
                        Serial.Write(texto)
                    ElseIf (motor >= 3000) And (motor < 5000) Then
                        Serial2.Write(texto)
                    ElseIf (motor >= 5000) And (motor < 7000) Then
                        Serial3.Write(texto)
                    End If
                    txtBoxEnviado.Text = texto
                    txtFila.Text = txtFila.Text & texto & Environment.NewLine
                Else
                    If valor = 1000 Or valor = 2000 Or valor = 3000 Or valor = 4000 Or valor = 5000 Or valor = 6000 Then
                        texto = valor & "\und/"
                    Else
                        texto = valor & "\nor/"
                    End If

                    If (motor >= 1000) And (motor < 3000) Then
                        Serial.Write(texto)
                    ElseIf (motor >= 3000) And (motor < 5000) Then
                        Serial2.Write(texto)
                    ElseIf (motor >= 5000) And (motor < 7000) Then
                        Serial3.Write(texto)
                    End If
                    txtBoxEnviado.Text = texto
                    txtFila.Text = txtFila.Text & texto & Environment.NewLine
                End If
            Else
                If CInt(txtBoxAngulo.Text) < 0 Then
                    If valor = 1000 Or valor = 2000 Or valor = 3000 Or valor = 4000 Or valor = 5000 Or valor = 6000 Then
                        texto = valor & "\und/"
                    Else
                        texto = valor & "\inv/"
                    End If

                    txtFila.Text = txtFila.Text & texto & Environment.NewLine
                Else
                    If valor = 1000 Or valor = 2000 Or valor = 3000 Or valor = 4000 Or valor = 5000 Or valor = 6000 Then
                        texto = valor & "\und/"
                    Else
                        texto = valor & "\nor/"
                    End If

                    txtFila.Text = txtFila.Text & texto & Environment.NewLine
                End If
            End If
            txtTamanho.Text = txtFila.Lines.Length
        End If

    End Sub

    Private Sub btnWH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWH.Click
        If Serial.IsOpen() = True Then
            Serial.Write("7000\")
            txtBoxEnviado.Text = "7000\"
        End If
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        RealizaCalculo()
    End Sub

    Private Sub cmbMotor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMotor.SelectedIndexChanged
        trbAngT1.Value = 0
        If cmbMotor.SelectedIndex = 0 Then
            motor = 1000
            lblAngMin.Text = "-180º"
            lblAngMax.Text = "180º"
            trbAngT1.Minimum = -180
            trbAngT1.Maximum = 180
            alteraVisibilidade(True, True, True, True, True, True, True, True, False, False, False, False, False, False, False)
        ElseIf cmbMotor.SelectedIndex = 1 Then
            motor = 2000
            lblAngMin.Text = "-90º"
            lblAngMax.Text = "110º"
            trbAngT1.Minimum = -90
            trbAngT1.Maximum = 110
            If chkNumNegativo.Checked Then
                alteraVisibilidade(True, True, True, True, True, True, True, True, False, False, False, False, False, False, False)
            Else
                alteraVisibilidade(True, True, True, True, True, True, True, False, False, False, False, False, False, False, False)
            End If
        ElseIf cmbMotor.SelectedIndex = 2 Then
            motor = 3000
            lblAngMin.Text = "-230º"
            lblAngMax.Text = "50º"
            trbAngT1.Minimum = -230
            trbAngT1.Maximum = 50
            If chkNumNegativo.Checked Then
                alteraVisibilidade(True, True, True, True, True, True, True, True, True, False, False, False, False, False, False)
            Else
                alteraVisibilidade(True, True, True, True, True, False, False, False, False, False, False, False, False, False, False)
            End If
        ElseIf cmbMotor.SelectedIndex = 3 Then
            motor = 4000
            lblAngMin.Text = "-200º"
            lblAngMax.Text = "200º"
            trbAngT1.Minimum = -200
            trbAngT1.Maximum = 200
            alteraVisibilidade(True, True, True, True, True, True, True, True, True, False, False, False, False, False, False)
        ElseIf cmbMotor.SelectedIndex = 4 Then
            motor = 5000
            lblAngMin.Text = "-120º"
            lblAngMax.Text = "120º"
            trbAngT1.Minimum = -120
            trbAngT1.Maximum = 120
            alteraVisibilidade(True, True, True, True, True, True, True, False, False, False, False, False, False, False, False)
        ElseIf cmbMotor.SelectedIndex = 5 Then
            motor = 6000
            lblAngMin.Text = "-400º"
            lblAngMax.Text = "400º"
            trbAngT1.Minimum = -400
            trbAngT1.Maximum = 400
            alteraVisibilidade(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
        End If
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

    Private Sub btnAng200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng200.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -200 * 1
        Else
            txtBoxAngulo.Text = 200 * 1
        End If
    End Sub

    Private Sub btnAng230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng230.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -230 * 1
        Else
            txtBoxAngulo.Text = 230 * 1
        End If
    End Sub

    Private Sub btnAng270_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng270.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -270 * 1
        Else
            txtBoxAngulo.Text = 270 * 1
        End If
    End Sub

    Private Sub btnAng300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng300.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -300 * 1
        Else
            txtBoxAngulo.Text = 300 * 1
        End If
    End Sub

    Private Sub btnAng330_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng330.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -330 * 1
        Else
            txtBoxAngulo.Text = 330 * 1
        End If
    End Sub

    Private Sub btnAng360_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng360.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -360 * 1
        Else
            txtBoxAngulo.Text = 360 * 1
        End If
    End Sub

    Private Sub btnAng400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng400.Click
        If chkNumNegativo.Checked Then
            txtBoxAngulo.Text = -400 * 1
        Else
            txtBoxAngulo.Text = 400 * 1
        End If
    End Sub

    Private Sub chkNumNegativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNumNegativo.CheckedChanged
        If cmbMotor.SelectedIndex = 0 Then
            alteraVisibilidade(True, True, True, True, True, True, True, True, False, False, False, False, False, False, False)
        ElseIf cmbMotor.SelectedIndex = 1 Then
            If chkNumNegativo.Checked Then
                alteraVisibilidade(True, True, True, True, True, True, True, True, False, False, False, False, False, False, False)
            Else
                alteraVisibilidade(True, True, True, True, True, True, True, False, False, False, False, False, False, False, False)
            End If
        ElseIf cmbMotor.SelectedIndex = 2 Then
            If chkNumNegativo.Checked Then
                alteraVisibilidade(True, True, True, True, True, True, True, True, True, True, False, False, False, False, False)
            Else
                alteraVisibilidade(True, True, True, True, True, False, False, False, False, False, False, False, False, False, False)
            End If
        ElseIf cmbMotor.SelectedIndex = 3 Then
            alteraVisibilidade(True, True, True, True, True, True, True, True, True, False, False, False, False, False, False)
        ElseIf cmbMotor.SelectedIndex = 4 Then
            alteraVisibilidade(True, True, True, True, True, True, True, False, False, False, False, False, False, False, False)
        ElseIf cmbMotor.SelectedIndex = 5 Then
            alteraVisibilidade(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
        End If
    End Sub

    Private Sub btnPas1_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPas1_8.Click
        txtBoxPassos.Text = "1,8"
    End Sub

    Private Sub btnPas0_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPas0_9.Click
        txtBoxPassos.Text = "0,9"
    End Sub

    Private Sub trbAngT1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbAngT1.Scroll
        txtBoxAngulo.Text = trbAngT1.Value
    End Sub

    Private Sub txtBoxAngulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxAngulo.TextChanged
        If (txtBoxAngulo.Text.Trim <> "") And (txtBoxAngulo.Text.Trim <> "-") And (txtBoxAngulo.Text.Trim <> "+") Then
            If (txtBoxAngulo.Text > trbAngT1.Maximum) Or (txtBoxAngulo.Text < trbAngT1.Minimum) Then
                Return
            End If
            trbAngT1.Value = txtBoxAngulo.Text
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        txtTamanho.Text = txtFila.Text.Length

        If Serial.BytesToRead > 0 Then
            txtRecebido.Text = Serial.ReadExisting

            If txtFila.Text.Length > 1 Then
                txtFila.Select(0, txtFila.Text.IndexOf("/") + 2)
                txtFila.SelectedText = ""

                If reset Then
                    TimerReset.Enabled = True
                Else
                    Timer2.Enabled = True
                End If
            End If
        End If

        If Serial2.BytesToRead > 0 Then
            txtRecebido.Text = Serial2.ReadExisting

            If txtFila.Text.Length > 1 Then
                txtFila.Select(0, txtFila.Text.IndexOf("/") + 2)
                txtFila.SelectedText = ""

                If reset Then
                    TimerReset.Enabled = True
                Else
                    Timer2.Enabled = True
                End If
            End If
        End If

        If Serial3.BytesToRead > 0 Then
            txtRecebido.Text = Serial3.ReadExisting

            If txtFila.Text.Length > 1 Then
                txtFila.Select(0, txtFila.Text.IndexOf("/") + 2)
                txtFila.SelectedText = ""

                If reset Then
                    TimerReset.Enabled = True
                Else
                    Timer2.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim texto As String
        Dim motorStr As String

        If txtFila.Text.Length > 1 Then
            txtFila.Select(0, txtFila.Text.IndexOf("/") + 1)
            texto = txtFila.SelectedText.Trim

            motorStr = txtFila.Text.Substring(0, txtFila.Text.IndexOf("\"))

            If (CInt(motorStr) >= 1000) And (CInt(motorStr) < 3000) Then
                Serial.Write(texto)
            ElseIf (CInt(motorStr) >= 3000) And (CInt(motorStr) < 5000) Then
                Serial2.Write(texto)
            ElseIf (CInt(motorStr) >= 5000) And (CInt(motorStr) < 7000) Then
                Serial3.Write(texto)
            End If
            txtBoxEnviado.Text = txtFila.SelectedText.Trim
        End If
        txtRecebido.Text = ""

        Timer2.Enabled = False
    End Sub

    Private Sub btnResetar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetar.Click

        Serial.Write("1000\und/")
        txtBoxEnviado.Text = "1000\und/"

        txtFila.Text = ""
        txtFila.Text = txtFila.Text & "1000\und/" & Environment.NewLine
        txtFila.Text = txtFila.Text & "2000\und/" & Environment.NewLine
        txtFila.Text = txtFila.Text & "3000\und/" & Environment.NewLine
        txtFila.Text = txtFila.Text & "4000\und/" & Environment.NewLine
        txtFila.Text = txtFila.Text & "5000\und/" & Environment.NewLine
        txtFila.Text = txtFila.Text & "6000\und/" & Environment.NewLine

        reset = True

    End Sub

    Private Sub TimerReset_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerReset.Tick
        Dim texto As String
        Dim motorStr As String

        If txtFila.Text.Length > 1 Then
            txtFila.Select(0, txtFila.Text.IndexOf("/") + 1)
            texto = txtFila.SelectedText.Trim

            motorStr = txtFila.Text.Substring(0, txtFila.Text.IndexOf("\"))

            If (CInt(motorStr) = 1000) Or (CInt(motorStr) = 2000) Then
                Serial.Write(texto)
            ElseIf (CInt(motorStr) = 3000) Or (CInt(motorStr) = 4000) Then
                Serial2.Write(texto)
            ElseIf (CInt(motorStr) = 5000) Or (CInt(motorStr) = 6000) Then
                Serial3.Write(texto)
            End If
            txtBoxEnviado.Text = texto
        End If
        txtRecebido.Text = ""

        reset = False
        TimerReset.Enabled = False
    End Sub
End Class
