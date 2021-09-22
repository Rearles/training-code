# to use this dockerfile (from within current dir):
# 1. dotnet publish -o publish
# 2. docker build -t webcontainer:1.0 .
# 3. docker run --rm -it -p 8000:80 webcontainer:1.0

FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app

COPY publish/ ./

CMD [ "dotnet", "WebContainer.dll" ]
