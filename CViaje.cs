using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_viajes
{
    public class CViaje
    {
        static float costoPorKilometro;
        static uint kilometrajeMinimo;
        private float peaje;
        private uint distanciaRecorida;
        private string dominio;


        public CViaje() { this.dominio = "XX XXX XXX"; }
        public CViaje(string dominio,uint distanciaRecorida)
        {
            this.dominio = dominio;
            this.distanciaRecorida = distanciaRecorida;
        }


        public void setCostoporKilomentro(float costo) { CViaje.costoPorKilometro = costo; }
        public void setKilometrajeMinimo(uint kilometrajes) { CViaje.kilometrajeMinimo= kilometrajes; }
        public void setDominio(string dominio) {  this.dominio = dominio;}

        public float getCostoPorKilometro() { return costoPorKilometro;}
        public uint getKilometrajeMinimo() { return CViaje.kilometrajeMinimo; }
        public uint getDistanciaRecorida() {  return distanciaRecorida;}
        public string getDominio() {  return this.dominio;}

        public uint Kilometraje
        {
            get => distanciaRecorida;
            set => distanciaRecorida = value;
        }


        public float DarCosto()
        {
            if(distanciaRecorida < kilometrajeMinimo)
            {
                return kilometrajeMinimo * costoPorKilometro;
            }

            return distanciaRecorida* costoPorKilometro;
        }

        public float DarCosto( float peaje)
        {
            return DarCosto()*peaje;
        }

        public int MayorViaje(CViaje otro)
        {
            int mayor = (int)(this.distanciaRecorida - otro.getDistanciaRecorida());

            if(mayor < 0) { return -1; }
            else if(mayor == 0) { return 0; }


              return 1; 
        }
        public string DarDatos()
        {
            return "\n Dominio :" + this.dominio + "\n Costo por Kilometro :"+ CViaje.costoPorKilometro + "\n Distancia Recorida :" + this.distanciaRecorida +"\n Kilomentraje minima minima :" + CViaje.kilometrajeMinimo;
        }
    }
}
