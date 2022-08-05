using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionVideoPlayer : MonoBehaviour
{
    public GameObject objectToHide,ObjectToShow;
    // Start is called before the first frame update
    private void Start()
    {
        Destroy(objectToHide, 8f);
        ObjectToShow.SetActive(true);
    }
}
