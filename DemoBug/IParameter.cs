using System;
using System.Security.Cryptography.X509Certificates;

namespace DemoBug
{
    public interface IParameter
    {
        string Text { get; set; }

        int Int { get; set; }

        double Point { get; set; }
    }
}
