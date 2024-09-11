# STRATZ GraphQL Models

[![NuGet Version](https://img.shields.io/nuget/v/7kruger.stratz)](https://www.nuget.org/packages/7kruger.STRATZ)
[![Downloads](https://img.shields.io/nuget/dt/7kruger.stratz)](https://www.nuget.org/packages/7kruger.STRATZ)

Nuget package
-------------
Installation:
```console
Install-Package 7kruger.STRATZ
```

# Usage
```csharp
var yatoroSteamAccountId = 321580662;

var query = new DotaQueryQueryBuilder()
    .WithPlayer(
        new PlayerTypeQueryBuilder()
            .WithSteamAccount(new SteamAccountTypeQueryBuilder()
                .WithId()
                .WithName()
                .WithProfileUri()
                .WithAvatar()
                .WithIsDotaPlusSubscriber()
                .WithDotaAccountLevel()
                .WithIsAnonymous()
                .WithSeasonRank()
                .WithSeasonLeaderboardRank()
                .WithSeasonLeaderboardDivisionId()
                .WithProSteamAccount(new ProSteamAccountTypeQueryBuilder()
                    .WithName()
                    .WithRealName())
            )
            .WithMatchCount()
            .WithWinCount()
            .WithFirstMatchDate()
            .WithLastMatchDate()
        ,
        yatoroSteamAccountId)
    .Build(STRATZ.Formatting.Indented);
```
results into
```graphql
query {                              
  player(steamAccountId: 321580662) {
    steamAccount {                   
      id                             
      name                           
      profileUri                     
      avatar                         
      isDotaPlusSubscriber           
      dotaAccountLevel               
      isAnonymous                    
      seasonRank
      seasonLeaderboardRank
      seasonLeaderboardDivisionId
      proSteamAccount {
        name
        realName
      }
    }
    matchCount
    winCount
    firstMatchDate
    lastMatchDate
  }
}
```

**Read more about usage [here](https://github.com/Husqvik/GraphQlClientGenerator?tab=readme-ov-file#query-builder-usage)**