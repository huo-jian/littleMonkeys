using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique_EONIX
{
    /// <summary>
    /// Interface pattern Observer (Publisher)
    /// </summary>
    public interface IMonkey
    {
        void Attach(ISpectator observer);
        void Detach(ISpectator observer);
        void Notify();
    }
}
