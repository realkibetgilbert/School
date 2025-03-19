namespace FileHandler.Service
{
    public class FileService : BackgroundService

    {

        private readonly string sourceFolder = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

        private readonly string destinationFolder = Path.Combine(Directory.GetCurrentDirectory(), "Processed");

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)

        {

            while (!stoppingToken.IsCancellationRequested)

            {

                MoveFiles();

                await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken); // Run every 5 minutes

            }

        }

        private void MoveFiles()

        {

            Directory.CreateDirectory(destinationFolder); // Ensure destination exists

            var files = Directory.GetFiles(sourceFolder);

            foreach (var file in files)

            {

                var destFile = Path.Combine(destinationFolder, Path.GetFileName(file));

                File.Move(file, destFile, true);

            }

        }

    }

}
