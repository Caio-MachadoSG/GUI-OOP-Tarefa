using System;
using System.Collections.Generic;

namespace Aula_01_09
{
    public class ComboBox
    {
        private List<string> opcoes = new List<string>();
        private int itemAtual;


        public void setItemAtual(int indice) {
            itemAtual = indice;
        }
    }
}