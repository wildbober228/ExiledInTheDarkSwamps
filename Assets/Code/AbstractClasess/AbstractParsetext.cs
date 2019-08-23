using UnityEngine;
using System.Collections;

public class AbstractParsetext : MonoBehaviour
{
    public static int Parse_Count(ref int current_army_count, string n_parse)
    {
        string need_to_parse = n_parse;
        string max_army_count = "";
        string current_army_count_s = "";
        int help = 1000;
        for (int i = 0; i < need_to_parse.Length; i++)
        {
            if (need_to_parse[i] == '/')
            {
                help = i;
            }
            if (i > help)
            {
                max_army_count += need_to_parse[i];
            }
            else if (i < help)
            {
                current_army_count_s += need_to_parse[i];
            }
        }
        current_army_count = System.Int32.Parse(current_army_count_s);
        return System.Int32.Parse(max_army_count);
    }
}
