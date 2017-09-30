<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioItemNfeEmitida
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_numeroCliNovoForm = New System.Windows.Forms.TextBox()
        Me.txt_NomeCliNovoForm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSetFinal = New ProgramaMarfiniteMogi.DataSetFinal()
        Me.ItemPedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemPedidosTableAdapter = New ProgramaMarfiniteMogi.DataSetFinalTableAdapters.ItemPedidosTableAdapter()
        Me.TableAdapterManager = New ProgramaMarfiniteMogi.DataSetFinalTableAdapters.TableAdapterManager()
        Me.ItemPedidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codpedido_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSetFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemPedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemPedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Txt_numeroCliNovoForm)
        Me.Panel1.Controls.Add(Me.txt_NomeCliNovoForm)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 69)
        Me.Panel1.TabIndex = 0
        '
        'Txt_numeroCliNovoForm
        '
        Me.Txt_numeroCliNovoForm.Location = New System.Drawing.Point(637, 23)
        Me.Txt_numeroCliNovoForm.Name = "Txt_numeroCliNovoForm"
        Me.Txt_numeroCliNovoForm.Size = New System.Drawing.Size(233, 20)
        Me.Txt_numeroCliNovoForm.TabIndex = 3
        '
        'txt_NomeCliNovoForm
        '
        Me.txt_NomeCliNovoForm.Location = New System.Drawing.Point(299, 19)
        Me.txt_NomeCliNovoForm.Name = "txt_NomeCliNovoForm"
        Me.txt_NomeCliNovoForm.Size = New System.Drawing.Size(218, 20)
        Me.txt_NomeCliNovoForm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(533, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número do Pedido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Cliente:"
        '
        'DataSetFinal
        '
        Me.DataSetFinal.DataSetName = "DataSetFinal"
        Me.DataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemPedidosBindingSource
        '
        Me.ItemPedidosBindingSource.DataMember = "ItemPedidos"
        Me.ItemPedidosBindingSource.DataSource = Me.DataSetFinal
        '
        'ItemPedidosTableAdapter
        '
        Me.ItemPedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autorizacaoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.balcaoTableAdapter = Nothing
        Me.TableAdapterManager.cadastrodoNCMTableAdapter = Nothing
        Me.TableAdapterManager.capitalgirofornecedorTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.corProdTableAdapter = Nothing
        Me.TableAdapterManager.estadosTableAdapter = Nothing
        Me.TableAdapterManager.exemploTableAdapter = Nothing
        Me.TableAdapterManager.fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.GeradorNumeroPedidoTableAdapter = Nothing
        Me.TableAdapterManager.indicesTableAdapter = Nothing
        Me.TableAdapterManager.ItemNfeEmitidaTableAdapter = Nothing
        Me.TableAdapterManager.ItemPedidosTableAdapter = Me.ItemPedidosTableAdapter
        Me.TableAdapterManager.linhasprodTableAdapter = Nothing
        Me.TableAdapterManager.NFE_EmitidasTableAdapter = Nothing
        Me.TableAdapterManager.nfefornecedorTableAdapter = Nothing
        Me.TableAdapterManager.pedidoMarfiniteTableAdapter = Nothing
        Me.TableAdapterManager.PedidoNFETableAdapter = Nothing
        Me.TableAdapterManager.produtosTableAdapter = Nothing
        Me.TableAdapterManager.tab_municipiosTableAdapter = Nothing
        Me.TableAdapterManager.transportadorasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProgramaMarfiniteMogi.DataSetFinalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendedorTableAdapter = Nothing
        '
        'ItemPedidosDataGridView
        '
        Me.ItemPedidosDataGridView.AllowUserToAddRows = False
        Me.ItemPedidosDataGridView.AllowUserToDeleteRows = False
        Me.ItemPedidosDataGridView.AutoGenerateColumns = False
        Me.ItemPedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemPedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.codpedido_item, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8})
        Me.ItemPedidosDataGridView.DataSource = Me.ItemPedidosBindingSource
        Me.ItemPedidosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemPedidosDataGridView.Location = New System.Drawing.Point(0, 69)
        Me.ItemPedidosDataGridView.Name = "ItemPedidosDataGridView"
        Me.ItemPedidosDataGridView.ReadOnly = True
        Me.ItemPedidosDataGridView.Size = New System.Drawing.Size(701, 559)
        Me.ItemPedidosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "entregue_item"
        Me.DataGridViewTextBoxColumn13.HeaderText = "entregue_item"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "for_item"
        Me.DataGridViewTextBoxColumn3.HeaderText = "for_item"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "linha_item"
        Me.DataGridViewTextBoxColumn4.HeaderText = "linha_item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nome_item"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nome_item"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cor_item"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cor_item"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "quantidade_item"
        Me.DataGridViewTextBoxColumn9.HeaderText = "quantidade_item"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "quantidadeparcialentregue_item"
        Me.DataGridViewTextBoxColumn14.HeaderText = "quantidadeparcialentregue_item"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "precovarejo_item"
        Me.DataGridViewTextBoxColumn10.HeaderText = "precovarejo_item"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "totalvalor_item"
        Me.DataGridViewTextBoxColumn12.HeaderText = "totalvalor_item"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'codpedido_item
        '
        Me.codpedido_item.DataPropertyName = "codpedido_item"
        Me.codpedido_item.HeaderText = "codpedido_item"
        Me.codpedido_item.Name = "codpedido_item"
        Me.codpedido_item.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "codcliente_item"
        Me.DataGridViewTextBoxColumn17.HeaderText = "codcliente_item"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "codproduto_item"
        Me.DataGridViewTextBoxColumn18.HeaderText = "codproduto_item"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "custototal_item"
        Me.DataGridViewTextBoxColumn19.HeaderText = "custototal_item"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "vendedor_item"
        Me.DataGridViewTextBoxColumn20.HeaderText = "vendedor_item"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "dataentrega_item"
        Me.DataGridViewTextBoxColumn21.HeaderText = "dataentrega_item"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "data_item"
        Me.DataGridViewTextBoxColumn2.HeaderText = "data_item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_item"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "tabelaFIscal_item"
        Me.DataGridViewTextBoxColumn24.HeaderText = "tabelaFIscal_item"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "horariocadastro_item"
        Me.DataGridViewTextBoxColumn23.HeaderText = "horariocadastro_item"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "codprod_item"
        Me.DataGridViewTextBoxColumn5.HeaderText = "codprod_item"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NCM_item"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NCM_item"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'FormularioItemNfeEmitida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 628)
        Me.Controls.Add(Me.ItemPedidosDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FormularioItemNfeEmitida"
        Me.Text = "FORMULÁRIO DE PEDIDOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSetFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemPedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemPedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataSetFinal As ProgramaMarfiniteMogi.DataSetFinal
    Friend WithEvents ItemPedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemPedidosTableAdapter As ProgramaMarfiniteMogi.DataSetFinalTableAdapters.ItemPedidosTableAdapter
    Friend WithEvents TableAdapterManager As ProgramaMarfiniteMogi.DataSetFinalTableAdapters.TableAdapterManager
    Friend WithEvents ItemPedidosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_numeroCliNovoForm As System.Windows.Forms.TextBox
    Friend WithEvents txt_NomeCliNovoForm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codpedido_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
