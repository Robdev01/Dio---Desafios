# Minimal API com Autenticação JWT

Este projeto implementa uma API mínima utilizando .NET, com autenticação via JWT (JSON Web Token), além de funcionalidades para gerenciamento de administradores e veículos.

## Funcionalidades

- Autenticação e autorização via JWT.
- CRUD de administradores com controle de acesso por perfil (Admin).
- CRUD de veículos com controle de acesso por perfis (Admin, Editor).
- Integração com o banco de dados MySQL utilizando Entity Framework Core.
- Documentação automática com Swagger.

## Tecnologias Utilizadas

- .NET 6
- Entity Framework Core
- MySQL
- JWT (JSON Web Token) para autenticação
- Swagger para documentação da API

## Endpoints

### Home

- `GET /` - Endpoint público que retorna uma mensagem de boas-vindas.

### Administradores

- `POST /administradores/login` - Autentica um administrador e retorna um token JWT.
- `GET /administradores` - Lista todos os administradores. **Acesso restrito a Admin.**
- `GET /administradores/{id}` - Exibe informações de um administrador específico. **Acesso restrito a Admin.**
- `POST /administradores` - Cria um novo administrador. **Acesso restrito a Admin.**

### Veículos

- `POST /veiculos` - Adiciona um novo veículo. **Acesso restrito a Admin e Editor.**
- `GET /veiculos` - Lista todos os veículos.
- `GET /veiculos/{id}` - Exibe informações de um veículo específico.
- `PUT /veiculos/{id}` - Atualiza um veículo existente. **Acesso restrito a Admin.**
- `DELETE /veiculos/{id}` - Remove um veículo. **Acesso restrito a Admin.**

## Instalação

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [MySQL](https://www.mysql.com/downloads/)

