using AllObjects.Controllers;

namespace AllObjects.Views
{
    public class ProgramCasaView
    {
        public void Run()
        {
            CasaController casaController = new CasaController();
            casaController.CriarCasa();
        }
    }
}

