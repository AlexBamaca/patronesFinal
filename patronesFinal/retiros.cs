using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patronesFinal
{
    public interface IRetiros
    {
        float CantRetiro { get; set; }

        float RetOperacion(float S);
    }
    public class retiros : IRetiros
    {
        private float cantRetiro;
        public float CantRetiro
        {
            get { return cantRetiro; }
            set { cantRetiro = value; }
        }

        public float RetOperacion(float S)
        {
            //Cuenta S = new Cuenta();
            float new_saldo = S - CantRetiro;
            return new_saldo;
        }
    }
}
