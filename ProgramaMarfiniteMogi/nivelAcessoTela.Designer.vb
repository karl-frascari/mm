<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nivelAcessoTela
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
        Dim Codigo_autorizadoLabel As System.Windows.Forms.Label
        Dim Nome_autorizadoLabel As System.Windows.Forms.Label
        Me.DataSetFinal = New ProgramaMarfiniteMogi.DataSetFinal()
        Me.AutorizacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutorizacaoTableAdapter = New ProgramaMarfiniteMogi.DataSetFinalTableAdapters.autorizacaoTableAdapter()
        Me.TableAdapterManager = New ProgramaMarfiniteMogi.DataSetFinalTableAdapters.TableAdapterManager()
        Me.Codigo_autorizadoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_autorizadoTextBox = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Codigo_autorizadoLabel = New System.Windows.Forms.Label()
        Nome_autorizadoLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorizacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codigo_autorizadoLabel
        '
        Codigo_autorizadoLabel.AutoSize = True
        Codigo_autorizadoLabel.Location = New System.Drawing.Point(24, 99)
        Codigo_autorizadoLabel.Name = "Codigo_autorizadoLabel"
        Codigo_autorizadoLabel.Size = New System.Drawing.Size(94, 13)
        Codigo_autorizadoLabel.TabIndex = 1
        Codigo_autorizadoLabel.Text = "codigo autorizado:"
        '
        'Nome_autorizadoLabel
        '
        Nome_autorizadoLabel.AutoSize = True
        Nome_autorizadoLabel.Location = New System.Drawing.Point(24, 49)
        Nome_autorizadoLabel.Name = "Nome_autorizadoLabel"
        Nome_autorizadoLabel.Size = New System.Drawing.Size(88, 13)
        Nome_autorizadoLabel.TabIndex = 2
        Nome_autorizadoLabel.Text = "nome autorizado:"
        '
        'DataSetFinal
        '
        Me.DataSetFinal.DataSetName = "DataSetFinal"
        Me.DataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutorizacaoBindingSource
        '
        Me.AutorizacaoBindingSource.DataMember = "autorizacao"
        Me.AutorizacaoBindingSource.DataSource = Me.DataSetFinal
        '
        'AutorizacaoTableAdapter
        '
        Me.AutorizacaoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autorizacaoTableAdapter = Me.AutorizacaoTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.capitalgirofornecedorTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.corProdTableAdapter = Nothing
        Me.TableAdapterManager.estadosTableAdapter = Nothing
        Me.TableAdapterManager.exemploTableAdapter = Nothing
        Me.TableAdapterManager.fornecedorTableAdapter = Nothing
        Me.TableAdapterManager.indicesTableAdapter = Nothing
        Me.TableAdapterManager.linhasprodTableAdapter = Nothing
        Me.TableAdapterManager.nfefornecedorTableAdapter = Nothing
        Me.TableAdapterManager.produtosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProgramaMarfiniteMogi.DataSetFinalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendedorTableAdapter = Nothing
        '
        'Codigo_autorizadoTextBox
        '
        Me.Codigo_autorizadoTextBox.Location = New System.Drawing.Point(124, 96)
        Me.Codigo_autorizadoTextBox.Name = "Codigo_autorizadoTextBox"
        Me.Codigo_autorizadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Codigo_autorizadoTextBox.TabIndex = 2
        '
        'Nome_autorizadoTextBox
        '
        Me.Nome_autorizadoTextBox.Location = New System.Drawing.Point(124, 46)
        Me.Nome_autorizadoTextBox.Name = "Nome_autorizadoTextBox"
        Me.Nome_autorizadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nome_autorizadoTextBox.TabIndex = 3
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(36, 192)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(169, 192)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'nivelAcessoTela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Nome_autorizadoLabel)
        Me.Controls.Add(Me.Nome_autorizadoTextBox)
        Me.Controls.Add(Codigo_autorizadoLabel)
        Me.Controls.Add(Me.Codigo_autorizadoTextBox)
        Me.Name = "nivelAcessoTela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nivelAcessoTela"
        CType(Me.DataSetFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorizacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetFinal As ProgramaMarfiniteMogi.DataSetFinal
    Friend WithEvents AutorizacaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutorizacaoTableAdapter As ProgramaMarfiniteMogi.DataSetFinalTableAdapters.autorizacaoTableAdapter
    Friend WithEvents TableAdapterManager As ProgramaMarfiniteMogi.DataSetFinalTableAdapters.TableAdapterManager
    Friend WithEvents Codigo_autorizadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nome_autorizadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
