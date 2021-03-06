﻿using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private float refreshRate = 1f;
    [SerializeField] private TMP_Text fpsText = null; 
    private float timer;
    private int fps;
    private void Start() {
        timer = 0;
        fps = 0;
    }
    public void Update ()
    {
        timer += Time.deltaTime;
        if (timer > refreshRate && fpsText != null) {
            fps = (int) (1f / Time.unscaledDeltaTime);
            fpsText.text = fps + " FPS";
            timer = 0;
        }

    }
}
