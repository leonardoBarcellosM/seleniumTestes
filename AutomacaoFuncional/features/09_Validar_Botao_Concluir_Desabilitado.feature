Feature: 09_Validar_Botao_Concluir_Desabilitado
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

#Dados editáveis
@02_2Etapa
Scenario: 05 Preencher Dados Do Estudante
#Given Inserir o numero de integrantes da familia " 2 "
#When Inserir a renda bruta mensal " 4.000,00 "
#Given Preencher os dados do estudante
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

#Dados editáveis
@03_3Etapa
Scenario: 06 Preencher Dados Do Fiador
Given Inserir nome e cpf " Leonardo Barcellos Teste "
When Inserir data de nasc e renda "4.000,00-06/08/2000"
And Clicar no botao enviar etapa 3
Then Validar direcionamento para etapa 4

@04_4Etapa
Scenario: 07 Preencher Dados Pessoais
Given Inserir os dados pessoais
When Inserir endereco e contato
And Clicar no botao proximo
Then Validar direcionamento dados fiador

@04_4Etapa
Scenario: 08 Preencher Dados Completos Do Fiador
Given Preencho os dados completos do fiador
When Preencho contato e endereco
And Clico em proximo
Then Validar direcionamento Dados Curso

@04_4Etapa
Scenario: 09 Preencher Dados Do Curso
Given Preencho matricula e percentual
When Preencho ano e semestre
And Clico em documentos
Then Validar direcionamento documentos

@04_4Etapa
Scenario: 10 Selecionar E Enviar Documentos
Given Seleciono documentos do estudante
When Seleciono documentos do grupo familiar
#And Seleciono documentos de renda familiar
And Seleciono documentos do fiador
And Seleciono documentos de renda do fiador
Then Validar botao desabilitado
