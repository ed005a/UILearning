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
        closeButton.onClick.AddListener(() => DestroyWindow());
        cancelButton.onClick.AddListener(() => DestroyWindow());
    }

    private void DestroyWindow()
    {
        var windowList = WindowsManager.Instance.GetAllWindows();
        foreach (var window in windowList)
        {
            if (window.name == transform.parent.name)
            {
                window.DestroyWindow();
                break;
            }
        }
    }
}
