// See https://aka.ms/new-console-template for more information
//novo projeto -> dotnet new console
//Console.WriteLine("Hello, World!");
// using C_.Models;

// Pessoa p =  new Pessoa();

// p.Nome = "Mary";
// p.Idade = 16;
// p.apresentar();

// string a = "1";

// int.TryParse(a, out int b); //tenta converter o a e jogar no b, caso seja um valor que não corresponda ao tipo o b é retornado intacto

// Console.WriteLine(b);

//// ARRAY ////
///

// int[] matriz = new int[5];
// int[] matriz2 = new int[5];

// matriz[0]=1;

// foreach(int valor in matriz){
//     Console.WriteLine(valor);
// }

// Array.Resize(ref matriz, matriz.Length * 2); //amplia a capacidade de um array

// Array.Copy(matriz, matriz2, matriz.Length);

//// LISTA ////
///

// List<string> lista = new List<string>();

// lista.Add("A");
// lista.Add("B");
// lista.Add("C");

// foreach(string v in lista){
//     Console.WriteLine(v);
// }

// lista.Remove("C");

// foreach(string v in lista){
//     Console.WriteLine(v);
// }

using System.Globalization;
using C_.Models;
using Newtonsoft.Json;

//// OBJECT ////
///

// Pessoa p = new Pessoa(nome: "Jose", sobrenome: "Carvalho");
// // p.Nome = "Jose";
// // p.Sobrenome = "Carvalho";

// Pessoa p2 = new Pessoa(nome: "Arnaldo", sobrenome: "Fritz");
// // p2.Nome = "Arnaldo";
// // p2.Sobrenome = "Fritz";

// Curso c = new Curso();
// c.Nome = "Ingles";
// c.Alunos = new List<Pessoa>();

// c.Adicionar(p);
// c.Adicionar(p2);
// c.Listar();

//// FORMATATION ////
///

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valor = 1582.40M;
// int valor2 = 123456;
// Console.WriteLine($"{valor:C}");
// Console.WriteLine(valor.ToString("C8", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valor.ToString("P"));
// Console.WriteLine(valor2.ToString("##-##-##"));

// DateTime data = new DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

//// throw ////
///

// Teste t =new Teste();
// t.m1();

//// FILA ////
/// os primeiros a entrar são os primeiros a sair

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);

// foreach(int item in fila){
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila){
//     Console.WriteLine(item);
// }

//// PILHA ////
/// ultimo a entrar é o primeiro a sair

// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);

// foreach(int item in pilha){
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
// pilha.Push(10);

// foreach(int item in pilha){
//     Console.WriteLine(item);
// }

//// DICIONARIO ////
/// em um dicionario não se pode ter chavez iguais

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");

// foreach(var item in estados){
//     Console.WriteLine($"Cahve: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine(estados.ContainsKey("BA"));
// estados.Remove("BA");
// Console.WriteLine(estados.ContainsKey("BA"));

// estados["SP"] = "Guarulhos";

// Console.WriteLine(estados["SP"]);

//// TUPLA ////
/// pode se por diferentes tipos em uma unica variavel

// (int ID, string Nome, string Sobrenome, decimal Altura) tupla = (1, "L", "B", 1.88M);

// ValueTuple<int, string> tupla2 = (1, "a");
// var tupla3 = Tuple.Create(1, "a");


// Console.WriteLine(tupla.ID);

// LeituraArquivos ler = new LeituraArquivos();

// // _ descarta um valor retornado, mas não usado
// var (sucesso, linhas, quant, _) = ler.LerArquivo("Arquivos/Arq.txt");

// if(sucesso){
//     Console.WriteLine("Quantidade de linhas: " + quant);
//     foreach(string l in linhas){
//         Console.WriteLine(l);
//     }
// } else{
//     Console.WriteLine("Não deu pra ler!");
// }

//// DESCONSTRUTOR ////
///

// Pessoa p = new Pessoa("A","b");

// (string nome, string sobrenome) = p;

// Console.WriteLine($"{nome} {sobrenome}");

//// IF Ternario ////
///

// int numero = 10;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));

//// SERIALIZAÇÂO ////
/// serializar é converter as informaç~oes para que sejam transmitidas, o JSON é um exemplo

// DateTime agora = DateTime.Now;

// List<Vendas> lista = new List<Vendas>();

// Vendas v = new Vendas(1, "Abacaxi", 10.00M, agora);
// Vendas v2 = new Vendas(2, "Macça", 20.00M, agora);

// lista.Add(v);
// lista.Add(v2);

// string serializacao = JsonConvert.SerializeObject(lista, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializacao);

// Console.WriteLine(serializacao);

//// DESSERIALIZE ////
///

string arq = File.ReadAllText("Arquivos/vendas.json");

List<Vendas> lista = JsonConvert.DeserializeObject<List<Vendas>>(arq);

foreach(Vendas v in lista){
    Console.WriteLine($"{v.Id} {v.Produto} {v.Preco} {v.DataVenda}");
}
