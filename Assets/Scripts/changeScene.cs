using UnityEngine;
using UnityEngine.InputSystem;

public class changeScene : MonoBehaviour
{
    void ChangeSceneBind(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main Scene");
        }
        
    }



}
