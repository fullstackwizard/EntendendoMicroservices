1️⃣ Instalar o .NET SDK (caso não tenha)

Verifique se o .NET SDK está instalado:

dotnet --version

Se não estiver instalado, baixe e instale a versão mais recente do .NET SDK:
🔗 https://dotnet.microsoft.com/download
2️⃣ Criar o projeto

Dependendo do tipo de aplicação, escolha uma das opções abaixo:
🔹 Aplicação Console

Se quiser uma aplicação simples para rodar no terminal:

dotnet new console -o MinhaApp

🔹 Aplicação Web API

Se quiser uma API REST com ASP.NET Core:

dotnet new webapi -o MinhaApi

🔹 Aplicação MVC

Se for um site web estruturado com MVC:

dotnet new mvc -o MeuSite

🔹 Aplicação Blazor (SPA)

Se quiser uma aplicação Web Single Page (SPA) com Blazor:

dotnet new blazorwasm -o MeuBlazorApp

🔹 Aplicação MAUI (Mobile e Desktop)

Se quiser uma aplicação multiplataforma para Android, iOS e Windows:

dotnet new maui -o MinhaAppMaui

⚠️ Obs: Para MAUI, você precisa do .NET 7+ e instalar as dependências conforme a plataforma.
3️⃣ Rodar a aplicação

Entre no diretório do projeto:

cd MinhaApp

E execute:

dotnet run

4️⃣ Compilar para diferentes plataformas

Para criar um executável para diferentes sistemas operacionais, use:

🔹 Windows

dotnet publish -c Release -r win-x64 --self-contained true

🔹 Linux

dotnet publish -c Release -r linux-x64 --self-contained true

🔹 macOS

dotnet publish -c Release -r osx-x64 --self-contained true

O executável gerado estará na pasta:

bin/Release/netX.X/platform/

🎯 Próximos Passos

Agora você pode: ✅ Editar o código no VS Code ou Rider
✅ Adicionar dependências com dotnet add package
✅ Criar testes unitários com dotnet new xunit
✅ Publicar o projeto em um servidor ou loja de aplicativos

Se quiser um guia mais aprofundado para um dos tipos de aplicação, me avise!
