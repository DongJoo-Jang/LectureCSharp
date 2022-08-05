using BlazorInputFile;

namespace FileUpload.Services
{
    public interface IFileUploadService
    {
        Task UploadAsync(IFileListEntry file);
    }
}
