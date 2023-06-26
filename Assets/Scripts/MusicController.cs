using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource[] audioSources;

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
