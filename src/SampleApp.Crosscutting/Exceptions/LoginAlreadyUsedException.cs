using SampleApp.Crosscutting.Constants;

namespace SampleApp.Crosscutting.Exceptions
{
    public class LoginAlreadyUsedException : BadRequestAlertException
    {
        public LoginAlreadyUsedException() : base(ErrorConstants.LoginAlreadyUsedType, "Login name is already in use!",
            "userManagement", "userexists")
        {
        }
    }
}
