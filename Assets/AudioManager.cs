using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicAudioSoure;
    public AudioSource vfxAudioSoure;

    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicAudioSoure.clip = musicClip;
        musicAudioSoure.Play();
    }
    public void PlaySFX(AudioClip sfxclip)
    {
        vfxAudioSoure.clip = sfxclip;
        vfxAudioSoure.PlayOneShot(sfxclip);
    }
}
