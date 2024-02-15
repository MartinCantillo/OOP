
Coche cohe= new Coche(3,"s");

cohe.GetInfo();


class Coche
{
  private int codigo;
  private String marca;
 //Constructor
  public Coche(int codigo, String marca)
  {
    this.codigo = codigo;
    this.marca = marca;
  }
  //Set and getter
  public int Codigo { get => codigo; set => codigo = value; }
  public String Marca { get => marca; set => marca = value; }

  public void  GetInfo(){
    Console.WriteLine($"Marca {this.Marca} and Codigo {this.Codigo}"); 
  }
}


