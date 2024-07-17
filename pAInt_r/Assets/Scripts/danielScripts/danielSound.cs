using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danielSound : MonoBehaviour
{
    // - - - - - - - - - - - - - - - - - - - - -
    void Start()
    {
        setupSoundBank1();
        startMusic();
    }

    // - - - - - - - - - - - - - - - - - - - - -
    void Update()
    {
        
    }

    // - - - - - - - - - - - - - - - - - - - - -
    void setupSoundBank1()
    {
        AkBankManager.LoadBank("SoundBank1", false, false);
    }
     void setupTheSoundBank2()
    {
        AkBankManager.LoadBank("SoundBank2", false, false);
    }

    // - - - - - - - - - - - - - - - - - - - - -
    void startMusic()
    {
        AkSoundEngine.PostEvent("PlayMusic", gameObject);
    }
    // - - - - - - - - - - - - - - - - - - - - -
    void FadeInBlack()
    {
        AkSoundEngine.PostEvent("FadeInBlack", gameObject);
    }
    // - - - - - - - - - - - - - - - - - - - - -
    void FadeInBlue()
    {
        AkSoundEngine.PostEvent("FadeInBlue", gameObject);
    }
     void FadeInBrown()
    {
        AkSoundEngine.PostEvent("FadeInBrown", gameObject);
    }
     void FadeInCyan()
    {
        AkSoundEngine.PostEvent("FadeInCyan", gameObject);
    }
     void FadeInGreen()
    {
        AkSoundEngine.PostEvent("FadeInGreen", gameObject);
    }
     void FadeInMagenta()
    {
        AkSoundEngine.PostEvent("FadeInMagenta", gameObject);
    }
     void FadeInRed()
    {
        AkSoundEngine.PostEvent("FadeInRed", gameObject);
    }
     void FadeInWhite()
    {
        AkSoundEngine.PostEvent("FadeInWhite", gameObject);
    }
     void FadeInYellow()
    {
        AkSoundEngine.PostEvent("FadeInYellow", gameObject);
    }
     void ImageGeneration()
    {
        AkSoundEngine.PostEvent("ImageGeneration", gameObject);
    }
     void Glitches()
    {
        AkSoundEngine.PostEvent("Glitches", gameObject);
    }
     void GlitchesLoopsStartControl()
    {
        AkSoundEngine.PostEvent("GlitchesLoopsStartControl", gameObject);
    }
     void GlitchesLoopsStopControl()
    {
        AkSoundEngine.PostEvent("GlitchesLoopsStopControl", gameObject);
    }
     void BrushGrabbing()
    {
        AkSoundEngine.PostEvent("BrushGrabbing", gameObject);
    }
     void BrushStroking()
    {
        AkSoundEngine.PostEvent("BrushStroking", gameObject);
    }
     void ButtonPressing()
    {
        AkSoundEngine.PostEvent("ButtonPressing", gameObject);
    }
}
