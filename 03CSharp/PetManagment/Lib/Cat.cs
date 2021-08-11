namespace Lib
{
    public enum FurType{
        Long,
        Short,
        noFur
    }
    public enum CatType{
        Himalyan,
        Abyssian,
        British_Munchkin,
        Calico,
        Maine_Coons,
        Sphynx,
        Persian,
        American_Bobtail
    }
    public class Cat:Pet
    {
        public Cat()
        {
            Weight = 8.0;
            CatType=CatType.Himalyan;
            FurType=FurType.Long;
        }
        public double Weight { get; set; } // auto - property
        public CatType CatType { get; set; }
        public FurType FurType { get; set; }

        public new string GetDetails(){
            var result=base.GetDetails();
            return result +" " + $"\nCat type: {CatType}\nWeight: {Weight} pounds\nFur type: {FurType}";
        }

    }
}