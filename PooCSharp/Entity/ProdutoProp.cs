namespace PooCSharp.Entity;

/* auto prop - "private" atributos
    classes criadas apenas para aprendizado.
 */
public class ProdutoProp
{
    public int Preco { get; set; }
    public int Quantidade { get; set; }
    public string Nome { get; set; }

    public ProdutoProp()
    {
    }
    public ProdutoProp(int preco, int quantidade, string nome)
    {
        Preco = preco;
        Quantidade = quantidade;
        Nome = nome;
    }

}