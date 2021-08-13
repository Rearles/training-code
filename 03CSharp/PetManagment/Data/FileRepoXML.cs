using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace Data
{
    public class FileRepoXML
    {
        static string path="C:/Revature/cats.xml";
        public static List<Cat> Init(){
            List<Cat> cats=new List<Cat>(){
                new Cat(){Id=100, Name ="Tolly", Dob =new DateTime(2018,11,12),Weight=9.0,CatType=CatType.Himalyan,FurType=FurType.Long,Gender=Gender.Male},
                new Cat(){Id=101, Name ="Snow", Dob =new DateTime(2019,01,02),Weight=7.0,CatType=CatType.Abyssian,FurType=FurType.Long,Gender=Gender.Female},
                new Cat(){Id=100, Name ="Diamond", Dob =new DateTime(2020,03,12),Weight=6.0,CatType=CatType.American_Bobtail,FurType=FurType.Short,Gender=Gender.Female},
                new Cat(){Id=100, Name ="Clifford", Dob =new DateTime(2015,10,22),Weight=9.0,CatType=CatType.Abyssian,FurType=FurType.NoFur,Gender=Gender.Male},
            };
            return cats;
        }
        public static void AddCats(List<Cat> cats){
            
            TextWriter writer=new StreamWriter(path);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cat>));
                serializer.Serialize(writer,cats);
            }
            finally
            {
                writer.Close();
            }
        }

        public static List<Cat> GetCats(){
            TextReader reader=new StreamReader(path);
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof (List<Cat>));
                var cats = (List<Cat>) deserializer.Deserialize(reader);
                if(cats.Count>0)
                    return cats;
                else
                    return null;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}