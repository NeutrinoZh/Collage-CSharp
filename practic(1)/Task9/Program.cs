using System.Reflection;

class Program
{

    public static void Main()
    {
        Assembly[] assems = AppDomain.CurrentDomain.GetAssemblies();
        foreach (Assembly assem in assems)
            Console.WriteLine($"Сборка {assem.ToString()}");

        foreach (Type type in assems[8 % assems.Length].GetTypes())
        {
            Console.WriteLine("Type name: {0}", type.Name);
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo mi in members)
            {
                Console.WriteLine("Member type: {0}, member name: {1}.", mi.MemberType, mi.Name);
            }
        }
    }
}