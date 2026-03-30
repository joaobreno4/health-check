# Health Check and Observability API

Este projeto implementa um endpoint de diagnóstico técnico utilizando .NET 8. O objetivo é fornecer uma interface de observabilidade para validar a integridade da aplicação e suas dependências de infraestrutura em ambientes de esteira CI/CD.

## Funcionalidades
- Diagnóstico de Integridade: Endpoint GET /health/check para monitoramento em tempo real.
- Validação de Dependências: Verificação automática da conectividade com o banco de dados via Entity Framework Core.
- Exposição de Metadados: Informações sobre o ambiente de execução, versão da build e timestamp de inicialização (uptime).

## Stack Técnica
- Runtime: .NET 8.0
- Framework: ASP.NET Core Web API
- ORM: Entity Framework Core
- Data Provider: In-Memory (Suporte para SQL Server e PostgreSQL)

## Instruções de Execução
1. Certifique-se de possuir o SDK do .NET 8 instalado no ambiente.
2. Restaure as dependências do projeto:
   dotnet restore
3. Inicie a aplicação:
   dotnet run
4. O endpoint de diagnóstico estará disponível em: http://localhost:5018/health/check

---
Projeto desenvolvido como Prova de Conceito (PoC) para estratégias de Readiness e Liveness probes em arquiteturas de microsserviços.
