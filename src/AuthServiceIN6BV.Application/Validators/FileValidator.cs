using AuthServiceIN6BV.Application.Interfaces;
 
namespace AuthServiceIN6BV.Application.Validators;
 
public static class FileValidator
{
    private static readonly string[] AllowedImageExtensions = [".jpg", ".jpeg", ".png", ".webp"];
 
    private const int MaxFilesSizeInBytes = 5 * 1024 * 1024; //5mb
 
    public static (bool IsValid, string? ErrorMessage) ValidateImage(IFileData file)
    {
        if (file == null || file.Size == 0)
        {
            return(false, "File is required.");
        }
 
        if (file.Size > MaxFilesSizeInBytes)
        {
            return(false, $"File size cannot exceed {MaxFilesSizeInBytes / (1024 * 1024)}MB");
        }
 
        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
 
        if (!AllowedImageExtensions.Contains(extension))
        {
            return(false,$"Only the following file types are allowed: {string.Join(", ")}");

        }

        //Validar tipo de archivo
        var allowebContentTypes = new [] {"image/jpg", "image/jpg", "image/png", "image/webp"};
        if (!allowebContentTypes.Contains(file.ContentType.ToLowerInvariant()))
        {
            return (false, "Invalid file type");

        }

        return (true,null);
 
       
 
    }
    public static string GenerateSecureFileName(string originalFileName)
    {
        var extension = Path.GetExtension(originalFileName).ToLowerInvariant();
        var uniqueId = Guid.NewGuid().ToString("N")[..12];
        return $"profile-{uniqueId}{extension}";
    }
}