FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/FreeCourse.Shared/*.csproj Shared/FreeCourse.Shared/
COPY WebUI/FreeCourse.WebApp/*.csproj WebUI/FreeCourse.WebApp/
RUN dotnet restore WebUI/FreeCourse.WebApp/*.csproj
COPY . .
RUN dotnet publish WebUI/FreeCourse.WebApp/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FreeCourse.WebApp.dll" ]




