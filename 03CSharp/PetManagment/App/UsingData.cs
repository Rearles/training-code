using Data;
namespace App
{
    public class UsingData
    {
        public static void CallDatabaseCon(){
            using(DatabaseConnection connection=new DatabaseConnection()){
                System.Console.WriteLine("Using connection");
            }           
        }

        public static void Serialize(){
            var cats=FileRepoXML.Init();
            if(cats.Count>0){
                FileRepoXML.AddCats(cats);
                System.Console.WriteLine("Data has been stored");
            }
        }
        public static void Deserialize(){
            var cats=FileRepoXML.GetCats();
            foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        }
    }
}