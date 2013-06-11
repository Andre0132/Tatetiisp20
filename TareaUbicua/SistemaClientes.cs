using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    public class SistemaClientes
    {
        //Incorporar como una propiedad de arraylist
        ArrayList clientes = new ArrayList();
        public SistemaClientes()
        {
            Console.WriteLine("Cargando el Sistema Cliente");
        }
        public void Iniciar()
        {
            Menu();
        }
        private void ListarClientes()
        {
            foreach (Cliente cli in clientes)
            {
                cli.Listar();
            }
        }
        private void BorraCliente(int id_borrar)
        {
            foreach (Cliente cli in clientes)
            {
                if (cli.codigo == id_borrar)
                {
                    clientes.Remove(cli);
                    break;
                }
            }
        }
        public void Menu()
        {
            int opcion = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CARGA DE CLIENTES");
                Console.WriteLine("1_Cargar un nuevo Cliente");
                Console.WriteLine("2_Listar los Clientes cargados");
                Console.WriteLine("3_Borrar un cliente");
                Console.WriteLine("4_Salir");
                Console.WriteLine("Ingrese el numero de la opcion");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error en la opcion ingresada");
                }
                switch (opcion)
                {
                    case 1:
                        Cliente cliente = new Cliente();
                        cliente.CapturarDatos();
                        clientes.Add(cliente);
                        break;
                    case 2:
                        ListarClientes();
                        Console.ReadLine();
                        break;
                    case 3:                       
                        ListarClientes();
                        Console.Write("Ingrese el número del cliente a borrar:");
                        int eliminar_cliente = Convert.ToInt32(Console.ReadLine());
                        BorraCliente(eliminar_cliente);
                        ListarClientes();
                        Console.ReadLine();
                        break; 
                    case 4:
                        return;
                }               
            }
        }
    }
}
