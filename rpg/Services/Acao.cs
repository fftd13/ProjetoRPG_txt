using rpg.Entities;

namespace rpg.Services
{
    class Acao
    {
        public Personagem Personagem1 { get; set; }        
        private IAttack _basicAttack;

        public Acao(){}

        public Acao(Personagem personagem1)
        {
            Personagem1 = personagem1;
        }

        public double BasicAttack()
        {
            return _basicAttack.BasicAttack()
        }
        
    }
}
