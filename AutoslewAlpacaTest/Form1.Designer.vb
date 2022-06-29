<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTelAscomName = New System.Windows.Forms.TextBox()
        Me.cmdTelAscom = New System.Windows.Forms.Button()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.cmdMoveAxis = New System.Windows.Forms.Button()
        Me.txtMoveAxRa = New System.Windows.Forms.TextBox()
        Me.txtMoveAxDe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdMoveAxStop = New System.Windows.Forms.Button()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.lblRA = New System.Windows.Forms.Label()
        Me.lblDE = New System.Windows.Forms.Label()
        Me.fraControl = New System.Windows.Forms.GroupBox()
        Me.cmdTrackSunCommand = New System.Windows.Forms.Button()
        Me.cmdTrackMoonCommand = New System.Windows.Forms.Button()
        Me.cmdTrackMoon = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdRightAscensionRate = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDeRate = New System.Windows.Forms.TextBox()
        Me.txtRaRate = New System.Windows.Forms.TextBox()
        Me.cmdDeclinationRate = New System.Windows.Forms.Button()
        Me.cmdTrackOff = New System.Windows.Forms.Button()
        Me.cmdTrackOn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPulseDe = New System.Windows.Forms.TextBox()
        Me.txtPulseRa = New System.Windows.Forms.TextBox()
        Me.cmdPulseGuide = New System.Windows.Forms.Button()
        Me.lblTracking = New System.Windows.Forms.Label()
        Me.cmdAbortSlew = New System.Windows.Forms.Button()
        Me.cmdTrackSiderial = New System.Windows.Forms.Button()
        Me.fraControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTelAscomName
        '
        Me.txtTelAscomName.AcceptsReturn = True
        Me.txtTelAscomName.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelAscomName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelAscomName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelAscomName.Location = New System.Drawing.Point(176, 32)
        Me.txtTelAscomName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelAscomName.MaxLength = 0
        Me.txtTelAscomName.Multiline = True
        Me.txtTelAscomName.Name = "txtTelAscomName"
        Me.txtTelAscomName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelAscomName.Size = New System.Drawing.Size(404, 32)
        Me.txtTelAscomName.TabIndex = 132
        Me.txtTelAscomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdTelAscom
        '
        Me.cmdTelAscom.BackColor = System.Drawing.Color.Blue
        Me.cmdTelAscom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTelAscom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTelAscom.ForeColor = System.Drawing.Color.Yellow
        Me.cmdTelAscom.Location = New System.Drawing.Point(13, 26)
        Me.cmdTelAscom.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTelAscom.Name = "cmdTelAscom"
        Me.cmdTelAscom.Size = New System.Drawing.Size(156, 44)
        Me.cmdTelAscom.TabIndex = 131
        Me.cmdTelAscom.Text = "Choose Ascom"
        Me.cmdTelAscom.UseVisualStyleBackColor = False
        '
        'cmdConnect
        '
        Me.cmdConnect.BackColor = System.Drawing.Color.Blue
        Me.cmdConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdConnect.ForeColor = System.Drawing.Color.Yellow
        Me.cmdConnect.Location = New System.Drawing.Point(13, 96)
        Me.cmdConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(156, 44)
        Me.cmdConnect.TabIndex = 133
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = False
        '
        'cmdMoveAxis
        '
        Me.cmdMoveAxis.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdMoveAxis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMoveAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMoveAxis.ForeColor = System.Drawing.Color.Black
        Me.cmdMoveAxis.Location = New System.Drawing.Point(105, 93)
        Me.cmdMoveAxis.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMoveAxis.Name = "cmdMoveAxis"
        Me.cmdMoveAxis.Size = New System.Drawing.Size(165, 44)
        Me.cmdMoveAxis.TabIndex = 134
        Me.cmdMoveAxis.Text = "MoveAxis"
        Me.cmdMoveAxis.UseVisualStyleBackColor = False
        '
        'txtMoveAxRa
        '
        Me.txtMoveAxRa.Location = New System.Drawing.Point(339, 81)
        Me.txtMoveAxRa.Name = "txtMoveAxRa"
        Me.txtMoveAxRa.Size = New System.Drawing.Size(122, 29)
        Me.txtMoveAxRa.TabIndex = 135
        Me.txtMoveAxRa.Text = "0.1"
        Me.txtMoveAxRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMoveAxDe
        '
        Me.txtMoveAxDe.Location = New System.Drawing.Point(339, 116)
        Me.txtMoveAxDe.Name = "txtMoveAxDe"
        Me.txtMoveAxDe.Size = New System.Drawing.Size(122, 29)
        Me.txtMoveAxDe.TabIndex = 136
        Me.txtMoveAxDe.Text = "0.1"
        Me.txtMoveAxDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 25)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "RA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 25)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "DE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "degr/sec"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 25)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "degr/sec"
        '
        'cmdMoveAxStop
        '
        Me.cmdMoveAxStop.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdMoveAxStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMoveAxStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMoveAxStop.ForeColor = System.Drawing.Color.Black
        Me.cmdMoveAxStop.Location = New System.Drawing.Point(613, 93)
        Me.cmdMoveAxStop.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMoveAxStop.Name = "cmdMoveAxStop"
        Me.cmdMoveAxStop.Size = New System.Drawing.Size(165, 44)
        Me.cmdMoveAxStop.TabIndex = 141
        Me.cmdMoveAxStop.Text = "Stop MoveAxis"
        Me.cmdMoveAxStop.UseVisualStyleBackColor = False
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 300
        '
        'lblRA
        '
        Me.lblRA.AutoSize = True
        Me.lblRA.Location = New System.Drawing.Point(796, 38)
        Me.lblRA.Name = "lblRA"
        Me.lblRA.Size = New System.Drawing.Size(45, 25)
        Me.lblRA.TabIndex = 142
        Me.lblRA.Text = "RA:"
        '
        'lblDE
        '
        Me.lblDE.AutoSize = True
        Me.lblDE.Location = New System.Drawing.Point(796, 72)
        Me.lblDE.Name = "lblDE"
        Me.lblDE.Size = New System.Drawing.Size(45, 25)
        Me.lblDE.TabIndex = 143
        Me.lblDE.Text = "DE:"
        '
        'fraControl
        '
        Me.fraControl.Controls.Add(Me.cmdTrackSiderial)
        Me.fraControl.Controls.Add(Me.cmdAbortSlew)
        Me.fraControl.Controls.Add(Me.cmdTrackSunCommand)
        Me.fraControl.Controls.Add(Me.cmdTrackMoonCommand)
        Me.fraControl.Controls.Add(Me.cmdTrackMoon)
        Me.fraControl.Controls.Add(Me.Label5)
        Me.fraControl.Controls.Add(Me.cmdRightAscensionRate)
        Me.fraControl.Controls.Add(Me.Label10)
        Me.fraControl.Controls.Add(Me.Label11)
        Me.fraControl.Controls.Add(Me.Label12)
        Me.fraControl.Controls.Add(Me.txtDeRate)
        Me.fraControl.Controls.Add(Me.txtRaRate)
        Me.fraControl.Controls.Add(Me.cmdDeclinationRate)
        Me.fraControl.Controls.Add(Me.cmdTrackOff)
        Me.fraControl.Controls.Add(Me.cmdTrackOn)
        Me.fraControl.Controls.Add(Me.Label9)
        Me.fraControl.Controls.Add(Me.Label6)
        Me.fraControl.Controls.Add(Me.Label7)
        Me.fraControl.Controls.Add(Me.Label8)
        Me.fraControl.Controls.Add(Me.txtPulseDe)
        Me.fraControl.Controls.Add(Me.txtPulseRa)
        Me.fraControl.Controls.Add(Me.cmdPulseGuide)
        Me.fraControl.Controls.Add(Me.cmdMoveAxStop)
        Me.fraControl.Controls.Add(Me.Label4)
        Me.fraControl.Controls.Add(Me.Label3)
        Me.fraControl.Controls.Add(Me.Label2)
        Me.fraControl.Controls.Add(Me.Label1)
        Me.fraControl.Controls.Add(Me.txtMoveAxDe)
        Me.fraControl.Controls.Add(Me.txtMoveAxRa)
        Me.fraControl.Controls.Add(Me.cmdMoveAxis)
        Me.fraControl.Enabled = False
        Me.fraControl.Location = New System.Drawing.Point(71, 172)
        Me.fraControl.Name = "fraControl"
        Me.fraControl.Size = New System.Drawing.Size(947, 616)
        Me.fraControl.TabIndex = 144
        Me.fraControl.TabStop = False
        Me.fraControl.Text = "Testactions"
        '
        'cmdTrackSunCommand
        '
        Me.cmdTrackSunCommand.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdTrackSunCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTrackSunCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrackSunCommand.ForeColor = System.Drawing.Color.Black
        Me.cmdTrackSunCommand.Location = New System.Drawing.Point(105, 491)
        Me.cmdTrackSunCommand.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrackSunCommand.Name = "cmdTrackSunCommand"
        Me.cmdTrackSunCommand.Size = New System.Drawing.Size(245, 44)
        Me.cmdTrackSunCommand.TabIndex = 163
        Me.cmdTrackSunCommand.Text = "Track Sun"
        Me.cmdTrackSunCommand.UseVisualStyleBackColor = False
        '
        'cmdTrackMoonCommand
        '
        Me.cmdTrackMoonCommand.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdTrackMoonCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTrackMoonCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrackMoonCommand.ForeColor = System.Drawing.Color.Black
        Me.cmdTrackMoonCommand.Location = New System.Drawing.Point(105, 439)
        Me.cmdTrackMoonCommand.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrackMoonCommand.Name = "cmdTrackMoonCommand"
        Me.cmdTrackMoonCommand.Size = New System.Drawing.Size(245, 44)
        Me.cmdTrackMoonCommand.TabIndex = 162
        Me.cmdTrackMoonCommand.Text = "Track Moon"
        Me.cmdTrackMoonCommand.UseVisualStyleBackColor = False
        '
        'cmdTrackMoon
        '
        Me.cmdTrackMoon.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdTrackMoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTrackMoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrackMoon.ForeColor = System.Drawing.Color.Black
        Me.cmdTrackMoon.Location = New System.Drawing.Point(105, 387)
        Me.cmdTrackMoon.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrackMoon.Name = "cmdTrackMoon"
        Me.cmdTrackMoon.Size = New System.Drawing.Size(302, 44)
        Me.cmdTrackMoon.TabIndex = 161
        Me.cmdTrackMoon.Text = "Track Moon custom speed"
        Me.cmdTrackMoon.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(557, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 25)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "arcSec per sec"
        '
        'cmdRightAscensionRate
        '
        Me.cmdRightAscensionRate.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdRightAscensionRate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRightAscensionRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRightAscensionRate.ForeColor = System.Drawing.Color.Black
        Me.cmdRightAscensionRate.Location = New System.Drawing.Point(105, 283)
        Me.cmdRightAscensionRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRightAscensionRate.Name = "cmdRightAscensionRate"
        Me.cmdRightAscensionRate.Size = New System.Drawing.Size(245, 44)
        Me.cmdRightAscensionRate.TabIndex = 159
        Me.cmdRightAscensionRate.Text = "RightAscensionRate"
        Me.cmdRightAscensionRate.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(557, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 25)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "RA Seconds per sec"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(368, 346)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 25)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "DE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(368, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 25)
        Me.Label12.TabIndex = 155
        Me.Label12.Text = "RA"
        '
        'txtDeRate
        '
        Me.txtDeRate.Location = New System.Drawing.Point(418, 342)
        Me.txtDeRate.Name = "txtDeRate"
        Me.txtDeRate.Size = New System.Drawing.Size(122, 29)
        Me.txtDeRate.TabIndex = 154
        Me.txtDeRate.Text = "3"
        Me.txtDeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRaRate
        '
        Me.txtRaRate.Location = New System.Drawing.Point(418, 290)
        Me.txtRaRate.Name = "txtRaRate"
        Me.txtRaRate.Size = New System.Drawing.Size(122, 29)
        Me.txtRaRate.TabIndex = 153
        Me.txtRaRate.Text = "2"
        Me.txtRaRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdDeclinationRate
        '
        Me.cmdDeclinationRate.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdDeclinationRate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdDeclinationRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeclinationRate.ForeColor = System.Drawing.Color.Black
        Me.cmdDeclinationRate.Location = New System.Drawing.Point(105, 335)
        Me.cmdDeclinationRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDeclinationRate.Name = "cmdDeclinationRate"
        Me.cmdDeclinationRate.Size = New System.Drawing.Size(245, 44)
        Me.cmdDeclinationRate.TabIndex = 152
        Me.cmdDeclinationRate.Text = "DeclinationRate"
        Me.cmdDeclinationRate.UseVisualStyleBackColor = False
        '
        'cmdTrackOff
        '
        Me.cmdTrackOff.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdTrackOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTrackOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrackOff.ForeColor = System.Drawing.Color.Black
        Me.cmdTrackOff.Location = New System.Drawing.Point(278, 29)
        Me.cmdTrackOff.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrackOff.Name = "cmdTrackOff"
        Me.cmdTrackOff.Size = New System.Drawing.Size(165, 44)
        Me.cmdTrackOff.TabIndex = 151
        Me.cmdTrackOff.Text = "Track Off"
        Me.cmdTrackOff.UseVisualStyleBackColor = False
        '
        'cmdTrackOn
        '
        Me.cmdTrackOn.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdTrackOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTrackOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrackOn.ForeColor = System.Drawing.Color.Black
        Me.cmdTrackOn.Location = New System.Drawing.Point(105, 29)
        Me.cmdTrackOn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrackOn.Name = "cmdTrackOn"
        Me.cmdTrackOn.Size = New System.Drawing.Size(165, 44)
        Me.cmdTrackOn.TabIndex = 150
        Me.cmdTrackOn.Text = "Track On"
        Me.cmdTrackOn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 25)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "milliseconds"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "milliseconds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(289, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 25)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "DE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(289, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 25)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "RA"
        '
        'txtPulseDe
        '
        Me.txtPulseDe.Location = New System.Drawing.Point(339, 207)
        Me.txtPulseDe.Name = "txtPulseDe"
        Me.txtPulseDe.Size = New System.Drawing.Size(122, 29)
        Me.txtPulseDe.TabIndex = 144
        Me.txtPulseDe.Text = "-1000"
        Me.txtPulseDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPulseRa
        '
        Me.txtPulseRa.Location = New System.Drawing.Point(339, 172)
        Me.txtPulseRa.Name = "txtPulseRa"
        Me.txtPulseRa.Size = New System.Drawing.Size(122, 29)
        Me.txtPulseRa.TabIndex = 143
        Me.txtPulseRa.Text = "500"
        Me.txtPulseRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdPulseGuide
        '
        Me.cmdPulseGuide.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdPulseGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPulseGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPulseGuide.ForeColor = System.Drawing.Color.Black
        Me.cmdPulseGuide.Location = New System.Drawing.Point(105, 184)
        Me.cmdPulseGuide.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPulseGuide.Name = "cmdPulseGuide"
        Me.cmdPulseGuide.Size = New System.Drawing.Size(165, 44)
        Me.cmdPulseGuide.TabIndex = 142
        Me.cmdPulseGuide.Text = "PulseGuide"
        Me.cmdPulseGuide.UseVisualStyleBackColor = False
        '
        'lblTracking
        '
        Me.lblTracking.AutoSize = True
        Me.lblTracking.Location = New System.Drawing.Point(796, 106)
        Me.lblTracking.Name = "lblTracking"
        Me.lblTracking.Size = New System.Drawing.Size(99, 25)
        Me.lblTracking.TabIndex = 145
        Me.lblTracking.Text = "Tracking: "
        '
        'cmdAbortSlew
        '
        Me.cmdAbortSlew.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdAbortSlew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAbortSlew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbortSlew.ForeColor = System.Drawing.Color.Black
        Me.cmdAbortSlew.Location = New System.Drawing.Point(613, 157)
        Me.cmdAbortSlew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAbortSlew.Name = "cmdAbortSlew"
        Me.cmdAbortSlew.Size = New System.Drawing.Size(165, 44)
        Me.cmdAbortSlew.TabIndex = 164
        Me.cmdAbortSlew.Text = "AbortSlew"
        Me.cmdAbortSlew.UseVisualStyleBackColor = False
        '
        'cmdTrackSiderial
        '
        Me.cmdTrackSiderial.BackColor = System.Drawing.Color.DarkTurquoise
        Me.cmdTrackSiderial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTrackSiderial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrackSiderial.ForeColor = System.Drawing.Color.Black
        Me.cmdTrackSiderial.Location = New System.Drawing.Point(105, 543)
        Me.cmdTrackSiderial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrackSiderial.Name = "cmdTrackSiderial"
        Me.cmdTrackSiderial.Size = New System.Drawing.Size(245, 44)
        Me.cmdTrackSiderial.TabIndex = 165
        Me.cmdTrackSiderial.Text = "Track Siderial"
        Me.cmdTrackSiderial.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 830)
        Me.Controls.Add(Me.lblTracking)
        Me.Controls.Add(Me.fraControl)
        Me.Controls.Add(Me.lblDE)
        Me.Controls.Add(Me.lblRA)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.txtTelAscomName)
        Me.Controls.Add(Me.cmdTelAscom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.fraControl.ResumeLayout(False)
        Me.fraControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtTelAscomName As TextBox
    Friend WithEvents cmdTelAscom As Button
    Friend WithEvents cmdConnect As Button
    Friend WithEvents cmdMoveAxis As Button
    Friend WithEvents txtMoveAxRa As TextBox
    Friend WithEvents txtMoveAxDe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdMoveAxStop As Button
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents lblRA As Label
    Friend WithEvents lblDE As Label
    Friend WithEvents fraControl As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPulseDe As TextBox
    Friend WithEvents txtPulseRa As TextBox
    Friend WithEvents cmdPulseGuide As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTracking As Label
    Friend WithEvents cmdTrackOff As Button
    Friend WithEvents cmdTrackOn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDeRate As TextBox
    Friend WithEvents txtRaRate As TextBox
    Friend WithEvents cmdDeclinationRate As Button
    Friend WithEvents cmdRightAscensionRate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdTrackMoon As Button
    Friend WithEvents cmdTrackMoonCommand As Button
    Friend WithEvents cmdTrackSunCommand As Button
    Friend WithEvents cmdAbortSlew As Button
    Friend WithEvents cmdTrackSiderial As Button
End Class
