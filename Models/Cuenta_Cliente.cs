using System;
using WebSiteAsi.Models;
namespace WebSiteASi.Models
{
    public class Cuenta_Cliente
    {
        public int Id{get;set;}
        public double saldo{get;set;}
        public int ClienteId{get;set;}
        //referencia al objeto Cliente
        public Cliente cliente{get;set;}
    }
}