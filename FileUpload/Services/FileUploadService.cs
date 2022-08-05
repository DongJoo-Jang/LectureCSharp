using BlazorInputFile;

namespace FileUpload.Services
{
    public class FileUploadService : IFileUploadService
    {
        private readonly IWebHostEnvironment _enviroment;
        public FileUploadService(IWebHostEnvironment env)
        {
            this._enviroment = env;
        }
        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_enviroment.WebRootPath, "Upload", fileEntry.Name);
            var ms = new MemoryStream(); 
            await fileEntry.Data.CopyToAsync(ms);
            using(FileStream file = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
    }
}
