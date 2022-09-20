Console.Write("Digite um número: ");

double num = Convert.ToDouble(Console.ReadLine());

if(num%3 == 0 && num%7 == 0){
    Console.WriteLine($"O número {num} é múltiplo de 3 e 7.");
} else {
    Console.WriteLine($"{num} não é múltiplo.");
}
Console.ReadKey();