using UnityEngine;
using System;
using System.Collections;

public class AudioRecorder : MonoBehaviour {
    string _FileStoragePath;
    [SerializeField]
    private AudioSource _Source;
	void Start ()
    {
#if UNITY_EDITOR
        _FileStoragePath = "C:\\Users\\Grygory\\Documents\\HackSchool 2016\\Assets\\Records\\";
#endif
#if UNITY_ANDROID || UNITY_IOS
           _FileStoragePath = "Records";
#endif
        StartCoroutine(RecordSound(4));
        
    }
	
    IEnumerator RecordSound(int time)
    {
        AudioClip clip = Microphone.Start(Microphone.devices[0], false, time, 44100);
        yield return new WaitForSeconds(time);
        SaveWav.Save(_FileStoragePath + DateTime.Now.Ticks.ToString(), clip);
        _Source.clip = clip;
        _Source.Play();
    }
}
