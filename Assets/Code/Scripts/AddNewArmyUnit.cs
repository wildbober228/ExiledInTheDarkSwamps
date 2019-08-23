using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class AddNewArmyUnit : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _count_army;
    
    int Parse_Count(ref int current_army_count)
    {
        string need_to_parse = _count_army.text;
        string max_army_count ="";
        string current_army_count_s = "";
        int help = 1000;
        for (int i = 0; i < need_to_parse.Length; i++)
        {
            if(need_to_parse[i] == '/')
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

    public void AddUnityToAllArmy()
    {
        int current = 0;
        int max = Parse_Count(ref current);
        _count_army.text = current+1 +"/"+ max;
        Debug.Log("Army = "+_count_army);
    }
}
