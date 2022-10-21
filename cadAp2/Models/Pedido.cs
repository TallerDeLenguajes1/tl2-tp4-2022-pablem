namespace cadAp2.Models
{
    public class Pedido
    {
        static private int pedidosRealizados = 0;

        int nro;
        string obs;
        EstadoPedido estado;
        Cliente cliente;

        //Constructor
        public Pedido(string nomb, string dire, string tel, string refe, string obs)
        {
            this.nro = ++pedidosRealizados;
            this.obs = obs;
            this.estado = EstadoPedido.Pendiente;
            this.cliente = new Cliente(nomb,dire,tel,refe);
        }

        //Getters & Setters
        public int Nro { get => nro; set => nro = value; }
        public string Obs { get => obs; set => obs = value; }
        public EstadoPedido Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public void mostrar()
        {
            Console.WriteLine("+ Pedido: {0} - Cliente: {1} - Estado: {2}", nro, cliente.Nombre, estado);
        }
    }
}