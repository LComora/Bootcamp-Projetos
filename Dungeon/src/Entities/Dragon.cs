namespace Dungeon.src.Entities
{
    public class Boss
    {
        public Boss(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
    }
        public Boss(){

        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;

        }
        public virtual string Attack(){
            return this.Name + " Atacou";
        }
        public string Attack(int Dano){

            if (Dano < 5){
                return this.Name + " atacou com suas garras causando " + Dano + " HP no oponente";
            }else{
                return this.Name + " cospiu fogo, causando um grande dano de " + Dano + " HP no oponente";
            }
        }
    }    
}