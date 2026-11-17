# Projeto Integrador 2026 - SENAC

## Sistema de Gestão de Dados Institucionais

Este repositório contém o desenvolvimento do Projeto Integrador do SENAC.

O objetivo do projeto é criar uma aplicação web para centralizar e organizar informações de uma instituição de ensino. Nesta etapa, o grupo está desenvolvendo uma Prova de Conceito (PoC) para demonstrar uma das principais jornadas definidas na primeira entrega.

---

## Prova de Conceito

A Prova de Conceito apresenta a jornada de um aluno que acessa o sistema, realiza login e consulta seus dados cadastrais.

O fluxo previsto contém as seguintes etapas:

1. O aluno acessa a página inicial do sistema;
2. Informa o RA e a senha para realizar o login;
3. O sistema verifica os dados informados;
4. Após o login, o aluno acessa seus dados pessoais;
5. O aluno pode atualizar informações permitidas, como telefone e endereço;
6. O sistema valida os campos preenchidos;
7. As alterações são salvas no banco de dados;
8. Uma mensagem de confirmação é apresentada;
9. O aluno pode encerrar sua sessão.

A finalidade dessa jornada é demonstrar a integração entre a interface da aplicação, as regras do sistema e o banco de dados.

---

## Situação atual do projeto

O projeto está em desenvolvimento.

Até o momento, foram iniciados os seguintes componentes:

- Estrutura do projeto em ASP.NET Core MVC;
- Configuração do Entity Framework Core;
- Configuração da conexão com PostgreSQL;
- Integração inicial com o Supabase;
- Criação da entidade de usuário;
- Criação dos modelos utilizados pelas páginas;
- Criação inicial dos controllers;
- Criação da página de dados do aluno;
- Configuração de sessões;
- Criação de uma rota para testar a aplicação;
- Criação de uma rota para testar a conexão com o banco de dados.

Algumas funcionalidades ainda podem depender de configuração adicional para serem executadas.

---

## Funcionalidades previstas

- Login por RA e senha;
- Validação dos dados de acesso;
- Controle da sessão do usuário;
- Consulta dos dados do aluno;
- Atualização do telefone;
- Atualização do endereço;
- Validação dos campos do formulário;
- Salvamento das alterações no banco de dados;
- Exibição de mensagens de confirmação ou erro;
- Encerramento da sessão;
- Interface responsiva para computadores e dispositivos móveis.

---

## Tecnologias utilizadas

- C#;
- .NET 9;
- ASP.NET Core MVC;
- Entity Framework Core;
- PostgreSQL;
- Supabase;
- Razor Views;
- HTML5;
- CSS3;
- JavaScript;
- Bootstrap;
- jQuery;
- Git;
- GitHub.

---

## Arquitetura do projeto

O sistema utiliza o padrão MVC, que divide a aplicação em três partes principais:

- **Model:** representa os dados e as regras utilizadas pelo sistema;
- **View:** representa as páginas apresentadas ao usuário;
- **Controller:** recebe as solicitações e controla a comunicação entre as páginas, os dados e as regras da aplicação.

Essa separação facilita a organização, a manutenção e a evolução do sistema.

---

## Estrutura do projeto

```text
ProjetoIntegrador/
│
├── ProjetoIntegrador.sln
│
├── src/
│   └── ProjetoIntegrador.Web/
│       ├── Controllers/
│       ├── Data/
│       ├── Models/
│       │   ├── Entities/
│       │   └── ViewModels/
│       ├── Views/
│       ├── wwwroot/
│       │   ├── css/
│       │   ├── js/
│       │   └── lib/
│       ├── appsettings.json
│       ├── Program.cs
│       └── ProjetoIntegrador.Web.csproj
│
├── .gitignore
└── README.md
```

### Função das principais pastas

- `Controllers`: contém os arquivos responsáveis por receber e controlar as solicitações do sistema;
- `Data`: contém a configuração de acesso ao banco de dados;
- `Models`: contém as entidades e os modelos utilizados pelas páginas;
- `Views`: contém as páginas apresentadas aos usuários;
- `wwwroot`: contém os arquivos CSS, JavaScript e as bibliotecas utilizadas no frontend.

