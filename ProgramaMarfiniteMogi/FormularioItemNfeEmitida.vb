Imports System.Data.SqlClient

Public Class FormularioItemNfeEmitida

    Private Property IDbConnection As Object

    Private Property IDbCommand As Object

    Private Sub ItemPedidosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ItemPedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetFinal)

    End Sub

    Private Sub FormularioItemNfeEmitida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetFinal.ItemPedidos' table. You can move, or remove it, as needed.
        Form1.ItemPedidosTableAdapter.Fill(Me.DataSetFinal.ItemPedidos)

    End Sub

    Private Sub ItemPedidosDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles ItemPedidosDataGridView.DoubleClick

        Dim connection As SqlConnection
        connection = New SqlConnection("data source=FERNANDO\SQLEXPRESS;initial catalog=teste;integrated security=SSPI; MultipleActiveResultSets=True")

        Dim command2 As SqlCommand
        command2 = connection.CreateCommand
        command2.CommandType = CommandType.Text

        Dim qtdEntregue As Double
        Dim v_SelectRow2 As Integer

        v_SelectRow2 = Me.ItemPedidosDataGridView.CurrentRow.Index

             Try

            qtdEntregue = InputBox("Digite a quantidade a ser entregue :", "Quantidade", ItemPedidosDataGridView.Item(5, v_SelectRow2).Value)


            Catch ex As Exception

                MessageBox.Show(ex.ToString)
                Exit Sub

            End Try

            
            command2.CommandText = "insert ItemNfeEmitida (NumeroNFe_ItemNfeEmitida,codProd_ItemNfeEmitida,NomeProd_ItemNfeemitida,QtdeProd_ItemNfeEmitida,VrUnitarioProd_ItemNfeEmitida,VrTlProd_itemNfeEmitida) values (@NumeroNFe_ItemNfeEmitida,@codProd_ItemNfeEmitida,@NomeProd_ItemNfeemitida,@QtdeProd_ItemNfeEmitida,@VrUnitarioProd_ItemNfeEmitida,@VrTlProd_itemNfeEmitida)"
        
            command2.Parameters.Add("@NumeroNFe_ItemNfeEmitida", SqlDbType.VarChar, 50).Value = Form1.txt_nNfe.Text
            command2.Parameters.Add("@codProd_ItemNfeEmitida", SqlDbType.VarChar, 50).Value = ItemPedidosDataGridView.Item(12, v_SelectRow2).Value
            command2.Parameters.Add("@NomeProd_ItemNfeemitida", SqlDbType.VarChar, 50).Value = ItemPedidosDataGridView.Item(3, v_SelectRow2).Value
            command2.Parameters.Add("@QtdeProd_ItemNfeEmitida", SqlDbType.VarChar, 50).Value = qtdEntregue
            command2.Parameters.Add("@VrUnitarioProd_ItemNfeEmitida", SqlDbType.VarChar, 50).Value = ItemPedidosDataGridView.Item(7, v_SelectRow2).Value
            command2.Parameters.Add("@VrTlProd_itemNfeEmitida", SqlDbType.VarChar, 50).Value = ItemPedidosDataGridView.Item(7, v_SelectRow2).Value * qtdEntregue
        Try

            connection.Open()
            command2.ExecuteNonQuery()
            connection.Close()


            Me.Close()
            Form1.ItemNfeEmitidaTableAdapter.Fill(Form1.DataSetFinal.ItemNfeEmitida)
            Form1.ItemNfeEmitidaBindingSource.Filter = String.Format("NumeroNFe_ItemNfeEmitida LIKE '{0}'", Form1.txt_nNfe.Text)


        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try


    End Sub

    Private Function ItemNfeEmitidaTableAdapter() As Object
        Throw New NotImplementedException
    End Function

End Class