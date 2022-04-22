namespace ClubSportsDomain.EntityInterface
{
  public interface ITeam
  {
    string ClubHistory { get; set; }
    string CurrentCoachName { get; set; }
    string DateEstablished { get; set; }
    int Id { get; set; }
    string ManagerName { get; set; }
    string Name { get; set; }
    int NumberOfChanpionship { get; set; }
    int NumberOfCurrentPlayers { get; set; }
    int NumberOfTopPlayers { get; set; }
    string PresidentName { get; set; }
  }
}