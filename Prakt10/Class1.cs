using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prakt10
{
    public class RadioValidation : TriggerAction<RadioButton>
    {
        protected override void Invoke(RadioButton sender)
        {
            if (sender.IsChecked == true)
            {
                sender.TextColor = Colors.Green;
            }
            else
            {
                sender.TextColor = Colors.Green;
            }
        }
    }

}
