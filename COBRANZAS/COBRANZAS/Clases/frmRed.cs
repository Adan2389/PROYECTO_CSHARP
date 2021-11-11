using System;
using COBRANZAS.Red;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS.Clases
{
    public partial class frmRed : Form
    {
        public frmRed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TImpresora objImpresora1 = new TImpresora("CANON", "MP280");
            TImpresora objConon2 = new TImpresora("CANON", "MP270");
            TImpresora objNuevaImpresora = new TImpresora("HP", "TX-900");

            TComputadora objCompu1 = new TComputadora("DELL", "Optiplex", 500, "i5 8va Gen");
            TComputadora objCompu2 = new TComputadora("HP", "LL-50", 1000, "i3 7va Gen");

            TTelefono objTel1 = new TTelefono("GRANDSTREAM", "DP750");
            TTelefono objTel2 = new TTelefono("MOTOROLA", "S3000");

            
            
            List<TDispositivo> ListaObjetos = new List<TDispositivo>();

            ListaObjetos.Add(objImpresora1);
            ListaObjetos.Add(objConon2);
            ListaObjetos.Add(objNuevaImpresora);

            ListaObjetos.Add(objCompu1);
            ListaObjetos.Add(objCompu2);

            ListaObjetos.Add(objTel1);
            ListaObjetos.Add(objTel2);


            int i = 10;
            foreach (var DispositivoX in ListaObjetos) {
                DispositivoX.ConectarRed("192.168.2." + i.ToString());
                i++;
                DispositivoX.Encender();
                lstagregar.Items.Add(DispositivoX.Get_info());

            }





        }
    }
}
