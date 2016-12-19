using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SmartLocalization;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {

    public Button yourButton;
    public Text btnText;
    void Start()
    {
        //Start by getting the language manager and initialize it  with a language
        LanguageManager languageManager = LanguageManager.Instance;
        //subscribe to the change language event
        languageManager.OnChangeLanguage += OnChangeLanguage;
        //Set the language to english   
        OnChangeLanguage(languageManager);
        //inicializamos los botones y le damos uso
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        //Cambiamos de escena
        SceneManager.LoadScene("fridaScene");
    }
    void OnChangeLanguage(LanguageManager thisLanguageManager)
    {
        btnText.text = thisLanguageManager.GetTextValue("Empezar");
    }
}
