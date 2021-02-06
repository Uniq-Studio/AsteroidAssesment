using System.Collections.Generic;
using UnityEngine;

public class randomBackgroundMusicSelector : MonoBehaviour
{
    #region Variables
    //TODO (1): Create a list to hold sound files
    /*We will be using a list to hold multiple music files,
    *to the list so we can randomly select one from the list.
    **/
    public List<AudioClip> audioClips = new List<AudioClip>();
    #endregion

    void Start()
    {
        #region Adding Audio To List
        //TODO (2): Add audio files to list w\ file location
        /* This bit of code looks withing the Recourse file in Assets and
         * linked the audio file by adding it to the list.
         **/
        audioClips.Add((AudioClip)Resources.Load("Background/MusicOne"));
        audioClips.Add((AudioClip)Resources.Load("Background/MusicTwo"));
        audioClips.Add((AudioClip)Resources.Load("Background/MusicThree"));
        #endregion

        #region Randomly Select Sound then play
        //TODO (3): Get the audio source and link audioClips using random range
        /*This get the clip to play, but we use a random number generator to select the song.
         * to be playing in the background, we used audioClip.Count so if we add more sounds.
         * we will not need to update this line of code.
         **/
        transform.GetComponent<AudioSource>().clip = audioClips[Random.Range(0, audioClips.Count)];

        //TODO (4): Play the audio
        //The randomly selected audio and then will start playing
        transform.GetComponent<AudioSource>().Play();
        #endregion
    }
}

#region Resources
//RESOURCES USED: Unity Answers
//TITLE: How do I create an array for sounds?
//URL: https://answers.unity.com/questions/1186480/how-do-i-create-an-array-for-sounds.html
#endregion

#region Code Details
/*
 * CODE CREATED: 		Aaron Hamilton – 27/01/2021
 * COMMENTED:			Aaron Hamilton – 27/01/2021
 * COMPLETION:		    Aaron Hamilton – 27/01/2021
 * DEBUGED ON:		    Aaron Hamilton – 27/01/2021
 * SPELLING CHECK:		Aaron Hamilton – 27/01/2021
 **/
#endregion
