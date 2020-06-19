'////////////////////////////////
Public Class ColumnaPersonalizada
    Inherits DataGridViewColumn

    ' propiedades
    Public Overrides Property CellTemplate() As System.Windows.Forms.DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As System.Windows.Forms.DataGridViewCell)
            MyBase.CellTemplate = value
        End Set
    End Property

    'métodos
    Public Sub New()
        MyBase.New(New CeldaPersonalizada())
    End Sub
End Class
'////////////////////////////////