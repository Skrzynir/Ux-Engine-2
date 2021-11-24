using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QualitySetter : MonoBehaviour
{
    Dropdown dropdown;
    
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.options.Clear();
        string[] qualityLevels = QualitySettings.names;

        for (int i = 0; i<qualityLevels.Length; i++)
        {
            Dropdown.OptionData data = new Dropdown.OptionData(qualityLevels[i]);
            dropdown.options.Add(data);
        }
        dropdown.value = QualitySettings.GetQualityLevel();
    }

    public void ChangeQuality(int value)
    {
        QualitySettings.SetQualityLevel(value);
    }
    
}
