using UnityEngine;
using System.Collections;
using SmartLocalization;
using System;
using UnityEngine.UI;

public class MyLocalizedScripts : MonoBehaviour {
    private string fridaText = "FridaText";
    private Text fridaGuiText;



	// Use this for initialization
    private void Awake()
    {

        //fridaGuiText = GetComponent<Text>();
        
    }

	void Start () {
        //Start by getting the language manager and initialize it  with a language
        //LanguageManager languageManager = LanguageManager.Instance;
        //subscribe to the change language event
        //languageManager.OnChangeLanguage += OnChangeLanguage;
        //Set the language to english
        //languageManager.ChangeLanguage("en");
        //fridaGuiText.text = LanguageManager.Instance.GetTextValue("FridaText");

    }
    
    void OnDestroy()
    {
        if (LanguageManager.HasInstance)
        {
            //LanguageManager.Instance.OnChangeLanguage -= OnChangeLanguage;
        }
    }

    //void OnChangeLanguage(LanguageManager thisLanguageManager)
    //{
        //fridaGuiText.text = thisLanguageManager.GetTextValue("FridaText");
    //}

    void OnGUI()
    {
        GUILayout.Label(LanguageManager.Instance.GetTextValue(fridaText));
        if (GUILayout.Button("Español"))
        {
            LanguageManager.Instance.ChangeLanguage("es");
        }

        if (GUILayout.Button("English"))
        {
            LanguageManager.Instance.ChangeLanguage("en");
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
