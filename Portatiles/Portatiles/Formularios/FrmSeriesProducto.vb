Public Class FrmSeriesProducto 

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        On Error GoTo tipoerr
        ClaveBusqueda = "Compras"

        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            txtNumCompra.Text = (CodigoGenerico)
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub txtNumCompra_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumCompra.EditValueChanged
        CargarProductosCompra()
    End Sub


    Private Sub CargarProductosCompra()
        On Error GoTo tipoerr
        Dim DtProductos As DataTable

        If Not txtNumCompra.Text.Trim = "" Then Exit Sub
        'DtProductos = EjecutarConsulta("")

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
End Class