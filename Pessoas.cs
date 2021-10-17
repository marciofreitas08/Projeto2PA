class Pessoa{
  
  private string Nome;
  private int Idade;
  private char Sexo; 
  
  public Pessoa()
  {

  }
  public Pessoa(string nome, int idade, char sexo)
  {
    Nome = nome;
    Idade = idade;
    Sexo = sexo;
         
  }

  public string getNome()
  {
    return Nome;
  }

  public void  setNome(string nome)
  {
    
    if (nome.Length < 3)
    {
      throw new Nomeinvalido();
    }

    for (int i = 0; i < nome.Length; i++)
    {
      if (char.IsNumber(nome, i))
      {
        throw new Nomeinvalido();
      }
    }
    Nome = nome;   
    
  }  

  public char getsexo()
  {

    return Sexo;
  }

  public bool setSexo(char s)
  {
    if (s == 'M' || s == 'F' || s == 'f' || s == 'm')
    {
      Sexo = s;
      return true;
    }
    return false;
  }

  public int getIdade()
  {
    return Idade;
  }
  public void setIdade(int num)
  {
    Idade = num;
  }
}