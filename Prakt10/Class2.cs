using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt10
{
    public class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int number;
            if (Int32.TryParse(sender.Text, out number) == false)
            {
                sender.TextColor = Colors.Green;
            }
            else
            {
                sender.TextColor = Colors.Red;
            }
        }
    }
}
