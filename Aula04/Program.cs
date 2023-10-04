using Aula03;
using Aula04.FormasDePagamento;

Produto calca = new Produto("Calça jeans", "calvin klein", 100, 4);
Produto lapis = new Produto("Lapis de cor", "Faber castle", 99.90, 2);

Carrinho carrinho02 = new Carrinho();
carrinho02.AdicionarAoCarrinho(calca);
carrinho02.AdicionarAoCarrinho(lapis);

Pix pix = new Pix("Loja.Pix@gmail.com");
pix.Pagar(carrinho02);

Console.WriteLine();

Boleto boleto = new Boleto("Rua das canetas", "Apartamento B", 9);
boleto.Pagar(carrinho02);

Console.WriteLine();

Cartao cartao = new Cartao("Débito");
cartao.Pagar(carrinho02);
