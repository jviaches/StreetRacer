using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Cars
{
    public interface ICar
    {
        int Id { get; }
        string Name { get; }
        float TopSpeed { get; }
        float Cost { get; }
        float Durability { get; }
    }
}
