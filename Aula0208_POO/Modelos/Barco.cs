using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("BARCO: Aceleração - Manete para frente");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("BARCO: Frenagem - Manete para trás");
            Velocidade -= 3;
        }
    }
}
