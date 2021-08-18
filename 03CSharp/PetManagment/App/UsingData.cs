using Data;
using System;
namespace App
{
    /// <summary>
    /// Delcaring a delegate of type void
    /// </summary>
    public delegate void DelCatOperations();
    public class UsingData
    {
        public static void CallDatabaseCon(){
            using(DatabaseConnection connection=new DatabaseConnection()){
                System.Console.WriteLine("Using connection");
            }           
        }
        //anonymous method - they are created for single use
        DelCatOperations del = delegate(){
         var cats=FileRepoXML.Init();
            if(cats.Count>0){
                FileRepoXML.AddCats(cats);
                Console.WriteLine("Data has been stored in XML");
            }   
        };

        
        public static void Serialize_Xml(){
            var cats=FileRepoXML.Init();
            if(cats.Count>0){
                FileRepoXML.AddCats(cats);
                Console.WriteLine("Data has been stored in XML");
            }
        }
        //lambda expression is short hand notation for anonymous method
        Action deserialize_xml=()=>{
            var cats=FileRepoXML.GetCats();
            System.Console.WriteLine("Reading from XML...");
            foreach (var cat in cats)
            {
               Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        };
        public static void Deserialize_Xml(){
            var cats=FileRepoXML.GetCats();
            System.Console.WriteLine("Reading from XML...");
            foreach (var cat in cats)
            {
               Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
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
            System.Console.WriteLine("Reading from Json...");
            foreach (var cat in cats)
            {
               Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        }
    }
}