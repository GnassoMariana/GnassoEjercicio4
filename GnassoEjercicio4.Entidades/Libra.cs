using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnassoEjercicio4.Entidades
{
    public class Libra
    {
        private float _peso;

        public static float _equivalenciaConKg;
        
        static Libra()
        {
            _equivalenciaConKg = 2.2046226219f;
        }
        public float GetPeso()
        {
            return _peso;
        }

        public Libra(float peso)
        {
            _peso = peso;
        }

        public Libra() : this(10)
        {

        }

        public static implicit operator float(Libra libra)
        {
            return libra.GetPeso();
        }

        public static bool operator ==(Libra libra1, Libra libra2)
        {
            return libra1.GetPeso() == libra2.GetPeso();
        }

        public static bool operator !=(Libra libra1, Libra libra2)
        {
            return !(libra1 == libra2);
        }


        public static explicit operator Kilogramo(Libra libra)
        {
            return new Kilogramo(libra.GetPeso() * Kilogramo._equivalenciaConLibra);
        }

       

        
    }
}
