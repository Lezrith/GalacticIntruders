using UnityEngine;
using System.Collections;

public class ClearStatistics : MonoBehaviour
{
    DisplayScore disp;
    // Use this for initialization
    public void Clear()
    {
        PlayerPrefs.SetInt("Wynik1", 0);
        PlayerPrefs.SetInt("Wynik2", 0);
        PlayerPrefs.SetInt("Wynik3", 0);
        PlayerPrefs.SetInt("Wynik4", 0);
        PlayerPrefs.SetInt("Wynik5", 0);
        disp=(DisplayScore)this.GetComponent(typeof(DisplayScore));
        disp.Start();
    }

}
