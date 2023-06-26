using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public int musicIndex;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayMusic);
    }

    private void PlayMusic()
    {
        FindObjectOfType<MusicController>().PlayMusic(musicIndex);
    }
}

