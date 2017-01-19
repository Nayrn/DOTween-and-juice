using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CollisionScript : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip boomboom;

    private Transform redSphere;
    private GameObject floor;
    private Material mat;
    Tween matTween;
    public Texture cracked;
    public Texture plain;
	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
        boomboom = GetComponent<AudioSource>().clip;
        audio.clip.LoadAudioData();
        redSphere = this.transform;

        floor = GameObject.FindGameObjectWithTag("Floor");
        mat = floor.GetComponent<Renderer>().material;
        mat.SetTexture("_MainTex", plain);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            audio.PlayOneShot(boomboom, 1);
            redSphere.GetComponent<Renderer>().material.DOColor(Color.red, 1);
            mat.SetTexture("_MainTex", cracked);
        }



    }
}
