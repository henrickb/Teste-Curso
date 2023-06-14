namespace Teste._Builders;


public class CursoBuilder
{
	private string _nome = "Banco  de Dados";
    private double _cargaHoraria = 80;
    private string _publico = "niversitário";
    private string _descricao = "SQL para iniciantes";
    private double _valor = 150.50;
    private double _nota = 12;
    
    public static CursoBuilder Novo()
    {
        return new CursoBuilder();
    }

    public Curso Criar()
    {
        return new Curso(_nome, _descricao, _cargaHoraria, _publico, _valor, _nota);
    }

    public CursoBuilder ComNome(string nome)
    {
        _nome = nome;
        return this;
    }
    public CursoBuilder ComDecricao(string decricao)
    {
        _descricao = decricao;
        return this;
    }
    public CursoBuilder ComCargaHoraria(double cargaHoraria)
    {
        _cargaHoraria = cargaHoraria;
        return this;
    }
    public CursoBuilder ComPublicoAlvo(string publico) 
    {
        _publico = publico;
        return this;
    }
    public CursoBuilder ComValor(double valor)
    {
        _valor = valor;
        return this;
    }
    public CursoBuilder ComNota(double nota) 
    {
        _nota=nota;
        return this;
    }

}

