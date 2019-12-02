using System;
using WebSiteAsi.Models;
using WebSiteASi.Models;
namespace WebSiteASi.Models
{
    public class ReciboCaja
    {
        public int Id{get;set;}
        //llave foranea
        public int Cuenta_ClienteId{get;set;}
        //LLLAVE FORANEA
        public int ContadorId{get;set;}
        public double Monto{get;set;}
        public string Fecha{get;set;}
        //referencia al objeto foraneo
        public Cuenta_Cliente cuentacliente{get;set;}
        public Contador contador{get;set;}
    }
}