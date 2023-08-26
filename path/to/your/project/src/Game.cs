public class Game
{
    private bool isRunning;

    public Game()
    {
        isRunning = true;
    }

    public void Run()
    {
        Initialize();

        while (isRunning)
        {
            HandleInput();
            Update();
            Render();
        }

        Cleanup();
    }

    private void Initialize()
    {
        // Initialization code here
    }

    private void HandleInput()
    {
        // Input handling code here
    }

    private void Update()
    {
        // Game update code here
    }

    private void Render()
    {
        // Rendering code here
    }

    private void Cleanup()
    {
        // Cleanup code here
    }
}