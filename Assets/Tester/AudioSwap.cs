using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwap : MonoBehaviour
{

    public AudioClip newTrack;
    

    bool isPlaying; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            AudioManager.instance.SwapTrack(newTrack);
            Debug.Log("Key down");
        }
        if(Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            AudioManager.instance.SwapTrack(newTrack);
        }
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    AudioManager.instance.ReturnToDefault();
        //}
    }
}
