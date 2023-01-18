<h1 align="center">Projeto CRUD de uma Agenda</h1>

Criação de um crude para gerenciamento de cadastro de uma agenda.

## 🛠️ Ferramentas e Tecnologias

- ASP.NET 6 
- EntityFramework 
- Vue3
- PrimeVue
- SQL Server 2019
- IDE: VS Code
- IDE: Visual Studio Community 2022

## ⚙ Funcionalidades

- Criar cadastro de usuário
- Ler cadastro de usuário
- Atualizar um usuário específico
- Deletar um usuárop específico

## 💻 Como executar o Frontend

- Clone esse repositório:

  ```$ git clone https://github.com/ViniciusRaony/project-blue.git projeto-blue```

- Entre no diretório do projeto: 

  ```cd projeto-blue/frontend```

- Instale as dependências:

  ```$ npm install```

- Execute a aplicação:
 
  ```$ npm run dev```

- URL para acessar servidor local:

  ```acesse http://localhost:5173/``` 
  
  
  ## 💻 Como executar o Back

Antes de iniciar a aplicação é necessário a instalação do banco de dados no SQL Server e alteração das credenciais de acesso User ID=<seu id>;Password=<sua senha> no arquivo BlueDbContext.cs.

- Clone esse repositório:

  ```$ git clone https://github.com/ViniciusRaony/project-blue.git projeto-blue```

- Entre no diretório do projeto: 

  ```cd projeto-blue/backend```

- Execute a aplicação:

  ```$ dotnet run```

- URL aplicação:

  ```acesse http://localhost:5236/```


## 🚉 Rotas da API

- Rota ```/v1/agendas``` (método ```GET```): Retorna todos usários cadastrados na API

- Rota ```/agendas/id``` (método ```GET```): Retorna um usário cadastrado na API baseado no ```id```

- Rota ```/agendas``` (método ```POST```): Cria um cadastro de usuário na API

- Rota ```/agendas/id``` (método ```PUT```): Atualiza um cadastro de usuário na API baseado no ```id```

- Rota ```/agendas/id``` (método ```DELETE```): Deleta um cadastro de usuário na API baseado no ```id```

### Links úteis

- [Documentação Flask: https://flask.palletsprojects.com ](https://flask.palletsprojects.com)
- [Documentação SQLAlchemy: https://flask-sqlalchemy.palletsprojects.com/en/2.x/](https://flask-sqlalchemy.palletsprojects.com/en/2.x/)

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com)

É bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/).

Qualquer banco de dados com compatibilidade com o [SQLAchelmy](https://sqlalchemy.org/) pode ser utilizado.
