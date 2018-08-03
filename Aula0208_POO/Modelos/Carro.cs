using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Carro : Veiculo, IMotorizado
    {    
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("CARRO: Aceleração - Pedal acelerador");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("CARRO: Frenagem - Pedal freio");
            Velocidade -= 3;
        }
    }
}
