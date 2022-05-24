namespace Dungeon.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " lançou ";
        }
        
        public string Attack(int Jogada){

            if (Jogada <= 6){
                return this.Name + " lançou " + Jogada + " Shurikens";
            }else{
                return this.Name + " lançou " + Jogada + " Skeans, acertando o alvo!";
            }
        }
            
    }
}