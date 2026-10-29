using UnityEngine;
using System.Collections;

public class moveIntoPosition : MonoBehaviour
{
    public float targetY; // The position to move towards
    public float speed = 1f; // The speed at which to move
    public float delay = 1f; // Delay before revealing the text

    public GameObject revealingText;

    IEnumerator WaitThenReveal()
    {
        yield return new WaitForSeconds(delay); // Wait for 1 second
        revealingText.SetActive(true); // Activate the revealing text
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Current Y Position: " + gameObject.transform.position.y + ", Target Y Position: " + targetY);
        if (gameObject.transform.position.y < targetY)
        {
            // Move the object upwards towards the target position
            gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else
        {
            StartCoroutine(WaitThenReveal()); // Start the coroutine to reveal the text after the delay

        }
    }
}
