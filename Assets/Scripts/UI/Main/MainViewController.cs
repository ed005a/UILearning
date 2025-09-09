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
            
        }

        private void Awake()
        {
            openWindowButton.onClick.AddListener(OpenWindow);
        }

        private void OpenWindow()
        {
            Debug.Log("OpenWindow");
            GameObject window = Instantiate(childWindowPrefab);
            
            window.transform.SetAsLastSibling();
        }
        
        
        
    }
}