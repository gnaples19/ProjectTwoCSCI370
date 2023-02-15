using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    //Sound Effect from https://pixabay.com/sound-effects/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=music&amp;utm_content=48358"

    public string text;
    private AudioSource audio;

    public void OnTriggerEnter2D(Collider2D collider2D){
        print("enter");
        
        if(collider2D.gameObject.CompareTag("Player")){
            GameManager.Instance.DialogShow(text);
            StartCoroutine("Escape");
        }
    }

    public void OnTriggerExit2D(Collider2D collider2D){
        if(collider2D.gameObject.CompareTag("Player")){
            GameManager.Instance.DialogHide();      
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Escape()
    {
        audio.Play();
        Debug.Log("Playing Escape Now?");
        yield return new WaitForSeconds(10);
        //Destroy(gameObject);
        //GameManager.Instance.FoundBoat();
        GameManager.Instance.
    }

}
