
namespace FinanceAPI.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserHandler : ICommandHandler<CreateUserCommand, Result<Guid?>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateUserHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<Guid?>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var profilePictureName = await ImageExtentions.SaveImage(request.ProfilePicture);
                var user = new ApplicationUser(request.FirstName,request.LastName,request.Email,request.Email,profilePictureName);
               

                var result = await _userManager.CreateAsync(user, request.Password);

                if (result.Succeeded)
                {
                    var adminRoleResult = await _userManager.AddToRoleAsync(user, "Admin");

                    if (adminRoleResult.Succeeded)
                    {

                        var isInRole = await _userManager.IsInRoleAsync(user, "Admin");

                        if (isInRole)
                        {
                            
                            return Result<Guid?>.Success(user.Id);
                        }
                        else
                            return Result<Guid?>.Failure("Failed to add user to the Admin role.");

                    }
                    return Result<Guid?>.Failure("Failed to add user to the Admin role.");
                }
                else
                {
                    var errorMessages = string.Join("; ", result.Errors.Select(e => e.Description));
                    return Result<Guid?>.Failure(errorMessages);
                }
            }
            catch (Exception ex)
            {

                throw;
            }          

        }
     
    }
}
