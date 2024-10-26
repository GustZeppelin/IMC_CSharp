

using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Serialization;

Console.WriteLine("Você está aqui para calcular o seu imc, para isso precisarei da sua altura e peso");
Console.WriteLine("Me informe sua altura EX(1,79)");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Me informe seu peso EX(72,30)");
float peso = float.Parse(Console.ReadLine());


//conta imc

float imc = peso / (altura * altura);

//Resposta do calculo :D
if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC é {imc}. Você está com magreza severa!");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine($"Seu IMC é {imc}. Você está com o peso normal!");
}
else if (imc >= 25.0 && imc <= 29.9)
{
    Console.WriteLine($"Seu IMC é {imc}. Você está com sobrepeso!");
}
else if ((imc >= 30 && imc <= 39.9))
{
    Console.WriteLine($"Seu IMC é {imc}. Você está com obesidade tipo II!");
}
else
{
    Console.WriteLine($"Seu IMC é {imc}. Você está com obesidade tipo III!");
}