using UnityEngine;
using System.Collections;

public class AudioRecorder : MonoBehaviour {
    static readonly string FILE_PATH = "C:\\Users\\Grygory\\Documents\\HackSchool 2016";
    [SerializeField]
    private AudioSource _Source;
	void Start ()
    {
        StartCoroutine(RecordSound(4));
        
    }
	
	void Update ()
    {
	
	}
    IEnumerator RecordSound(int time)
    {
        AudioClip clip = Microphone.Start(Microphone.devices[0], false, time, 44100);
        yield return new WaitForSeconds(time);
        SaveWav.Save(FILE_PATH, clip); 
    }
}
