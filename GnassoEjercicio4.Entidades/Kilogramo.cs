using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;
using System.Runtime.CompilerServices;

namespace GnassoEjercicio4.Entidades
{
    public class Kilogramo
    {
        private float _peso;

        public static float _equivalenciaConLibra;

        static Kilogramo()
        {
            _equivalenciaConLibra = 0.45359237f;
        }
        public float GetPeso()
        {
            return _peso;
        }

        public Kilogramo( float  peso)
        {
            _peso = peso; 
        }

        public Kilogramo() : this(10)
        {

        }

        public static implicit operator float (Kilogramo kilogramo)
        {
            return kilogramo.GetPeso();
        }

        public static bool operator ==(Kilogramo kilo1, Kilogramo kilo2)
        {
            return kilo1.GetPeso()== kilo2.GetPeso();
        }

        public static bool operator !=(Kilogramo kilo1, Kilogramo kilo2)
        {
            return !(kilo1 == kilo2);

        }


        public static Kilogramo operator +(Kilogramo kilo1, Kilogramo kilo2)
        {
            return new Kilogramo(kilo1.GetPeso() + kilo2.GetPeso());
        }

        public static Kilogramo operator -(Kilogramo kilo1, Kilogramo kilo2)
        {
            return new Kilogramo(kilo1.GetPeso() - kilo2.GetPeso());
        }

        public static explicit operator Libra(Kilogramo kilo1)
        {
            return new Libra(kilo1.GetPeso() * Libra._equivalenciaConKg);
        }



        public static Kilogramo operator +(Kilogramo kilo, Libra libra)
        {
            return kilo + (Kilogramo)libra;
        }
        public static Kilogramo operator -(Kilogramo kilo, Libra libra)
        {
            return kilo - (Kilogramo)libra;
        }


       



    }


//    Crear las clases Kilo y Libra con las siguientes características:
//Cada clase tiene 1 un atributo privado _peso de tipo float.
//Las clases deben tener un método para informar dicho atributo.
//    Deberán tener 2 constructores uno donde se proporciona el valor del atributo _peso y otro sin atributos que por defecto inicializa el atributo en 10.
//Hacer la sobrecarga implícita y explícita entre float y las clases.
//Hacer la sobrecarga explícita entre las clases.
//Sobrecargar los operadores de igualdad en las clases. Los operadores de comparación == compararán los valores de los atributos de las clases.
//Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo en cuenta las siguientes equivalencias:
//1 K = 0.45359237 libras.
//1 L = 2.2046226219 kilos.
//Siempre que se pueda se debe reutilizar código.
//Probar en programa de consola.

}