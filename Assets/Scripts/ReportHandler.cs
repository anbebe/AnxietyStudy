using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReportHandler : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnButtonCLicked);
    }

    private void OnButtonCLicked()
    {
        Debug.Log("Button clicked with argument: " + slider.value);
        ExperimentManager.AddSelfReport((int)slider.value);
        ExperimentManager.LoadNextScene();
    }
}
