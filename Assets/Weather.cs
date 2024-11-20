using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public GameObject camera;
    public Color Day, Night, Sunny, Sunless, Rainy, Snowy, Sunrise, Sunset;
    Light light;
    Material skybox;

    public void SetWeather(/*Color color,*/ float intensity, Material weather) {
        //light.color = color;
        light.intensity = intensity;
        skybox = weather;
        
        RenderSettings.skybox = skybox;
    }
}
