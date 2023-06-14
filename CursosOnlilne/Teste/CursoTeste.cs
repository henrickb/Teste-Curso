using ExpectedObjects;
using Teste._Util;
using Teste._Builders;

namespace Teste
{
    public class CursoTeste
    {
        /*
         * Criar cursos
         * 
         * Eu como administrador preciso criar e editar cursos para que sejam abertas
         * matriculas para o mesmo
         * 
         * 1 - Criar curso com nome, carga hor�ria, p�blico alvo, valor do curso
         * 2 - As op��es para p�blico alvo s�o somente: secundarista, universit�rio, 
         *     profissional e empreendedor
         * 3 - Todos os campos s�o preenchimento obrigat�rio
         */
        private string _nome;
        private double _cargaHoraria;
        private string _publico;
        private double _valor;

        public CursoTeste()
        {
            _nome = "Banco de Dados";
            _cargaHoraria = 80;
            _publico = "Universitario";
            _valor = 150.00;
        }


        /*
                [Fact]
                public void CriarCurso()
                {
                    // Arrange
                    var cursoEsperado = new
                    {
                        Nome = _nome,
                        CargaHoraria = _cargaHoraria,
                        Publico = _publico,
                        Valor = _valor
                    };

                    // Act
                    Curso novoCurso = new Curso(
                        cursoEsperado.Nome,
                        cursoEsperado.CargaHoraria,
                        cursoEsperado.Publico,
                        cursoEsperado.Valor);

                    // Assert
                    cursoEsperado.ToExpectedObject().ShouldMatch(novoCurso);
                }
        */

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CursoNomeVazio(string nome)
        {
            Assert.Throws<ArgumentException>( () =>
                CursoBuilder.Novo().ComNome(nome).Criar()
            );
           
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CursoCargaHorariaInvalida(int ch)
        {
            // Act & Assert
            /*
            var mensagem = Assert.Throws<ArgumentException>(
                () =>
                new Cu
                rso(curso.Nome, ch, curso.Publico, curso.Valor)
            ).Message;
            Assert.Equal("CH inv�lida!", mensagem);
            */
            Assert.Throws<ArgumentException>(
                () =>
                CursoBuilder.Novo().ComCargaHoraria(ch).Criar()
                ).ComMensagem("CH inv�lida!");
        }

    }

    public class Curso
    {
        // campos
        private string nome;
        private string descricao;
        private double cargaHoraria;
        private string publico;
        private double valor;
        private double nota;
        

        // propriedades
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public string Publico { get => publico; set => publico = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Nota { get => nota; set => nota = value; }


        public Curso(string nome, string descricao,double cargaHoraria, string publico, double valor, double nota)
        {
            //if (nome == string.Empty) throw new ArgumentException();
            //if (nome == null) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException();
            if ( cargaHoraria <= 0 ) throw new ArgumentException("CH inv�lida!");


            this.Nome = nome;
            this.Descricao = descricao;
            this.CargaHoraria = cargaHoraria;
            this.Publico = publico;
            this.Valor = valor;
            this.Nota = nota;   
        }

    }
}