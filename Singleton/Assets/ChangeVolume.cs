using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    private Slider _slider;
    void Start()
    {
        _slider = GetComponent<Slider>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Change();
        }
    }
    public void Change()
    {
        AudioManager.Instance.SaveSettings(_slider.value);
    }
}
