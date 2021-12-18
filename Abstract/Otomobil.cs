
namespace Abstract
{
    public abstract class Otomobil
    {
        public int KacTekedenOlusur()
        {
            return 4;
        }
        public virtual Renk StandartRenkNe()
        {
            return Renk.Beyaz;
        }
        public abstract Marka HangiMarkaninAracı();
        
    }
}
