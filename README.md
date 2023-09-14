# ASP.NET Core RPG (Role-Playing Game) Application with Authentication

Este é um projeto ASP.NET Core que implementa um RPG (Role-Playing Game) com recursos de autenticação de usuário. O projeto permite que os usuários se registrem, façam login, obtenham tokens JWT e explorem o mundo do jogo enquanto interagem com seus personagens e habilidades.


## Conteúdo

1. [Visão Geral](#visão-geral)
2. [Tecnologias](#tecnologias)
3. [Estrutura do Projeto](#estrutura-do-projeto)
4. [Funcionalidades](#funcionalidades)
5. [Como Usar](#como-usar)
6. [Rotas da API](#rotas-da-api)
7. [Autenticação](#autenticação)
8. [Contribuição](#contribuição)

## Visão Geral

Este projeto é um RPG em que os usuários podem criar personagens, equipá-los com armas e habilidades, e lutar contra outros personagens. Além disso, inclui autenticação de usuário para proteger as funcionalidades e os dados do jogo.

## Tecnologias

- ASP.NET Core
- Entity Framework Core
- JWT (JSON Web Tokens)
- C#
- RESTful API
- SQL Server (Banco de Dados)

## Estrutura do Projeto

O projeto é organizado em várias partes, incluindo personagens, habilidades, armas e lutas. A autenticação é tratada por meio de uma API separada. As principais partes do projeto são:

- **API de Personagens**: Gerencia personagens e suas informações.
- **API de Habilidades**: Gerencia habilidades disponíveis para personagens.
- **API de Armas**: Gerencia armas disponíveis para personagens.
- **API de Lutas**: Permite que os usuários organizem e participem de lutas entre personagens.
- **API de Autenticação**: Lida com o registro, login e autenticação de usuários.

## Funcionalidades

As principais funcionalidades incluem:

- Registro de novos usuários com senhas criptografadas.
- Autenticação de usuários com base em credenciais.
- Geração de tokens JWT após o login bem-sucedido.
- Criação, atualização e exclusão de personagens.
- Adição de habilidades e armas aos personagens.
- Organização e registro de lutas entre personagens.
- Classificação dos jogadores com base nas vitórias e derrotas.

## Como Usar

1. Clone o repositório para sua máquina local.
2. Configure uma instância SQL Server e atualize a string de conexão no arquivo `appsettings.json`.
3. Execute as migrações do Entity Framework Core para criar o banco de dados e as tabelas: `dotnet ef database update`.
4. Execute o aplicativo ASP.NET Core: `dotnet run`.
5. Acesse a API por meio de um cliente REST (por exemplo, Postman ou Insomnia) para interagir com as funcionalidades do RPG.

## Autenticação

A autenticação é baseada em tokens JWT. Os usuários podem se registrar e fazer login para obter um token JWT. Esse token deve ser incluído nos cabeçalhos das solicitações para acessar as funcionalidades protegidas por autenticação.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas, propor melhorias ou enviar solicitações de pull request.
