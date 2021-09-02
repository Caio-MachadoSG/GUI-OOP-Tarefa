using System;

namespace Aula_01_09
{
    public abstract class Janela
    {
        private bool BotaoFechar;
        private bool BotaoMax;
        private bool BotaoMin;
        private string Titulo;

        protected void setTitulo(string nt) {
            Titulo = nt;
        }
        public string getTitulo() {
            return Titulo;
        }

        private int PosX;
        private int PosY;
        public void posAtual() {
            Console.WriteLine("Posição x atual -> " + PosX + "\nPosição y atual -> " + PosY);
        }


        public void MoverJanela(int x, int y) {
            PosX = x;
            PosY = y;
        }
    }
}