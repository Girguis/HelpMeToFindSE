using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideoScript : MonoBehaviour
{
    public GameObject videoPlayer,wall;
    public float destroyTime;
    public bool isFoundItem;

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag=="Player" && videoPlayer !=null)
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, destroyTime);
            wall.SetActive(!isFoundItem);
        }
    }
}