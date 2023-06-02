using System;

namespace LogicaNegocio
{
    public class ClsPromedio
    {
        private string condicion;
        private string color;
        private double promedio;
        
        public ClsPromedio()
        {
           
        }

        public Double CalcularPromedio(int suma, int cantidadNotas)
        {
            double prom = suma / cantidadNotas;
            return prom;
        }

        public string CondicionPromedio(double promedio)
        {
            string color;

            if (promedio >= 70)
            {
                
                color = "green";
            }
            else
            {
                
                color = "red";
            }

            
            return color;
        } 
    }
}
