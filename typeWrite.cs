using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typeWrite : MonoBehaviour {

    public Text messageBox;
    public AudioClip typeWriteSound;

    private AudioSource audioPlayer;

    public string inputMessage;
    public float timeWait;
    public float volumeVar;

    // Use this for initialization
    void Awake()
    {

        audioPlayer = GetComponent<AudioSource>();

    }

    void Start() {
        
        StartCoroutine(typeText(inputMessage, timeWait));

    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator typeText(string inputMessage, float timeWait) {
        string finalMessage = "";
        int breakValue = 0;
        while (breakValue++ < inputMessage.Length)
        {
            finalMessage += inputMessage[breakValue - 1];
            yield return new WaitForSeconds(timeWait);
            if (inputMessage[breakValue - 1].ToString() != " ")
            {
                audioPlayer.PlayOneShot(typeWriteSound, volumeVar);

            }
            messageBox.text = finalMessage;

            
        }


    }
}
