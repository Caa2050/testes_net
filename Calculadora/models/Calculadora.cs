using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;
        public Calculadora(string data){
            listahistorico = new List<string>();
            this.data = data;
        }
        public int somar(int n1, int n2){
            
            int res = n1 + n2;
            listahistorico.Add($"soma :  {n1} + {n2} = {res} + data {data}");
            return res;
        }
        public int subtrair(int n1, int n2){
            int res = n1 - n2;
            listahistorico.Add($"subtrair :  {n1} - {n2} = {res} + data {data}");
            return res;

        }
        public int multiplicar(int n1, int n2){
            int res = n1 * n2;
            listahistorico.Add($"Multiplicar :  {n1} x {n2} = {res} + data {data}");

            return res;
        }
        public int dividir(int n1, int n2){
            int res = n1 / n2;
            listahistorico.Add($"Dividir :  {n1} / {n2} = {res} + data {data}");

            return res;
        }

        public List<string> historico(){

            listahistorico.RemoveRange(3,listahistorico.Count - 3);
            return listahistorico;
        }
    }
}