using ModAcessoPropriedades;

//Criar objeto
CarrinhoItem camiseta = new CarrinhoItem();
camiseta.Nome = "camisa da Loud";
camiseta.Cor = "";
camiseta.Quantidade = 2;
camiseta.VerItem();

//Criar objeto utilizando construtor e sobrecarga
CarrinhoItem bolsa = new CarrinhoItem("bolsa termica", "Amarela", 3);
CarrinhoItem.VerItem(bolsa);

//Criar objeto a nivel de classe
CarrinhoItem estojo = CarrinhoItem.CriarItem("Estojo personalizado", "Roxo", 2);
CarrinhoItem.VerItem(estojo);
