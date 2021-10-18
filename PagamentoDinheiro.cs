class PagamentoDinheiro : Ipagavel{
  
  double valor_pago;

  public double Valor_pago{
    get{
      return Valor_pago;
    }
    set {
      
      valor_pago = value;
    }
    
  }

  public void Pagar(double x ){
    valor_pago = x ;
  }
 
}