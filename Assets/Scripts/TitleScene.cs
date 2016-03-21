using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScene : MonoBehaviour
{
    public void OnScreenClick()
    {
        SceneManager.LoadScene( SceneNames.Play );
    }
}
