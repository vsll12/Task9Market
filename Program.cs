using Market.Models;
using Market.Services;

MainService mainService = new MainService();

mainService.Initialize();

while (true)
{
    mainService.Start();
}