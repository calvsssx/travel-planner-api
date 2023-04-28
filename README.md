# travel-planner-api 

1. Create database 'TravelApplicationDB' in localserver
2. Change connection string on appsettings.json (DefaultConnection)
3. run 'dotnet ef update database' in terminal (zsh/bash) on root folder of the project
4. Run program in IIS Express (Chrome or Edge)

File Structure (proposed development)

TravelPlanner/
  |- Controllers/
      |- UserController.cs
      |- DestinationController.cs
      |- TripController.cs
      |- ActivityController.cs
  |- Data/
      |- TravelPlannerContext.cs
  |- Models/
      |- User.cs
      |- Destination.cs
      |- Trip.cs
      |- Activity.cs
      |- TripDestination.cs
      |- DestinationActivity.cs
  |- Services/
      |- IUserService.cs
      |- UserService.cs
      |- IDestinationService.cs
      |- DestinationService.cs
      |- ITripService.cs
      |- TripService.cs
      |- IActivityService.cs
      |- ActivityService.cs
  |- ViewModels/
      |- CreateUserViewModel.cs
      |- CreateDestinationViewModel.cs
      |- CreateTripViewModel.cs
      |- CreateActivityViewModel.cs
  |- TravelPlanner.csproj
  |- TravelPlanner.Tests/
      |- UserControllerTests.cs
      |- DestinationControllerTests.cs
      |- TripControllerTests.cs
      |- ActivityControllerTests.cs
      |- TravelPlannerContextTests.cs
      |- UserServiceTests.cs
      |- DestinationServiceTests.cs
      |- TripServiceTests.cs
      |- ActivityServiceTests.cs
      |- TravelPlanner.Tests.csproj

