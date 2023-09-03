namespace ControleDeClientes
{
    internal class Pessoa_Juridica : Clientes
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void Pagar_Imposto(float Valor)
        {
            this.Valor = Valor;
            this.Imposto = this.Valor * 0.20F;
            this.Total = this.Valor + this.Imposto;
        }
    }
}
