using System.Collections.Generic;

namespace Inheritance
{
    public interface ILearner
    {
        List<string> Knowledge { get; }
        void Learn(string lesson);
    }
}