Feature: 10_Validar_Funil_IES
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@01_AcessarPagina
Scenario: 01 Acessar o endereco
#Given Acessar o endereco "http://testes.fundacred.org.br/ies/#/login"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/ies/#/login"	
Then Validar Acesso ao portal

#ADICIONAR E-MAIL E SENHA DO USUÁRIO DA IES DESEJADA
#Ângela@teste.org.br
#Cristiane@teste.org.br
@02_RealizarLogin
Scenario: 02 Realizar Login Portal IES
#Given Informo o email "Ângela@teste.org.br"
Given Informo o email "Cristiane@teste.org.br"
When Informo a senha "welcome1"
And Clico no botao Entrar
Then Validar login com sucesso

#ADICIONAR O BOL_ID DA IES DESEJADA COM A SEGUINTE FORMATAÇÃO EX.(0000, 0000, 0000, 0000) PENDENTE ****
@03_ValidarFunil
Scenario: 03 Capturar os dados do DB e Funil
Given Consulto os dados no banco "1539, 1541"
Then Consulto os dados do funil 

@03_ValidarFunil
Scenario: 04 Valido solicitacoes iniciadas
Then Valido solicitacoes iniciadas

@03_ValidarFunil
Scenario: 05 Valido pendente analise fundacred
When Valido pendente analise fundacred

@03_ValidarFunil
Scenario: 06 Valido Pendente analise ies
When Valido Pendente analise ies

@03_ValidarFunil
Scenario: 07 Valido aprovados
When Valido aprovados

@03_ValidarFunil
Scenario: 08 Valido reprovados fundacred
When Valido reprovados fundacred

@03_ValidarFunil
Scenario: 09 Valido reprovados ies
When Valido reprovados ies