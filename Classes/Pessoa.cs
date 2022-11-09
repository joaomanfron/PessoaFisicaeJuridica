using Interface;

namespace Classes {
    public abstract class Pessoa : IPessoa {
        
        public string? nome {get; set;}

        public float rendimento { get; set; }

        public EnderecoFinal? endereco { get; set; }

        public abstract float calcularImposto(float rendimento);

        public abstract float pagarImposto(float rendimento);
        
    }
    
}