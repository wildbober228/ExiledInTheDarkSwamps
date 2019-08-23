using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Interface
{
    interface IParseText
    {
        int Parse_Count(ref int current_army_count, string n_parse);
    }
}
