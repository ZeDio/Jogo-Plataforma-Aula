 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private UIDocument document;
    private Button btnJogar;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        btnJogar = document.rootVisualElement.Q<Button>("btnJogar");
        btnJogar.RegisterCallback<ClickEvent>(OnPlayGame);    
    }

    void OnPlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }
}
