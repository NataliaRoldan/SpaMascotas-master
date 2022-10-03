using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaMascotas
{
    internal class Spa
    {
        public string Propietario { get => propietario; set => propietario = value; }
        public double identificacion { get; set; }
        public string mascota { get; set; }
        public string estrato { get; set; }
        public double DescuentoEstrato12 = 15;
        public double DescuentoEstrato34 = 10;
        public double DescuentoEstrato5 = 5;
        public double descuento;
        public double totalValor;
        public double valorServicio1 = 45000;
        public double valorServicio2 = 80000;
        public double valorServicio3 = 100000;
        private string propietario;

        public void setpagoservicio1()
       {
           if (estrato == "1-2")
            {
                descuento = (valorServicio1 * DescuentoEstrato12) / 100;
                totalValor = valorServicio1 - descuento;
           }
            if (estrato== "3-4")
            {
                descuento = (valorServicio1 * DescuentoEstrato34) / 100;
                totalValor = valorServicio1 - descuento;
            }
            if (estrato == "5-6")
            {
                descuento = (valorServicio1 * DescuentoEstrato5) / 100;
                totalValor = valorServicio1 - descuento;
            }
        }
        public void setpagoservicio2()
        {
            if (estrato == "1-2")
            {
                descuento = (valorServicio2 * DescuentoEstrato12) / 100;
                totalValor = valorServicio2 - descuento;
            }
            if (estrato =="3-4")
            {
                descuento = (valorServicio2 * DescuentoEstrato34) / 100;
                totalValor = valorServicio2 - descuento;
            }
            if (estrato =="5-6")
            {
                descuento = (valorServicio2 * DescuentoEstrato5) / 100;
                totalValor = valorServicio2 - descuento;
            }
        }
        public void setpagoservicio3()
        {
            if (estrato == "5-6")
            {
                descuento = (valorServicio3 * DescuentoEstrato12) / 100;
                totalValor = valorServicio3 - descuento;
            }
            if (estrato == "3-4")
            {
                descuento = (valorServicio3 * DescuentoEstrato34) / 100;
                totalValor = valorServicio3 - descuento;
            }
            if (estrato=="5-6")
            {
                descuento = (valorServicio3 * DescuentoEstrato5) / 100;
                totalValor = valorServicio3 - descuento;
            }
        }
        public double gettotalvalor()
        {
            return totalValor;
        }
    }
}
