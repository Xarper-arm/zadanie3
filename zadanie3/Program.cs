struct person
{
    public string Name;
    public string Surname;
    public int Age;
    public string Sex;

    public person(string n, string s, int a, string sex)
    {
        Name = n;
        Surname = s;
        Age = a;
        Sex = sex;


    }

    public void Displayinfo()
    {
        Console.WriteLine($"Name = {Name} surname = {Surname} age = {Age} sex = {Sex}");
            }

    }
 class Program
{
    static void Main(string[] args)
    {
        person[] persons = new person[2];
        persons[0] = new person("Hayk", "Gevorgyan", 30, "male");

        persons[1].Name = "Liza";
        persons[1].Surname = "Grigoryan";
        persons[1].Age = 20;
        persons[1].Sex = "female";

        foreach (person person in persons)
        {
            person.Displayinfo();
        }

        person David = new person("David", "Khachatryan", 28, "male");
        //David.Name = "David";
        //David.surname = "Khachatryan";
        //David.age = 28;
        //David.sex = "male";

        for ( int i = 0;i< persons.Length;i++)
        {
            int midage = persons[0].Age + persons[1].Age;
            //Console.WriteLine(midage / persons.Length);
        }
        

        David.Displayinfo();

        
        Console.ReadKey();
    

    }
}
