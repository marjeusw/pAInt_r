using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robAnim : MonoBehaviour
{
    public Animator animator;
    public Animator animatorGlitch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IdleAnim()
    {
        //normal
        animator.SetBool("backToIdle", true);

        //false
        animator.SetBool("isAppraising", false);
        animator.SetBool("isCheering", false);
        animator.SetBool("isGlitching", false);
        animator.SetBool("badEnd", false);
        animator.SetBool("goodEnd", false);
        animator.SetBool("byebye", false);
        //glitch
        animatorGlitch.SetBool("backToIdle", true);

        //false
        animatorGlitch.SetBool("isAppraising", false);
        animatorGlitch.SetBool("isCheering", false);
        animatorGlitch.SetBool("isGlitching", false);
        animatorGlitch.SetBool("badEnd", false);
        animatorGlitch.SetBool("goodEnd", false);
        animatorGlitch.SetBool("byebye", false);

    }

    public void AppraisingAnim()
    {
        //normal
        animator.SetBool("isAppraising", true);
        animator.SetBool("backToIdle", false);
        //glitch
        animatorGlitch.SetBool("isAppraising", true);
        animatorGlitch.SetBool("backToIdle", false);
    }
    public void CheerAnim()
    {
        //normal
        animator.SetBool("isCheering", true);
        animator.SetBool("backToIdle", false);
        //glitch
        animatorGlitch.SetBool("isCheering", true);
        animatorGlitch.SetBool("backToIdle", false);
    }
    public void GlitchAnim()
    {
        //normal
        animator.SetBool("isGlitching", true);
        animator.SetBool("backToIdle", false);
        //glitch
        animatorGlitch.SetBool("isGlitching", true);
        animatorGlitch.SetBool("backToIdle", false);
    }

    public void HandsAnim()
    {
        //normal
        animator.SetBool("badEnd", true);
        animator.SetBool("backToIdle", false);
        //glitch
        animatorGlitch.SetBool("badEnd", true);
        animatorGlitch.SetBool("backToIdle", false);
    }
    public void ScrewAnim()
    {
        //normal
        animator.SetBool("goodEnd", true);
        animator.SetBool("backToIdle", false);
        //glitch
        animatorGlitch.SetBool("goodEnd", true);
        animatorGlitch.SetBool("backToIdle", false);
    }
    public void WaveAnim()
    {
        //normal
        animator.SetBool("byebye", true);
        animator.SetBool("backToIdle", false);
        //glitch
        animatorGlitch.SetBool("byebye", true);
        animatorGlitch.SetBool("backToIdle", false);
    }
}
