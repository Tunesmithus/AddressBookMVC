using AddressBookMVC.Services.Interfaces;

namespace AddressBookMVC.Services
{
    public class BasicImageService : IImageService
    {
        public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
        {
            using MemoryStream memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            byte[] byteArray = memoryStream.ToArray();

            return byteArray;

        }

        public string CovertByteArrayToFile(byte[] fileData, string extension)
        {
            if (fileData is null)
            {
                return string.Empty;
            }

            string imageBase64Data = Convert.ToBase64String(fileData);
            return $"data:{extension};base64,{imageBase64Data}";
        }
    }
}
