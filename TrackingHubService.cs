public class TrackingHubService
{
    public HubConnection Hub { get; private set; }

    public async Task Start()
    {
        Hub = new HubConnectionBuilder()
            .WithUrl("https://api.truckerback.com/trackingHub")
            .Build();

        await Hub.StartAsync();
    }
}
