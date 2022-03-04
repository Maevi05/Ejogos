using EJOGOS.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{
    //: -> herança
    public class equipe : EquipeBase, Iequipe
    {
        public int Idequipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variavel de banco de dados

        private const string caminho = "Database/equipe.csv";

        //ctro + TAB + TAB -> cria um construtor
        public equipe()
        {
            //metodo da classe de herança
            CriarPastaouArquivo(caminho);
        }

        private string Preparar(equipe E)
        {
            //cifrão($) retorna uma string
            return $"{E.Idequipe};{E.Nome};{E.Imagem}";
        }




        //Equipe equipe = new Equipe();
        //equipe.IdEquipe = 1;
        //equipe.nome = "Equipe 1";
        //euqipe.Imagem = "Caminho da imagem";
        //ja vem preenchido
        public void Criar(equipe novaEquipe)
        {


            //preparar a classe para retornar um texto
            //array de strings  =na posicao 0 vai existir nossa linha
            string[] equipe_txt = { Preparar(novaEquipe) };
        

        //caminho, string em formato de array
        File.AppendAllLines(caminho, equipe_txt);
        
            
            
        }

        public List<equipe> LerEquipes()
        {
        List<equipe> listadeEquipes = new List<equipe>();

        //pegar o testo e add na classe

        string[] linhas = File.ReadAllLines(caminho);
        
        //add a classe na lsita

        foreach(string item in linhas)
        {
            string[] linhaEquipe = item.Split(';');

            equipe equipeAtual = new equipe();
            equipeAtual.Idequipe = int.Parse(linhaEquipe[0]);
                equipeAtual = linhaEquipe[1];
            equipeAtual.Imagem = linhaEquipe[2];

            listadeEquipes.Add(equipeAtual);

        }

        //devolver a lista
        return listadeEquipes;
           
        }

        public static implicit operator equipe(string v)
        {
            throw new NotImplementedException();
        }
    }
}
