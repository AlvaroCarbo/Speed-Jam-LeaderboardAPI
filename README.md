# SpeedJamLeaderboardAPI
API Rest made with ASP.NET WeB API using Azure Cosmos DB (MongoDB).

## API Documentation
- **Swagger Index** [https://speedjamleaderboardapi.azurewebsites.net/swagger/index.html](https://speedjamleaderboardapi.azurewebsites.net/swagger/index.html)
- **ENDPOINT** [https://speedjamleaderboardapi.azurewebsites.net/Leaderboard](https://speedjamleaderboardapi.azurewebsites.net/Leaderboard)

## Endpoints Documentation
- **GET** Leaderboard list: [https://speedjamleaderboardapi.azurewebsites.net/Leaderboard](https://speedjamleaderboardapi.azurewebsites.net/Leaderboard)
- **GET** Leaderboard specific item: [https://speedjamleaderboardapi.azurewebsites.net/Leaderboard/{id:length(24)}](https://speedjamleaderboardapi.azurewebsites.net/Leaderboard/{id:length(24)})*
- **POST** Leaderboard item: [https://speedjamleaderboardapi.azurewebsites.net/Leaderboard](https://speedjamleaderboardapi.azurewebsites.net/Leaderboard)
- **PUT** Leaderboard specific item: [https://speedjamleaderboardapi.azurewebsites.net/Leaderboard/{id:length(24)}](https://speedjamleaderboardapi.azurewebsites.net/Leaderboard/{id:length(24)})*
- **DELETE** Leaderboard specific item: [https://speedjamleaderboardapi.azurewebsites.net/Leaderboard/{id:length(24)}](https://speedjamleaderboardapi.azurewebsites.net/Leaderboard/{id:length(24)})*

**Where **{id:length(24)}** should be a 24 digit hex string.*

## JSON Documentation
```
{
    "id": "string",
    "name": "string",
    "score": "string"
}
```

## JSON Example
```
{
    "id": "63e8da973a6ef76eab81a27b",
    "name": "Alvaro",
    "score": "11999"
}
```

## Azure Cosmos DB Settings / Mongo DB Atlas Settings
- **Connection String**
```
mongodb://leadeboard-db:OmuK3E7lcgKdFzHATLfuqkTIeDPigvnYs90f00E9JuQYDI7Tg8YLSa83MertzXwZmiMFhLKe8CEuACDbdAYFUw==@leadeboard-db.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@leadeboard-db@
```
- **Database Name** `SpeedGameJam`
- **Leaderboard Collection Name** `Leaderboard`

  
