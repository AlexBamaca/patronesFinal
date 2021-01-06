using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesFinal
{
    class Cuenta
    {
        float saldo = 2500;

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        string nombreE = "Esdras";

        public string NombreE
        {
            get { return nombreE; }
            set { nombreE = value; }
        }

        string nombreM = "Manuel";
        public string NombreM
        {
            get { return nombreM; }
            set { nombreM = value; }
        }

        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
    }
}
