using UnityEngine;
using UnityEngine.UI;

namespace App.UI
{
    public class MainViewController : ViewController
    {
        [SerializeField] private Button openWindowButton;
        [SerializeField] private GameObject childWindowPrefab;
    
        public override void Init(IWindowStarter starter)
        {
            base.Init(starter);
            openWindowButton.onClick.AddListener(OpenWindow);
        }
        
        
        private void OpenWindow()
        {
            Debug.Log("OpenWindow");
            WindowsManager.Instance.CreateWindow<AddDeviceViewController>(new AddDeviceViewStarter()).Show();
        }
        
        
        
    }
}