using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class GlowPulse : MonoBehaviour
{
    public Renderer[] renderers;
    public PlayableDirector director;

    public float bpm = 130.0f;
    public float intensityHigh = 3.0f;
    public float intensityLow = 0.2f;

    private float intensityLerp;
    private float bps;

    void Start()
    {
        intensityLerp = 0.0f;
        UpdateBps();
    }

    void Update()
    {
        if (intensityLerp >= 1.0f) intensityLerp = 0.0f;

        foreach (Renderer r in renderers)
        {
            r.material.SetFloat("GLOW_PULSE_SG_GLOW_INTENSITY", Mathf.Lerp(intensityHigh, intensityLow, intensityLerp));
        }

        intensityLerp += Time.smoothDeltaTime * bps;
    }

    void UpdateBps()
    {
        bps = bpm / 60.0f;
    }
}