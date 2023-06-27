using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public static MusicController instance;

    public AudioSource[] audioSources;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayMusic(0);
    }

    public void PlayMusic(int index)
    {
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.Stop();
        }

        if (index >= 0 && index < audioSources.Length)
        {
            audioSources[index].Play();
        }
    }
}

