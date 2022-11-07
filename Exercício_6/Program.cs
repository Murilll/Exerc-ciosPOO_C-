Livros livrofavorito = new Livros("O Pequeno Príncipe", 98, 23);
/*
List<Livros> listLivros = new List<Livros>();
listLivros.Add(livrofavorito);
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(listLivros.);
}
*/
Console.WriteLine($"Livro: {livrofavorito.TituloDoLivro()}");
Console.WriteLine($"Quantidade de Pg: {livrofavorito.Paginas()}");
Console.WriteLine($"Porcentagem já lida: {livrofavorito.VerificarProgresso()} %");