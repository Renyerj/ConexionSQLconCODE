using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//Improtamos nuestro modelo de dato para crear la BD con todas las entidades espesificadas
using DataModel;

namespace BDGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de BdModel quien contiene la conexion con la BD y donde espesificamos 
            //el nombre de la BD a crear
            using (var db = new BdModel())
            {
                Console.WriteLine("PRECIONE ENTER PARA CREAR LA BD...!!!");
                Console.ReadKey();

                try
                {
                    //Si no existe la BD mandarla a crear
                    db.Database.CreateIfNotExists();
                }
                catch (Exception e)
                {//Presentar errores de compilacion
                    Console.WriteLine(e.ToString());
                }

                finally
                {
                    Console.WriteLine("[Proceso finalizado]");
                    Console.ReadKey();
                }
            }
        }
    }
}
