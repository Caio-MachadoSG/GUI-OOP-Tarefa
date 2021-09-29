namespace Aula_01_09
{
    public class Modal : Janela,IDimensionavel
    {
        private int maxAlt;
        private int maxLarg;
        private int atualAlt;
        private int atualLarg;

        
        private void alterarTitulo(string t) {
            base.setTitulo(t);
        }

        public void fullScreen() {
            atualAlt = maxAlt;
            atualLarg = maxLarg;
        }

        public void setLargura(int larg) {
            if (larg > 1) {
                atualLarg = larg;
            }
        }

        public void setAltura(int alt) {
            if (alt > 1) {
                atualAlt = alt;
            }
        }
    }
}
