using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ReportHandler : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Dropdown question1;
    [SerializeField] private TMP_Dropdown question2;
    [SerializeField] private TMP_Dropdown question3;
    [SerializeField] private TMP_Dropdown question4;
    [SerializeField] private TMP_Dropdown question5;
    [SerializeField] private TMP_Dropdown question6;
    [SerializeField] private Canvas canvasText;
    [SerializeField] private Canvas canvasQuestions;
    
    // Start is called before the first frame update
    void Start()
    {
        canvasQuestions.GameObject().SetActive(false);
        canvasText.GameObject().SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            canvasQuestions.GameObject().SetActive(true);
            canvasText.GameObject().SetActive(false);
            button.onClick.AddListener(OnButtonCLicked);
        }
    }
    

    private string GetDropdownValues()
    {
        List<TMP_Dropdown> dropdowns = new List<TMP_Dropdown>()
            { question1, question2, question3, question4, question5, question6 };
        string values = String.Empty;
        foreach (TMP_Dropdown d in dropdowns)
        {
            values += "," + (d.value + 1).ToString();
        }

        return values;
    }

    private void OnButtonCLicked()
    {
        Debug.Log("Button clicked with first argument: " + question1.value);
        ExperimentManager.AddSelfReport(GetDropdownValues());
        ExperimentManager.LoadNextScene();
    }
}
