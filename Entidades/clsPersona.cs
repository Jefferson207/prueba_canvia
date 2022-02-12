using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class clsPersona
    {
        private int _IdPersona;
        private string _nombres;
        private string _apellidos;
        private int _dni;
        private DateTime _fecha_nacimiento;
        private int _telefono;
        private string _email;
        private string _sexo;

        public clsPersona(int IdPersona, string nombres, string apellidos, int dni, DateTime fecha_nacimiento, int telefono, string email, string sexo)
        {
            _IdPersona = IdPersona;
            _nombres = nombres;
            _apellidos = apellidos;
            _dni = dni;
            _fecha_nacimiento = fecha_nacimiento;
            _telefono = telefono;
            _email = email;
            _sexo = sexo;
        }
        public clsPersona(string nombres, string apellidos, int dni, DateTime fecha_nacimiento, int telefono, string email, string sexo)
        {
            _nombres =nombres;
            _apellidos = apellidos;
            _dni = dni;
            _fecha_nacimiento = fecha_nacimiento;
            _telefono = telefono;
            _email = email;
            _sexo = sexo;
        }

        public int idpersona
        {
            get { return _IdPersona; }
            set { _IdPersona = value; }
        }
        public string nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public DateTime fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }
        public int telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
    }
}
