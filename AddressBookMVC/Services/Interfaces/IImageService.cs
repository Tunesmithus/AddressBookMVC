namespace AddressBookMVC.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        string CovertByteArrayToFile(byte[] fileData, string extension);

    }
}
