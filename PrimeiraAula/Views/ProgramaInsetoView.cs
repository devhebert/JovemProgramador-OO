using AllObjects.Controllers;
using AllObjects.Services;

namespace AllObjects.Views
{
    public class ProgramaInsetoView
    {
        public void Run()
        {
            BesouroController besouroController = new BesouroController();
            besouroController.CriarBesoruos();
        }
      
    }
}

