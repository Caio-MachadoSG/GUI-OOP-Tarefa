using System;

namespace Aula_01_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Popup popUp = new Popup();
            Modal modal = new Modal();


            popUp.MoverJanela(200, 100);
            popUp.posAtual();


            modal.MoverJanela(400, 250);
            modal.posAtual();
        }
    }
}
