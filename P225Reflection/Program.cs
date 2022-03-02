using System;
using System.Reflection;

namespace P225Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\memme\Desktop\P225\Task\P225ReflectionLibraryLibrary\bin\Debug\netcoreapp3.1\P225ReflectionLibraryLibrary.dll");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                //Console.WriteLine(type.Name);

                if (type.Name == "Student")
                {
                    MemberInfo[] memberInfos = type.GetMembers(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                    //foreach (MemberInfo memberInfo in memberInfos)
                    //{
                    //    //Console.WriteLine($"{memberInfo.Name} {memberInfo.DeclaringType} {memberInfo.MemberType} {memberInfo.CustomAttributes}");


                    //}

                    var ins = Activator.CreateInstance(type);
                    MethodInfo methodInfo = type.GetMethod("Write1");
                    object[] param =
                    {
                        "Test P225 Code Academy",
                        2022
                    };
                    Console.WriteLine(methodInfo.Invoke(ins, param));
                }
            }
        }
    }
}
