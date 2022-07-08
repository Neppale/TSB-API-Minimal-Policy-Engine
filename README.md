[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/2fe25d04adce953c2f24?action=collection%2Fimport#?env%5BTSB%20API%20Policy%20Engine%20DEV%5D=W3sia2V5IjoiIF8uVVJMICIsInZhbHVlIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzA5MyIsImVuYWJsZWQiOnRydWUsInNlc3Npb25WYWx1ZSI6Imh0dHBzOi8vbG9jYWxob3N0OjcwOTMiLCJzZXNzaW9uSW5kZXgiOjB9LHsia2V5IjoiQkVBUkVSIiwidmFsdWUiOiJleUpoYkdjaU9pSklVekkxTmlJc0luUjVjQ0k2SWtwWFZDSjkuZXlKcGMzTWlPaUowYjNCelpXZDFjbTl6TG1KeUlpd2lZWFZrSWpvaWRHOXdjMlZuZFhKdmN5NWljaUo5LkJsZ2RYZFlfd3YwNkFiR3RsQlBScGVYcy1FeUdyeXAtMjBpSzNsTjBIRzgiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0Iiwic2Vzc2lvblZhbHVlIjoiZXlKaGJHY2lPaUpJVXpJMU5pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SnBjM01pT2lKMGIzQnpaV2QxY205ekxtSnlJaXdpWVhWa0lqb2lkRzl3YzJWbmRYSnZjeTVpY2lKOS5CbGdkWGRZX3d2MDZBYkd0bEJQUnBlWHMtRXlHcnlwLTIwaUszbE4uLi4iLCJzZXNzaW9uSW5kZXgiOjF9XQ==)

[![Teste de Build .NET](https://github.com/Neppale/tsb.mininal.policy.engine/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Neppale/tsb.mininal.policy.engine/actions/workflows/dotnet.yml)

![Logotipo da Top Seguros Brasil](https://i.imgur.com/dEYYaYQ.png)

Projeto Integrado Multidisciplinar do segundo semestre da Universidade Paulista, curso Análise e Desenvolvimento de Sistemas. Neste projeto, foi desenvolvido um sistema de gerenciamento de apólices de seguros para uma empresa. O sistema foi desenvolvido em linguagem de programação C#, utilizando o framework ASP.NET Core.

Esta API foi desenvolvida com o objetivo de ser utilizada por funcionários da empresa, para gerenciar as apólices de seguros, e para os clientes que desejem contratar seguros.

## Instalação

Primeiramente, é necessário instalar as dependências do projeto e em seguida, compilar o projeto:

    dotnet restore
    dotnet build

## Execução

Para executar o projeto, basta utilizar o comando:

    dotnet run

É importante lembrar que o arquivo _appsettings.json_ contém as configurações de conexão com o banco de dados. Caso o banco de dados não esteja disponível, o projeto não irá funcionar. O banco de dados utilizado é o Microsoft SQL Server, e o script de criação do banco de dados está disponível no diretório Scripts.

## Testes

É possível realizar um conjunto de testes. Para isso, é necessário ter o NodeJS em sua máquina, e instalar o pacote Newman:

    npm install -g newman

Este comando irá instalar o pacote Newman, e em seguida, é possível executar os testes:

    newman run Tests/Postman/PostmanCollection.json -e Tests/Postman/PostmanEnvironment.json -k --bail

Lembre-se que o servidor deve estar ligado para que os testes funcionem. Os testes incluem a criação, alteração, exclusão e consulta de usuários, coberturas, terceirizados, clientes, veículos, apólices e ocorrências.

## Endpoints

É possível acessar os endpoints da API através dos links abaixo:

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/2fe25d04adce953c2f24?action=collection%2Fimport#?env%5BTSB%20API%20Policy%20Engine%20DEV%5D=W3sia2V5IjoiIF8uVVJMICIsInZhbHVlIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzA5MyIsImVuYWJsZWQiOnRydWUsInNlc3Npb25WYWx1ZSI6Imh0dHBzOi8vbG9jYWxob3N0OjcwOTMiLCJzZXNzaW9uSW5kZXgiOjB9LHsia2V5IjoiQkVBUkVSIiwidmFsdWUiOiJleUpoYkdjaU9pSklVekkxTmlJc0luUjVjQ0k2SWtwWFZDSjkuZXlKcGMzTWlPaUowYjNCelpXZDFjbTl6TG1KeUlpd2lZWFZrSWpvaWRHOXdjMlZuZFhKdmN5NWljaUo5LkJsZ2RYZFlfd3YwNkFiR3RsQlBScGVYcy1FeUdyeXAtMjBpSzNsTjBIRzgiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0Iiwic2Vzc2lvblZhbHVlIjoiZXlKaGJHY2lPaUpJVXpJMU5pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SnBjM01pT2lKMGIzQnpaV2QxY205ekxtSnlJaXdpWVhWa0lqb2lkRzl3YzJWbmRYSnZjeTVpY2lKOS5CbGdkWGRZX3d2MDZBYkd0bEJQUnBlWHMtRXlHcnlwLTIwaUszbE4uLi4iLCJzZXNzaW9uSW5kZXgiOjF9XQ==)
