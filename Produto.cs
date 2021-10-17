class Produto{
  private string Nome;
  private double Preco;

  public Produto (){

  }
  public Produto ( string nome, double preco){
    Nome = nome;
    Preco = preco;
  }
  public string getNome(){
    return Nome;
  }
  public void setNome(string nome){
    Nome = nome;
  }
  public double getPreco(){
    return Preco;
  }
  public void setPreco(double preco){
    Preco = preco;
  }
}