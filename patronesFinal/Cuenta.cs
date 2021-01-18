using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesFinal
{
    public interface ICuenta
    {
        float Saldo { get; set; }
        string NombreE { get; set; }
        string NombreM { get; set; }
    }
    public class Cuenta : ICuenta
    {
        private float saldo = 2500;

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private string nombreE = "Esdras";

        public string NombreE
        {
            get { return nombreE; }
            set { nombreE = value; }
        }

        private string nombreM = "Manuel";
        public string NombreM
        {
            get { return nombreM; }
            set { nombreM = value; }
        }
    }
}
