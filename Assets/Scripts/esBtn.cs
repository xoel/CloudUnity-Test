using UnityEngine;
using System.Collections;
using SmartLocalization;
using UnityEngine.UI;

public class esBtn : MonoBehaviour
{

    public Button yourButton;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        LanguageManager.Instance.ChangeLanguage("es");
    }
}