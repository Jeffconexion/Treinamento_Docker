# 1- Definir uma imagem base.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base

# 2- Definir informa��es para a imagem.
LABEL version="1.0.1" description="Aplicacao Asp .Net Core"

# 3- Definir a pasta de trabalho (/app)
WORKDIR /app

# 4- Copiar os arquivos da pasta dist para uma pasta no cont�iner (/app)
COPY dist /app

# 5- Expor a porta do cont�iner e definir em qual porta o servidor vai atender.
EXPOSE 80/tcp

# 6- Definir o local de entrada para aplica��o (app.dll que est� na pasta dist) .
ENTRYPOINT ["dotnet","AppMVC.dll"]