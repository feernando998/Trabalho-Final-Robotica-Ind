<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoxCiclos = New System.Windows.Forms.TextBox()
        Me.txtBoxPassos = New System.Windows.Forms.TextBox()
        Me.txtBoxAngulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAng180 = New System.Windows.Forms.Button()
        Me.btnAng90 = New System.Windows.Forms.Button()
        Me.btnAng60 = New System.Windows.Forms.Button()
        Me.btnAng45 = New System.Windows.Forms.Button()
        Me.btnAng30 = New System.Windows.Forms.Button()
        Me.btnAng15 = New System.Windows.Forms.Button()
        Me.btnAng18 = New System.Windows.Forms.Button()
        Me.btnAng09 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnInverteSent = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnWH = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtBoxEnviado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoxCiclos)
        Me.GroupBox1.Controls.Add(Me.txtBoxPassos)
        Me.GroupBox1.Controls.Add(Me.txtBoxAngulo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuração:"
        '
        'txtBoxCiclos
        '
        Me.txtBoxCiclos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBoxCiclos.Location = New System.Drawing.Point(101, 71)
        Me.txtBoxCiclos.Name = "txtBoxCiclos"
        Me.txtBoxCiclos.ReadOnly = True
        Me.txtBoxCiclos.Size = New System.Drawing.Size(41, 20)
        Me.txtBoxCiclos.TabIndex = 5
        '
        'txtBoxPassos
        '
        Me.txtBoxPassos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBoxPassos.Location = New System.Drawing.Point(101, 44)
        Me.txtBoxPassos.Name = "txtBoxPassos"
        Me.txtBoxPassos.ReadOnly = True
        Me.txtBoxPassos.Size = New System.Drawing.Size(41, 20)
        Me.txtBoxPassos.TabIndex = 4
        Me.txtBoxPassos.Text = "1,8"
        '
        'txtBoxAngulo
        '
        Me.txtBoxAngulo.Location = New System.Drawing.Point(101, 17)
        Me.txtBoxAngulo.Name = "txtBoxAngulo"
        Me.txtBoxAngulo.Size = New System.Drawing.Size(41, 20)
        Me.txtBoxAngulo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ciclos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Passos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ângulo (0 a 360):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAng180)
        Me.GroupBox2.Controls.Add(Me.btnAng90)
        Me.GroupBox2.Controls.Add(Me.btnAng60)
        Me.GroupBox2.Controls.Add(Me.btnAng45)
        Me.GroupBox2.Controls.Add(Me.btnAng30)
        Me.GroupBox2.Controls.Add(Me.btnAng15)
        Me.GroupBox2.Controls.Add(Me.btnAng18)
        Me.GroupBox2.Controls.Add(Me.btnAng09)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ângulos predefinidos:"
        '
        'btnAng180
        '
        Me.btnAng180.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng180.Location = New System.Drawing.Point(163, 64)
        Me.btnAng180.Name = "btnAng180"
        Me.btnAng180.Size = New System.Drawing.Size(46, 23)
        Me.btnAng180.TabIndex = 7
        Me.btnAng180.Text = "180"
        Me.btnAng180.UseVisualStyleBackColor = False
        '
        'btnAng90
        '
        Me.btnAng90.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng90.Location = New System.Drawing.Point(111, 64)
        Me.btnAng90.Name = "btnAng90"
        Me.btnAng90.Size = New System.Drawing.Size(46, 23)
        Me.btnAng90.TabIndex = 6
        Me.btnAng90.Text = "90"
        Me.btnAng90.UseVisualStyleBackColor = False
        '
        'btnAng60
        '
        Me.btnAng60.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng60.Location = New System.Drawing.Point(59, 64)
        Me.btnAng60.Name = "btnAng60"
        Me.btnAng60.Size = New System.Drawing.Size(46, 23)
        Me.btnAng60.TabIndex = 5
        Me.btnAng60.Text = "60"
        Me.btnAng60.UseVisualStyleBackColor = False
        '
        'btnAng45
        '
        Me.btnAng45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng45.Location = New System.Drawing.Point(6, 64)
        Me.btnAng45.Name = "btnAng45"
        Me.btnAng45.Size = New System.Drawing.Size(46, 23)
        Me.btnAng45.TabIndex = 4
        Me.btnAng45.Text = "45"
        Me.btnAng45.UseVisualStyleBackColor = False
        '
        'btnAng30
        '
        Me.btnAng30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng30.Location = New System.Drawing.Point(163, 20)
        Me.btnAng30.Name = "btnAng30"
        Me.btnAng30.Size = New System.Drawing.Size(46, 23)
        Me.btnAng30.TabIndex = 3
        Me.btnAng30.Text = "30"
        Me.btnAng30.UseVisualStyleBackColor = False
        '
        'btnAng15
        '
        Me.btnAng15.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng15.Location = New System.Drawing.Point(111, 20)
        Me.btnAng15.Name = "btnAng15"
        Me.btnAng15.Size = New System.Drawing.Size(46, 23)
        Me.btnAng15.TabIndex = 2
        Me.btnAng15.Text = "15"
        Me.btnAng15.UseVisualStyleBackColor = False
        '
        'btnAng18
        '
        Me.btnAng18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng18.Location = New System.Drawing.Point(59, 20)
        Me.btnAng18.Name = "btnAng18"
        Me.btnAng18.Size = New System.Drawing.Size(46, 23)
        Me.btnAng18.TabIndex = 1
        Me.btnAng18.Text = "1.8"
        Me.btnAng18.UseVisualStyleBackColor = False
        '
        'btnAng09
        '
        Me.btnAng09.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng09.Location = New System.Drawing.Point(7, 20)
        Me.btnAng09.Name = "btnAng09"
        Me.btnAng09.Size = New System.Drawing.Size(46, 23)
        Me.btnAng09.TabIndex = 0
        Me.btnAng09.Text = "0.9"
        Me.btnAng09.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnInverteSent)
        Me.GroupBox3.Controls.Add(Me.btnCalcular)
        Me.GroupBox3.Controls.Add(Me.btnWH)
        Me.GroupBox3.Controls.Add(Me.btnEnviar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 85)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comandos:"
        '
        'btnInverteSent
        '
        Me.btnInverteSent.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInverteSent.Location = New System.Drawing.Point(74, 19)
        Me.btnInverteSent.Name = "btnInverteSent"
        Me.btnInverteSent.Size = New System.Drawing.Size(96, 23)
        Me.btnInverteSent.TabIndex = 9
        Me.btnInverteSent.Text = "Inverter sentido"
        Me.btnInverteSent.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalcular.Location = New System.Drawing.Point(6, 48)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(62, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnWH
        '
        Me.btnWH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWH.Location = New System.Drawing.Point(74, 48)
        Me.btnWH.Name = "btnWH"
        Me.btnWH.Size = New System.Drawing.Size(96, 23)
        Me.btnWH.TabIndex = 7
        Me.btnWH.Text = "Wave / Half"
        Me.btnWH.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnviar.Location = New System.Drawing.Point(6, 19)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(62, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBoxEnviado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(195, 141)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(199, 49)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status (serial):"
        '
        'txtBoxEnviado
        '
        Me.txtBoxEnviado.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBoxEnviado.Location = New System.Drawing.Point(86, 19)
        Me.txtBoxEnviado.Name = "txtBoxEnviado"
        Me.txtBoxEnviado.ReadOnly = True
        Me.txtBoxEnviado.Size = New System.Drawing.Size(76, 20)
        Me.txtBoxEnviado.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Enviado:"
        '
        'Serial
        '
        Me.Serial.PortName = "COM4"
        '
        'FrmMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(406, 214)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.Name = "FrmMP"
        Me.ShowIcon = False
        Me.Text = "Controlador "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxCiclos As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPassos As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxAngulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAng180 As System.Windows.Forms.Button
    Friend WithEvents btnAng90 As System.Windows.Forms.Button
    Friend WithEvents btnAng60 As System.Windows.Forms.Button
    Friend WithEvents btnAng45 As System.Windows.Forms.Button
    Friend WithEvents btnAng30 As System.Windows.Forms.Button
    Friend WithEvents btnAng15 As System.Windows.Forms.Button
    Friend WithEvents btnAng18 As System.Windows.Forms.Button
    Friend WithEvents btnAng09 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnWH As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxEnviado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Serial As System.IO.Ports.SerialPort
    Friend WithEvents btnInverteSent As System.Windows.Forms.Button

End Class
