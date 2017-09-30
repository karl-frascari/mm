Public Class nivelAcessoTela

    Private Sub AutorizacaoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AutorizacaoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetFinal)

    End Sub

    Private Sub nivelAcessoTela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetFinal.autorizacao' table. You can move, or remove it, as needed.
        Me.AutorizacaoTableAdapter.Fill(Me.DataSetFinal.autorizacao)

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Form1.verificarNivelAcesso()

        If Form1.logado = True Then

            Me.Visible = False

        Else

            MessageBox.Show("Login ou senha errados!")

        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Visible = False

    End Sub
End Class