namespace FinanceAPI.Application.Extentions
{
    public static class ImageExtentions
    {
        public static async Task<string?> SaveImage(IFormFile? profilePicture)
        {
            if (profilePicture == null) return null;

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var extension = Path.GetExtension(profilePicture.FileName).ToLower();

            if (!allowedExtensions.Contains(extension))
            {
                throw new InvalidOperationException("Invalid file extension. Only .jpg, .jpeg, .png, and .gif are allowed.");
            }

            var fileName = Path.GetFileNameWithoutExtension(profilePicture.FileName);
            var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", uniqueFileName);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await profilePicture.CopyToAsync(stream);
            }

            return uniqueFileName;
        }
    }
}
