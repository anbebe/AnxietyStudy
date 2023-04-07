using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    [SerializeField] private float _time = 180f; // 3 minutes time to present
    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(OnButtonCLicked);
        }
        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(_time);
        ExperimentManager.LoadNextScene();
    }
    
    private void OnButtonCLicked()
    {
        ExperimentManager.LoadNextScene();
    }
}
