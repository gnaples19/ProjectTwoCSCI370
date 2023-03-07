using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public GameObject Pirate;
    public GameObject startMenu;

    public GameObject Canvas;
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;


    public void DialogShow(string text){
        dialogBox.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(TypeText(text));
    }

    public void DialogHide(){
        dialogBox.SetActive(false);
    }  
    
    IEnumerator TypeText(string text){
    dialogText.text = "";
    foreach (char c in text.ToCharArray()){
        dialogText.text += c;
        yield return new WaitForSeconds(0.02f);
        }
    }
    
    public void StartGame(){
    startMenu.SetActive(false);
    Pirate.SetActive(true);

    }
    public void ReloadGame(){
        DialogHide();
        SceneManager.LoadScene("GN_Scene");
        
    }
    void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(Canvas);
        } else {
        Destroy(gameObject);
    }
    }
    // Start is called before the first frame update
    void Start()
    {
        DialogHide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
