# .Net-REST

Tutorial - REST API using dotnet core

Steps for setting up project

1. clone this repository

2. enter into .Net-REST/Rest-Example
   ```
   cd .Net-RESt/Rest-Example
   ```
3. Install all Dependencies
   ```
   dotnet restore
   ```
4. Build the application
   ```
   dotnet build
   ```
5. setup your connection string in appsetting.json for database(PostgreSQL)
   ```
   "ConnectionStrings": {
       "TaskConnection":"UserID=postgresPassword=*******Host=localhostPort=432;Database=rest;Pooling=true;"
   }
   ```
6. run migrations to instantiate database

   ```
    dotnet ef database update
   ```

7. Run the application
   ```
   dotnet run
   ```
8. Your application is hosted on

   ```
   https://localhost:5001
   or
   http://localhost:5000
   ```

9. You can test your APIs using postman
   ```
   GET     ->   https://localhost:5001/api/task
   POST    ->   https://localhost:5001/api/task
   PUT     ->   https://localhost:5001/api/task/{id}
   DELETE  ->   https://localhost:5001/api/task/{id}
   ```
