namespace Profiler
{
    using System;
    using System.IO;
    class Program
    {
        static void Main()
        {
            UserProfile profile = new UserProfile();
            profile.FirstName = "Ivailo";
            profile.LastName = "Kenov";
            profile.Age = 10;
            profile.Description = "sadsadasfas";
            //profile.DateOfBirth = new DateTime(2001,1,1);
            //влез в този метод
            Save(profile);
        }
        
        static void Save(UserProfile profile)
        {
            //за запазване на информацията
            StreamWriter writer = new StreamWriter("data.txt");
            using (writer)
            {
                //взимам типа на UserProfile, по този начин
                Type profileType = typeof(UserProfile);
                //ако напишем profileType.pro и ни излиза какво може да вземем от proparty
                //FirstName Ще ми вземе инфо за пропъртито от класа UserProfile.cs
                profileType.GetProperty("FirstName");
                //така си имам инфо за всичките пропъртита
                var profileProperties = profileType.GetProperties();
                foreach (var property in profileProperties)
                {
                    //търсим всички атрибути на пропъртито и ако има save тогава да записвам
                    var attributes = property.GetCustomAttributes(typeof(SaveAttribute), false);
                    //с долния ред му казвам: трябва да имаме 1 атрибут [Save] (не два)
                    if (attributes.Length >= 1)
                    {   
                        //търсим нещо с Name + стойността (взимаме пропъртито на profile) 
                        writer.WriteLine(property.Name + " " + property.GetValue(profile));
                    }
                    
                }
                //какво направих дотук - хващам типа (profileType) на това, което ме интересува, взимам му всички пропъртита
                //за всяко пропърти взимам всички атрибути от тип SaveAttribute
                //ако имам attributes.Length >= 1 такива атрибути записвам property.Name + " " + property.GetValue(profile) от този обект, който подавам (profile)
                        
                
                //writer.WriteLine(profile.FirstName);
                //writer.WriteLine(profile.LastName); 
                //writer.WriteLine(profile.Age); 
                //writer.WriteLine(profile.DateOfBirth); 
            }
            
        }
        
         static UserProfile Load()
        {
            StreamWriter reader = new StreamWriter("data.txt");
            UserProfile profile = new UserProfile();
            using (reader)
            {
                //profile.FirstName = reader.ReadLine();
                //profile.LastName = reader.ReadLine(); 
                //profile.Age = int.Parse(reader.ReadLine());
                //profile.DateOfBirth = reader.ReadLine(); 
            }
            
            return profile;
            
        }
        
        //вземи ми типа на UserProfile, шземи ми всички пропъртита вътре, foreach-ни ги  и за всяко пропърти запиши(или логни)
    }
}
