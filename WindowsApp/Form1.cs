using Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Producto guitarra = new Producto()
            {

                Nombre = "Guitarra",
                Descripcion = "Esta guitarra es una bomba",
                PrecioCosto = 2000,
                Margen = 300.6,
                IVA = 0.21,
                Proveedor = "Samuel Tribulo",
                Categoria = "Instrumentos de cuerda",
                SubCategoria = "Guitarras",
            };

            ClienteIndividuo juan = new ClienteIndividuo()
            {
                Nombre = "Juan",
                Apellido = "Carlos",
                CUIT = "20-40278279-5",
                Email = "emailfalso@hotmail.com",
                Telefono = "1112345678",
                Direccion = "Calle Falsa 123"
            };

            MessageBox.Show(
                $"Producto: ${guitarra.Nombre}" +
                $"\nDescripcion: {guitarra.Descripcion}\n" +
                $"Precio de costo: {guitarra.PrecioCosto}\n" +
                $"Margen: {guitarra.Margen}\n" +
                $"IVA: {guitarra.IVA}\n" +
                $"Precio bruto: {guitarra.PrecioBruto}\n" +
                $"Precio venta: {guitarra.PrecioVenta}\n" +
                $"Proveedor: {guitarra.Proveedor}\n" +
                $"Categoria: {guitarra.Categoria}\n" +
                $"Subcategoria: {guitarra.SubCategoria}\n\n" +
                $"Cliente: {juan.Nombre} {juan.Apellido}\n" +
                $"CUIT: {juan.CUIT}\n" +
                $"Email: {juan.Email}\n" +
                $"Telefono: {juan.Telefono}\n" +
                $"Direccion: {juan.Direccion}"
                );
        }
    }
}