using Grpc.Core;

namespace WorkBookExtractionService.Services
{
    public class FileUploadService : FileService.FileServiceBase
    {
        public FileUploadService()
        {

        }

        public override Task<UploadResponse> UploadCsv(CsvFile request, ServerCallContext context)
        {
            Console.WriteLine("FileUploadService Called");
            Console.WriteLine(request);

            return Task.FromResult(new UploadResponse() { Success = true, Message = "gRPC Service" });
        }
    }
}
