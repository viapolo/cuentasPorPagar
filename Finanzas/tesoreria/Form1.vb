Imports System.Text

Imports ShowMessage

Public Class Form1

    Private Sub HelloWorldTextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles HelloWorldTextButton.Click
        ShowMsg("Hello, world!")
    End Sub

    Private Sub HelloWorldIconButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles HelloWorldIconButton.Click
        ShowMsg("Hello, world!", ShowMsgImage.Info)
    End Sub

    Private Sub HelloWorldTitleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles HelloWorldTitleButton.Click
        ShowMsg("Hello, world!", ShowMsgImage.Security, "Example dialog")
    End Sub

    Private Sub IfYouProceedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles IfYouProceedButton.Click
        Dim Result As DialogResult = _
            ShowMsg("If you proceed, another message box will be displayed.", _
            "Do you wish to proceed?", ShowMsgButtons.ContinueCancel)
        ShowMsg("You selected " + Result.ToString, ShowMsgImage.Info)
    End Sub

    Private Sub DoYouLikeCurryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles DoYouLikeCurryButton.Click
        Dim Result As DialogResult = ShowMsg("Do you like curry?", "", ShowMsgButtons.YesNo, ShowMsgDefaultButton.Button2)
        ShowMsg("You selected " + Result.ToString, ShowMsgImage.Info)
    End Sub

    Private Sub CleanBathtubButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles CleanBathtubButton.Click
        Dim Result As DialogResult = ShowMsg("The bathtub is filthy.", _
        "Would you like to clean it?", ShowMsgButtons.YesNoCancel)

        Select Case Result
            Case Windows.Forms.DialogResult.Yes
                ShowMsg("Out of cleanser. Unable to proceed.", ShowMsgImage.Critical)
            Case Windows.Forms.DialogResult.No
                ShowMsg("The bathroom has been closed because it needs cleaning.", ShowMsgImage.UnderConstruction)
            Case Windows.Forms.DialogResult.Cancel
                ShowMsg("We return you to our regularly scheduled demo.", ShowMsgImage.Info)
        End Select
    End Sub

    Private Sub DatabaseErrorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles DatabaseErrorButton.Click
        Dim Inner As New System.Exception("This is the inner exception.")
        Dim Ex As New System.Data.DataException("Unable to find requested data.", Inner)
        Ex.Data.Add("Table name", "ShinyThings")
        Ex.Data.Add("Column name", "Pretties")
        ShowMsg(Ex)
    End Sub

    Private Sub COMErrorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles COMErrorButton.Click
        Dim Inner As New System.Exception("The spark is gone.")
        Dim Ex As New System.Runtime.InteropServices.COMException("Component Object Model error (huge negative number)", Inner)
        ShowMsg(Ex, ShowMsgImage.Security)
    End Sub

    Private Sub FileErrorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles FileErrorButton.Click
        Dim Ex As New System.IO.FileNotFoundException("The file you requested could not be found.")
        ShowMsg(Ex, ShowMsgImage.Critical)
    End Sub

    Private Sub GeneralErrorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles GeneralErrorButton.Click
        Dim Ex As New System.Exception("Programmer is hungry error. Pizza should be ordered.")
        ShowMsg(Ex, ShowMsgImage.UnderConstruction)
    End Sub

    Private Sub AccessDeniedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles AccessDeniedButton.Click
        ShowAccessDenied()
    End Sub

    Private Sub FeatureUnavailableButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles FeatureUnavailableButton.Click
        ShowUnderConstruction()
    End Sub

    Private Sub DeprecatedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles DeprecatedButton.Click
        ShowDeprecated("Please alert the IT department if you still need this.")
    End Sub

    Private Sub LoremIpsumButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles LoremIpsumButton.Click
        Dim Msg As String = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed lacinia " + _
        "vestibulum urna vitae semper. Quisque ornare leo faucibus erat iaculis scelerisque. " + _
        "Phasellus sed lorem felis. In fringilla, augue vel tempor feugiat, dolor nisl faucibus magna, " + _
        "non interdum dolor ipsum sed velit. Cras pellentesque tristique vulputate. In euismod mi quis " + _
        "leo eleifend eget iaculis erat lacinia. Curabitur et eros vel neque ultrices tempor. Etiam " + _
        "rhoncus felis sed nunc porttitor vestibulum. Sed at massa orci, vel molestie dui. Sed tincidunt " + _
        "congue purus at rhoncus. Aenean metus ligula, volutpat cursus iaculis sit amet, rutrum vitae quam. " + _
        "Curabitur luctus eleifend nibh sed pharetra. Sed quam lacus, consectetur id sagittis ut, fringilla " + _
        "dapibus odio. Etiam tempor lectus id nisi adipiscing molestie. Nulla suscipit nunc hendrerit nisl " + _
        "accumsan convallis. Nullam ac tortor vitae nibh tristique vestibulum eget a elit."

        ShowMsg(Msg)
    End Sub
End Class
