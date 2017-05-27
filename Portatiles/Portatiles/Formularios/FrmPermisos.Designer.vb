<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisos
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.PanelPrincipal = New DevExpress.XtraEditors.PanelControl()
        Me.chkTodosGeneral = New DevExpress.XtraEditors.CheckEdit()
        Me.btnBuscarUser = New DevExpress.XtraEditors.SimpleButton()
        Me.LueUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelBotones = New DevExpress.XtraEditors.PanelControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.xtcPermisos = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpVentas = New DevExpress.XtraTab.XtraTabPage()
        Me.chkTodos1 = New DevExpress.XtraEditors.CheckEdit()
        Me.gcVentas = New DevExpress.XtraGrid.GridControl()
        Me.gvVentas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Modulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Acceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.xtpCompras = New DevExpress.XtraTab.XtraTabPage()
        Me.chkTodos2 = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.xtpListados = New DevExpress.XtraTab.XtraTabPage()
        Me.chkTodos3 = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.xtpReportes = New DevExpress.XtraTab.XtraTabPage()
        Me.chkTodos4 = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelTitulo = New DevExpress.XtraEditors.PanelControl()
        Me.LblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.PanelPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.chkTodosGeneral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        CType(Me.xtcPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcPermisos.SuspendLayout()
        Me.xtpVentas.SuspendLayout()
        CType(Me.chkTodos1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCompras.SuspendLayout()
        CType(Me.chkTodos2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpListados.SuspendLayout()
        CType(Me.chkTodos3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpReportes.SuspendLayout()
        CType(Me.chkTodos4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.chkTodosGeneral)
        Me.PanelPrincipal.Controls.Add(Me.btnBuscarUser)
        Me.PanelPrincipal.Controls.Add(Me.LueUsuario)
        Me.PanelPrincipal.Controls.Add(Me.LabelControl1)
        Me.PanelPrincipal.Controls.Add(Me.PanelBotones)
        Me.PanelPrincipal.Controls.Add(Me.xtcPermisos)
        Me.PanelPrincipal.Controls.Add(Me.PanelTitulo)
        Me.PanelPrincipal.Controls.Add(Me.Splitter1)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(602, 546)
        Me.PanelPrincipal.TabIndex = 4
        '
        'chkTodosGeneral
        '
        Me.chkTodosGeneral.Location = New System.Drawing.Point(442, 54)
        Me.chkTodosGeneral.Name = "chkTodosGeneral"
        Me.chkTodosGeneral.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodosGeneral.Properties.Appearance.Options.UseFont = True
        Me.chkTodosGeneral.Properties.Caption = "Acceso total"
        Me.chkTodosGeneral.Size = New System.Drawing.Size(119, 23)
        Me.chkTodosGeneral.TabIndex = 8
        '
        'btnBuscarUser
        '
        Me.btnBuscarUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarUser.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUser.Appearance.Options.UseFont = True
        Me.btnBuscarUser.Appearance.Options.UseTextOptions = True
        Me.btnBuscarUser.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarUser.Image = Global.Portatiles.My.Resources.Resources.Find_32x32
        Me.btnBuscarUser.Location = New System.Drawing.Point(364, 53)
        Me.btnBuscarUser.Name = "btnBuscarUser"
        Me.btnBuscarUser.Size = New System.Drawing.Size(42, 28)
        Me.btnBuscarUser.TabIndex = 3
        '
        'LueUsuario
        '
        Me.LueUsuario.Location = New System.Drawing.Point(123, 53)
        Me.LueUsuario.Name = "LueUsuario"
        Me.LueUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueUsuario.Properties.Appearance.Options.UseFont = True
        Me.LueUsuario.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueUsuario.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LueUsuario.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueUsuario.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.LueUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueUsuario.Size = New System.Drawing.Size(235, 26)
        Me.LueUsuario.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(19, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Cód. Usuario:"
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.btnGuardar)
        Me.PanelBotones.Controls.Add(Me.btnSalir)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotones.Location = New System.Drawing.Point(5, 479)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(595, 65)
        Me.PanelBotones.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.Image = Global.Portatiles.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(386, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 48)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Appearance.Options.UseTextOptions = True
        Me.btnSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnSalir.Location = New System.Drawing.Point(490, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        '
        'xtcPermisos
        '
        Me.xtcPermisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcPermisos.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtcPermisos.AppearancePage.Header.Options.UseFont = True
        Me.xtcPermisos.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xtcPermisos.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcPermisos.Location = New System.Drawing.Point(8, 90)
        Me.xtcPermisos.Name = "xtcPermisos"
        Me.xtcPermisos.SelectedTabPage = Me.xtpVentas
        Me.xtcPermisos.Size = New System.Drawing.Size(590, 383)
        Me.xtcPermisos.TabIndex = 3
        Me.xtcPermisos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpVentas, Me.xtpCompras, Me.xtpListados, Me.xtpReportes})
        '
        'xtpVentas
        '
        Me.xtpVentas.Controls.Add(Me.chkTodos1)
        Me.xtpVentas.Controls.Add(Me.gcVentas)
        Me.xtpVentas.Name = "xtpVentas"
        Me.xtpVentas.Size = New System.Drawing.Size(584, 352)
        Me.xtpVentas.Text = "Ventas"
        '
        'chkTodos1
        '
        Me.chkTodos1.Location = New System.Drawing.Point(374, 3)
        Me.chkTodos1.Name = "chkTodos1"
        Me.chkTodos1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos1.Properties.Appearance.Options.UseFont = True
        Me.chkTodos1.Properties.Caption = "Acceso a todo el módulo"
        Me.chkTodos1.Size = New System.Drawing.Size(195, 23)
        Me.chkTodos1.TabIndex = 6
        '
        'gcVentas
        '
        Me.gcVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVentas.Location = New System.Drawing.Point(10, 32)
        Me.gcVentas.MainView = Me.gvVentas
        Me.gcVentas.Name = "gcVentas"
        Me.gcVentas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcVentas.Size = New System.Drawing.Size(567, 313)
        Me.gcVentas.TabIndex = 5
        Me.gcVentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVentas})
        '
        'gvVentas
        '
        Me.gvVentas.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVentas.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvVentas.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVentas.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvVentas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvVentas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvVentas.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVentas.Appearance.Row.Options.UseFont = True
        Me.gvVentas.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVentas.Appearance.ViewCaption.Options.UseFont = True
        Me.gvVentas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Modulo, Me.Acceso})
        Me.gvVentas.GridControl = Me.gcVentas
        Me.gvVentas.Name = "gvVentas"
        Me.gvVentas.OptionsBehavior.Editable = False
        Me.gvVentas.OptionsView.ColumnAutoWidth = False
        Me.gvVentas.OptionsView.ShowGroupPanel = False
        '
        'Modulo
        '
        Me.Modulo.Caption = "Módulo"
        Me.Modulo.FieldName = "Modulo"
        Me.Modulo.Name = "Modulo"
        Me.Modulo.Visible = True
        Me.Modulo.VisibleIndex = 0
        Me.Modulo.Width = 450
        '
        'Acceso
        '
        Me.Acceso.Caption = "Acceso"
        Me.Acceso.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.Acceso.FieldName = "Acceso"
        Me.Acceso.Name = "Acceso"
        Me.Acceso.Visible = True
        Me.Acceso.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'xtpCompras
        '
        Me.xtpCompras.Controls.Add(Me.chkTodos2)
        Me.xtpCompras.Controls.Add(Me.GridControl1)
        Me.xtpCompras.Name = "xtpCompras"
        Me.xtpCompras.Size = New System.Drawing.Size(584, 352)
        Me.xtpCompras.Text = "Compras"
        '
        'chkTodos2
        '
        Me.chkTodos2.Location = New System.Drawing.Point(374, 3)
        Me.chkTodos2.Name = "chkTodos2"
        Me.chkTodos2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos2.Properties.Appearance.Options.UseFont = True
        Me.chkTodos2.Properties.Caption = "Acceso a todo el módulo"
        Me.chkTodos2.Size = New System.Drawing.Size(195, 23)
        Me.chkTodos2.TabIndex = 8
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(10, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(567, 313)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Módulo"
        Me.GridColumn1.FieldName = "Modulo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 450
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Acceso"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GridColumn2.FieldName = "Acceso"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemCheckEdit2.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'xtpListados
        '
        Me.xtpListados.Controls.Add(Me.chkTodos3)
        Me.xtpListados.Controls.Add(Me.GridControl2)
        Me.xtpListados.Name = "xtpListados"
        Me.xtpListados.Size = New System.Drawing.Size(584, 352)
        Me.xtpListados.Text = "Listados"
        '
        'chkTodos3
        '
        Me.chkTodos3.Location = New System.Drawing.Point(374, 3)
        Me.chkTodos3.Name = "chkTodos3"
        Me.chkTodos3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos3.Properties.Appearance.Options.UseFont = True
        Me.chkTodos3.Properties.Caption = "Acceso a todo el módulo"
        Me.chkTodos3.Size = New System.Drawing.Size(195, 23)
        Me.chkTodos3.TabIndex = 10
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Location = New System.Drawing.Point(10, 32)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.GridControl2.Size = New System.Drawing.Size(567, 313)
        Me.GridControl2.TabIndex = 9
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Módulo"
        Me.GridColumn3.FieldName = "Modulo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 450
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Acceso"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GridColumn4.FieldName = "Acceso"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemCheckEdit3.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'xtpReportes
        '
        Me.xtpReportes.Controls.Add(Me.chkTodos4)
        Me.xtpReportes.Controls.Add(Me.GridControl3)
        Me.xtpReportes.Name = "xtpReportes"
        Me.xtpReportes.Size = New System.Drawing.Size(584, 352)
        Me.xtpReportes.Text = "Reportes"
        '
        'chkTodos4
        '
        Me.chkTodos4.Location = New System.Drawing.Point(374, 3)
        Me.chkTodos4.Name = "chkTodos4"
        Me.chkTodos4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos4.Properties.Appearance.Options.UseFont = True
        Me.chkTodos4.Properties.Caption = "Acceso a todo el módulo"
        Me.chkTodos4.Size = New System.Drawing.Size(195, 23)
        Me.chkTodos4.TabIndex = 12
        '
        'GridControl3
        '
        Me.GridControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl3.Location = New System.Drawing.Point(10, 32)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit4})
        Me.GridControl3.Size = New System.Drawing.Size(567, 313)
        Me.GridControl3.TabIndex = 11
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Módulo"
        Me.GridColumn5.FieldName = "Modulo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 450
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Acceso"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.GridColumn6.FieldName = "Acceso"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemCheckEdit4.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'PanelTitulo
        '
        Me.PanelTitulo.Controls.Add(Me.LblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(5, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(595, 39)
        Me.PanelTitulo.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTitulo.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic)
        Me.LblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblTitulo.Location = New System.Drawing.Point(40, 3)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(506, 33)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Permisos de Acceso a Módulos del Sistema"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(2, 2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 542)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 546)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPermisos"
        Me.Text = "FrmPermisos"
        CType(Me.PanelPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.chkTodosGeneral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        CType(Me.xtcPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcPermisos.ResumeLayout(False)
        Me.xtpVentas.ResumeLayout(False)
        CType(Me.chkTodos1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCompras.ResumeLayout(False)
        CType(Me.chkTodos2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpListados.ResumeLayout(False)
        CType(Me.chkTodos3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpReportes.ResumeLayout(False)
        CType(Me.chkTodos4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelPrincipal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents xtcPermisos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpVentas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelTitulo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents gcVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVentas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Modulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Acceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkTodos1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LueUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnBuscarUser As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkTodosGeneral As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents xtpCompras As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkTodos2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents xtpListados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkTodos3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents xtpReportes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkTodos4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
