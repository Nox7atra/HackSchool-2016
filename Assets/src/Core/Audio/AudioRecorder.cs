using UnityEngine;
using System;
using System.Collections;

public class AudioRecorder : MonoBehaviour {
    string _FileStoragePath;
    [SerializeField]
    private AudioSource _Voice;
    [SerializeField]
    private AudioSource _Music;
	void Start ()
    {
#if UNITY_EDITOR
        _FileStoragePath = "C:\\Users\\Grygory\\Documents\\HackSchool 2016\\Assets\\Records\\";
#endif
#if UNITY_ANDROID || UNITY_IOS
         _FileStoragePath = "Records";
#endif
        StartCoroutine(RecordSound((int)_Music.clip.length + 1));
        
    }
	
    IEnumerator RecordSound(int time)
    {
        AudioClip clip = Microphone.Start(Microphone.devices[0], false, time, 44100);
        yield return new WaitForSeconds(time);
        SaveWav.Save(_FileStoragePath + DateTime.Now.Ticks.ToString(), clip);
        _Voice.clip = clip;
        _Music.Play();
        _Voice.Play();
    }
}
