using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewTimeLine : MonoBehaviour
{
    public GameObject model3;

    public void slider_changed(float newValue)
    {
        Vector3 pos = model3.transform.position;
        pos.y = newValue;
        model3.transform.position = pos;
    }
}
