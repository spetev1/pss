using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
using WelcomeExtended.Others;


namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User("John Smith", "password123",UserRolesEnum.STUDENT, "123@gmail.com", "1234");
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}