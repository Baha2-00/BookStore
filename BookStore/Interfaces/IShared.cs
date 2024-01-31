using BookStore.DTOs.Subscription;

namespace BookStore.Interfaces
{
    public interface IShared
    {
        Task<List<GetSubDTO>> GetAllSubs();
        //GetSubsByFiltering
        Task<GetSubDTO> GetEventDetails(int Price, float durationInDays,);
        //Registraition
        //Task CreateNewAccount(RegistrationDTO dto);
        //Login
        //Task Login(LoginDTO dto);
        //ResetPassword
        //Task ResetPassword(ResetPasswordDTO dto);
    }
}
