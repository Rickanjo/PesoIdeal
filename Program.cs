// Solicite que o usuário digite sua altura e o seu sexo ('M' para masculino, 'F' para feminino). Calcule e exiba seu peso ideal.
Console.WriteLine("--- Peso Ideal ---");

Console.Write("Digite sua altura (m)...:");
double altura = double.Parse(Console.ReadLine()!);

Console.Write("Digite seu sexo (M ou F):");
char sexo = char.Parse(Console.ReadLine()!);

double pesoIdeal;

if (sexo == 'M') {
    pesoIdeal = altura * 72.7 - 58.0;
    Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal:N1} kg.");

}else if (sexo == 'F') {
    pesoIdeal = altura * 62.1 - 44.7;
    Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal:N1}  kg.");

}else {
    Console.WriteLine("Sexo invalido");
}


