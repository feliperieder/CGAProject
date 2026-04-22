using UnityEngine;

public class LightControç : MonoBehaviour
{
    const float MAX_LIGHT = 130000.0f;  
    const float MID_LIGHT = 65000.0f;
    const float MIN_LIGHT = 0.0f;

    Light globalLight;
     void Awake()
    {
        globalLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            globalLight.intensity = MAX_LIGHT;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            globalLight.intensity = MID_LIGHT;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            globalLight.intensity = MIN_LIGHT;
        }
    }
}
