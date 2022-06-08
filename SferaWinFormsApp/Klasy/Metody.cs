using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SferaWinFormsApp
{
    public class Best_Void
    {
        
        public Func<int, int, float> Count_Progresbar1 = (row,number_loop) => (number_loop / row * 100f); //Delegaty do obliczania metody

    }

    interface IConneting
    {
        void Conneting();

        string Builder();            

    }
}
