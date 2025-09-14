using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButtonsControl : MonoBehaviour
{
    [SerializeField] private Button addButton;
    [SerializeField] private Button closeButton;
    [SerializeField] private Button cancelButton;

    private void Awake()
    {
        addButton.onClick.AddListener(() => Debug.Log("Added device"));
        closeButton.onClick.AddListener(() => Destroy(transform.parent.gameObject));
        cancelButton.onClick.AddListener(() => Destroy(transform.parent.gameObject));
    }
}
