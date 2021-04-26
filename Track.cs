using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    public SongData song;
    public AudioSource audioSource;

    void Start()
    {
        //moves track away from player the player so the first beat is not immediately in front of the player
        transform.position = Vector3.forward * (song.speed * GameManager.instance.startTime);
        //delays song so that first beat will be ready when it reaches player
        Invoke("StartSong", GameManager.instance.startTime - song.startTime);
    }
    //called when we want the song to start
    void StartSong ()
    {
        //play the song and controls volume of the song
        audioSource.PlayOneShot(song.song,0.5f);
        Invoke("SongIsOver", song.song.length);
    }
    void Update()
    {
        //moves the track of enemies an objects toward player over time every frame  
        transform.position += Vector3.back * song.speed * Time.deltaTime;
    }

    //called when the song ends to send the player to the main lobby
    void SongIsOver ()
    {
        GameManager.instance.WinGame();
    }

    //draws lines not in GameView to help place blocks
    //Unity Function built into MonoBehavior
    void OnDrawGizmos()
    {                
        for(int i = 0; i < 800; i++)
        {
            //how long each beat is in seconds

            float beatLength = 60.0f / (float)song.bpm;
            float beatDist = beatLength * song.speed;

                                                        //Start draw line Position                              //End draw line Position
            Gizmos.DrawLine(transform.position + new Vector3(-5, -3, i * beatDist), transform.position + new Vector3(5, -3, i * beatDist));
        }                                                      
    }
}
