using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartScene : MonoBehaviour
{
    [SerializeField] private TMP_Text userID_text;
    [SerializeField] private Button button;
    [SerializeField] private TMP_Dropdown dropdown;
    
    // Start is called before the first frame update
    void Start()
    {
        userID_text.text = "ID: " + ExperimentManager.userGuid.ToString();
        button.onClick.AddListener(OnButtonCLicked);
    }

    private void OnButtonCLicked()
    {
        Debug.Log("Button clicked with argument: " + dropdown.value);
        ExperimentManager.calmingSetup = dropdown.value == 1;
        ExperimentManager.SetSceneList();
        ExperimentManager.LoadNextScene();
    }
    
    
}
