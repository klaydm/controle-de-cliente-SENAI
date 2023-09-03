
namespace ControleDeClientes
{

    class Clientes
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float Imposto { get; protected set; }
        public float Total { get; protected set; }

        public virtual void Pagar_Imposto(float Valor)
        {
            this.Valor = Valor;
            this.Imposto = this.Valor * 0.10F;
            this.Total = this.Valor + this.Imposto;
        }
    }
}

