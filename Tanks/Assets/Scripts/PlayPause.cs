using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPause : MonoBehaviour
{
    [SerializeField] private GameObject _play;
    [SerializeField] private GameObject _pause;


   public void Play()
    {
        _play.SetActive(false);
        Time.timeScale = 1f;
        _pause.SetActive(true);
    }

    public void Pause()
    {
        _pause.SetActive(false);
        Time.timeScale = 0f;
        _play.SetActive(true);
    }
}
