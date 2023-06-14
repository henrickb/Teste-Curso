using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste._Util
{
    public static class ArgumentoExtensao
    {
        public static void ComMensagem(this ArgumentException excecao, 
            string mensagem)
        {
            if (excecao.Message == mensagem) 
            {
                Assert.True(true);
            }
            else
            {
                //Assert.False(true);
                //Assert.False(true, "Esperava a mensagem: " + mensagem);
                Assert.False(true, $"Esperava a mensagem: {mensagem}");
            }
        }
    }
}
