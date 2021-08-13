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

        public static void Serialize_Xml(){
            var cats=FileRepoXML.Init();
            if(cats.Count>0){
                FileRepoXML.AddCats(cats);
                System.Console.WriteLine("Data has been stored");
            }
        }
        public static void Deserialize_Xml(){
            var cats=FileRepoXML.GetCats();
            foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        }

        public static void Serialize_Json(){
            var cats=FileRepoXML.Init();
            if(cats.Count>0){
                FileRepoJson.AddCats(cats);
            }
        }
        public static void Deserialize_Json(){
            var cats=FileRepoJson.GetCats().Result;
            foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        }
    }
}