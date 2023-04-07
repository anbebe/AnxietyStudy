using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text tmpText;
    [SerializeField] public string textDescription;
    [SerializeField] public List<string> displayedText;
    private int displayedInd = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        tmpText.text = textDescription;
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            displayedInd = displayedInd==0 ? 1 : 0;
            tmpText.text = displayedText[displayedInd];
        }
    }
    
    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(10f); // 5 minutes = 300
        ExperimentManager.LoadNextScene();
    }
}