---

## Modelo de dados

A entidade `Usuario` representa os usuários cadastrados no sistema.

Atualmente, estão previstos os seguintes campos:

| Campo | Descrição |
|---|---|
| `Id` | Identificador do usuário |
| `Nome` | Nome completo |
| `Cpf` | CPF do usuário |
| `Ra` | Registro acadêmico |
| `Telefone` | Telefone para contato |
| `Endereco` | Endereço do usuário |
| `Senha` | Credencial utilizada no acesso |
| `TipoUsuario` | Tipo ou perfil do usuário |

O campo `TipoUsuario` poderá ser utilizado para diferenciar alunos, professores, funcionários e outros perfis cadastrados.

> **Aviso de segurança:** dados pessoais reais, senhas e informações de acesso ao Supabase não devem ser publicados neste repositório.

---

## Requisitos para execução

Antes de executar o projeto, é necessário instalar:

- Git;
- .NET 9 SDK;
- Visual Studio 2022 com a carga de trabalho para ASP.NET e Web;
- ou Visual Studio Code com suporte para C# e .NET.

Também será necessário ter acesso ao banco PostgreSQL configurado no Supabase.

Para verificar a versão instalada do .NET, execute:

```bash
dotnet --version
```

O resultado deverá apresentar uma versão iniciada pelo número `9`.

---

## Como baixar o projeto

O projeto pode ser baixado pelo botão **Code → Download ZIP** do GitHub.

Também é possível clonar o repositório utilizando o Git:

```bash
git clone https://github.com/rafamiralha/Projeto_Integrador_2026_SENAC.git
```

Depois, acesse a pasta:

```bash
cd Projeto_Integrador_2026_SENAC
```

---

## Como abrir no Visual Studio

1. Abra o Visual Studio;
2. Selecione **Abrir um projeto ou uma solução**;
3. Localize o arquivo:

```text
ProjetoIntegrador/ProjetoIntegrador.sln
```

4. Aguarde a restauração dos pacotes NuGet;
5. Confira a configuração da conexão com o Supabase;
6. Selecione `ProjetoIntegrador.Web` como projeto de inicialização;
7. Pressione `Ctrl + F5` para executar.

---

## Como executar pelo terminal

Restaure as dependências:

```bash
dotnet restore ProjetoIntegrador/src/ProjetoIntegrador.Web/ProjetoIntegrador.Web.csproj
```

Compile o projeto:

```bash
dotnet build ProjetoIntegrador/src/ProjetoIntegrador.Web/ProjetoIntegrador.Web.csproj
```

Inicie a aplicação:

```bash
dotnet run --project ProjetoIntegrador/src/ProjetoIntegrador.Web/ProjetoIntegrador.Web.csproj
```

Após a inicialização, o endereço local da aplicação será apresentado no terminal.

---

## Configuração do Supabase

A aplicação utiliza PostgreSQL por meio do Supabase.

A string de conexão deve ser configurada com o nome:

```text
Supabase
```

A senha do banco de dados não deve ser colocada neste README nem publicada no arquivo `appsettings.json`.

No Visual Studio, a configuração pode ser feita em:

```text
ProjetoIntegrador.Web → Gerenciar Segredos do Usuário
```

Estrutura esperada:

```json
{
  "ConnectionStrings": {
    "Supabase": "STRING_DE_CONEXAO_FORNECIDA_PELO_RESPONSAVEL"
  }
}
```

A conexão verdadeira deve ser compartilhada somente entre os integrantes autorizados do grupo.

---

## Rotas de teste

### Teste da aplicação

```text
/teste
```

Resposta esperada:

```text
Minha rota está funcionando!
```

### Teste da conexão com o Supabase

```text
/teste-conexao
```

Resposta esperada quando a conexão estiver corretamente configurada:

