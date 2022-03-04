using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface Iequipe
    {
        //contrato
        //como a classe vai se comportar
        //o que a classe pode fazer
        //metodos obrigatorios em uma classe

        void Criar(equipe novaEquipe);

        List<equipe> LerEquipes();


    }
}
