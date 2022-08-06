using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_PulasthiBethmage.View
{
    public interface IPaymentView
    {
        ///Lables
        string EmpFirstNameLabel { get; set; }
        string EmpLastNameLabel { get; set; }
        string EmpContactNoLabel { get; set; }
        string EmpAmountPaidLabel { get; set; }
        string EmpPointsLabel { get; set; }

        ///Text Boxes
        string EmpFirstNameTextBox { get; set; }
        string EmpLastNameTextBox { get; set; }
        string EmContactNoTextBox { get; set; }
        string EmpAmountPaidTextBox { get; set; }
        
    }
}
