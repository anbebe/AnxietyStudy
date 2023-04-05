using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountTime : MonoBehaviour
{
    [SerializeField] private float _time = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(_time);
        ExperimentManager.LoadNextScene();
    }
}
