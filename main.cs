using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    while (true)
    {
        try
        {
          Menu();
          break;
        }
        catch
        {
          Console.WriteLine();
          Console.WriteLine("Erro inesperado! Você retornou ao menu principal!");
        }
    }
    
  }
  public static void Menu()
  {
    Console.WriteLine("                                      "
                      + "    _________________________________");
    Console.WriteLine();
    Console.WriteLine("                                      "
                      + "              Papelaria UCL          ");
    Console.WriteLine("                                      "
                      + "    _________________________________");
    Console.WriteLine();
    Console.WriteLine("                                      "
                      + "              MENU PRINCIPAL         ");
    Console.WriteLine();
    Console.WriteLine("                                " +
                      "           1 - Fazer Cadastro          ");
    Console.WriteLine("                                " +
                      "           2 - Sair                    ");   
    Console.WriteLine("                                " +
                      "           4 - Fazer Compras           ");
    Console.WriteLine();
    Console.Write("> Digite a opção desejada: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (num == 1)
    {
      CadastrarCliente();
    }    
    else if (num == 4)
    {
      Menu();
    }
    else 
    {
      Console.WriteLine(" Sistema Finalizado");
    }
    
  }
  public static void CadastrarCliente()
  {
    Cliente P1 = new Cliente();
    Console.WriteLine("Cadastrar Cliente");
    Console.WriteLine();  

    Console.WriteLine("Sexo: M - Masculino | F - Feminino");
    Console.WriteLine();
    Console.Write("> Digite o sexo: ");
    char S = char.Parse(Console.ReadLine());
    while (!P1.setSexo(S))
    {
      Console.WriteLine("Caracter inválido!");
      Console.Write("> Por favor, tente novamente: ");
      S = char.Parse(Console.ReadLine());
    }
    Console.Write("> Nome: ");
    string nome = Console.ReadLine();
    
    while (true)
    {
      try
      {
        P1.setNome(nome);
        break;
          
      }
      catch (Nomeinvalido ) 
      {
        Console.WriteLine("Nome invalido");
        Console.WriteLine("> Por favor, tente novamente: ");
        nome = Console.ReadLine();
      }
    }                    

    Console.Write("> ID (4 primeiros dígitos do CPF): ");
    string id = Console.ReadLine(); 
    P1.setId(id);

    Console.WriteLine(" Atendemos alunos de 4 a 10 anos");
    Console.Write("> Digite a idade de seu filho:");
    int idade_filho = int.Parse(Console.ReadLine());
    while (!P1.setidade_filho(idade_filho))
    {
      Console.WriteLine("Idade inválida!");
      Console.WriteLine("> Por favor, tente novamente: ");
      Console.WriteLine("> Digite a idade de seu filho:");
      idade_filho =  int.Parse(Console.ReadLine());
    }   
    Console.WriteLine(" Atendenmos alunos de 1 a 9 Serie");
    Console.Write("> Digite a série que seu filho estuda:");
    int serie = int.Parse(Console.ReadLine());
    while (! P1.setano_estudo(serie))
    {
      Console.WriteLine("Série inválida!");
      Console.WriteLine("> Por favor, tente novamente: ");
      Console.WriteLine("> Digite a série que seu filho estuda:");
      serie = int.Parse(Console.ReadLine());
    } 
    Console.WriteLine(); 
    Console.WriteLine();
                                      
    Console.WriteLine(" Deseja ver nossas recomendações de material baseado no seu perfil?");
    Console.Write("| 1 - Sair; 2 - Sim;  3 - Menu principal |");
    Console.WriteLine("> Digite a opção desejada:");
    int  re = int.Parse(Console.ReadLine());
    if (re == 3)
    {
      Menu();
    }

    else if ( re == 2)
    {
      P1.Recomendacao(P1.getidade_filho(), P1.getano_estudo());
    }           
    else
    {
    Console.WriteLine( " Sisitema finalizado com sucesso:");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(" Degite a opção desejada");
    Console.Write("| 1 - Sair; 2 - Menu principal |");
    Console.WriteLine("> Digite a opção desejada:");
    int  r = int.Parse(Console.ReadLine());
    if (r == 2)
    {
      Menu();
    }

    else
    {
    Console.WriteLine( " Sisitema finalizado com sucesso:");
    }
  }
    
}