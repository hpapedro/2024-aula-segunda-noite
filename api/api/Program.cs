//Minimal Apis em C#
//Testar a API
// Rest Client -- Extensão VS Code
// - Postman
// - Insomnia

using api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
        {
            
                new Produto { Nome = "Teclado Mecânico", Valor = 199.99, Quantidade = 50 },
                new Produto { Nome = "Monitor 24\" LED", Valor = 799.90, Quantidade = 30 },
                new Produto { Nome = "Mouse Gamer", Valor = 149.90, Quantidade = 75 },
                new Produto { Nome = "SSD 512GB", Valor = 349.90, Quantidade = 40 },
                new Produto { Nome = "Cadeira Gamer", Valor = 999.00, Quantidade = 20 },
                new Produto { Nome = "Headset Bluetooth", Valor = 259.90, Quantidade = 60 },
                new Produto { Nome = "Smartphone 128GB", Valor = 1999.90, Quantidade = 25 },
                new Produto { Nome = "Notebook i5 8GB", Valor = 2999.90, Quantidade = 15 },
                new Produto { Nome = "Impressora Multifuncional", Valor = 799.00, Quantidade = 10 },
                new Produto { Nome = "Caixa de Som Bluetooth", Valor = 119.90, Quantidade = 100 }
            }; 

//Endpoints - Funcionalidades
//Requisição - URL e método/verbo HTTP

app.MapGet("/", () => "API de Produtos");

app.MapGet("/api/produto/listar", () => 
{
    return produtos;
});

//POST: /api/produto/cadastrar/param_nome
app.MapPost("/api/produto/cadastrar/{nome}", (string nome) =>{

    Produto produto = new Produto();
    produto.Nome = "flamengo";
    produtos.Add(produto);
    return produtos;
});



app.Run();

//EXERCICIOS PARA PROXIMA AULA 
// - Criar um ebdpoint para receber informaçoes pela URL
// - Criar um endpointi para receber informaçoes pelo corpo 

//Java
// Produto produto = new produto();
//produto.setValor(10);
//Console.WriteLine("Preco: " + produto.getValor());

//C#
//Produto produto = new Produto();
//prduto.Nome = "Notebook";
//Console.WriteLine("Preco:  )
