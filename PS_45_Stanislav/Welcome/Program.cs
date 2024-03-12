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

        }
    }
}