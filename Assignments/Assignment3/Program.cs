
class Program
{
    static void Main(string[] args)
    {
        HomePage homePage = new HomePage();
        homePage.Navigate("https://www.homepage.com");
        homePage.HandleMenuClick("Home");

        AboutUs aboutUs = new AboutUs();
        aboutUs.InitiatePhone("9849197330");
        aboutus.initiateEmail("pradyumnasubedi@gmail.com");
    }
}
