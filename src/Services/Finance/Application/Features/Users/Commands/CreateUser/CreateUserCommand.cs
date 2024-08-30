namespace FinanceAPI.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommand : ICommand<Result<Guid?>>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public IFormFile? ProfilePicture { get; set; } = default!;
    }
}
