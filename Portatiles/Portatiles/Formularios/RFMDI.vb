Public Class RFMDI 

   
  
    Private Sub RFMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConfiguracion()
    End Sub

    Private Sub BBICatalogos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBICatalogos.ItemClick
        FrmCatalogos.MdiParent = Me
        FrmCatalogos.Show()
    End Sub

    Private Sub BBIConfiguracion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIConfiguracion.ItemClick
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub BBIAjustes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIAjustes.ItemClick
        FrmAjustes.MdiParent = Me
        FrmAjustes.Show()
    End Sub

    Private Sub BBICompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBICompras.ItemClick
        FrmCompras.MdiParent = Me
        FrmCompras.Show()
    End Sub

    Private Sub BBIListadoAjustes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListadoAjustes.ItemClick
        MovimientoListado = "Ajustes"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIListaFacturas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListaFacturas.ItemClick
        MovimientoListado = "Ventas"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIListaRemisiones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListaRemisiones.ItemClick
        MovimientoListado = "Remisiones"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIListadoCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListadoCompras.ItemClick
        MovimientoListado = "Compras"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIImportador_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIImportador.ItemClick
        FrmImportador.MdiParent = Me
        FrmImportador.Show()
    End Sub

    Private Sub BBIFacturacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIFacturacion.ItemClick
        FrmFacturacion.MdiParent = Me
        FrmFacturacion.Show()
    End Sub

    Private Sub BBIRemision_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIRemision.ItemClick

    End Sub

    Private Sub BBIKardex_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIKardex.ItemClick
        XtraForm1.Show()
    End Sub

    Private Sub BBISeries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBISeries.ItemClick
        FrmSeriesProducto.MdiParent = Me
        FrmSeriesProducto.Show()
    End Sub
End Class