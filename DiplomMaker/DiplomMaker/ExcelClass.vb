Public Class ExcelClass
    Dim path_ As String
    Public Property path As String
        Get
            Return path_
        End Get
        Set(value As String)
            path_ = value
        End Set
    End Property
End Class
