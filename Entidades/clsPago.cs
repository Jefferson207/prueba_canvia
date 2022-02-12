using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsPago
    {
        private int _id_persona;
        private DateTime _fecha_pago;
        private decimal _monto;
        private string _estado;

        public clsPago (int id_persona, DateTime fecha_pago, decimal monto, string estado)
        {
            _id_persona = id_persona;
            _fecha_pago = fecha_pago;
            _monto= monto;
            _estado = estado;
        }
        public int id_persona
        {
            get { return _id_persona; }
            set { _id_persona = value; }
        }
        public DateTime fecha_pago
        {
            get { return _fecha_pago; }
            set { _fecha_pago = value; }
        }
        public decimal monto
        {
            get { return _monto; }
            set { _monto= value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        
    }
}
