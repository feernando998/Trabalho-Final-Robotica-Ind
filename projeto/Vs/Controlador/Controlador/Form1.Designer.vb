﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblAngMax = New System.Windows.Forms.Label()
        Me.lblAngMin = New System.Windows.Forms.Label()
        Me.trbAngT1 = New System.Windows.Forms.TrackBar()
        Me.btnPas0_9 = New System.Windows.Forms.Button()
        Me.btnPas1_8 = New System.Windows.Forms.Button()
        Me.txtBoxCiclos = New System.Windows.Forms.TextBox()
        Me.txtBoxPassos = New System.Windows.Forms.TextBox()
        Me.txtBoxAngulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAngulo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNumNegativo = New System.Windows.Forms.CheckBox()
        Me.btnAng400 = New System.Windows.Forms.Button()
        Me.btnAng360 = New System.Windows.Forms.Button()
        Me.btnAng330 = New System.Windows.Forms.Button()
        Me.btnAng300 = New System.Windows.Forms.Button()
        Me.btnAng270 = New System.Windows.Forms.Button()
        Me.btnAng230 = New System.Windows.Forms.Button()
        Me.btnAng200 = New System.Windows.Forms.Button()
        Me.btnAng180 = New System.Windows.Forms.Button()
        Me.btnAng90 = New System.Windows.Forms.Button()
        Me.btnAng60 = New System.Windows.Forms.Button()
        Me.btnAng45 = New System.Windows.Forms.Button()
        Me.btnAng30 = New System.Windows.Forms.Button()
        Me.btnAng15 = New System.Windows.Forms.Button()
        Me.btnAng18 = New System.Windows.Forms.Button()
        Me.btnAng09 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnWH = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTamanho = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecebido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxEnviado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFila = New System.Windows.Forms.TextBox()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbMotor = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Serial2 = New System.IO.Ports.SerialPort(Me.components)
        Me.Serial3 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnResetar = New System.Windows.Forms.Button()
        Me.TimerReset = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.trbAngT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAngMax)
        Me.GroupBox1.Controls.Add(Me.lblAngMin)
        Me.GroupBox1.Controls.Add(Me.trbAngT1)
        Me.GroupBox1.Controls.Add(Me.btnPas0_9)
        Me.GroupBox1.Controls.Add(Me.btnPas1_8)
        Me.GroupBox1.Controls.Add(Me.txtBoxCiclos)
        Me.GroupBox1.Controls.Add(Me.txtBoxPassos)
        Me.GroupBox1.Controls.Add(Me.txtBoxAngulo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblAngulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(237, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(308, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuração:"
        '
        'lblAngMax
        '
        Me.lblAngMax.AutoSize = True
        Me.lblAngMax.Location = New System.Drawing.Point(268, 27)
        Me.lblAngMax.Name = "lblAngMax"
        Me.lblAngMax.Size = New System.Drawing.Size(31, 13)
        Me.lblAngMax.TabIndex = 10
        Me.lblAngMax.Text = "180º"
        '
        'lblAngMin
        '
        Me.lblAngMin.AutoSize = True
        Me.lblAngMin.Location = New System.Drawing.Point(8, 27)
        Me.lblAngMin.Name = "lblAngMin"
        Me.lblAngMin.Size = New System.Drawing.Size(37, 13)
        Me.lblAngMin.TabIndex = 9
        Me.lblAngMin.Text = "-180º"
        '
        'trbAngT1
        '
        Me.trbAngT1.Location = New System.Drawing.Point(51, 23)
        Me.trbAngT1.Maximum = 180
        Me.trbAngT1.Minimum = -180
        Me.trbAngT1.Name = "trbAngT1"
        Me.trbAngT1.Size = New System.Drawing.Size(211, 45)
        Me.trbAngT1.TabIndex = 8
        '
        'btnPas0_9
        '
        Me.btnPas0_9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPas0_9.Location = New System.Drawing.Point(168, 95)
        Me.btnPas0_9.Name = "btnPas0_9"
        Me.btnPas0_9.Size = New System.Drawing.Size(45, 23)
        Me.btnPas0_9.TabIndex = 7
        Me.btnPas0_9.Text = "0,9"
        Me.btnPas0_9.UseVisualStyleBackColor = False
        '
        'btnPas1_8
        '
        Me.btnPas1_8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPas1_8.Location = New System.Drawing.Point(117, 95)
        Me.btnPas1_8.Name = "btnPas1_8"
        Me.btnPas1_8.Size = New System.Drawing.Size(45, 23)
        Me.btnPas1_8.TabIndex = 6
        Me.btnPas1_8.Text = "1,8"
        Me.btnPas1_8.UseVisualStyleBackColor = False
        '
        'txtBoxCiclos
        '
        Me.txtBoxCiclos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBoxCiclos.Location = New System.Drawing.Point(69, 124)
        Me.txtBoxCiclos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxCiclos.Name = "txtBoxCiclos"
        Me.txtBoxCiclos.ReadOnly = True
        Me.txtBoxCiclos.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxCiclos.TabIndex = 5
        '
        'txtBoxPassos
        '
        Me.txtBoxPassos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBoxPassos.Location = New System.Drawing.Point(69, 97)
        Me.txtBoxPassos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxPassos.Name = "txtBoxPassos"
        Me.txtBoxPassos.ReadOnly = True
        Me.txtBoxPassos.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxPassos.TabIndex = 4
        Me.txtBoxPassos.Text = "1,8"
        '
        'txtBoxAngulo
        '
        Me.txtBoxAngulo.Location = New System.Drawing.Point(69, 73)
        Me.txtBoxAngulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxAngulo.Name = "txtBoxAngulo"
        Me.txtBoxAngulo.Size = New System.Drawing.Size(42, 20)
        Me.txtBoxAngulo.TabIndex = 3
        Me.txtBoxAngulo.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ciclos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Passos:"
        '
        'lblAngulo
        '
        Me.lblAngulo.AutoSize = True
        Me.lblAngulo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngulo.Location = New System.Drawing.Point(9, 76)
        Me.lblAngulo.Name = "lblAngulo"
        Me.lblAngulo.Size = New System.Drawing.Size(49, 13)
        Me.lblAngulo.TabIndex = 0
        Me.lblAngulo.Text = "Ângulo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNumNegativo)
        Me.GroupBox2.Controls.Add(Me.btnAng400)
        Me.GroupBox2.Controls.Add(Me.btnAng360)
        Me.GroupBox2.Controls.Add(Me.btnAng330)
        Me.GroupBox2.Controls.Add(Me.btnAng300)
        Me.GroupBox2.Controls.Add(Me.btnAng270)
        Me.GroupBox2.Controls.Add(Me.btnAng230)
        Me.GroupBox2.Controls.Add(Me.btnAng200)
        Me.GroupBox2.Controls.Add(Me.btnAng180)
        Me.GroupBox2.Controls.Add(Me.btnAng90)
        Me.GroupBox2.Controls.Add(Me.btnAng60)
        Me.GroupBox2.Controls.Add(Me.btnAng45)
        Me.GroupBox2.Controls.Add(Me.btnAng30)
        Me.GroupBox2.Controls.Add(Me.btnAng15)
        Me.GroupBox2.Controls.Add(Me.btnAng18)
        Me.GroupBox2.Controls.Add(Me.btnAng09)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(219, 271)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ângulos predefinidos:"
        '
        'chkNumNegativo
        '
        Me.chkNumNegativo.AutoSize = True
        Me.chkNumNegativo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNumNegativo.Location = New System.Drawing.Point(12, 23)
        Me.chkNumNegativo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNumNegativo.Name = "chkNumNegativo"
        Me.chkNumNegativo.Size = New System.Drawing.Size(74, 17)
        Me.chkNumNegativo.TabIndex = 16
        Me.chkNumNegativo.Text = "Negativo"
        Me.chkNumNegativo.UseVisualStyleBackColor = True
        '
        'btnAng400
        '
        Me.btnAng400.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng400.Location = New System.Drawing.Point(115, 144)
        Me.btnAng400.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng400.Name = "btnAng400"
        Me.btnAng400.Size = New System.Drawing.Size(46, 24)
        Me.btnAng400.TabIndex = 15
        Me.btnAng400.Text = "400"
        Me.btnAng400.UseVisualStyleBackColor = False
        Me.btnAng400.Visible = False
        '
        'btnAng360
        '
        Me.btnAng360.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng360.Location = New System.Drawing.Point(66, 144)
        Me.btnAng360.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng360.Name = "btnAng360"
        Me.btnAng360.Size = New System.Drawing.Size(46, 24)
        Me.btnAng360.TabIndex = 14
        Me.btnAng360.Text = "360"
        Me.btnAng360.UseVisualStyleBackColor = False
        Me.btnAng360.Visible = False
        '
        'btnAng330
        '
        Me.btnAng330.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng330.Location = New System.Drawing.Point(12, 144)
        Me.btnAng330.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng330.Name = "btnAng330"
        Me.btnAng330.Size = New System.Drawing.Size(46, 24)
        Me.btnAng330.TabIndex = 13
        Me.btnAng330.Text = "330"
        Me.btnAng330.UseVisualStyleBackColor = False
        Me.btnAng330.Visible = False
        '
        'btnAng300
        '
        Me.btnAng300.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng300.Location = New System.Drawing.Point(167, 116)
        Me.btnAng300.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng300.Name = "btnAng300"
        Me.btnAng300.Size = New System.Drawing.Size(46, 24)
        Me.btnAng300.TabIndex = 12
        Me.btnAng300.Text = "300"
        Me.btnAng300.UseVisualStyleBackColor = False
        Me.btnAng300.Visible = False
        '
        'btnAng270
        '
        Me.btnAng270.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng270.Location = New System.Drawing.Point(115, 116)
        Me.btnAng270.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng270.Name = "btnAng270"
        Me.btnAng270.Size = New System.Drawing.Size(46, 24)
        Me.btnAng270.TabIndex = 11
        Me.btnAng270.Text = "270"
        Me.btnAng270.UseVisualStyleBackColor = False
        Me.btnAng270.Visible = False
        '
        'btnAng230
        '
        Me.btnAng230.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng230.Location = New System.Drawing.Point(66, 116)
        Me.btnAng230.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng230.Name = "btnAng230"
        Me.btnAng230.Size = New System.Drawing.Size(46, 24)
        Me.btnAng230.TabIndex = 10
        Me.btnAng230.Text = "230"
        Me.btnAng230.UseVisualStyleBackColor = False
        Me.btnAng230.Visible = False
        '
        'btnAng200
        '
        Me.btnAng200.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng200.Location = New System.Drawing.Point(12, 116)
        Me.btnAng200.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng200.Name = "btnAng200"
        Me.btnAng200.Size = New System.Drawing.Size(46, 24)
        Me.btnAng200.TabIndex = 9
        Me.btnAng200.Text = "200"
        Me.btnAng200.UseVisualStyleBackColor = False
        Me.btnAng200.Visible = False
        '
        'btnAng180
        '
        Me.btnAng180.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng180.Location = New System.Drawing.Point(168, 88)
        Me.btnAng180.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng180.Name = "btnAng180"
        Me.btnAng180.Size = New System.Drawing.Size(46, 24)
        Me.btnAng180.TabIndex = 7
        Me.btnAng180.Text = "180"
        Me.btnAng180.UseVisualStyleBackColor = False
        '
        'btnAng90
        '
        Me.btnAng90.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng90.Location = New System.Drawing.Point(115, 88)
        Me.btnAng90.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng90.Name = "btnAng90"
        Me.btnAng90.Size = New System.Drawing.Size(46, 24)
        Me.btnAng90.TabIndex = 6
        Me.btnAng90.Text = "90"
        Me.btnAng90.UseVisualStyleBackColor = False
        '
        'btnAng60
        '
        Me.btnAng60.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng60.Location = New System.Drawing.Point(65, 88)
        Me.btnAng60.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng60.Name = "btnAng60"
        Me.btnAng60.Size = New System.Drawing.Size(46, 24)
        Me.btnAng60.TabIndex = 5
        Me.btnAng60.Text = "60"
        Me.btnAng60.UseVisualStyleBackColor = False
        '
        'btnAng45
        '
        Me.btnAng45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng45.Location = New System.Drawing.Point(12, 88)
        Me.btnAng45.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng45.Name = "btnAng45"
        Me.btnAng45.Size = New System.Drawing.Size(46, 24)
        Me.btnAng45.TabIndex = 4
        Me.btnAng45.Text = "45"
        Me.btnAng45.UseVisualStyleBackColor = False
        '
        'btnAng30
        '
        Me.btnAng30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng30.Location = New System.Drawing.Point(167, 58)
        Me.btnAng30.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng30.Name = "btnAng30"
        Me.btnAng30.Size = New System.Drawing.Size(46, 24)
        Me.btnAng30.TabIndex = 3
        Me.btnAng30.Text = "30"
        Me.btnAng30.UseVisualStyleBackColor = False
        '
        'btnAng15
        '
        Me.btnAng15.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng15.Location = New System.Drawing.Point(115, 58)
        Me.btnAng15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng15.Name = "btnAng15"
        Me.btnAng15.Size = New System.Drawing.Size(46, 24)
        Me.btnAng15.TabIndex = 2
        Me.btnAng15.Text = "15"
        Me.btnAng15.UseVisualStyleBackColor = False
        '
        'btnAng18
        '
        Me.btnAng18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng18.Location = New System.Drawing.Point(65, 58)
        Me.btnAng18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng18.Name = "btnAng18"
        Me.btnAng18.Size = New System.Drawing.Size(46, 24)
        Me.btnAng18.TabIndex = 1
        Me.btnAng18.Text = "1.8"
        Me.btnAng18.UseVisualStyleBackColor = False
        '
        'btnAng09
        '
        Me.btnAng09.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAng09.Location = New System.Drawing.Point(12, 58)
        Me.btnAng09.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAng09.Name = "btnAng09"
        Me.btnAng09.Size = New System.Drawing.Size(46, 24)
        Me.btnAng09.TabIndex = 0
        Me.btnAng09.Text = "0.9"
        Me.btnAng09.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnResetar)
        Me.GroupBox3.Controls.Add(Me.btnCalcular)
        Me.GroupBox3.Controls.Add(Me.btnWH)
        Me.GroupBox3.Controls.Add(Me.btnEnviar)
        Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(237, 267)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(308, 84)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comandos:"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalcular.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(7, 21)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(148, 24)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnWH
        '
        Me.btnWH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWH.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWH.Location = New System.Drawing.Point(161, 21)
        Me.btnWH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWH.Name = "btnWH"
        Me.btnWH.Size = New System.Drawing.Size(141, 24)
        Me.btnWH.TabIndex = 7
        Me.btnWH.Text = "Wave / Half"
        Me.btnWH.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnviar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(7, 49)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(148, 24)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTamanho)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtRecebido)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtBoxEnviado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtFila)
        Me.GroupBox4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(551, 80)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(162, 272)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status:"
        '
        'txtTamanho
        '
        Me.txtTamanho.Enabled = False
        Me.txtTamanho.Location = New System.Drawing.Point(25, 232)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Size = New System.Drawing.Size(36, 20)
        Me.txtTamanho.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Lista:"
        '
        'txtRecebido
        '
        Me.txtRecebido.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRecebido.Location = New System.Drawing.Point(67, 44)
        Me.txtRecebido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRecebido.Name = "txtRecebido"
        Me.txtRecebido.ReadOnly = True
        Me.txtRecebido.Size = New System.Drawing.Size(76, 20)
        Me.txtRecebido.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Recebido:"
        '
        'txtBoxEnviado
        '
        Me.txtBoxEnviado.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBoxEnviado.Location = New System.Drawing.Point(67, 17)
        Me.txtBoxEnviado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxEnviado.Name = "txtBoxEnviado"
        Me.txtBoxEnviado.ReadOnly = True
        Me.txtBoxEnviado.Size = New System.Drawing.Size(76, 20)
        Me.txtBoxEnviado.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Enviado:"
        '
        'txtFila
        '
        Me.txtFila.Cursor = System.Windows.Forms.Cursors.No
        Me.txtFila.Enabled = False
        Me.txtFila.Location = New System.Drawing.Point(67, 69)
        Me.txtFila.Multiline = True
        Me.txtFila.Name = "txtFila"
        Me.txtFila.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFila.Size = New System.Drawing.Size(89, 183)
        Me.txtFila.TabIndex = 7
        '
        'Serial
        '
        Me.Serial.PortName = "COM4"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.cmbMotor)
        Me.GroupBox5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(219, 63)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Motor"
        '
        'cmbMotor
        '
        Me.cmbMotor.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMotor.FormattingEnabled = True
        Me.cmbMotor.Items.AddRange(New Object() {"Theta 1", "Theta 2", "Theta 3", "Theta 4", "Theta 5", "Theta 6"})
        Me.cmbMotor.Location = New System.Drawing.Point(56, 20)
        Me.cmbMotor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbMotor.Name = "cmbMotor"
        Me.cmbMotor.Size = New System.Drawing.Size(121, 27)
        Me.cmbMotor.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Serial2
        '
        Me.Serial2.PortName = "COM2"
        '
        'Serial3
        '
        Me.Serial3.PortName = "COM3"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'btnResetar
        '
        Me.btnResetar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnResetar.Location = New System.Drawing.Point(161, 50)
        Me.btnResetar.Name = "btnResetar"
        Me.btnResetar.Size = New System.Drawing.Size(141, 23)
        Me.btnResetar.TabIndex = 9
        Me.btnResetar.Text = "Resetar"
        Me.btnResetar.UseVisualStyleBackColor = False
        '
        'TimerReset
        '
        '
        'FrmMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(748, 367)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmMP"
        Me.ShowIcon = False
        Me.Text = "Controlador ABB IRB 140"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trbAngT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxCiclos As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPassos As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxAngulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAngulo As System.Windows.Forms.Label
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
    Friend WithEvents Serial As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMotor As System.Windows.Forms.ComboBox
    Friend WithEvents btnAng400 As System.Windows.Forms.Button
    Friend WithEvents btnAng360 As System.Windows.Forms.Button
    Friend WithEvents btnAng330 As System.Windows.Forms.Button
    Friend WithEvents btnAng300 As System.Windows.Forms.Button
    Friend WithEvents btnAng270 As System.Windows.Forms.Button
    Friend WithEvents btnAng230 As System.Windows.Forms.Button
    Friend WithEvents btnAng200 As System.Windows.Forms.Button
    Friend WithEvents chkNumNegativo As System.Windows.Forms.CheckBox
    Friend WithEvents btnPas0_9 As System.Windows.Forms.Button
    Friend WithEvents btnPas1_8 As System.Windows.Forms.Button
    Friend WithEvents lblAngMax As System.Windows.Forms.Label
    Friend WithEvents lblAngMin As System.Windows.Forms.Label
    Friend WithEvents trbAngT1 As System.Windows.Forms.TrackBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtFila As System.Windows.Forms.TextBox
    Friend WithEvents Serial2 As System.IO.Ports.SerialPort
    Friend WithEvents Serial3 As System.IO.Ports.SerialPort
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecebido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBoxEnviado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtTamanho As System.Windows.Forms.TextBox
    Friend WithEvents btnResetar As System.Windows.Forms.Button
    Friend WithEvents TimerReset As System.Windows.Forms.Timer

End Class
