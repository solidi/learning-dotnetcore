dotnet new console
dotnet run
dotnet publish -c Release
docker build -t hello-world-core .
docker run -it --rm hello-world-core