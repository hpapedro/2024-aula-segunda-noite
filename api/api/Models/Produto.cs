namespace api.Models;

public class Produto
{

    public Produto(){
        
        Id = Guid.NewGuid().ToString();
        CriadoEM = DateTime.Now;
    }
    
    public string? Id { get; set; }

    public string? Nome { get; set; }

    public double Valor {get; set; }

    public int Quantidade {get; set;}

    public DateTime CriadoEM {get; set;}
    
}
