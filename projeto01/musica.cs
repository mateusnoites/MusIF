using System;

class Musica {
  private int id;
  private string Nome;
  private double Tempo;
  
  public Musica(int id, string Nome, double Tempo){
    this.id = id;
    this.Nome = Nome;
    this.Tempo = Tempo;
  }

  public void SetId(int id){
        this.id = id;
  }
  public void SetNome(string Nome){
        this.Nome = Nome;
  }
  public void SetTempo(double Tempo){
        this.Tempo = Tempo;
  }
  public int Getid(){
    return id;
  }
  public string GetNome(){
    return Nome;
  }
  public double GetTempo(){
    return Tempo;
  }
  public override string ToString(){
    return $"{id} - {Nome} - {Tempo}";
  }
}