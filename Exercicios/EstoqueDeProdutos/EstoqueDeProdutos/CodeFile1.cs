Estoque estoque = new Estoque();

// Adicionando produtos
estoque.AdicionarProduto(new Produto("Leite", 2, 7.50m));
estoque.AdicionarProduto(new Produto("Produto A", 10, 15.50m));
estoque.AdicionarProduto(new Produto("Produto B", 5, 30.00m));

// Exibindo todos os produtos
estoque.ExibirTodosOsProdutos();