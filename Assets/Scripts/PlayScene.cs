using UnityEngine;
using System.Collections;

public class PlayScene : MonoBehaviour
{
    public UILabel statusLabel;
    public UIProgressBar playTimerBar;

    
    void Start()
    {
        statusLabel.text = "Ready";

        StartCoroutine( PlayTimer() );
    }

    private readonly float PlayDuration = 2;
    private float playClock = 0;

    IEnumerator PlayTimer()
    {
        while ( playClock < PlayDuration )
        {
            playClock += Time.deltaTime;
            playTimerBar.value = playClock / PlayDuration;

            yield return null;
        }
    }

    public void OnRockClick()
    {
    }

    public void OnPaperClick()
    {
    }

    public void OnScissorsClick()
    {
    }
}
