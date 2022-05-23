using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.Entities
{
    public class BindingManager
    {
        public static void GetBingingExpression(FrameworkElement fe, DependencyProperty dp)
        {
            BindingExpression binding = fe.GetBindingExpression(dp);
            binding.UpdateSource();
        }
    }
}
