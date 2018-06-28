Public Class Form1
    Dim Tens As Integer
    Dim Units As Integer
    Dim TargetVolume As Integer

    Public Class Sound
        Dim nircmd As String
        Const MAXVOL As Integer = 65535
        Public Sub New(ByVal nircmd_location As String)
            nircmd = nircmd_location
        End Sub
        Public Sub setVol(ByVal level As Integer)
            Dim p As New ProcessStartInfo
            p.FileName = nircmd
            p.Arguments = "setsysvolume " & (MAXVOL * (level / 100)).ToString
            Process.Start(p)
        End Sub
    End Class

    Public Sub Recognize()
        Dim vol As New Sound(System.IO.Directory.GetCurrentDirectory + "\nircmd.exe")
        If Tens1.Checked = True And Tens4.Checked = True And Tens6.Checked = True And Tens9.Checked = True And Tens11.Checked = True Then
            Tens = 10
        End If
        If Tens1.Checked = True And Tens2.Checked = True And Tens3.Checked = True And Tens5.Checked = True And Tens8.Checked = True And Tens7.Checked = True And Tens6.Checked = True And Tens9.Checked = True And Tens11.Checked = True And Tens12.Checked = True And Tens13.Checked = True Then
            Tens = 20
        End If
        If Tens1.Checked = True And Tens4.Checked = True And Tens6.Checked = True And Tens7.Checked = True And Tens8.Checked = True And Tens3.Checked = True And Tens5.Checked = True And Tens10.Checked = True And Tens13.Checked = True Then
            Tens = 40
        End If
        If Tens1.Checked = True And Tens4.Checked = True And Tens6.Checked = True And Tens7.Checked = True And Tens8.Checked = True And Tens10.Checked = True And Tens13.Checked = True And Tens12.Checked = True And Tens11.Checked = True And Tens2.Checked = True And Tens3.Checked = True Then
            Tens = 50
        End If
        If Tens1.Checked = True And Tens3.Checked = True And Tens2.Checked = True And Tens4.Checked = True And Tens6.Checked = True And Tens9.Checked = True And Tens11.Checked = True And Tens12.Checked = True And Tens13.Checked = True And Tens10.Checked = True And Tens8.Checked = True And Tens7.Checked = True Then
            Tens = 60
        End If
        If Tens1.Checked = True And Tens2.Checked = True And Tens3.Checked = True And Tens5.Checked = True And Tens8.Checked = True And Tens10.Checked = True And Tens13.Checked = True Then
            Tens = 70
        End If
        If Tens1.Checked = True And Tens2.Checked = True And Tens3.Checked = True And Tens5.Checked = True And Tens8.Checked = True And Tens7.Checked = True And Tens6.Checked = True And Tens10.Checked = True And Tens13.Checked = True And Tens12.Checked = True And Tens11.Checked = True Then
            Tens = 30
        End If
        If Tens1.Checked = True And Tens2.Checked = True And Tens3.Checked = True And Tens4.Checked = True And Tens5.Checked = True And Tens6.Checked = True And Tens7.Checked = True And Tens8.Checked = True And Tens10.Checked = True And Tens11.Checked = True And Tens12.Checked = True And Tens13.Checked = True Then
            Tens = 90
        End If
        If Tens1.Checked = True And Tens2.Checked = True And Tens3.Checked = True And Tens4.Checked = True And Tens5.Checked = True And Tens6.Checked = True And Tens7.Checked = True And Tens8.Checked = True And Tens9.Checked = True And Tens10.Checked = True And Tens11.Checked = True And Tens12.Checked = True And Tens13.Checked = True Then
            Tens = 80
        End If
        If Units1.Checked = True And Units4.Checked = True And Units6.Checked = True And Units9.Checked = True And Units11.Checked = True Then
            Units = 1
        End If
        If Units1.Checked = True And Units2.Checked = True And Units3.Checked = True And Units5.Checked = True And Units8.Checked = True And Units7.Checked = True And Units6.Checked = True And Units9.Checked = True And Units11.Checked = True And Units12.Checked = True And Units13.Checked = True Then
            Units = 2
        End If
        If Units1.Checked = True And Units4.Checked = True And Units6.Checked = True And Units7.Checked = True And Units8.Checked = True And Units3.Checked = True And Units5.Checked = True And Units10.Checked = True And Units13.Checked = True Then
            Units = 4
        End If
        If Units1.Checked = True And Units4.Checked = True And Units6.Checked = True And Units7.Checked = True And Units8.Checked = True And Units10.Checked = True And Units13.Checked = True And Units12.Checked = True And Units11.Checked = True And Units2.Checked = True And Units3.Checked = True Then
            Units = 5
        End If
        If Units1.Checked = True And Units3.Checked = True And Units2.Checked = True And Units4.Checked = True And Units6.Checked = True And Units9.Checked = True And Units11.Checked = True And Units12.Checked = True And Units13.Checked = True And Units10.Checked = True And Units8.Checked = True And Units7.Checked = True Then
            Units = 6
        End If
        If Units1.Checked = True And Units2.Checked = True And Units3.Checked = True And Units5.Checked = True And Units8.Checked = True And Units10.Checked = True And Units13.Checked = True Then
            Units = 7
        End If
        If Units1.Checked = True And Units2.Checked = True And Units3.Checked = True And Units5.Checked = True And Units8.Checked = True And Units7.Checked = True And Units6.Checked = True And Units10.Checked = True And Units13.Checked = True And Units12.Checked = True And Units11.Checked = True Then
            Units = 3
        End If
        If Units1.Checked = True And Units2.Checked = True And Units3.Checked = True And Units4.Checked = True And Units5.Checked = True And Units6.Checked = True And Units7.Checked = True And Units8.Checked = True And Units10.Checked = True And Units11.Checked = True And Units12.Checked = True And Units13.Checked = True Then
            Units = 9
        End If
        If Units1.Checked = True And Units2.Checked = True And Units3.Checked = True And Units4.Checked = True And Units5.Checked = True And Units6.Checked = True And Units7.Checked = True And Units8.Checked = True And Units9.Checked = True And Units10.Checked = True And Units11.Checked = True And Units12.Checked = True And Units13.Checked = True Then
            Units = 8
        End If
        If Tens1.Checked = True And Tens2.Checked = True And Tens3.Checked = True And Tens5.Checked = True And Tens8.Checked = True And Tens10.Checked = True And Tens13.Checked = True And Tens12.Checked = True And Tens11.Checked = True And Tens9.Checked = True And Tens6.Checked = True And Tens4.Checked = True Then
            Units = 0
        End If
        Label1.Text = Tens + Units
        vol.setVol(Label1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Recognize()
    End Sub
    Private Sub Tens1_CheckedChanged(sender As Object, e As EventArgs) Handles Tens1.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens2_CheckedChanged(sender As Object, e As EventArgs) Handles Tens2.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens3_CheckedChanged(sender As Object, e As EventArgs) Handles Tens3.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens14_CheckedChanged(sender As Object, e As EventArgs) Handles Tens4.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens5_CheckedChanged(sender As Object, e As EventArgs) Handles Tens5.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens6_CheckedChanged(sender As Object, e As EventArgs) Handles Tens6.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens7_CheckedChanged(sender As Object, e As EventArgs) Handles Tens7.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens8_CheckedChanged(sender As Object, e As EventArgs) Handles Tens8.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens9_CheckedChanged(sender As Object, e As EventArgs) Handles Tens9.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens10_CheckedChanged(sender As Object, e As EventArgs) Handles Tens10.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens11_CheckedChanged(sender As Object, e As EventArgs) Handles Tens11.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens12_CheckedChanged(sender As Object, e As EventArgs) Handles Tens12.CheckedChanged
        Recognize()
    End Sub
    Private Sub Tens13_CheckedChanged(sender As Object, e As EventArgs) Handles Tens13.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units1_CheckedChanged(sender As Object, e As EventArgs) Handles Units1.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units2_CheckedChanged(sender As Object, e As EventArgs) Handles Units2.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units3_CheckedChanged(sender As Object, e As EventArgs) Handles Units3.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units14_CheckedChanged(sender As Object, e As EventArgs) Handles Units4.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units5_CheckedChanged(sender As Object, e As EventArgs) Handles Units5.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units6_CheckedChanged(sender As Object, e As EventArgs) Handles Units6.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units7_CheckedChanged(sender As Object, e As EventArgs) Handles Units7.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units8_CheckedChanged(sender As Object, e As EventArgs) Handles Units8.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units9_CheckedChanged(sender As Object, e As EventArgs) Handles Units9.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units10_CheckedChanged(sender As Object, e As EventArgs) Handles Units10.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units11_CheckedChanged(sender As Object, e As EventArgs) Handles Units11.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units12_CheckedChanged(sender As Object, e As EventArgs) Handles Units12.CheckedChanged
        Recognize()
    End Sub
    Private Sub Units13_CheckedChanged(sender As Object, e As EventArgs) Handles Units13.CheckedChanged
        Recognize()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
