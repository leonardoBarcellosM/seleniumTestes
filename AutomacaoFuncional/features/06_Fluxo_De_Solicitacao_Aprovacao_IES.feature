Feature: 06_Fluxo_De_Solicitacao_Aprovacao_IES
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@01_AcessarPagina
Scenario: 01 Acessar o endereco
#Given Acessar o endereco "http://testes.fundacred.org.br/estudante-web/#/"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@02_1Etapa
Scenario: 02 Iniciar Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

@02_1Etapa
Scenario: 03 Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso


@02_1Etapa
Scenario: 04 Selecionar Instituicao
Given Selecionar instituicao "USF - UNIVERSIDADE SAO FRANCISCO"
When Selecionar curso "ADMINISTRAÇÃO-NOTURNO-BRAGANÇA"
#Given Selecionar instituicao "CENTRO UNIVERSITARIO IESB (GRADUACAO)"
#When Selecionar curso "CIENCIA DA COMPUTACAO-MATUTINO-EDSON MACHADO (SUL)"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

@02_1Etapa
Scenario: 05 Validar DB
Then Validar status de solicitacao no db "Solicitacao"

#Dados editáveis
@02_2Etapa
Scenario: 06 Preencher Dados Do Estudante
#Given Inserir o numero de integrantes da familia " 2 "
#When Inserir a renda bruta mensal " 4.000,00 "
#Given Preencher os dados do estudante
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

@02_1Etapa
Scenario: 07 Validar DB
Then Validar status de solicitacao no db "Estudante"

#Dados editáveis
@03_3Etapa
Scenario: 08 Preencher Dados Do Fiador
Given Inserir nome e cpf " Leonardo Barcellos Teste "
When Inserir data de nasc e renda "5.000,00-06/08/2000"
And Clicar no botao enviar etapa 3
Then Validar direcionamento para etapa 4

@02_1Etapa
Scenario: 09 Validar DB
Then Validar status de solicitacao no db "Fiador"

@04_4Etapa
Scenario: 10 Preencher Dados Pessoais
Given Inserir os dados pessoais
When Inserir endereco e contato
And Clicar no botao proximo
Then Validar direcionamento dados fiador

@04_4Etapa
Scenario: 11 Preencher Dados Completos Do Fiador
Given Preencho os dados completos do fiador
When Preencho contato e endereco
And Clico em proximo
Then Validar direcionamento Dados Curso

@04_4Etapa
Scenario: 12 Validar DB
Then Validar status de solicitacao no db "PosFiador"

@04_4Etapa
Scenario: 13 Preencher Dados Do Curso
Given Preencho matricula e percentual
When Preencho ano e semestre
And Clico em documentos
Then Validar direcionamento documentos

@04_4Etapa
Scenario: 14 Selecionar E Enviar Documentos
Given Seleciono documentos do estudante
When Seleciono documentos do grupo familiar
#And Seleciono documentos de renda familiar
And Seleciono documentos do fiador
And Seleciono documentos de renda do fiador
And Clico em concluir
Then Validar a conclusao da etapa 4

@05_5Etapa
Scenario: 15 Validar DB
Then Validar status de solicitacao no db "Solicitação concluída"

@05_5Etapa
Scenario: 16 Atualizar Status SGCred
Given Realizo update de status
Then Update realizado com sucesso

@06_AcessarPagina
Scenario: 17 Acessar o endereco
#Given Acessar o endereco "http://testes.fundacred.org.br/ies/#/login"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/ies/#/login"	
Then Validar Acesso ao portal

@06_6Etapa
Scenario: 18 Realizar Login Portal IES
Given Informo o email "Cristiane@teste.org.br"
When Informo a senha "welcome1"
And Clico no botao Entrar
Then Validar login com sucesso

@06_6Etapa
Scenario: 19 iniciar Aprovacao
Given Acesso a opcao aprovacao
When Pesquiso a solicitacao desejada
And Clico em prosseguir confirmacao
Then Valido o acesso a tela aprovar solicitacao

@06_6Etapa
Scenario: 20 Finalizar Aprovacao
Given Preencho os dados pendentes
When Preencho as informacoes de valores
And Clico em aprovar
Then Valido solicitacao aprovada com sucesso

@06_6Etapa
Scenario: 21 Validar DB
Then Validar status de solicitacao no db "Solicitação aprovada"