using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Stanislav","12345",Others.UserRolesEnum.ADMIN,"sp@gmail.com","1111");
            UserViewModel userviewm1 = new UserViewModel(user1);
            UserView userv1 = new UserView(userviewm1);
            userv1.Display();

            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Role = Others.UserRolesEnum.STUDENT,
                    email = "123@gmail.com",
                    facNumber = "1234"
                };
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();
            }
            catch (Exception e) 
            {
                var log = new ActionOnError(log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}