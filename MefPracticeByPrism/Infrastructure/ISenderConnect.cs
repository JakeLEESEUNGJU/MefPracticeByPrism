using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface ISendConnect
    {
        event EventHandler SendConnect;

        ConnectionState connectionState
        {
            get; set;
        }
    }
}
