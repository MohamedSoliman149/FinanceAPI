namespace FinanceAPI.Application.Features.Users.Commands.Login
{
    public class LoginHandler : ICommandHandler<LoginCommand, Result<string>>
    {
        private readonly JwtTokenGenerator _jwtTokenGenerator;
        private readonly UserManager<ApplicationUser> _userManager;
        public LoginHandler(JwtTokenGenerator jwtTokenGenerator, UserManager<ApplicationUser> userManager)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userManager = userManager;
        }

        public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, request.Password))
            {
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault(); 
                if (string.IsNullOrEmpty(role))
                    return Result<string>.Failure("This user doesnot assign to Role.");

                var token = _jwtTokenGenerator.GenerateToken(user.Id.ToString(), user.Email, role);
                return Result<string>.Success(token);
            }
            return Result<string>.Failure("Invalid email or password.");
        }
    }
}
