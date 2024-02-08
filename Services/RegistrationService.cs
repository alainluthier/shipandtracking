public class RegistrationService
{
    private List<RegistrationModel> registeredUsers = new List<RegistrationModel>();

    public async Task<bool> RegisterUser(RegistrationModel registrationModel)
    {
        registeredUsers.Add(registrationModel);

        return true;
    }
}
