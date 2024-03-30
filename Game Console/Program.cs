/* using Game_Console;

Car car1 = new Car();
Car car2 = new Car();

car1.color = "Green";
car1.year = 2015;
car1.value = 10000;

car2.color = "Blue";
car2.year = 2020;
car2.value = 20000;

Console.WriteLine($"The car {car1.color} from {car1.year} cost {car1.value}");
Console.WriteLine($"The car {car2.color} from {car2.year} cost {car2.value}");

Animal animal1 = new Animal();
Animal animal2 = new Animal();

animal1.name = "Piriquito";
animal1.species = "Bird";
animal1.age = 2;
animal1.amountLegs = 2;
animal1.height = 12.2;
animal1.weight = 2.4;

animal2.name = "Eagle";
animal2.species = "Bird";
animal2.age = 4;
animal2.amountLegs = 2;
animal2.height = 17.2;
animal2.weight = 5.4;

Console.WriteLine($"The {animal1.name} is a {animal1.species} specie that has {animal1.amountLegs} legs and lives between the age of {animal1.age} years. It height {animal1.height} and weight {animal1.weight}.");
Console.WriteLine($"The {animal2.name} is a {animal2.species} specie that has {animal2.amountLegs} legs and lives between the age of {animal2.age} years. It height {animal2.height} and weight {animal2.weight}.");


using Game_Console;

Person p = new Person()
{
    name = "Mathias",
    age = 20
};

PhysicalPerson physical = new PhysicalPerson()
{
    name = "Mathias",
    age = 20,
    CPF = "50072166827"
};

void writePerson(Person p)
{
    Console.WriteLine($"The name of the person is {p.name}");
}

writePerson(p);
writePerson(physical);



using Game_Console.Base;

string teste = 
@"
uma palavra
duas palavras
tres palavras";

World world = new World(20, 40);
world.Fill();
world.Draw(4, 5, teste);
//world.Print();
Scene scene = new Scene();

scene.Add(teste);
scene.Show();
*/

using Game_Console.Scenarios;

Menu menu = new Menu();
menu.Show();

//using Game_Console;

//Singleton.Instance.Name = "Mathias";

//Console.WriteLine(Singleton.Instance.Name);
