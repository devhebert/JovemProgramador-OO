using System;
using AllObjects.Controllers;

namespace AllObjects.Views
{
    public class ProgramAnimalsView
    {
        public void Run()
        {
            CachorroController cachorroController = new CachorroController();
            cachorroController.CriarCachorros();
        }
    }
}