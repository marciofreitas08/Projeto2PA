using System.Collections.Generic;
class Compra{

  private List <Produto> Produt = new List <Produto>();
  private string Id_Cliente;
  private string Id_compra;

  public Compra (List <Produto> produt, string id_cliente, string  id_compra){

    Produt = produt;
    Id_Cliente = id_cliente;
    Id_compra = id_compra;
  }
  
}