using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Dtos
{
    internal class CuentaDto
    {
        //Atributos
        long id; //pk
        string isban = "aaaaa";
        long swift = 1111111;
        string FchaAlta = "9999/12/31";
        string FchaBaja = "9999/12/31";

        //constructor
        public CuentaDto(long id, string isban, long swift, string fchaAlta1)
        {
            Id = id;
            Isban = isban;
            Swift = swift;
            FchaAlta1 = fchaAlta1;
        }

        //get y set
        public long Id { get => id; set => id = value; }
        public string Isban { get => isban; set => isban = value; }
        public long Swift { get => swift; set => swift = value; }
        public string FchaAlta1 { get => FchaAlta; set => FchaAlta = value; }
        public string FchaBaja1 { get => FchaBaja; set => FchaBaja = value; }

        //constuctor
        public CuentaDto() { 
        }


        //to string
        override

        public string ToString()
        {
            string clienteString = "id: " + this.Id
                + "isban: " + this.Isban
                + "swift: " + this.swift
                + "fechaAlta: " + this.FchaAlta1
                + "fechaBaja: " + this.FchaBaja1;
            return clienteString;

        }
    }
}
