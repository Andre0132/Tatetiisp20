using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   

        public class Cliente
        {
            private string nombre, apellido, direccion, localidad, telefono;
            public int codigo;
            private DateTime FechaNac;

            private void CapturarNombre()
            {
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                if (nombre == "")
                {
                    Console.WriteLine("Error al ingresar su nombre. Ingreselo nuevamente");
                    CapturarNombre();
                }
            }

            private void CapturarApellido()
            {
                Console.Write("Ingrese su apellido: ");
                apellido = Console.ReadLine();
                if (apellido == "")
                {
                    Console.WriteLine("Error al ingresar su apellido. Ingreselo nuevamente");
                    CapturarApellido();
                }        
            }

            private void CapturarDireccion()
            {
                Console.Write("Ingrese su dirección: ");
                direccion = Console.ReadLine();
                if (direccion == "")
                {
                    Console.WriteLine("Error al ingresar su direccion. Ingreselo nuevamente");
                    CapturarDireccion();
                }
            }

            private void CapturarLocalidad()
            {
                Console.Write("Ingrese su localidad: ");
                localidad = Console.ReadLine();
                if (localidad == "")
                {
                    Console.WriteLine("Error al ingresar su localidad. Ingreselo nuevamente");
                    CapturarLocalidad();
                }
            }
              
            private void CapturarTelefono()
            {
                Console.Write("Ingrese su teléfono: ");
                telefono = Console.ReadLine();
                if (telefono == "")
                {
                    Console.WriteLine("Error al ingresar su nùmero Telefono. Ingreselo nuevamente");
                    CapturarTelefono();
                }
                
            }

            private void CapturarCodigo()
            {
                Console.Write("Ingrese su Codigo: ");
                //INTENTA convertir a int lo q escribe el usuario
                try
                {
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                 //si la conversion fallo vuelve a llamar al metodo
                catch
                {
                    Console.WriteLine("Error al ingresar su codigo. intente nuevamente");
                    CapturarCodigo();
                }
            }
            private void CapturarFechaNac()
            {
                Console.Write("Ingrese su Fecha de Nacimiento: ");
                try
                {
                    FechaNac = Convert.ToDateTime(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Error al ingresar la fecha de nac. intente nuevamente");
                    CapturarFechaNac();
                }
            }

            public string ImprimirFicha()
            {
                string ficha="FICHA PERSONAL CLIENTE";
                ficha += "\nCodigo: " + codigo;
                ficha+="\nNombre: " + nombre;
                ficha+="\nApellido: " + apellido;
                ficha+="\nDireccion: " + direccion;
                ficha+="\nLocalidad: " + localidad;
                ficha+="\nTelefono: " + telefono;
                ficha += "\nFecha de nacimiento: " + FechaNac.ToShortDateString();
                return ficha;
            }

            public void CapturarDatos()
            {
                CapturarCodigo();
                CapturarNombre();
                CapturarApellido();
                CapturarDireccion();
                CapturarLocalidad();
                CapturarTelefono();
                CapturarFechaNac();
            }

            private string Presentarse()
            {
                string presentacion = "Hola Soy: " + nombre + " " + apellido;
                return presentacion;
            }
            public void Listar()
            {
                //imprimimos en un renglon los datos del cliente
                Console.WriteLine( "|{0}|{1}|{2}|{3}|{4}|",codigo,nombre,apellido,direccion,localidad);
                
            }

            private string AnunciarDomicilio()
            {
                string anunciar = "Vivo en: " + direccion + " - " + localidad;
                return anunciar;
            }
            public string AnunciarEdad()
            {
                //calculamos la edad y la mostramos en un string
                int edad;
                DateTime hoy = DateTime.Now;
                edad = hoy.Year - FechaNac.Year;
                string MiEdad = ("Nací en el año " + FechaNac.Year + " y tengo " + edad + " años de edad");
                return MiEdad;

            }
            public void Hablar()
            {
                Console.WriteLine (Presentarse());
                Console.WriteLine (AnunciarDomicilio());
                Console.WriteLine (AnunciarEdad());
            }
        }
    }

