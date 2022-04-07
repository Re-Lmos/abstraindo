namespace abstraindo_poo.src.entities;


public class  Hero
{   
    public string name;

    public int level;

    public string typeHero;

    public Hero(string name, int level, string typeHero)
    {
        this.name = name;
        this.level = level;
        this.typeHero = typeHero;
    }
        
    public override string ToString()
    {
        return this.name + " " + this.level + " " + this.typeHero;   
    }

}    

