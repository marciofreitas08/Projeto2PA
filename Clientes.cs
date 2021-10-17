using System;
using System.Collections.Generic;
class Cliente : Pessoa{
  
  private string Id;
  private double Idade_filho;
  private double Ano_estudo;
  
 

  public Cliente (){

  }
  public Cliente  (string nome, int idade, char sexo, string id, double idade_filho, double ano_estudo) : base (nome,idade,sexo){
    Id = id;
    Idade_filho = idade_filho;
    Ano_estudo = ano_estudo;
  }
  public string getId() {
    return Id;
  }
  public void setId(string id){
    Id = id;
  }
  public double getidade_filho(){
    return Idade_filho;
  }
  public bool setidade_filho(double idade_filho){
    if (idade_filho <= 10){
      Idade_filho = idade_filho;
      return true;
    }
    return false;
     
  }
  public double getano_estudo(){
    return Ano_estudo;
  }
  public bool setano_estudo(double ano_estudo){
    if(ano_estudo <= 9) {
      Ano_estudo = ano_estudo; 
      return true;
    }
    return false;
     
  }
 
  public void Recomendacao(double x, double y){

    string [,] list1 = new string [3,3] {{"Pincel","Massinha de modelar","Giz de cera"},{"Papel sulfite","Tubo de cola","Caixa de lápis de cor"}, {"livro de história infantil","Tinta guache","Cola Bastão"}};
    string [,] list2 = new string [3,3] {{"Lápis","Apontador", "Caneta hidrográfica"},{"Tesoura sem ponta","Tinta guache","Pincel"}, {"Cadernos de brochura","Caderno de desenho","Caderno de caligrafia"}};
    string [,] list3 = new string [3,3] {{"Cadernos","Régua","Lápis"},{"Caneta esferográfica","Estojo","Tubo de cola"}, {"Caixa de lápis de cor","Papel sulfite","Dicionario"}};
    
    double [,] it = new double [3,2] {{4,1},{8,5},{10,8}};
    
    double soma1 = Math.Pow(Math.Pow( x - it[0,0],2) + Math.Pow( y - it[0,1],2),0.5);

    double soma2 = Math.Pow(Math.Pow( x - it[1,0],2) + Math.Pow( y - it[1,1],2),0.5);

    double soma3 = Math.Pow(Math.Pow( x - it[2,0],2) + Math.Pow( y - it[2,1],2),0.5);

    double menor;
 
    if(soma1 < soma2){
      if(soma1 < soma3){
        menor = soma1;
        Console.WriteLine(">  LISTA DE MATERIAIS 1  <");
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
              Console.WriteLine(" -> "+list1[i,j]);
            }
        }      
        
      }
      else{
        menor = soma3;
        Console.WriteLine(">  LISTA DE MATERIAIS 3  <");

        for (int i = 0; i < 3; i++)
        {
          for (int j = 0; j < 3; j++)
          {
            
            Console.WriteLine(" -> "+list3[i,j]);
          }
        }      
       
      }
    }
    else{
      if(soma2 < soma3){
        menor = soma2;
        Console.WriteLine(">  LISTA DE MATERIAIS 2  <");
        
        for (int i = 0; i < 3; i++)
        {
          for (int j = 0; j < 3; j++)
          {
            Console.WriteLine(" -> "+list2[i,j]);
          }
        }      
      }  
       
      else{
        
        menor = soma3;
        Console.WriteLine(">  LISTA DE MATERIAIS 3  <");
       
        for (int i = 0; i < 3; i++)
        {
          for (int j = 0; j < 3; j++)
          {
            Console.WriteLine(" -> "+list3[i,j]);
          }
        }       
        
      }
    }

  }
  
}