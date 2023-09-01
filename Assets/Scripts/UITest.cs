using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    //public GameObject MusicVolSlider;
    public Slider musicVolSlider;
    public GameObject settingsPanel;
    private void Start()
    {
        //print(MusicVolSlider.GetComponent<Slider>().value);
        print(musicVolSlider.value);
    }
    public void OnClick_SettingsButton()
    {
        if (settingsPanel.activeInHierarchy)
        {
            settingsPanel.SetActive(false);
        }
        else
        {
            settingsPanel.SetActive(true);
        }
    }
}
