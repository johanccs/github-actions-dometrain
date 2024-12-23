namespace github_actions_dometrain;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        await Task.Delay(4000);

        await Task.CompletedTask;
    }
}