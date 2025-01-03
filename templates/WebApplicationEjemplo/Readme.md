Swashbuckle.AspNetCore

PS C:\Users\fernando\source\repos\WebApplication15\WebApplication15> dotnet dev-certs https --check --trust
A trusted certificate was found: 082FCB5E142446CCE2331A27C679CCA9C7B29440 - CN=localhost - Valid from 2025-01-01 21:50:35Z to 2026-01-01 21:50:35Z - IsHttpsDevelopmentCertificate: true - IsExportable: true

dotnet dev-certs https --clean
dotnet dev-certs https --trust

certmgr.msc

https://www.youtube.com/watch?v=orLOuvaToco&list=PLur-8VoYbGX7z2iL_8ZifnkKkIJqDmbg8&index=65