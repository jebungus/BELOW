using UnityEngine;

public class randomCycleOffset : MonoBehaviour
{
    Animator anim;
    float offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        offset = Random.Range(0f, 1f);
        anim.SetFloat("timingOffset", offset);
        //Debug.Log($"Random timing offset set to: {offset}");
    }

    
}
