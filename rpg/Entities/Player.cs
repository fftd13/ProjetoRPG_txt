using rpg.Services;

namespace rpg.Entities
{
    class Player : Personagem
    {
        public string Name { get; set; }
        public Status Status { get; set; }
        public int MyProperty { get; set; }
    }
}
