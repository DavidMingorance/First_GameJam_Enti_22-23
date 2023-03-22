using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image Mute;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        EstoyMute();
    }

    public void ChangeSlider(float valor)
    {
        slider.value = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        EstoyMute();
    }

    public void EstoyMute()
    {
        if (sliderValue == 0)
        {
            Mute.enabled = true;
        }
        else
        {
            Mute.enabled = false;
        }
    }
 
}
