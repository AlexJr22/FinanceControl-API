# 💻 Gestão de Financias (pensar em um nome)

## ⚙️ Funcionalidades

* Cadastro e autenticação de usuários (JWT)
* CRUD de categorias (ex: Alimentação, Transporte, Lazer, etc.)
* CRUD de transações (receitas e despesas)
* Filtros por data e tipo (ex: despesas do mês)
* Resumo financeiro (saldo total, total de despesas e receitas)
* Documentação com Swagger
* Deploy via Docker Compose (API + SQL Server)

##  🧱 Estrutura de Entidades

### 🙍 Usuário

* Id
* Nome
* Email
* Senha (hash)

---

### ✅ Categoria

* Id
* Nome
* Tipo (Receita/Despesa)

### 📈 Transação

* Id
* Título
* Valor
* Data
* Tipo (Receita/Despesa)
* CategoriaId
* UsuarioId

## 🗄️ Entidades e Endpoints da API — App de Gestão Financeira

## 🧍‍♂️ User

| Campo | Tipo | Descrição |
|-------|------|------------|
| Id | Guid | ID do usuário (Identity) |
| Name | string | Nome completo |
| Email | string | Email de login |
| PasswordHash | string | Senha criptografada |

---

## 💳 Account

| Campo | Tipo | Descrição |
|-------|------|------------|
| Id | Guid | Identificador da conta |
| UserId | string | Dono da conta |
| Name | string | Nome da conta (ex: Carteira, Nubank) |
| Type | enum(AccountType) | Tipo da conta (Cash, Bank, CreditCard) |
| Balance | decimal | Saldo atual |
| CreatedAt | DateTime | Data de criação |

---

## 🏷️ Category

| Campo | Tipo | Descrição |
|-------|------|------------|
| Id | Guid | Identificador |
| UserId | string | Dono da categoria |
| Name | string | Nome da categoria |
| Type | enum(CategoryType) | Tipo: Expense / Income |
| Color | string | Cor (hex) para gráficos |

---

## 💵 Transaction

| Campo | Tipo | Descrição |
|-------|------|------------|
| Id | Guid | Identificador |
| UserId | Guid | Dono da transação |
| AccountId | Guid | Conta vinculada |
| CategoryId | Guid | Categoria |
| Amount | decimal | Valor da transação |
| Type | enum(TransactionType) | Receita ou despesa |
| Date | DateTime | Data da transação |
| Description | string | Observações |
| CreatedAt | DateTime | Data de criação |

---

# 🌐 Endpoints da API

---

## 🔐 Autenticação

| Método | Rota | Descrição |
|--------|------|------------|
| POST | `/api/auth/register` | Registrar novo usuário |
| POST | `/api/auth/login` | Autenticar e gerar JWT |
| GET | `/api/auth/me` | Retornar dados do usuário autenticado |

---

## 💳 Accounts

| Método | Rota | Descrição |
|--------|------|------------|
| GET | `/api/accounts` | Listar contas do usuário |
| GET | `/api/accounts/{id}` | Buscar conta específica |
| POST | `/api/accounts` | Criar nova conta |
| PUT | `/api/accounts/{id}` | Atualizar conta |
| DELETE | `/api/accounts/{id}` | Excluir conta |

---

## 🏷️ Categories

| Método | Rota | Descrição |
|--------|------|------------|
| GET | `/api/categories` | Listar categorias do usuário |
| POST | `/api/categories` | Criar nova categoria |
| PUT | `/api/categories/{id}` | Atualizar categoria |
| DELETE | `/api/categories/{id}` | Excluir categoria |

---

## 💵 Transactions

| Método | Rota | Descrição |
|--------|------|------------|
| GET | `/api/transactions` | Listar transações (filtro por data/categoria) |
| GET | `/api/transactions/{id}` | Buscar transação específica |
| POST | `/api/transactions` | Criar nova transação |
| PUT | `/api/transactions/{id}` | Atualizar transação |
| DELETE | `/api/transactions/{id}` | Excluir transação |
