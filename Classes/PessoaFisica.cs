using Interface;

namespace Classes {
    
    public class PessoaFisica : Pessoa, pessoaFisica {

        public string? cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        

        public override float calcularImposto(float rendimento) {
            if (rendimento <= 1500) {
                return 0;
            } else if ((rendimento > 1500) && (rendimento <= 3500)) {
                float resultado = (rendimento / 100) * 2;
                return resultado;
            } else if ((rendimento > 3500) && (rendimento <= 6000)) {
                float resultado = (rendimento / 100) * 3.5f;
                return resultado;
            } else { 
                float resultado = (rendimento / 100) *5;
                return resultado;
            }
        }

        public override float pagarImposto(float rendimento) {
            throw new NotImplementedException();
        }

        public bool validarDataNascimento(DateTime dataNascimento) {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNascimento).TotalDays/365;
            Console.WriteLine(anos);

            if (anos >= 18) {
                return true;
            } else {
                return false;
            }
        }
        public bool validarDataNascimento(string dataNascimento) {
            if (DateTime.TryParse(dataNascimento, out DateTime dataConvertida)) {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                Console.WriteLine(anos);

                if (anos >= 18) {
                    return true;
                } 
            }
            return false;
        }
    }

}
