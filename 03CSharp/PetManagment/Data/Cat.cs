namespace Data
{
    public class Cat:Pet
    {
        public double Weight { get; set; }
        public FurType FurType { get; set; }
        public CatType CatType { get; set; }
    }
    public enum FurType{
        Long, Short, NoFur
    }
     public enum CatType{
        Himalyan, Abyssian,
        British_Munchkin,
        Calico,
        Maine_Coons,
        Sphynx,
        Persian,
        American_Bobtail
    }
}