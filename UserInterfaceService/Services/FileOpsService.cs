using static UserInterfaceService.FileService;
using System.Threading.Tasks;
using UserInterfaceService;

namespace UserInterfaceService.Services
{
    public class FileOpsService
    {
        private readonly FileServiceClient client;
        public FileOpsService(FileServiceClient client)
        {
            this.client = client;
        }

        public async Task<UploadResponse> SendCsvFileAsync(CsvFile csvFile)
        {
            var uploadResponse = await client.UploadCsvAsync(csvFile);
            return uploadResponse;
        }
    }
}
