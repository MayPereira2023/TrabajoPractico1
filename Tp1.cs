using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class Tp1
    {

        public int sumarNumero(int numa, int numb)
        {
            int suma;
            suma = numa + numb;
            return suma;

        }
        public string validarCadena(String cadena)
        {
            //tring cadena;
            //Console.WriteLine("Ejercicio 2 Cortar Cadena");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine(" ");
            //Console.WriteLine("Ingrese una cadena de caracteres de 8 posiciones:");
            //cadena = (Console.ReadLine());
            if (cadena.Length >= 4 && cadena.Length <= 8)
            {
                cadena = cadena.Substring(0, 4);
                //Console.WriteLine(" ");
                //Console.WriteLine("La cadena cortada es : " + cadena); // Esto imprimirá "cadena"
                //Console.ReadLine();
                //DateTime fechaHoraActual = DateTime.Now;
                //Console.WriteLine("Fecha y Hora Actual: " + fechaHoraActual);
                return cadena;
            }
            else
            {
                cadena = "La cadena debe contener entree 4 y menos de 8 carecteres";
                return cadena;

            }
            //public string mostrarFecha() {

            //    DateTime fechaHoraActual = DateTime.Now;
            //    return fechaHoraActual.ToString();

            //}
        }
            public string mostrarColor(int opcion) {

                string colores = "SIN ELECCION";
                            
                switch (opcion)
                {
                    case 1:
                        colores = "Blanco"
                        ; break;
                    case 2:
                        colores = "Azul"
                        ; break;
                    case 3:
                        colores = "Negro"
                        ; break;
                    default:
                         colores ="Seleccion incorrecta";
                        break;
                                       
                }
                  return colores;
            
            }







        }




        }










    
