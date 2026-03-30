namespace RocketseatAPI.Communication;

public class ResponseHealthCheckJson
{
    public string Version { get; set; } = "1.0.0.0";
    public string Environment { get; set; } = string.Empty;
    public bool DatabaseConnected { get; set; }
    public DateTime ApplicationStartedAt { get; set; }
}
