namespace Dungeon.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){
        
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " atacou com sua espada ";
        }

        public string Attack(int Dano){
            if(Dano >= 10){
                return this.Name + " atacou com sua espada, causando um super dano de "+ Dano + " HP";
            }if(Dano >= 5){
                return this.Name + " atacou com sua espada, causando um dano baixo de " + Dano + " HP";
            }else{
                return this.Name + " atacou com sua espada, causando um dano de " + Dano + " HP";
            }

        }
            
    }
}