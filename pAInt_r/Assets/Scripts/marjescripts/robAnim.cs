using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class robAnim : MonoBehaviour
{
    public Animator animator;
    public Animator animatorGlitch;

    //2Danim
    public VideoPlayer vid;
    public VideoClip appraiseClip;
    public VideoClip goodEndClip;
    public VideoClip badEndClip;

    //for check glitch
    public bool badEnding;


    public void IdleAnim()
    {
        //normal
        animator.SetBool("backToIdle", true);

        //false in case something is checked
        animator.SetBool("isAppraising", false);
        animator.SetBool("isCheering", false);
        animator.SetBool("isGlitching", false);
        animator.SetBool("badEnd", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("byebye", false);
        //glitch
        animatorGlitch.SetBool("backToIdle", true);

        //false in case something is checked
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("badEnd", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("byebye", false);

    }

    public void AppraisingAnim()
    {
        Debug.Log("Appraising anim shoudl play now");

        //normal
        animator.SetBool("isAppraising", true);

        //
        animator.SetBool("backToIdle", false);
        animator.SetBool("isCheering", false);
        animator.SetBool("isGlitching", false);
        animator.SetBool("badEnd", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("byebye", false);

        //glitch
        animatorGlitch.SetBool("isAppraising", true);

        //
        animatorGlitch.SetBool("backToIdle", false);
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("badEnd", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("byebye", false);

        vid.clip = appraiseClip;
    }
    public void CheerAnim()
    {
        //normal
        animator.SetBool("isCheering", true);

        //
        animator.SetBool("backToIdle", false);
        animator.SetBool("isAppraising", false);
        animator.SetBool("isGlitching", false);
        animator.SetBool("badEnd", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("byebye", false);

        //glitch
        animatorGlitch.SetBool("isCheering", true);

        //
        animatorGlitch.SetBool("backToIdle", false);
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("badEnd", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("byebye", false);

    }
    public void GlitchAnim()
    {
        //normal
        animator.SetBool("isGlitching", true);

        //
        animator.SetBool("isCheering", false);
        animator.SetBool("backToIdle", false);
        animator.SetBool("isAppraising", false);
        animator.SetBool("badEnd", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("byebye", false);

        //glitch
        animatorGlitch.SetBool("isGlitching", true);

        //
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("backToIdle", false);
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("badEnd", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("byebye", false);

        //bool
        badEnding = true;
    }

    public void HandsAnim()
    {
        //normal
        animator.SetBool("badEnd", true);

        //
        animator.SetBool("isGlitching", false);
        animator.SetBool("isCheering", false);
        animator.SetBool("backToIdle", false);
        animator.SetBool("isAppraising", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("byebye", false);

        //glitch
        animatorGlitch.SetBool("badEnd", true);

        //
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("backToIdle", false);
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("byebye", false);
    }
    public void ScrewAnim()
    {
        //normal
        animator.SetBool("goodEnd", true);

        //
        animator.SetBool("isGlitching", false);
        animator.SetBool("isCheering", false);
        animator.SetBool("backToIdle", false);
        animator.SetBool("isAppraising", false);
        animator.SetBool("badEnd", false);
        animator.SetBool("byebye", false);
        //glitch
        animatorGlitch.SetBool("goodEnd", true);

        //
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("backToIdle", false);
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("badEnd", false);
        animatorGlitch.SetBool("byebye", false);

        vid.clip = goodEndClip;


    }
    public void WaveAnim()
    {
        //normal
        animator.SetBool("byebye", true);

        //
        animator.SetBool("isGlitching", false);
        animator.SetBool("isCheering", false);
        animator.SetBool("backToIdle", false);
        animator.SetBool("isAppraising", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("badEnd", false);

        //glitch
        animatorGlitch.SetBool("byebye", true);

        //
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("backToIdle", false);
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("badEnd", false);

        vid.clip = badEndClip;

    }

    public void CheckForGlitch()
    {
        //animator.GetBool("isGlitching");
        if(animator.GetBool("isGlitching") == true)
        {
            badEnding = true;
        }
    }
}
