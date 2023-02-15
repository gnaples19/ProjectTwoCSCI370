using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : MonoBehaviour
{
    public string text;
    
    public void OnTriggerEnter2D(Collider2D collider2D){
        print("enter");
        
        if(collider2D.gameObject.CompareTag("Player")){
            GameManager.Instance.DialogShow(text);
           float playerLoc = collider2D.gameObject.transform.position.x;
           FlipFace(playerLoc); 
        }
    }

    public void OnTriggerExit2D(Collider2D collider2D){
        if(collider2D.gameObject.CompareTag("Player")){
            GameManager.Instance.DialogHide();
            float playerLoc = collider2D.gameObject.transform.position.x;
            FlipFace(playerLoc); 
        }
    }

    public void FlipFace (float xLoc){
        if(xLoc > gameObject.transform.position.x){
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(xLoc < gameObject.transform.position.x){
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
