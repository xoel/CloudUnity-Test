using UnityEngine;
using System.Collections;
using SmartLocalization;
using UnityEngine.UI;

public class TextFrida : MonoBehaviour
{
    private string fridaText = "FridaText";
    public Text fridaGuiText;
    // Use this for initialization
    void Start()
    {
        //Start by getting the language manager and initialize it  with a language
        LanguageManager languageManager = LanguageManager.Instance;
        //subscribe to the change language event
        languageManager.OnChangeLanguage += OnChangeLanguage;
        //Set the language to english   
        OnChangeLanguage(languageManager);

    }
    void OnChangeLanguage(LanguageManager thisLanguageManager)
    {
        fridaGuiText.text = thisLanguageManager.GetTextValue(fridaText);
    }
}
