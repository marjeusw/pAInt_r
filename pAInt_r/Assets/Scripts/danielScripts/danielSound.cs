using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danielSound : MonoBehaviour
{
	public GameObject Animatic;
	public robAnim robart;
	public GameObject Robart;
	//public GameObject GameHandler;
	//public Animator animator;

	// - - - - - - - - - - - - - - - - - - - - -
	void Start()
	{
		setupSoundBank1();
		StartCoroutine(WaitForVideo());
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

	//coroutine to make sound start after video
	IEnumerator WaitForVideo()
	{
		yield return new WaitForSeconds(4f); //60f

		startMusic();
		Animatic.SetActive(false);

        //relocate robart after the video is over so he stands next to the canvas
        //Robart.transform.localPosition = new Vector3(-8.7f, -7.76f, 5.8f);
        //Robart.transform.eulerAngles = new Vector3(0, 114f, 0);

        //setting robarts rotation in general direction 
        Robart.transform.eulerAngles = new Vector3(
			Robart.transform.eulerAngles.x,
			Robart.transform.eulerAngles.y -90,
			Robart.transform.eulerAngles.z
			);

		//animation robart		
		Animator animator = gameObject.GetComponent<Animator>();
		robart.IdleAnim();
    }

	// - - - - - - - - - - - - - - - - - - - - -
	void startMusic()
	{
		AkSoundEngine.PostEvent("PlayMusic", gameObject);
	}
	// - - - - - - - - - - - - - - - - - - - - -
	public void FadeInBlack()
	{
		AkSoundEngine.PostEvent("FadeInBlack", gameObject);
	}
	// - - - - - - - - - - - - - - - - - - - - -
	public void FadeInBlue()
	{
		AkSoundEngine.PostEvent("FadeInBlue", gameObject);
	}
	public void FadeInBrown()
	{
		AkSoundEngine.PostEvent("FadeInBrown", gameObject);
	}
	public void FadeInCyan()
	{
		AkSoundEngine.PostEvent("FadeInCyan", gameObject);
	}
	public void FadeInGreen()
	{
		AkSoundEngine.PostEvent("FadeInGreen", gameObject);
	}
	public void FadeInMagenta()
	{
		AkSoundEngine.PostEvent("FadeInMagenta", gameObject);
	}
	public void FadeInRed()
	{
		AkSoundEngine.PostEvent("FadeInRed", gameObject);
	}
	void FadeInWhite()
	{
		AkSoundEngine.PostEvent("FadeInWhite", gameObject);
	}
	public void FadeInYellow()
	{
		AkSoundEngine.PostEvent("FadeInYellow", gameObject);
	}
	public void ImageGeneration()
	{
		AkSoundEngine.PostEvent("ImageGeneration", gameObject);
	}
	public void Glitches()
	{
		AkSoundEngine.PostEvent("Glitches", gameObject);
	}
	public void GlitchesLoopsStartControl()
	{
		AkSoundEngine.PostEvent("GlitchesLoopsStartControl", gameObject);
	}
	public void GlitchesLoopsStopControl()
	{
		AkSoundEngine.PostEvent("GlitchesLoopsStopControl", gameObject);
	}
	public void BrushGrabbing()
	{
		AkSoundEngine.PostEvent("BrushGrabbing", gameObject);
	}
	void BrushStroking()
	{
		AkSoundEngine.PostEvent("BrushStroking", gameObject);
	}
	public void ButtonPressing()
	{
		AkSoundEngine.PostEvent("ButtonPressing", gameObject);
	}
}
