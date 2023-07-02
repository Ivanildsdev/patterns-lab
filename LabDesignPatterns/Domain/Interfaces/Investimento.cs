using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDesignPatterns.Domain.Interfaces
{
    public interface Investimento
    {
        double Calcula(Conta conta);
    }
}
