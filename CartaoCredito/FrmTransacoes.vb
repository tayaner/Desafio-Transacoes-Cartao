
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports ClosedXML.Excel



Public Class FrmTransacoes
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub FrmTransacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configura formato do DateTimePicker
        DtpDataTransacao.Format = DateTimePickerFormat.Custom
        DtpDataTransacao.CustomFormat = "dd/MM/yyyy HH:mm:ss"


        ' Preenche ComboBox Status
        CmbStatusTransacao.Items.Clear()
        CmbStatusTransacao.Items.Add("Selecione")
        CmbStatusTransacao.Items.Add("Aprovada")
        CmbStatusTransacao.Items.Add("Pendente")
        CmbStatusTransacao.Items.Add("Cancelada")


        ' Preenche ComboBox Status Consulta
        CmbStatus.Items.Clear()
        CmbStatus.Items.Add("Selecione")
        CmbStatus.Items.Add("Aprovada")
        CmbStatus.Items.Add("Pendente")
        CmbStatus.Items.Add("Cancelada")

        ' (Opcional) definir um valor padrão
        CmbStatusTransacao.SelectedIndex = 0
        CmbStatus.SelectedIndex = 0


        ObterProximoId()

    End Sub
    Private Sub ObterProximoId()
        Try
            Dim conexao As New SqlConnection("Data Source=CHOPPER\SQLEXPRESS;Initial Catalog=CartaoCredito_db;Trusted_Connection=True;TrustServerCertificate=True")
            conexao.Open()

            Dim comando As New SqlCommand("SELECT ISNULL(MAX(Id_Transacao), 0) + 1 FROM transacoes_tb", conexao)
            Dim proximoId As Integer = Convert.ToInt32(comando.ExecuteScalar())

            TxtIdTransacao.Text = proximoId.ToString()

            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao obter próximo ID: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click


        ' Validação dos campos
        If TxtNumeroCartao.Text = "" Or
       TxtValorTransacao.Text = "" Or
       CmbStatusTransacao.SelectedIndex = 0 Or
       Txtdescricao.Text = "" Then
            MessageBox.Show("Preencha todos os campos corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Abre conexão
            AbrirConexao()

            ' Comando SQL de INSERT
            Dim sql As String = "INSERT INTO transacoes_tb (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao) " &
                             "VALUES (@NumeroCartao, @Valor, @DataTransacao, @Descricao, @Status)"

            Using cmd As New SqlCommand(sql, conexao)
                ' Parâmetros
                cmd.Parameters.AddWithValue("@NumeroCartao", TxtNumeroCartao.Text)
                cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(TxtValorTransacao.Text))
                cmd.Parameters.AddWithValue("@DataTransacao", DtpDataTransacao.Value)
                cmd.Parameters.AddWithValue("@Descricao", Txtdescricao.Text)
                cmd.Parameters.AddWithValue("@Status", CmbStatusTransacao.SelectedItem.ToString())

                ' Executa comando
                cmd.ExecuteNonQuery()

                MessageBox.Show("Transação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' (Opcional) Limpar campos após cadastro
                LimparCampos()
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            FecharConexao()
        End Try

    End Sub

    ' ===== Função para limpar os campos =====
    Private Sub LimparCampos()
        TxtIdTransacao.Clear()
        TxtNumeroCartao.Clear()
        TxtValorTransacao.Clear()
        DtpDataTransacao.Value = DateTime.Now
        Txtdescricao.Clear()

        If CmbStatusTransacao.Items.Count > 0 Then
            CmbStatusTransacao.SelectedIndex = 0
        Else
            CmbStatusTransacao.SelectedIndex = -1
        End If

        TxtCartao.Clear()
        TxtValor.Clear()

        If CmbStatus.Items.Count > 0 Then
            CmbStatus.SelectedIndex = 0
        Else
            CmbStatus.SelectedIndex = -1
        End If
    End Sub


    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub
    ' Função para carregar as transações no DataGridView
    Private Sub CarregarTransacoes()
        Try
            AbrirConexao()

            Dim sql As String = "SELECT Id_Transacao, Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao FROM transacoes_tb"
            Dim cmd As New SqlCommand(sql, conexao)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New System.Data.DataTable()

            da.Fill(dt)

            DgvTransacoes.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar as transações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub DgvTransacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTransacoes.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvTransacoes.Rows(e.RowIndex)

            TxtIdTransacao.Text = row.Cells("Id_Transacao").Value.ToString()
            TxtNumeroCartao.Text = row.Cells("Numero_Cartao").Value.ToString()
            TxtValorTransacao.Text = row.Cells("Valor_Transacao").Value.ToString()
            DtpDataTransacao.Value = Convert.ToDateTime(row.Cells("Data_Transacao").Value)
            Txtdescricao.Text = row.Cells("Descricao").Value.ToString()
            CmbStatusTransacao.SelectedItem = row.Cells("Status_Transacao").Value.ToString()
        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        ' Verifica se tem ID selecionado
        If TxtIdTransacao.Text = "" Then
            MessageBox.Show("Selecione uma transação para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirmação
        Dim confirm As DialogResult = MessageBox.Show("Tem certeza que deseja excluir esta transação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                AbrirConexao()

                Dim sql As String = "DELETE FROM transacoes_tb WHERE Id_Transacao = @Id"
                Using cmd As New SqlCommand(sql, conexao)
                    cmd.Parameters.AddWithValue("@Id", TxtIdTransacao.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Transação excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimparCampos()
                CarregarTransacoes()

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharConexao()
            End Try
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Verifica se tem ID selecionado
        If TxtIdTransacao.Text = "" Then
            MessageBox.Show("Selecione uma transação para editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            AbrirConexao()

            Dim sql As String = "UPDATE transacoes_tb SET Numero_Cartao = @NumeroCartao, Valor_Transacao = @Valor, Data_Transacao = @Data, Descricao = @Descricao, Status_Transacao = @Status WHERE Id_Transacao = @Id"

            Using cmd As New SqlCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@NumeroCartao", TxtNumeroCartao.Text)
                cmd.Parameters.AddWithValue("@Valor", Convert.ToDecimal(TxtValorTransacao.Text))
                cmd.Parameters.AddWithValue("@Data", DtpDataTransacao.Value)
                cmd.Parameters.AddWithValue("@Descricao", Txtdescricao.Text)
                cmd.Parameters.AddWithValue("@Status", CmbStatusTransacao.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Id", TxtIdTransacao.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Transação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimparCampos()
            CarregarTransacoes()

        Catch ex As Exception
            MessageBox.Show("Erro ao editar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
    End Sub



    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            AbrirConexao()

            Dim sql As String = "SELECT Id_Transacao, Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao FROM transacoes_tb WHERE 1=1"

            ' Monta os filtros dinamicamente
            If Not String.IsNullOrWhiteSpace(TxtCartao.Text) Then
                sql &= " AND Numero_Cartao LIKE @NumeroCartao"
            End If

            If Not String.IsNullOrWhiteSpace(TxtValor.Text) Then
                sql &= " AND Valor_Transacao = @Valor"
            End If

            If CmbStatus.SelectedIndex > 0 Then ' 0 é "Selecione"
                sql &= " AND Status_Transacao = @Status"
            End If

            Using cmd As New SqlCommand(sql, conexao)
                ' Passa os parâmetros se houverem filtros
                If Not String.IsNullOrWhiteSpace(TxtCartao.Text) Then
                    cmd.Parameters.AddWithValue("@NumeroCartao", "%" & TxtCartao.Text.Trim() & "%")
                End If

                If Not String.IsNullOrWhiteSpace(TxtValor.Text) Then
                    Dim valorDecimal As Decimal
                    If Decimal.TryParse(TxtValor.Text.Trim(), valorDecimal) Then
                        cmd.Parameters.AddWithValue("@Valor", valorDecimal)
                    Else
                        MessageBox.Show("Valor inválido para filtro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If

                If CmbStatus.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("@Status", CmbStatus.SelectedItem.ToString())
                End If

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                DgvTransacoes.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
    End Sub


    Private Sub BtnListarTudo_Click(sender As Object, e As EventArgs) Handles BtnListarTudo.Click
        CarregarTransacoes()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        If DgvTransacoes.Rows.Count = 0 Then
            MessageBox.Show("Não há dados para exportar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dt As New DataTable()

            ' Criar colunas
            For Each coluna As DataGridViewColumn In DgvTransacoes.Columns
                dt.Columns.Add(coluna.HeaderText, GetType(String))
            Next

            ' Preencher linhas
            For Each linha As DataGridViewRow In DgvTransacoes.Rows
                If Not linha.IsNewRow Then
                    Dim novaLinha = dt.NewRow()
                    For i As Integer = 0 To DgvTransacoes.Columns.Count - 1
                        novaLinha(i) = linha.Cells(i).Value?.ToString()
                    Next
                    dt.Rows.Add(novaLinha)
                End If
            Next

            ' Criar o arquivo Excel
            Using wb As New XLWorkbook()
                wb.Worksheets.Add(dt, "Transacoes")

                Dim salvarDialogo As New SaveFileDialog With {
                .Filter = "Arquivo Excel (*.xlsx)|*.xlsx",
                .FileName = "Relatorio_Transacoes.xlsx"
            }

                If salvarDialogo.ShowDialog() = DialogResult.OK Then
                    wb.SaveAs(salvarDialogo.FileName)
                    MessageBox.Show("Exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao exportar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
