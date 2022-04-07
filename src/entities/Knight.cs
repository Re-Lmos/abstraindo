namespace abstraindo_poo.src.entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string typeHero) : base(name, level, typeHero)
        {
            this.name = name;
            this.level = level;
            this.typeHero = typeHero;
        }

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.typeHero;
        }

        public string Attack()
        {   
            if (this.level >= 40) 
            {
                return $"{this.name} é um herói {this.typeHero} que está no level {this.level} e ataca com uma espada na potência poderosa";
            } 
            if (this.level >= 20)
            {
                return $"{this.name} é um herói {this.typeHero} que está no level {this.level} e ataca com uma espada na potência média";
            }
            else {
                return $"{this.name} é um herói {this.typeHero} que está no level {this.level} e ataca com uma espada na potência fraca";
            }
        }
        
    }

}