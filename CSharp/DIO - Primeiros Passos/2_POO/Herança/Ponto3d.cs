namespace _2_POO.Herança
{
    public class Ponto3d : Ponto
    {
        public int z;
        public Ponto3d(int x,int y, int z): base(x,y){
            this.z =z;
            this.CalcularDistancia3();
        }

        public static void Calcular(){

        }
        public override void CalcularDistancia3()
        {
            base.CalcularDistancia3();
        }
    }
}