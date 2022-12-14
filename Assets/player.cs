using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Rigidbody rb;
    Animator amin;
    bool isground = true;
    public bool isgameover=false;
    public AudioClip jumpcip;
    public AudioClip crashcip;
    private AudioSource AS;
    public ParticleSystem dirt;
    public ParticleSystem explode;
    public TextMeshProUGUI scorestext;
    public TextMeshProUGUI go;
   
    public int scores=0;



    public Button Restart;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        amin = GetComponent<Animator>();
        AS = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isground)
        {
            
            dirt.Pause();
            scorestext.text = "score : " + scores;
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            amin.SetBool("isjumping",true);
            isground = false;
            AS.PlayOneShot(jumpcip);
        }
        else if( isground)
        {
            amin.SetBool("isjumping", false);
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isground = true;
            dirt.Play();
        }
        if(collision.gameObject.CompareTag("obsticle"))
        {
            isgameover = true;
            Debug.Log("collision");
            AS.PlayOneShot(crashcip);
            explode.Play();
            dirt.Pause();
            scores = 0;
            Restart.gameObject.SetActive(true);
            go.gameObject.SetActive(true);
            amin.SetBool("isdying", true);
            
        }
        
    }
    public void Restatfun()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
