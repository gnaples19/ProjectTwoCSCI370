using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    public GameObject startMenu;
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    private bool raiseLower = false;

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
    }
    public void StartGame(){
    startMenu.SetActive(false);

    }
    public void ReloadGame(){
        SceneManager.LoadScene("GN_Scene");
    }
    void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
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
