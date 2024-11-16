// Screen Sound
string mensagemDeBoasVindas = "Boas vinda ao Screen Sound";
//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso"};

Dictionary<string, List<double>> bandasRegistradas = new Dictionary<string, List<double>>();
bandasRegistradas.Add("Linkin Park", new List<double> {10 ,8 ,6, 9, 4});
bandasRegistradas.Add("The Beatles", new List<double>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
    
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a media de uma banda");
  Console.WriteLine("Digite 0 para sair");

  Console.Write("\nDigite a sua opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1: RegistrarBandas();
      break;
    case 2: MostrarBandasRegistradas();
      break;
    case 3: AvaliarUmaBanda();
      break;
    case 4: CacularMediaDaBanda();
      break;
    case 0: Console.Write("Tchau tchau :)");  
      break;     
    default: Console.Write("Opção Inválida");
      break;
  }
}

void ExibirTituloDaOpção(string titulo)
{
  int quantidadeDeLetras = titulo.Length;
  string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
  Console.WriteLine(asteriscos);
  Console.WriteLine(titulo);
  Console.WriteLine(asteriscos + "\n");
}

void RegistrarBandas()
{
  Console.Clear();
  ExibirTituloDaOpção("Registro de bandas");
  Console.Write("Digite o nome da banda que deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  bandasRegistradas.Add(nomeDaBanda, new List<double>());
  Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
  Console.Clear();
  ExibirTituloDaOpção("Exibindo todas as bandas registradas");
  //for (int i = 0; i < listaDasBandas.Count; i++)
  //{
  //  Console.WriteLine($"Banda: {listaDasBandas[i]}");
  // }

  foreach (string banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"Banda: {banda}");
  }

  Console.WriteLine("\nDigite uma tecla para voltar ao meno principal");
  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
  Console.Clear();
  ExibirTituloDaOpção("Avaliar Banda");
  Console.Write("Digite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;

  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
    int nota = int.Parse(Console.ReadLine()!);
    bandasRegistradas[nomeDaBanda].Add(nota);
    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

void CacularMediaDaBanda()
{
  Console.Clear();
  ExibirTituloDaOpção("Exibir Média da Banda");
  Console.Write("Digite o nome da banda que deseja consultar a mádia: ");
  string nomeDaBanda = Console.ReadLine()!;
  if(bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    double media = bandasRegistradas[nomeDaBanda].Average();
    Console.Write($"A média da banda {nomeDaBanda} é {media}");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

ExibirOpcoesDoMenu();



