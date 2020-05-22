namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome;
        public string idade;
        public string armadura;

        public float Atacar(float força, float potência)
        {
            return força * potência;
        }

        public string Defender()
        {
            return "O personagem atacou!";
        }
    }
}