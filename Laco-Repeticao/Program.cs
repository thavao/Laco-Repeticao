int valorInicial = 0, max = 0, auxiliar = 0, contador = 0;

Console.Write("Digite o valor inicial: ");
valorInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quanto quer incrementar");
max = int.Parse(Console.ReadLine());


Console.WriteLine("For");

auxiliar = valorInicial;

for (contador = 0; contador <= max; contador++)
{
    Console.WriteLine(auxiliar);
    auxiliar++;
}

Console.WriteLine("Do While");

auxiliar = valorInicial;
contador = 0;

do
{
    Console.WriteLine(auxiliar);
    auxiliar++;
    contador++;

} while (contador <= max);


Console.WriteLine("While");

auxiliar = valorInicial;
contador = 0;

while (contador <= max)
{
    Console.WriteLine(auxiliar);
    auxiliar++;
    contador++;
}