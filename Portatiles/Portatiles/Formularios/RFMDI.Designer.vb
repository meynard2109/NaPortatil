<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFMDI
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BBIFacturacion = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIRemision = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIAjustes = New DevExpress.XtraBars.BarButtonItem()
        Me.BBICompras = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIKardex = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIListaFacturas = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIListaRemisiones = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIListadoAjustes = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIListadoCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.BBICatalogos = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIConfiguracion = New DevExpress.XtraBars.BarButtonItem()
        Me.BBIImportador = New DevExpress.XtraBars.BarButtonItem()
        Me.RPMovimientos = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RPGMovimientos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGListados = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGCatalogo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RPGCatalogos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BBISeries = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BBIFacturacion, Me.BBIRemision, Me.BBIAjustes, Me.BBICompras, Me.BBIKardex, Me.BBIListaFacturas, Me.BBIListaRemisiones, Me.BBIListadoAjustes, Me.BBIListadoCompras, Me.BBICatalogos, Me.BBIConfiguracion, Me.BBIImportador, Me.BBISeries})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 26
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RPMovimientos})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl.Size = New System.Drawing.Size(701, 145)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BBIFacturacion
        '
        Me.BBIFacturacion.Caption = "Facturación"
        Me.BBIFacturacion.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIFacturacion.Id = 10
        Me.BBIFacturacion.LargeGlyph = Global.Portatiles.My.Resources.Resources.Calc
        Me.BBIFacturacion.Name = "BBIFacturacion"
        '
        'BBIRemision
        '
        Me.BBIRemision.Caption = "Remisión"
        Me.BBIRemision.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIRemision.Id = 11
        Me.BBIRemision.LargeGlyph = Global.Portatiles.My.Resources.Resources.Refresh
        Me.BBIRemision.Name = "BBIRemision"
        '
        'BBIAjustes
        '
        Me.BBIAjustes.Caption = "Ajustes"
        Me.BBIAjustes.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIAjustes.Id = 12
        Me.BBIAjustes.LargeGlyph = Global.Portatiles.My.Resources.Resources.Document_Spreadsheet
        Me.BBIAjustes.Name = "BBIAjustes"
        '
        'BBICompras
        '
        Me.BBICompras.Caption = "Compras"
        Me.BBICompras.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBICompras.Id = 13
        Me.BBICompras.LargeGlyph = Global.Portatiles.My.Resources.Resources.shopping_cart
        Me.BBICompras.Name = "BBICompras"
        '
        'BBIKardex
        '
        Me.BBIKardex.Caption = "Kardex"
        Me.BBIKardex.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIKardex.Id = 14
        Me.BBIKardex.Name = "BBIKardex"
        '
        'BBIListaFacturas
        '
        Me.BBIListaFacturas.Caption = "Listado de Facturas"
        Me.BBIListaFacturas.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIListaFacturas.Id = 15
        Me.BBIListaFacturas.LargeGlyph = Global.Portatiles.My.Resources.Resources.Calc
        Me.BBIListaFacturas.Name = "BBIListaFacturas"
        '
        'BBIListaRemisiones
        '
        Me.BBIListaRemisiones.Caption = "Listado de Remisiones"
        Me.BBIListaRemisiones.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIListaRemisiones.Id = 16
        Me.BBIListaRemisiones.LargeGlyph = Global.Portatiles.My.Resources.Resources.Refresh
        Me.BBIListaRemisiones.Name = "BBIListaRemisiones"
        '
        'BBIListadoAjustes
        '
        Me.BBIListadoAjustes.Caption = "Listado de Ajustes"
        Me.BBIListadoAjustes.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIListadoAjustes.Id = 17
        Me.BBIListadoAjustes.LargeGlyph = Global.Portatiles.My.Resources.Resources.Document_Spreadsheet
        Me.BBIListadoAjustes.Name = "BBIListadoAjustes"
        '
        'BBIListadoCompras
        '
        Me.BBIListadoCompras.Caption = "Listado de Compras"
        Me.BBIListadoCompras.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIListadoCompras.Id = 18
        Me.BBIListadoCompras.LargeGlyph = Global.Portatiles.My.Resources.Resources.shopping_cart
        Me.BBIListadoCompras.Name = "BBIListadoCompras"
        '
        'BBICatalogos
        '
        Me.BBICatalogos.Caption = "Catálogos"
        Me.BBICatalogos.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBICatalogos.Id = 20
        Me.BBICatalogos.LargeGlyph = Global.Portatiles.My.Resources.Resources.Contact
        Me.BBICatalogos.Name = "BBICatalogos"
        '
        'BBIConfiguracion
        '
        Me.BBIConfiguracion.Caption = "Configuración"
        Me.BBIConfiguracion.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIConfiguracion.Id = 21
        Me.BBIConfiguracion.LargeGlyph = Global.Portatiles.My.Resources.Resources.Luggage
        Me.BBIConfiguracion.Name = "BBIConfiguracion"
        '
        'BBIImportador
        '
        Me.BBIImportador.Caption = "Importador"
        Me.BBIImportador.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBIImportador.Id = 22
        Me.BBIImportador.LargeGlyph = Global.Portatiles.My.Resources.Resources.Arrow___Down
        Me.BBIImportador.Name = "BBIImportador"
        '
        'RPMovimientos
        '
        Me.RPMovimientos.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RPGMovimientos, Me.RPGListados, Me.RPGCatalogo, Me.RPGConfiguracion})
        Me.RPMovimientos.Name = "RPMovimientos"
        Me.RPMovimientos.Text = "Movimientos"
        '
        'RPGMovimientos
        '
        Me.RPGMovimientos.ItemLinks.Add(Me.BBIFacturacion)
        Me.RPGMovimientos.ItemLinks.Add(Me.BBIRemision)
        Me.RPGMovimientos.ItemLinks.Add(Me.BBIAjustes)
        Me.RPGMovimientos.ItemLinks.Add(Me.BBICompras)
        Me.RPGMovimientos.ItemLinks.Add(Me.BBISeries)
        Me.RPGMovimientos.ItemLinks.Add(Me.BBIKardex)
        Me.RPGMovimientos.Name = "RPGMovimientos"
        Me.RPGMovimientos.Text = "Movimientos"
        '
        'RPGListados
        '
        Me.RPGListados.ItemLinks.Add(Me.BBIListaFacturas)
        Me.RPGListados.ItemLinks.Add(Me.BBIListaRemisiones)
        Me.RPGListados.ItemLinks.Add(Me.BBIListadoAjustes)
        Me.RPGListados.ItemLinks.Add(Me.BBIListadoCompras)
        Me.RPGListados.Name = "RPGListados"
        Me.RPGListados.Text = "Listados"
        '
        'RPGCatalogo
        '
        Me.RPGCatalogo.ItemLinks.Add(Me.BBICatalogos)
        Me.RPGCatalogo.Name = "RPGCatalogo"
        '
        'RPGConfiguracion
        '
        Me.RPGConfiguracion.ItemLinks.Add(Me.BBIConfiguracion)
        Me.RPGConfiguracion.ItemLinks.Add(Me.BBIImportador)
        Me.RPGConfiguracion.Name = "RPGConfiguracion"
        Me.RPGConfiguracion.Text = "Herramientas"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 417)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(701, 32)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue"
        '
        'RPGCatalogos
        '
        Me.RPGCatalogos.Name = "RPGCatalogos"
        Me.RPGCatalogos.Text = "Catálogos"
        '
        'BBISeries
        '
        Me.BBISeries.Caption = "Series de Productos"
        Me.BBISeries.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BBISeries.Id = 25
        Me.BBISeries.Name = "BBISeries"
        '
        'RFMDI
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.Appearance.BackColor = System.Drawing.Color.Navy
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "RFMDI"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Sistema de Control de Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RPGMovimientos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BBIFacturacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIRemision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIAjustes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBICompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIKardex As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIListaFacturas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIListaRemisiones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIListadoAjustes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIListadoCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RPMovimientos As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RPGListados As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RPGCatalogo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RPGCatalogos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBICatalogos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBIConfiguracion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RPGConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBIImportador As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBISeries As DevExpress.XtraBars.BarButtonItem


End Class
