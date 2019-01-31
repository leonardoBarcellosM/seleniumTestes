Feature: 08_Validar_Renda_Minima
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@01_AcessarPagina
Scenario: 01 Acessar o endereco
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@Renda_Minima
Scenario: 02 Iniciar Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

@Renda_Minima
Scenario: 03 Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso

@Renda_Minima
Scenario: 04 Selecionar Instituicao
Given Selecionar instituicao "PUCRS (GRADUACAO)"
When Selecionar curso "ADMINISTRACAO DE EMPRESAS"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

@Renda_Minima
Scenario: 05 Preencher Dados Do Estudante
Given Inserir o numero de integrantes da familia " 2 "
When Inserir a renda bruta mensal " 4.000,00 "
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

@Renda_Minima
Scenario: 06 Validar DB
Then Consultar renda "minima" no db

@Renda_Minima
Scenario: 07 Validar Renda Minima
Given Verifico a mensagem renda minima "3.808,14."
When Informo renda inferior " 3.808,13 "
And valido a mensagem apresentada
Then Valido botão enviar desabilitado

@Renda_Minima
Scenario: 08 Validar Botao Continuar
Given Verifico o botão apresentado
When clico no botão
Then Valido botao enviar habilitado

@Renda_Minima
Scenario: 09 Validar Renda Superior
Given Informo renda superior "3.808,14"
When Valido a mensagem
Then Valido botao enviar habilitado renda valida

@Renda_Minima
Scenario: 10 Validar Renda minima para fiador vinculado
Given Informo cpf "63837781020"
Then Valido a mensagem "6.454,54."