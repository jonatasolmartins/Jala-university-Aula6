
using Aula6;


//Descomente a linha abaixo para ver o que acontece
// var baseclass = new BaseClass(12); 

var child = new ChildClass("Nate", "Baptist", "Ross");

//O membro SecondName não pode ser acessado fora da classe ChildClass
//child.SecondName = "";
Console.WriteLine(child.GetFullName());
Console.WriteLine($"ChildClass herda de {ChildClass.BaseType}");


Console.ReadLine();
