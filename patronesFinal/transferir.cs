using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesFinal
{
    public interface ITransferir
    {
        float Cantidad { get; set; }
        float OpTransferir(float Saldo);
    }

    public class transferir : ITransferir
    {
        private float cantidad;
        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public float OpTransferir(float Saldo)
        {
            float new_saldo = Saldo - Cantidad;
            return new_saldo;

        }
    }
}
