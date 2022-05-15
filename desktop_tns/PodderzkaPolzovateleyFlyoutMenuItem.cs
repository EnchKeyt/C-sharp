using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Telecom_Neva_Svyaz
{
    public class PodderzkaPolzovateleyFlyoutMenuItem
    {
        public PodderzkaPolzovateleyFlyoutMenuItem()
        {
            TargetType = typeof(PodderzkaPolzovateleyFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}