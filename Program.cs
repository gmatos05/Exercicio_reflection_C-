 using System;
 using System.Reflection;
namespace Exercicio_Reflection{
    class Program{
        public static void Main(){
            
        DisplayPublicProperties();
        CreateInstance();
        }
        public static void DisplayPublicProperties(){
            Student student =  new Student();
            PropertyInfo[] propertyInfos = student.GetType().GetProperties();
            foreach (var propertyInfo in propertyInfos){
                System.Console.WriteLine($"{propertyInfo.Name}");
            }
        }
        public static void CreateInstance(){
            Type t = typeof(Student);
            object objeto = Activator.CreateInstance(t);

            PropertyInfo propriedade_Name = t.GetProperty("Name");
            propriedade_Name.SetValue(objeto,"Nome");

            PropertyInfo propriedade_rollNumber = t.GetProperty("RollNumber");
            propriedade_rollNumber.SetValue(objeto,45486);

            PropertyInfo propriedade_faculdade = t.GetProperty("University");
            propriedade_faculdade.SetValue(objeto,"Nome da Faculdade");

            MethodInfo displayMethod =t.GetMethod("DisplayInfo");
            displayMethod.Invoke(objeto,null);
        }
    }
   
        
}