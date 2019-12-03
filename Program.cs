using System;
using System.IO;
using System.Collections.Generic;
namespace creadir
{
    class Producto 
    {
        public string codigo;
        public string descripcion;
        public double precio;

        public Producto(string c,string d,double p)
        {
            codigo = c; descripcion = d; precio = p;
        }
    }

    class ProductoArchivo
    {
        public static void EscribeProductosBIN(string archivo, List<Producto> productos)
        {
            FileStream fs = new FileStream(archivo,FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);
            foreach(Producto p in productos)
            {
                binOut.Write(p.codigo);
                binOut.Write(p.descripcion);
                binOut.Write(p.precio);
            }

            binOut.Close();
        }

        public static void EscribeProductosTXT(string archivo, List<Producto> productos)
        {
            FileStream fs = new FileStream(archivo,FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}",p.codigo,p.descripcion,p.precio);

            }
            txtOut.Close();
        }

        public static List<Producto> LeeProductosBIN(string archivo)
        {
            List<Producto> productos = new List<Producto>();
            FileStream 
            using( StreamReader sr = new StreamReader(archivo))
            {

                while(binIn.PeakChar() != 1 ) // No llegaremos al dinal del archivo
              {
                   Producto producto = new Producto();
                   producto.codigo = binIn.ReadString();
                   producto.descripcion = binIn.ReadString();
                   producto.precio = binIn.ReadDouble();

                   productos.Add( producto );
              }

            }
            return productos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW","Lapiz Azul w2", 12.23d));
            productos.Add(new Producto("AQW","Lapiz  Verdew2", 12.23d));
            productos.Add(new Producto("AQW","Pluma Azul w2", 22.23d));
            productos.Add(new Producto("AQW","Borrador Azul w2", 22.23d));

            ProductoArchivo.EscribeProductosBIN(@"productos.bin", productos);

            Console.WriteLine("Archivo Grabado");
            Console.ReadKey();

            List<Producto> productos_leidos = ProductoArchivo.LeeProductosBIN();
            FileStream 
            using( StreamReader sr = new StreamReader(archivo))
            {

                while(binIn.PeakChar() != 1 ) // No llegaremos al dinal del archivo
              {

                /*foreach(Producto p in productos)
                {

                Console.WriteLine("{0} {1} {2}",p.codigo,p.descripcion,p.precio);

                }*/

           // Streamdriter txtOut = new Streamdriter()


            /*
            Console.WriteLine("Captura el folder a ocultar ");
            string archivos = Console.ReadLine();
            File.SetAttributes(archivo, FileAttributes.Hidden);
            */


            //Directory.Delete(directorio, true); archivo a eliminar
           /* if(Directory.Exists(directorio)) 
            {
                Console.WriteLine("Ya existe ");
            }
            else 
            {
                Directory.CreateDirectory(directorio);
            }*/

        }
    }
}
