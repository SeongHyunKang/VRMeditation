using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public static MusicController instance;

    public AudioSource[] audioSources;

    private int currentMusicIndex = 0;
    private float currentPlaybackTime = 0f;

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
        AudioSource currentAudioSource = audioSources[currentMusicIndex];

        currentPlaybackTime = currentAudioSource.time;

        PlayMusic(currentMusicIndex);

        currentAudioSource.time = currentPlaybackTime;
        currentAudioSource.Play();
    }

    public void PlayMusic(int index)
    {
        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.Stop();
        }

        if (index >= 0 && index < audioSources.Length)
        {
            AudioSource audioSource = audioSources[index];

            audioSource.time = currentPlaybackTime;
            audioSource.Play();

            currentMusicIndex = index;
        }
    }
}
