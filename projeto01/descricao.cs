using System;

class Descricao{
  private int id;
  private string Cantor;
  private string Genero;
  private DateTime Lancamento;
  
  public Descricao (int id, string Cantor, string Genero, DateTime Lancamento){
    this.id = id;
    this.Cantor = Cantor;
    this.Genero = Genero;
    this.Lancamento = Lancamento;
  }

  public void SetId(int id){
        this.id = id;
  }
  public void SetCantor(string Cantor){
        this.Cantor = Cantor;
  }
  public void SetGenero(string Genero){
        this.Genero = Genero;
  }
  public void SetLancamento (DateTime Lancamento){
        this.Lancamento = Lancamento;
  }
  public int Getid(){
    return id;
  }
  public string GetCantor(){
    return Cantor;
  }
  public string GetGenero(){
    return Genero;
  }
  public DateTime GetLancamento(){
    return Lancamento;
  }
  public override string ToString(){
    return $"{id} - {Cantor} - {Genero} - {Lancamento:yyyy}";
  }
}