```text
Conexão com o Supabase!
```

Essas rotas são temporárias e poderão ser removidas depois dos testes.

---

## Testes recomendados

Antes da entrega final, deverão ser verificados os seguintes cenários:

- A aplicação inicia sem erros;
- A conexão com o Supabase funciona;
- O login aceita um usuário válido;
- O login rejeita dados incorretos;
- A sessão é criada após o login;
- Os dados do aluno são exibidos corretamente;
- Telefone e endereço podem ser alterados;
- Os campos obrigatórios são validados;
- As alterações permanecem salvas após atualizar a página;
- O usuário consegue encerrar a sessão;
- A interface funciona em computadores;
- A interface funciona em tamanho de tela de celular;
- As mensagens de erro e confirmação são apresentadas corretamente.

---

## Usuário de demonstração

Esta seção deverá ser atualizada quando o usuário fictício estiver cadastrado no Supabase.

```text
RA: a definir
Senha: a definir
```

Não devem ser utilizadas credenciais reais de alunos ou integrantes do grupo.

---

## Integrantes

- Amadeu Paschoa Portoghese;
- Bruna Adeline de Moraes Pereira;
- Gustavo Ferraz Pigosso;
- Rafael Miralha de Carvalho;
- Vitor Ricelle de Oliveira.

Cada integrante deverá realizar contribuições identificadas no histórico de commits.

---

## Como contribuir

1. Atualize sua cópia local:

```bash
git pull
```

2. Crie uma branch para sua atividade:

```bash
git checkout -b nome-da-atividade
```

3. Faça as alterações;
4. Confira os arquivos modificados:

```bash
git status
```

5. Adicione os arquivos:

```bash
git add .
```

6. Registre a contribuição:

```bash
git commit -m "Descreva objetivamente a alteração"
```

7. Envie a branch:

```bash
git push -u origin nome-da-atividade
```

8. Abra um Pull Request no GitHub para revisão.

---

## Vídeo demonstrativo

A segunda entrega deverá incluir um vídeo de até **1 minuto**, demonstrando o funcionamento da Prova de Conceito.

O vídeo deverá apresentar:

1. A finalidade da aplicação;
2. A tela inicial;
3. O login do aluno;
4. A consulta dos dados;
5. A alteração do telefone ou do endereço;
6. O salvamento das informações;
7. A mensagem de confirmação;
8. A visualização responsiva em tela de celular.

**Link do vídeo:**

```text
A adicionar após a conclusão da demonstração.
```

---

## Etapas pendentes

- [ ] Finalizar a tela de login;
- [ ] Finalizar a autenticação por RA e senha;
- [ ] Criar ou revisar o controle de sessão;
- [ ] Finalizar a consulta dos dados do aluno;
- [ ] Finalizar a edição de telefone e endereço;
- [ ] Implementar as validações dos formulários;
- [ ] Confirmar o salvamento no Supabase;
- [ ] Tratar as mensagens de erro;
- [ ] Implementar o encerramento da sessão;
- [ ] Revisar a responsividade das páginas;
- [ ] Testar a aplicação em outro computador;
- [ ] Definir um usuário fictício para demonstração;
- [x] Adicionar os nomes dos integrantes;
- [ ] Conferir as contribuições no GitHub;
- [ ] Gravar o vídeo demonstrativo;
- [ ] Adicionar o link do vídeo;
- [ ] Revisar a documentação final.

---

## Boas práticas de segurança

- Não publicar senhas reais;
- Não publicar a string completa de conexão;
- Não enviar segredos ou credenciais ao GitHub;
- Não utilizar dados pessoais verdadeiros nos testes;
- Utilizar credenciais fictícias na demonstração;
- Armazenar as senhas de maneira protegida;
- Validar os dados no servidor antes de salvar;
- Revisar o arquivo `.gitignore` antes de cada envio.

---

## Uso do projeto

Este projeto possui finalidade acadêmica e foi desenvolvido como parte do Projeto Integrador do SENAC.
