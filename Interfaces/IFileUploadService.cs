namespace DevTest.Interfaces
{
    public interface IFileUploadService
    {
        Task<string> UploadFile(IFormFile postedFile);
    }
}
