using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Bogus;

namespace WebAppMVC.Services;

public class ImageStorageService
{
    private readonly string _azureConnectionString;
    private readonly IWebHostEnvironment _environment;

    public ImageStorageService(IConfiguration configuration, IWebHostEnvironment environment)
    {
        _environment = environment;
        _azureConnectionString = configuration.GetConnectionString("AzureConnectionString");
    }

    private string GenerateFileName(IFormFile file)
    {
        var ext = Path.GetExtension(file.FileName);
        return $"{Guid.NewGuid()}.{ext}";
    }

    public async Task<string> UploadFileToBlobAsync(IFormFile file)
    {
        // var uploads = Path.Combine(_environment.WebRootPath, "uploads");
        // if (!Directory.Exists(uploads))
        // {
        //     Directory.CreateDirectory(uploads);
        // }

        var container = new BlobContainerClient(_azureConnectionString, "images");
        string fileName = GenerateFileName(file);
        var blob = container.GetBlobClient(fileName);

        await using (var filestream = file.OpenReadStream())
        {
            await blob.UploadAsync(
                filestream,
                new BlobHttpHeaders() { ContentType = file.ContentType }
            );
        }

        return blob.Uri.ToString();
    }

    public bool IsImage(IFormFile file)
    {
        if (file.ContentType.Contains("image"))
        {
            return true;
        }

        string[] formats = new string[] { ".jpg", ".png", ".gif", ".jpeg", ".webp" };

        return formats.Any(
            item => file.FileName.EndsWith(item, StringComparison.OrdinalIgnoreCase)
        );
    }
}
