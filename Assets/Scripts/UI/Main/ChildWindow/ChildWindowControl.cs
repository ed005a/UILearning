using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildWindowControl : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject inputButtonsPrefab;
    [SerializeField] private GameObject inputFieldsPrefab;
    [SerializeField] private Transform parent;
   

    private void Awake()
    {
        Debug.Log("Child Window Control Awake");
        GameObject inputButtons = Instantiate(inputButtonsPrefab, parent);
        
        GameObject inputFields = Instantiate(inputFieldsPrefab, parent);
    }

}
