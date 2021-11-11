using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBRANZAS.Red
{

    public class TDispositivo {

        // Atributos de la clase
       protected String Marca;
       protected String Modelo;
       protected String IP;
       protected bool Encedido;

        public TDispositivo(String prmMarca, String prmModelo) {
            this.Marca = prmMarca;
            this.Modelo = prmModelo;
        }

        public bool Encender()
        {
            this.Encedido = true;
            return true;
        }

        public bool ConectarRed(String prmIp)
        {
            this.IP = prmIp;
            return true;
        }

        public virtual String Get_info()
        {

            return $" Marca: {this.Marca}, Modelo: {this.Modelo}, IP: {this.IP}, Encendida: {this.Encedido.ToString()} ";
        }
    }

    
    
    public class TImpresora : TDispositivo
    {
        int Cant_Pagina_Imp;

        // Constructor
        public TImpresora(String prmMarca, String prmModelo): base(prmMarca, prmModelo) {
            this.Cant_Pagina_Imp = 500;
        }

        // Imprimir una cantidad de paguna
        public void Imprimir(int prmCant_Pag_Imp) {
            this.Cant_Pagina_Imp = this.Cant_Pagina_Imp - prmCant_Pag_Imp;
        }

        public override String Get_info () {

            return base.Get_info() + "Cant. Paginas: "+this.Cant_Pagina_Imp.ToString();
        }

    }


    public class TComputadora: TDispositivo {
       
        int Disco_Duro;
        String Procesador;
        int Cant_Prog_Instalados;

        public TComputadora(String prmMarca, String prmModelo, int prmDisco, String prmProcesador) : base (prmMarca, prmModelo) {
            this.Cant_Prog_Instalados = 3;
            this.Disco_Duro = prmDisco;
            this.Procesador = prmProcesador;
        }

        public bool InstalarProgramas(int prmCantProg) {
            this.Cant_Prog_Instalados = this.Cant_Prog_Instalados + prmCantProg;
            return true;
        }

        public override String Get_info()
        {
            return $" Marca: {this.Marca}, Modelo: {this.Modelo}, IP: {this.IP}, Encendida: {this.Encedido.ToString()} Disco: {this.Disco_Duro}, Procesdor: {this.Procesador} ";
        }
    }


    public class TTelefono : TDispositivo {

        int Extension;
        int Cant_Min_Llamadas;

        public TTelefono(String prmMarca, String prmModelo): base (prmMarca, prmModelo) {
        }

        public void Configurar(int prmExtension) { 
            this.Extension = prmExtension;
        }

        public int LLamar(int pmrCant_Min) {
            this.Cant_Min_Llamadas = this.Cant_Min_Llamadas + pmrCant_Min;
            return 0;
        }

        public override String Get_info() => base.Get_info()+$"Extension: {this.Extension}, Minitos: {this.Cant_Min_Llamadas} ";
        

    }



}
