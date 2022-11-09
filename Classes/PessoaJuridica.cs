using System.Text.RegularExpressions;
using Backend;
using Interface;

namespace Classes {
    
    public class PessoaJuridica : Pessoa, pessoaJuridica {

        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }
        

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";



        public override float calcularImposto(float rendimento) {
            if (rendimento <= 3000) {
                return rendimento * 0.03f;
            } else if ((rendimento > 3000) && (rendimento <= 6000)) {
                return rendimento * 0.03f;
            } else if ((rendimento > 6000) && (rendimento <= 10000)) {
                return rendimento * 0.07f;
            } else { 
                return rendimento * 0.09f;
            }
        }

        public override float pagarImposto(float rendimento) {
            throw new NotImplementedException();
        }

        internal void validarCnpj() {
            throw new NotImplementedException();
        }
        public bool validarCnpj (string cnpj) {
            bool retornoCnpjValidacao = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");
            
            if (retornoCnpjValidacao) {
                string substringCnpj14 = cnpj.Substring(8, 4);
                if (substringCnpj14 == "0001") {
                    return true;
                }
        
            }
            string substringCnpj18 = cnpj.Substring(11, 4);

            if (substringCnpj18 == "0001") {
                return true;
            }
            return false;
         }


        public void Inserir (PessoaJuridica pj) {
            Utils.VerificarPastaArquivo(caminho);
            string[] pjValores = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};
            File.AppendAllLines(caminho, pjValores);           
        }

        public List<PessoaJuridica> LerArquivo() {
            List<PessoaJuridica> listPj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
           
            string[] atributos = cadaLinha.Split(",");   
            PessoaJuridica CadaPj = new PessoaJuridica();
             CadaPj.nome = atributos[0];
             CadaPj.cnpj = atributos[1];
             CadaPj.razaoSocial = atributos[2];

             listPj.Add(CadaPj);
            }
        return listPj;
            

            

        }
    }
}