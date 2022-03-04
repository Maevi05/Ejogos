using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {
        public void CriarPastaouArquivo(string path)
        {
            //nome da pasta / nome do aruqivo.csv

            //strtok, dentro do colchete pega o que foi separado no vetor
            string pasta = path.Split('/')[0];
            string arquivo = path.Split('/')[1];

            //analise se a pasta existe
            //se não existir, cria a pasta

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);  
            }

            //analise se o arquivo existe
            //se não existir, cria o arquivo

            if (!File.Exists(path))
            {
                File.Create(path).Close();

            }


        }


    }
}
