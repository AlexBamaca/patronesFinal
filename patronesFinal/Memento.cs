using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesFinal
{
    public interface IDatos
    {
        string NTarjeta { get; set; }
        string Cantidad { get; set; }
        string Concepto { get; set; }
    }
    public class Memento : IDatos
    {
        private string ntarjeta;
        public string NTarjeta
        {
            get { return ntarjeta; }
            set { ntarjeta = value; }
        }
        private string cantidad;
        public string Cantidad 
        { 
            get { return cantidad; }
            set { cantidad = value; }
        }
        private string concepto;
        public string Concepto 
        {
            get { return concepto; }
            set { concepto = value; }
        }

        private MementoCopia copia = new MementoCopia();
        public MementoCopia Copia
        {
            get 
            { 
                return copia; 
            }
            set 
            { 
                copia = value; 
            }
            
        }

        public void Revertir()
        {
            this.NTarjeta = Copia.NTarjeta;
            this.Cantidad = Copia.Cantidad;
            this.Concepto = Copia.Concepto;
        }
        public Boolean IsModified()
        {
            return !(this.NTarjeta.Equals(Copia.NTarjeta) && this.Cantidad.Equals(Copia.Cantidad) && this.Concepto.Equals(Copia.Concepto));
        }
    }

    public class MementoCopia : IDatos
    {
        private string ntarjeta;
        public string NTarjeta
        {
            get { return ntarjeta; }
            set { ntarjeta = value; }
        }
        private string cantidad;
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private string concepto;
        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
    }
}
