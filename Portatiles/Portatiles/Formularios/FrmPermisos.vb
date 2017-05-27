Public Class FrmPermisos
    Dim i As Integer
    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("simple error")

        ' If 1 = 1 Then


        MsgBox("Esta cosa nada tiene XD")


        'mi codigo AADG
        If True Then
            MsgBox("Ahora se me antojo escribir esta cosa")
            MsgBox("y esta cosa tambien")
            Dim animal As String = "perro"
            Select Case animal
                Case "perro"
                    MsgBox("soy un perro")
                Case Else
                    MsgBox("soy otra cosa menos un perro")
            End Select

        End If



    End Sub
End Class