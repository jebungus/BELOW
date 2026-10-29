using UnityEngine;
using UnityEngine.Rendering;

public class LightDimCycle : MonoBehaviour
{
    Light lightComp;
    public LensFlareComponentSRP lensFlare;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightComp = gameObject.GetComponent<Light>();
        lensFlare = gameObject.GetComponent<LensFlareComponentSRP>();
    }

    void Update()
    {
        if (lightComp != null)
        {
            lightComp.intensity = 1 + Mathf.Sin(Time.time);
            lensFlare.intensity = 1 + Mathf.Sin(Time.time);
        }
    }
    
}
