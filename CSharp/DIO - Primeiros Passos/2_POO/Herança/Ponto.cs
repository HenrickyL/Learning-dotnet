namespace _2_POO.Herança
{
    public class Ponto
    {
        public int x,y;
        protected int distancia;
        public Ponto(int x,int y){
            this.x = x;
            this.y=y;
        }

        protected void CalcularDistancia(){

        }
        private void CalcularDistancia2(){

        }
        public virtual void CalcularDistancia3(){

        }
    }
}