using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class robManager : MonoBehaviour
{
	//public MeshRenderer RobArtTorso;
	//public MeshRenderer RobArtScarf;
	public GameObject RobArtTorso1;
	public GameObject RobArtScarf1;

	//public GameObject VideoPlayer;

	public VideoPlayer vid;
	public VideoClip myclip;
	robAnim robart;
	public GameObject GameHandler;
	public bool glitching;


	void Start()
	{
        robart = GameHandler.GetComponent<robAnim>();
        Animator animator = robart.GetComponent<Animator>();
		glitching = false;
    }

	//pressing space starts glitching coroutine
	//some bugs occur if we don't use a button to start it so maybe we could use a button the user would use anyways (like switching colours or something)
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(Glitching());
		}
	}


	//glitching appears after a few seconds again
	IEnumerator Glitching()
	{
		SkinnedMeshRenderer MeshComponent = RobArtTorso1.GetComponent<SkinnedMeshRenderer>();
		SkinnedMeshRenderer MeshComponent2 = RobArtScarf1.GetComponent<SkinnedMeshRenderer>();

		//VideoPlayer Clip = VideoPlayer.GetComponent<VideoPlayer>();

		yield return new WaitForSeconds(5f);

		//RobArtTorso.enabled=true;
		//RobArtScarf.enabled = true;
		GlitchAnim();

		MeshComponent.enabled = true;
		MeshComponent2.enabled = true;

		//for the bluescreen
		vid.clip = myclip;
		//endWait = true;
		glitching = true;
	}

	void GlitchAnim()
	{
		robart.GlitchAnim();
	}

	public void StayBluescreen()
    {
		if(vid.clip != myclip && glitching == true)
        {
			vid.clip = myclip;
			Debug.Log("should be bluescreen");        
				
		} 
		
    }
}
