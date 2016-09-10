Public Class WindowsOptimizerForm
    Private Sub AddRemoveProgramsButton_Click(sender As Object, e As EventArgs) Handles AddRemoveProgramsButton.Click
        Shell("control appwiz.cpl")
    End Sub

    Private Sub DiskCleanupButton_Click(sender As Object, e As EventArgs) Handles DiskCleanupButton.Click
        Shell("cleanmgr.exe")
    End Sub

    Private Sub DiskDefragmentButton_Click(sender As Object, e As EventArgs) Handles DiskDefragmentButton.Click
        Shell("dfrgui.exe")
    End Sub

    Private Sub PerformanceOptionsButton_Click(sender As Object, e As EventArgs) Handles PerformanceOptionsButton.Click
        Shell("cmd.exe /c explorer.exe PerformanceOptions.{78F3955E-3B90-4184-BD14-5397C15F1EFC}")
    End Sub

    Private Sub PowerOptionsButton_Click(sender As Object, e As EventArgs) Handles PowerOptionsButton.Click
        Shell("control powercfg.cpl")
    End Sub
End Class
