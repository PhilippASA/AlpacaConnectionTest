Imports ASCOM.DeviceInterface
Public Class Form1
    Dim Telescope As ASCOM.DriverAccess.Telescope ' AstrooptikServer.Telescope
    Dim gTelAscomName As String
    Dim trackrates As ITrackingRates
    Dim gGeoBreite As Double = 50 'Latitude
    Dim gGeoLaenge As Double = -11 'Longitude (11 east)
    Dim gGeoHoehe As Double = 500 'MSL
    Dim gTemp As Double = 10
    Dim gDruck As Double = 1000



    Private Function WandleKomma_Punkt(ByRef Kette As String) As String
        Dim Position As Integer
        Dim Laenge As Integer
        Dim String1 As String
        Dim String2 As String
        Position = InStr(Kette, ",")
        If Position = 0 Then
            WandleKomma_Punkt = Kette
            Exit Function
        End If
        Laenge = Len(Kette)
        String1 = Strings.Left(Kette, Position - 1)
        String2 = Strings.Right(Kette, Laenge - Position)
        WandleKomma_Punkt = String1 & "." & String2

    End Function

    Private Sub cmdTelAscom_Click(sender As Object, e As EventArgs) Handles cmdTelAscom.Click
        Dim chsr As New ASCOM.Utilities.Chooser
        ' This will be a Telescope chooser
        chsr.DeviceType = "Telescope"
        ' Retrieve the ProgID of the previously chosen
        ' device, or set it to ""
        gTelAscomName = chsr.Choose("Ascom.AlpacaDynamic1.Telescope")
        txtTelAscomName.Text = gTelAscomName
        Me.Refresh()
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        Telescope = New ASCOM.DriverAccess.Telescope(gTelAscomName)
        Telescope.Connected = True
        Dim ConnectTest As Boolean = Telescope.Connected
        Beep()
        tmrRefresh.Enabled = True
        fraControl.Enabled = True
        trackrates = Telescope.TrackingRates




    End Sub

    Private Sub cmdMoveAxis_Click(sender As Object, e As EventArgs) Handles cmdMoveAxis.Click
        Dim RaSpeed, DeSpeed As Double
        RaSpeed = Val(WandleKomma_Punkt(txtMoveAxRa.Text))
        DeSpeed = Val(WandleKomma_Punkt(txtMoveAxDe.Text))
        Telescope.MoveAxis(TelescopeAxes.axisPrimary, RaSpeed)
        Telescope.MoveAxis(TelescopeAxes.axisSecondary, DeSpeed)


    End Sub

    Private Sub cmdMoveAxStop_Click(sender As Object, e As EventArgs) Handles cmdMoveAxStop.Click
        Telescope.MoveAxis(TelescopeAxes.axisPrimary, 0)
        Telescope.MoveAxis(TelescopeAxes.axisSecondary, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        lblRA.Text = Telescope.RightAscension.ToString("0.00000")
        lblDE.Text = Telescope.Declination.ToString("0.0000")
        If Telescope.Tracking Then
            lblTracking.Text = "Tracking: true  Rate " + Telescope.TrackingRate.ToString
        Else
            lblTracking.Text = "Tracking: false  Rate " + Telescope.TrackingRate.ToString
        End If

    End Sub

    Private Sub cmdPulseGuide_Click(sender As Object, e As EventArgs) Handles cmdPulseGuide.Click
        Dim ValRa As Integer = CInt(Val(WandleKomma_Punkt(txtPulseRa.Text)))
        Dim ValDe As Integer = CInt(Val(WandleKomma_Punkt(txtPulseDe.Text)))

        Telescope.Tracking = True 'tracking must be on for pulseguide


        If ValRa < 0 Then
            Telescope.PulseGuide(GuideDirections.guideWest, ValRa)
        ElseIf ValRa > 0 Then
            Telescope.PulseGuide(GuideDirections.guideEast, ValRa)
        Else

        End If

        If ValDe < 0 Then
            Telescope.PulseGuide(GuideDirections.guideSouth, ValDe)
        ElseIf Valde > 0 Then
            Telescope.PulseGuide(GuideDirections.guideNorth, ValDe)
        Else

        End If


    End Sub

    Private Sub cmdTrackOn_Click(sender As Object, e As EventArgs) Handles cmdTrackOn.Click
        Telescope.Tracking = True
    End Sub

    Private Sub cmdTrackOff_Click(sender As Object, e As EventArgs) Handles cmdTrackOff.Click
        Telescope.Tracking = False
    End Sub

    Private Sub cmdRightAscensionRate_Click(sender As Object, e As EventArgs) Handles cmdRightAscensionRate.Click
        Telescope.RightAscensionRate = CDbl(Val(WandleKomma_Punkt(txtRaRate.Text)))
    End Sub

    Private Sub cmdDeclinationRate_Click(sender As Object, e As EventArgs) Handles cmdDeclinationRate.Click
        Dim MyVal As Double = Val(WandleKomma_Punkt(txtDeRate.Text))
        Telescope.DeclinationRate = MyVal
    End Sub

    Private Sub cmdTrackMoon_Click(sender As Object, e As EventArgs) Handles cmdTrackMoon.Click
        Dim Nov As New ASCOM.Astrometry.NOVAS.NOVAS31
        Dim MyPlace As Short
        Dim myDate As DateTime = DateTime.UtcNow
        Dim JDNow As Double
        Dim JDFut As Double '10 Minutes later
        Dim MyObj As New ASCOM.Astrometry.Object3
        Dim MyPosNow As New ASCOM.Astrometry.SkyPos
        Dim MyPosFut As New ASCOM.Astrometry.SkyPos 'Position 10 Minutes later

        Dim MyObsSurface As ASCOM.Astrometry.OnSurface
        Dim MyObserver As New ASCOM.Astrometry.Observer

        Dim MoonRaNow As Double
        Dim MoonRaFut As Double
        Dim MoonDeNow As Double
        Dim MoonDeFut As Double
        Dim MoonDiffRa As Double
        Dim MoonDiffDe As Double
        Dim MoonSpeedDe As Double 'in degr. per second
        Dim MoonSpeedRa As Double 'in degr. per second

        JDNow = Nov.JulianDate(myDate.Year, myDate.Month, myDate.Day, myDate.Hour + myDate.Minute / 60 + myDate.Second / 3600)
        JDFut = JDNow + 10 / 60 / 24

        Nov.MakeOnSurface(gGeoBreite, -gGeoLaenge, gGeoHoehe, gTemp, gDruck, MyObsSurface)
        MyObserver.OnSurf = MyObsSurface
        MyObserver.Where = ASCOM.Astrometry.ObserverLocation.EarthSurface
        MyObj.Name = "Moon"
        MyObj.Number = ASCOM.Astrometry.Body.Moon
        MyObj.Type = ASCOM.Astrometry.ObjectType.MajorPlanetSunOrMoon

        MyPlace = Nov.Place(JDNow, MyObj, MyObserver, 0, 1, 0, MyPosNow)
        MyPlace = Nov.Place(JDFut, MyObj, MyObserver, 0, 1, 0, MyPosFut)

        MoonRaNow = MyPosNow.RA
        MoonRaFut = MyPosFut.RA
        MoonDeNow = MyPosNow.Dec
        MoonDeFut = MyPosFut.Dec

        MoonDiffRa = MoonRaFut - MoonRaNow 'RA Hours per 10 Minutes of UTC time 
        If MoonDiffRa > 180 Then MoonDiffRa = 360 - MoonDiffRa
        If MoonDiffRa < -180 Then MoonDiffRa = 360 + MoonDiffRa

        MoonDiffDe = MoonDeFut - MoonDeNow 'Degree per 10 Minutes
        MoonSpeedRa = MoonDiffRa * 3600 / 10 / 60   'we have to convert to RA seconds per second

        MoonSpeedDe = MoonDiffDe * 3600 / 10 / 60 'we have to convert to arc seconds per second

        txtRaRate.Text = MoonSpeedRa.ToString("0.000000")
        txtDeRate.Text = MoonSpeedDe.ToString("0.000000")
        cmdRightAscensionRate_Click(Me, Nothing)
        cmdDeclinationRate_Click(Me, Nothing)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim isOK As Boolean = Telescope.CommandBool("TrackMoon", "")

    End Sub

    Private Sub cmdTrackMoonCommand_Click(sender As Object, e As EventArgs) Handles cmdTrackMoonCommand.Click
        'Dim isOK As Boolean = Telescope.CommandBool("TrackMoon", "true")
        Telescope.TrackingRate = DriveRates.driveLunar
    End Sub

    Private Sub cmdTrackSunCommand_Click(sender As Object, e As EventArgs) Handles cmdTrackSunCommand.Click
        'Dim isOK As Boolean = Telescope.CommandBool("TrackSun", "true")
        Telescope.TrackingRate = DriveRates.driveSolar

    End Sub

    Private Sub fraControl_Enter(sender As Object, e As EventArgs) Handles fraControl.Enter

    End Sub

    Private Sub cmdAbortSlew_Click(sender As Object, e As EventArgs) Handles cmdAbortSlew.Click
        Telescope.AbortSlew()
    End Sub

    Private Sub cmdTrackSiderial_Click(sender As Object, e As EventArgs) Handles cmdTrackSiderial.Click
        Telescope.TrackingRate = DriveRates.driveSidereal
    End Sub
End Class
