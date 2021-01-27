using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBackgroundMusicSelector : MonoBehaviour
{
    #region Variables
    //TODO (1): Create a list to hold sound files
    public List<AudioClip> audioClips = new List<AudioClip>();

    
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        //TODO (2): Add audio files to list w\ file location
        audioClips.Add((AudioClip)Resources.Load("Background/MusicOne"));
        audioClips.Add((AudioClip)Resources.Load("Background/MusicTwo"));
        audioClips.Add((AudioClip)Resources.Load("Background/MusicThree"));

        //TODO (3): Get the audio source and link audioClips using random range 
        transform.GetComponent<AudioSource>().clip = audioClips[Random.Range(0, audioClips.Count)];
        //TODO (4): Play the audio
        transform.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

#region Resources
//RESOURCES USED: Unity Answers
//TITLE: How do I create an array for sounds?
//URL: https://answers.unity.com/questions/1186480/how-do-i-create-an-array-for-sounds.html

//RESOURCES USED: Personal Portfolio
//TITLE: Magic-8 Ball Taught By Jerry Burg
//URL: None
#endregion
