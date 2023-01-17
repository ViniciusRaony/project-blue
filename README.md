<h1 align="center">Projeto CRUD de uma Agenda</h1>

Criação de um microserviço que gerencia a criação e edição de um cartão de visita digital QR-CODE, a partir de aplicação API.

## 🛠️ Ferramentas e Tecnologias

- ASP.NET 6 (
- Vue3 - conexão com banco de dados SQLite

- IDE: Visual Studio Code
- EntityFramework - framework web usado
- 


## ⚙ Funcionalidades

- Lista de usuários
- Informações sobre um usuário em específico
- Cadastro de novo usuário
- Atualização de cadastro
- Remoção de usuários
- Relação entre usuários e projetos
- Geração de QR-CODE



## 💻 Como executar o Frontend

Antes de iniciar a aplicação é necessário a instalação das seguintes ferramentas: Python, Git e IDE de sua preferência. Além disso, a criação do banco de dados "project_manager" no MySQL.

- Clone esse repositório:

  ```$ git clone https://github.com/ViniciusRaony/project-blue.git projeto-blue```

- Entre no diretório do projeto: 

  ```cd projeto-blue```

- Instale as dependências:

  ```$ npm install```

- Execute a aplicação:
 
  ```$ npm run dev```

- URL para acessar servidor local:

  ```acesse http://localhost:5173/``` 


## 🚉 Rotas da API


- Rota ```/login``` (método ```POST```): Login usuário

- Rota ```/sign_up``` (método ```POST```): Cadastrar usuario

- Rota ```/logout```: Deslogar do sistema

- Rota ```/user``` (método ```POST```): Cadastrar cartão

- Rota ```/user/id``` (método ```GET```): Retornar dados do cartão 

- Rota ```/user/id``` (método ```PUT```): Atualiza dados do cartao

- Rota ```/user/id``` (método ```DELETE```): Deletar dados do cartão

- Rota ```/user/qr_code_c``` (método ```GET```): Retorna QR Code coorporativo 

- Rota ```/user/qr_code_p``` (método ```GET```): Retornar QR Code pessoal


### Links úteis

- [Documentação Flask: https://flask.palletsprojects.com ](https://flask.palletsprojects.com)
- [Documentação SQLAlchemy: https://flask-sqlalchemy.palletsprojects.com/en/2.x/](https://flask-sqlalchemy.palletsprojects.com/en/2.x/)



### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com)

É bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/).

Qualquer banco de dados com compatibilidade com o [SQLAchelmy](https://sqlalchemy.org/) pode ser utilizado.


🚀 Como executar o projeto

Este projeto é divido em três partes:

Backend (pasta server)
Frontend (pasta web)
Mobile (pasta mobile)
💡Tanto o Frontend quanto o Mobile precisam que o Backend esteja sendo executado para funcionar.

Pré-requisitos
Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas: Git, Node.js. Além disto é bom ter um editor para trabalhar com o código como VSCode

🎲 Rodando o Backend (servidor)
# Clone este repositório
$ git clone git@github.com:tgmarinho/README-ecoleta.git

# Acesse a pasta do projeto no terminal/cmd
$ cd README-ecoleta

# Vá para a pasta server
$ cd server

# Instale as dependências
$ npm install

# Execute a aplicação em modo de desenvolvimento
$ npm run dev:server

# O servidor inciará na porta:3333 - acesse http://localhost:3333 
Run in Insomnia

🧭 Rodando a aplicação web (Frontend)
# Clone este repositório
$ git clone git@github.com:tgmarinho/README-ecoleta.git

# Acesse a pasta do projeto no seu terminal/cmd
$ cd README-ecoleta

# Vá para a pasta da aplicação Front End
$ cd web

# Instale as dependências
$ npm install

# Execute a aplicação em modo de desenvolvimento
$ npm run start

# A aplicação será aberta na porta:3000 - acesse http://localhost:3000
🛠 Tecnologias
As seguintes ferramentas foram usadas na construção do projeto:

Website (React + TypeScript)
React Router Dom
React Icons
Axios
Leaflet
React Leaflet
React Dropzone
Veja o arquivo package.json
