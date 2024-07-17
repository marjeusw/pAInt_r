using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class RobArtCollisionHandler : MonoBehaviour
{
	public GameObject RobArtTorso1;
	public GameObject RobArtScarf1;
	public VideoPlayer vid;
	public VideoClip myclip;
    
	//public MeshRenderer RobArtTorso;
	//public MeshRenderer RobArtScarf;

	public bool collide;

	robAnim robart;
	public GameObject GameHandler;

	private void Start()
	{
 
	}

	private void Update()
	{
   	 
	}

	//checks for collision
	public void OnCollisionEnter(Collision collision)
	{
    	collide = true;
    	Debug.Log("Collision");
    	TurnOff();
	}    

	//turns off meshrenderer
	public void TurnOff()
	{
    	if (collide == true)
    	{

        	//RobArtTorso.SetActive(false); //no setactive but meshrenderer off
        	//RobArtScarf.SetActive(false);
        	SkinnedMeshRenderer MeshComponent = RobArtTorso1.GetComponent<SkinnedMeshRenderer>();
        	SkinnedMeshRenderer MeshComponent2 = RobArtScarf1.GetComponent<SkinnedMeshRenderer>();

        	MeshComponent.enabled = false;
        	MeshComponent2.enabled = false;

        	//for the bluescreen
        	vid.clip = myclip;

        	Idle();

        	collide = false;
      	 
    	}
	}

	void Idle()
	{
    	robart = GameHandler.GetComponent<robAnim>();
    	Animator animator = robart.GetComponent<Animator>();
    	robart.IdleAnim();
	}
}
