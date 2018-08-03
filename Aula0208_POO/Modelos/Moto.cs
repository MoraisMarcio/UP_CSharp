using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {       

        public string Cor { get; set; }

        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("MOTO: Aceleração - Manopla de aceleração");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Frenagem - Pedal de freio");
            Velocidade -= 3;
        }
    }
}
