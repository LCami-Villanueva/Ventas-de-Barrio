namespace ex03_VentasBarrio
{
    public class Pedido//proxima preuba
    {
        //Atributos
        private string barrio;
        private int cantidadGalletas;

        //Constructor
        public Pedido()
        {
            barrio = "";
            cantidadGalletas = 0;
        }

        //Propiedades
        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public int CantidadGalletas
        {
            get { return cantidadGalletas; }
            set { cantidadGalletas = value; }
        }
    }
}