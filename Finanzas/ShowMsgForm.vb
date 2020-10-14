Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Media

Friend Class ShowMsgForm

#Region " Storage "

    Private _Sound As SystemSound

    Private WithEvents PD As Printing.PrintDocument = Nothing
    Private FormImage As Bitmap = Nothing

#End Region

#Region " Properties "

    Friend Property Sound() As SystemSound
        Get
            Return _Sound
        End Get
        Set(ByVal value As System.Media.SystemSound)
            _Sound = value
        End Set
    End Property

#End Region

#Region " Constructors "



#End Region

#Region " Event handlers "

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) _
    Handles PD.PrintPage
        e.Graphics.DrawImage(FormImage, 100, 100)
    End Sub

    Private Sub PrintLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles PrintLabel.Click
        If PD IsNot Nothing Then Exit Sub 'A print is already in progress

        'Get an image of the form
        Dim G As Graphics = Me.CreateGraphics()
        FormImage = New Bitmap(Me.Width, Me.Height, G)
        Dim FG As Graphics = Graphics.FromImage(FormImage)
        Dim dc1 As IntPtr = G.GetHdc
        Dim dc2 As IntPtr = FG.GetHdc

        Dim WidthDiff As Integer = (Me.Width - Me.ClientRectangle.Width)
        Dim HeightDiff As Integer = (Me.Height - Me.ClientRectangle.Height)
        Dim BorderSize As Integer = WidthDiff \ 2
        Dim HeightTitleBar As Integer = HeightDiff - BorderSize

        Win32.BitBlt(dc2, 0, 0,
        Me.ClientRectangle.Width + WidthDiff, Me.ClientRectangle.Height + HeightDiff,
        dc1, 0 - BorderSize, 0 - HeightTitleBar, Win32.SRCCOPY)

        G.ReleaseHdc(dc1)
        FG.ReleaseHdc(dc2)
        FG = Nothing
        G = Nothing

        'And print it
        PD = New Printing.PrintDocument
        PD.Print()

        'Then clean up
        PD.Dispose()
        FormImage = Nothing
    End Sub

    Private Sub ShowMsgForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) _
    Handles Me.FormClosing
        'If the user clicks on the Close Form button in the upper right,
        'it will have the same effect as clicking the accept button
        If e.CloseReason = CloseReason.UserClosing AndAlso Me.AcceptButton IsNot Nothing Then
            Me.DialogResult = CType(Me.AcceptButton, Button).DialogResult
        End If
    End Sub

    Private Sub ShowMsgForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Me.Load
        'Give the focus to the accept button, providing a visual clue as to which button it is.
        Dim Btn As Button = TryCast(Me.AcceptButton, Button)

        If Btn IsNot Nothing AndAlso Btn.Visible Then
            Btn.Select()
        Else
            Me.Button1.Select()
        End If
    End Sub

#End Region

#Region " Methods "

    Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
        'Intercept OnShown to play the sound
        If _Sound Is Nothing Then
            SystemSounds.Asterisk.Play()
        Else
            _Sound.Play()
        End If

        'Then carry on as usual
        MyBase.OnShown(e)
    End Sub

    Public Sub SizeForm()
        Dim NewHeight As Integer = 0
        Dim NewWidth As Integer = 0

        'Icon stays where it is.
        'TextLabel.Left and QuestionLabel.Left are already correct

        NewWidth = Math.Max(TextLabel.Width, QuestionTextLabel.Width) + TextLabel.Left + 4
        If NewWidth < 275 Then NewWidth = 275

        Button1.Left = NewWidth - Button1.Width - 4
        Button2.Left = Button1.Left - Button2.Width - 4

        If QuestionTextLabel.Text = "" Then
            PrintLabel.Top = TextLabel.Top + TextLabel.Height + 8
        Else
            QuestionTextLabel.Top = TextLabel.Top + TextLabel.Height + 8
            PrintLabel.Top = QuestionTextLabel.Top + QuestionTextLabel.Height + 8
        End If

        Button1.Top = PrintLabel.Top + PrintLabel.Height + 8
        Button2.Top = Button1.Top
        Button3.Top = Button1.Top

        NewHeight = Math.Max(Button1.Top + Button1.Height, MessagePictureBox.Top + MessagePictureBox.Height) + 4

        Me.SetClientSizeCore(NewWidth, NewHeight)
    End Sub

#End Region

End Class
