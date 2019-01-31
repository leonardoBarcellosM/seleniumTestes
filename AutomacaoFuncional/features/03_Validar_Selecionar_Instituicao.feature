Feature: 03_Validar_Selecionar_Instituicao
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

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
Given Selecionar instituicao "CENTRO UNIVERSITARIO IESB (GRADUACAO)"
When Selecionar curso "CIENCIA DA COMPUTACAO-MATUTINO-EDSON MACHADO (SUL)"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

@02_1Etapa
Scenario: 05 Validar DB
Then Validar status de solicitacao no db "Solicitacao"
