using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewToggle : MonoBehaviour
{
    public GameObject model01;
    public GameObject model02;

    public void BIM_Toggle_Changed(bool newValue)
    {
        model01.SetActive(newValue);
    }

    public void Image_Toggle_Changed(bool newValue)
    {
        model02.SetActive(newValue);
    }
}
