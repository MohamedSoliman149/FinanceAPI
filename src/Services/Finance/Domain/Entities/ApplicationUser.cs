namespace FinanceAPI.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? ProfilePicture { get; set; } = default!;

        public ApplicationUser() { }

        public ApplicationUser(string firstName, string lastName, string email,string userName, string? profilePicture =null)
        {
            FirstName = firstName;
            LastName = lastName;
            ProfilePicture = profilePicture;
            Email = email;
            UserName = userName;
        }
    }
}
