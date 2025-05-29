<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTransacoes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        LblNumeroCartao = New Label()
        LblValorTransacao = New Label()
        LblDataTransacao = New Label()
        LblDescricao = New Label()
        LblStatusTransacao = New Label()
        TxtNumeroCartao = New TextBox()
        Label7 = New Label()
        Txtdescricao = New TextBox()
        TxtValorTransacao = New TextBox()
        DtpDataTransacao = New DateTimePicker()
        CmbStatusTransacao = New ComboBox()
        DgvTransacoes = New DataGridView()
        BtnLimpar = New Button()
        BtnEditar = New Button()
        BtnConsulta = New Button()
        BtnExcluir = New Button()
        BtnExportar = New Button()
        TxtIdTransacao = New TextBox()
        LblIdTransacao = New Label()
        BtnCadastrar = New Button()
        BtnSair = New Button()
        TxtCartao = New TextBox()
        LblCartao = New Label()
        BindingSource1 = New BindingSource(components)
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TxtValor = New TextBox()
        LblValor = New Label()
        CmbStatus = New ComboBox()
        LblStatus = New Label()
        GroupBox1 = New GroupBox()
        BtnListarTudo = New Button()
        CType(DgvTransacoes, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblNumeroCartao
        ' 
        LblNumeroCartao.AutoSize = True
        LblNumeroCartao.Location = New Point(10, 92)
        LblNumeroCartao.Name = "LblNumeroCartao"
        LblNumeroCartao.Size = New Size(133, 20)
        LblNumeroCartao.TabIndex = 0
        LblNumeroCartao.Text = "Número do Cartão"
        ' 
        ' LblValorTransacao
        ' 
        LblValorTransacao.AutoSize = True
        LblValorTransacao.Location = New Point(6, 139)
        LblValorTransacao.Name = "LblValorTransacao"
        LblValorTransacao.Size = New Size(134, 20)
        LblValorTransacao.TabIndex = 1
        LblValorTransacao.Text = "Valor da Transação"
        ' 
        ' LblDataTransacao
        ' 
        LblDataTransacao.AutoSize = True
        LblDataTransacao.Location = New Point(6, 182)
        LblDataTransacao.Name = "LblDataTransacao"
        LblDataTransacao.Size = New Size(132, 20)
        LblDataTransacao.TabIndex = 2
        LblDataTransacao.Text = "Data da Transação"
        ' 
        ' LblDescricao
        ' 
        LblDescricao.AutoSize = True
        LblDescricao.Location = New Point(10, 215)
        LblDescricao.Name = "LblDescricao"
        LblDescricao.Size = New Size(74, 20)
        LblDescricao.TabIndex = 3
        LblDescricao.Text = "Descrição"
        ' 
        ' LblStatusTransacao
        ' 
        LblStatusTransacao.AutoSize = True
        LblStatusTransacao.Location = New Point(5, 285)
        LblStatusTransacao.Name = "LblStatusTransacao"
        LblStatusTransacao.Size = New Size(140, 20)
        LblStatusTransacao.TabIndex = 4
        LblStatusTransacao.Text = "Status da Transação"
        ' 
        ' TxtNumeroCartao
        ' 
        TxtNumeroCartao.Location = New Point(156, 92)
        TxtNumeroCartao.Name = "TxtNumeroCartao"
        TxtNumeroCartao.Size = New Size(203, 27)
        TxtNumeroCartao.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label7.Location = New Point(191, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(369, 23)
        Label7.TabIndex = 7
        Label7.Text = "Cadastro de Transações de Cartão de Crédito"
        ' 
        ' Txtdescricao
        ' 
        Txtdescricao.Location = New Point(151, 215)
        Txtdescricao.Multiline = True
        Txtdescricao.Name = "Txtdescricao"
        Txtdescricao.Size = New Size(208, 55)
        Txtdescricao.TabIndex = 9
        ' 
        ' TxtValorTransacao
        ' 
        TxtValorTransacao.Location = New Point(153, 139)
        TxtValorTransacao.Name = "TxtValorTransacao"
        TxtValorTransacao.Size = New Size(206, 27)
        TxtValorTransacao.TabIndex = 11
        ' 
        ' DtpDataTransacao
        ' 
        DtpDataTransacao.Location = New Point(153, 182)
        DtpDataTransacao.Name = "DtpDataTransacao"
        DtpDataTransacao.Size = New Size(206, 27)
        DtpDataTransacao.TabIndex = 12
        ' 
        ' CmbStatusTransacao
        ' 
        CmbStatusTransacao.FormattingEnabled = True
        CmbStatusTransacao.Location = New Point(151, 285)
        CmbStatusTransacao.Name = "CmbStatusTransacao"
        CmbStatusTransacao.Size = New Size(151, 28)
        CmbStatusTransacao.TabIndex = 13
        ' 
        ' DgvTransacoes
        ' 
        DgvTransacoes.BackgroundColor = SystemColors.ButtonHighlight
        DgvTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvTransacoes.Location = New Point(6, 367)
        DgvTransacoes.Name = "DgvTransacoes"
        DgvTransacoes.RowHeadersWidth = 51
        DgvTransacoes.Size = New Size(794, 220)
        DgvTransacoes.TabIndex = 16
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.Location = New Point(710, 332)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(94, 29)
        BtnLimpar.TabIndex = 17
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = True
        ' 
        ' BtnEditar
        ' 
        BtnEditar.Location = New Point(110, 332)
        BtnEditar.Name = "BtnEditar"
        BtnEditar.Size = New Size(94, 29)
        BtnEditar.TabIndex = 18
        BtnEditar.Text = "Editar"
        BtnEditar.UseVisualStyleBackColor = True
        ' 
        ' BtnConsulta
        ' 
        BtnConsulta.Location = New Point(279, 162)
        BtnConsulta.Name = "BtnConsulta"
        BtnConsulta.Size = New Size(94, 29)
        BtnConsulta.TabIndex = 19
        BtnConsulta.Text = "Consultar"
        BtnConsulta.UseVisualStyleBackColor = True
        ' 
        ' BtnExcluir
        ' 
        BtnExcluir.Location = New Point(614, 332)
        BtnExcluir.Name = "BtnExcluir"
        BtnExcluir.Size = New Size(94, 29)
        BtnExcluir.TabIndex = 20
        BtnExcluir.Text = "Excluir"
        BtnExcluir.UseVisualStyleBackColor = True
        ' 
        ' BtnExportar
        ' 
        BtnExportar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnExportar.Location = New Point(573, 593)
        BtnExportar.Name = "BtnExportar"
        BtnExportar.Size = New Size(135, 35)
        BtnExportar.TabIndex = 21
        BtnExportar.Text = "Exportar Excel"
        BtnExportar.UseVisualStyleBackColor = True
        ' 
        ' TxtIdTransacao
        ' 
        TxtIdTransacao.BackColor = SystemColors.ControlLight
        TxtIdTransacao.Location = New Point(156, 49)
        TxtIdTransacao.Name = "TxtIdTransacao"
        TxtIdTransacao.ReadOnly = True
        TxtIdTransacao.Size = New Size(136, 27)
        TxtIdTransacao.TabIndex = 22
        ' 
        ' LblIdTransacao
        ' 
        LblIdTransacao.AutoSize = True
        LblIdTransacao.Location = New Point(12, 52)
        LblIdTransacao.Name = "LblIdTransacao"
        LblIdTransacao.Size = New Size(113, 20)
        LblIdTransacao.TabIndex = 23
        LblIdTransacao.Text = "Id da Transação"
        ' 
        ' BtnCadastrar
        ' 
        BtnCadastrar.Location = New Point(10, 332)
        BtnCadastrar.Name = "BtnCadastrar"
        BtnCadastrar.Size = New Size(94, 29)
        BtnCadastrar.TabIndex = 24
        BtnCadastrar.Text = "Cadastrar"
        BtnCadastrar.UseVisualStyleBackColor = True
        ' 
        ' BtnSair
        ' 
        BtnSair.Location = New Point(710, 593)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New Size(94, 35)
        BtnSair.TabIndex = 25
        BtnSair.Text = "Sair"
        BtnSair.UseVisualStyleBackColor = True
        ' 
        ' TxtCartao
        ' 
        TxtCartao.Location = New Point(166, 27)
        TxtCartao.Name = "TxtCartao"
        TxtCartao.Size = New Size(203, 27)
        TxtCartao.TabIndex = 28
        ' 
        ' LblCartao
        ' 
        LblCartao.AutoSize = True
        LblCartao.Location = New Point(18, 30)
        LblCartao.Name = "LblCartao"
        LblCartao.Size = New Size(133, 20)
        LblCartao.TabIndex = 27
        LblCartao.Text = "Número do Cartão"
        ' 
        ' TxtValor
        ' 
        TxtValor.Location = New Point(166, 74)
        TxtValor.Name = "TxtValor"
        TxtValor.Size = New Size(206, 27)
        TxtValor.TabIndex = 30
        ' 
        ' LblValor
        ' 
        LblValor.AutoSize = True
        LblValor.Location = New Point(19, 74)
        LblValor.Name = "LblValor"
        LblValor.Size = New Size(134, 20)
        LblValor.TabIndex = 29
        LblValor.Text = "Valor da Transação"
        ' 
        ' CmbStatus
        ' 
        CmbStatus.FormattingEnabled = True
        CmbStatus.Location = New Point(166, 117)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(151, 28)
        CmbStatus.TabIndex = 32
        ' 
        ' LblStatus
        ' 
        LblStatus.AutoSize = True
        LblStatus.Location = New Point(20, 117)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(140, 20)
        LblStatus.TabIndex = 31
        LblStatus.Text = "Status da Transação"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtValor)
        GroupBox1.Controls.Add(CmbStatus)
        GroupBox1.Controls.Add(LblCartao)
        GroupBox1.Controls.Add(LblStatus)
        GroupBox1.Controls.Add(TxtCartao)
        GroupBox1.Controls.Add(LblValor)
        GroupBox1.Controls.Add(BtnConsulta)
        GroupBox1.Location = New Point(416, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(398, 193)
        GroupBox1.TabIndex = 33
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filtros"
        ' 
        ' BtnListarTudo
        ' 
        BtnListarTudo.Location = New Point(688, 251)
        BtnListarTudo.Name = "BtnListarTudo"
        BtnListarTudo.Size = New Size(112, 29)
        BtnListarTudo.TabIndex = 33
        BtnListarTudo.Text = "Exibir Todos"
        BtnListarTudo.UseVisualStyleBackColor = True
        ' 
        ' FrmTransacoes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 637)
        Controls.Add(BtnListarTudo)
        Controls.Add(GroupBox1)
        Controls.Add(BtnSair)
        Controls.Add(BtnCadastrar)
        Controls.Add(LblIdTransacao)
        Controls.Add(TxtIdTransacao)
        Controls.Add(BtnExportar)
        Controls.Add(BtnExcluir)
        Controls.Add(BtnEditar)
        Controls.Add(BtnLimpar)
        Controls.Add(DgvTransacoes)
        Controls.Add(CmbStatusTransacao)
        Controls.Add(DtpDataTransacao)
        Controls.Add(TxtValorTransacao)
        Controls.Add(Txtdescricao)
        Controls.Add(Label7)
        Controls.Add(TxtNumeroCartao)
        Controls.Add(LblStatusTransacao)
        Controls.Add(LblDescricao)
        Controls.Add(LblDataTransacao)
        Controls.Add(LblValorTransacao)
        Controls.Add(LblNumeroCartao)
        Name = "FrmTransacoes"
        Text = "+-"
        CType(DgvTransacoes, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNumeroCartao As Label
    Friend WithEvents LblValorTransacao As Label
    Friend WithEvents LblDataTransacao As Label
    Friend WithEvents LblDescricao As Label
    Friend WithEvents LblStatusTransacao As Label
    Friend WithEvents TxtNumeroCartao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtdescricao As TextBox
    Friend WithEvents TxtValorTransacao As TextBox
    Friend WithEvents DtpDataTransacao As DateTimePicker
    Friend WithEvents CmbStatusTransacao As ComboBox
    Friend WithEvents DgvTransacoes As DataGridView
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnConsulta As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents TxtIdTransacao As TextBox
    Friend WithEvents LblIdTransacao As Label
    Friend WithEvents BtnCadastrar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents TxtCartao As TextBox
    Friend WithEvents LblCartao As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblValor As Label
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnListarTudo As Button

End Class
