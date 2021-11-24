using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSetter : MonoBehaviour
{
    Dropdown dropdown;

    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.options.Clear();

        Resolution[] res = Screen.resolutions;
        int length = res.Length;
        for (int i = 0; i < res.Length; i++)
        {
            Dropdown.OptionData data = new Dropdown.OptionData(res[i].ToString());
            dropdown.options.Add(data);
            if (res[i].Equals(Screen.currentResolution))
            {
                dropdown.value = i;
            }
        }
    }

   public void ChangeRes(int value)
    {
        Resolution res = Screen.resolutions[value];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
