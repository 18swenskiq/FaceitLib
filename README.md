# FaceitLib
A C# Library for using Faceit.com's Data API v4

# Notes
Frequently, endpoints will just return a 503 response. Its important to check for your object either being null
after each call, or checking the object's status. To do the latter, check the "Check HTTP Status" section under Usage

# Usage:
(While there are many endpoints, I will not showcase them all here. The ones shown here are just for example purposes)

## Create Object
```
  using FaceitLib;
  
  var faceit = new FaceitClient("yourAPItokenhere");
```

## Call API Endpoint
```
  var results = await faceit.GetTournamentDetails("tournament_id");
  return results.CompetitionID;
```

## Check HTTP Status
```
  var status = faceit.GetStatusCode()
  // Will return a HttpStatusCode object
```

## Using some of the library's constants
```
  using FaceitLib;
  using FaceitLib.Constants
  
  var faceit = new FaceitClient("yourAPItokenhere");
  var results = await faceit.GetGameRanking("game", FaceitLib.Constants.Regions.UnitedStates);
```
  
  
