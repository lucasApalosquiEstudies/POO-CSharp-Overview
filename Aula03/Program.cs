using Aula03;

Produto tennis = new Produto("Air max", "Nike", 300.50, 3);
Produto bola = new Produto("Bola de futsal", "Addidas", 150, 5);
Produto camisa = new Produto("Camisa de time", "Bahia", 199.99, 2);

Carrinho carrinho01 = new Carrinho();
carrinho01.AdicionarAoCarrinho(tennis);
carrinho01.AdicionarAoCarrinho(bola);
carrinho01.AdicionarAoCarrinho(camisa);

carrinho01.VerCarrinho();

