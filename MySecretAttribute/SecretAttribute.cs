using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecretAttribute
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class SecretAttribute : Attribute
    {       
        public SecretAttribute() { }
    }
}
