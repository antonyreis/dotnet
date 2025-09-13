using src.models;


string text = "123";
int numero_texto = Convert.ToInt32(text);

string text_dois = "5210";

int num = int.Parse(text_dois);
string input = Console.ReadLine();

if (input == "blablabla")
{
    Console.WriteLine("blablablablablablabla");
}

switch (input)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("VOGAL");
        break;
    default:
        Console.WriteLine("Não é vogal");
        break;
}

// DateTime dataAgora = DateTime.Now;
// DateTime dataFormatada = DateTime.Now.AddDays(5);
// String dataFormatadaString = dataFormatada.ToString("dd/MM HH:mm");



// string texto = "teste";
// int numero = 123;
// double numero_dois = 1.23;
// decimal preco = 1.230M;
// bool true_ou_false = true;

// Console.WriteLine($"{texto}, {numero}, {numero_dois}, {preco}, {true_ou_false}");


// Pessoa p = new Pessoa();

// p.Nome = "tunes";
// p.Idade = 20;
// p.Apresentar();

// Console.WriteLine($"Data agora: {dataAgora}, data5dias: {dataFormatada}, data formatada: {dataFormatadaString}");