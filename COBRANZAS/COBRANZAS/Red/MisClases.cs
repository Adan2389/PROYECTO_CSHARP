using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBRANZAS.Red
{
   
    
    
    class TImpresora
    {
        // Atributos de la clase
        String Marca;
        String Modelo;
        String IP;
        bool Encedido;
        int Cant_Pagina_Imp;

        // Constructor
        public TImpresora(String prmMarca, String prmModelo) {
            this.Marca = prmMarca;
            this.Modelo = prmModelo;
            this.Cant_Pagina_Imp = 500;
            this.Encedido = false;
        }

        // Imprimir una cantidad de paguna
        public void Imprimir(int prmCant_Pag_Imp) {
            this.Cant_Pagina_Imp = this.Cant_Pagina_Imp - prmCant_Pag_Imp;
        }

        public bool Encender() {
            this.Encedido = true;
            return true;
        }

        public bool ConectarRed(String prmIp) {
            this.IP = prmIp;
            return true;
        }

        public String Get_info() {

            return $" Marca: {this.Marca}, Modelo: {this.Modelo}, IP: {this.IP}, Encendida: {this.Encedido.ToString()}, Pagina Disponibles: {this.Cant_Pagina_Imp}   ";
        }


    }


    class TComputadora {

        String Marca;
        String Modelo;
        String IP;
        bool Encendido;
        int Disco_Duro;
        String Procesador;
        int Cant_Prog_Instalados;

        public TComputadora(String prmMarca, String prmModelo, int prmDisco, String prmProcesador) {

            this.Cant_Prog_Instalados = 3;
            this.Modelo = prmModelo;
            this.Marca = prmMarca;
            this.Disco_Duro = prmDisco;
            this.Procesador = prmProcesador;
        }


        public bool InstalarProgramas(int prmCantProg) {
            this.Cant_Prog_Instalados = this.Cant_Prog_Instalados + prmCantProg;
            return true;
        }

        public bool Encender()
        {
            this.Encendido = true;
            return true;
        }

        public bool ConectarRed(String prmIp)
        {
            this.IP = prmIp;
            return true;
        }

    }



    class TTelefono {

        String Marca;
        String Modelo;
        String IP;
        bool Encendido;
        int Extension;
        int Cant_Min_Llamadas;

        public TTelefono(String prmMarca, String prmModelo, int prmExtension) {

            this.Modelo = prmModelo;
            this.Marca = prmMarca;
            this.Extension = prmExtension;
        }


        public bool Encender()
        {
            this.Encendido = true;
            return true;
        }

        public bool ConectarRed(String prmIp)
        {
            this.IP = prmIp;
            return true;
        }

        public int LLamar(int pmrCant_Min) {
            this.Cant_Min_Llamadas = this.Cant_Min_Llamadas + pmrCant_Min;
            return 0;
        }
    
    }



}
