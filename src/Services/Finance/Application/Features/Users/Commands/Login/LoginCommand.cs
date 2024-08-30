namespace FinanceAPI.Application.Features.Users.Commands.Login
{
    public class LoginCommand : ICommand<Result<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
