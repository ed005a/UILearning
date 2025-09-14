using UnityEngine;
using UnityEngine.UI;
namespace App.UI
{
    public class AddDeviceViewController : ViewController
    {
        [SerializeField] private GameObject inputButtonsPrefab;
        [SerializeField] private GameObject inputFieldsPrefab;
        [SerializeField] private Transform parent;
   
        public override void Init(IWindowStarter starter)
        {
            base.Init(starter);
        }

        private void Awake()
        {
            Debug.Log("Child Window Control Awake");
            GameObject inputButtons = Instantiate(inputButtonsPrefab, parent);
        
            GameObject inputFields = Instantiate(inputFieldsPrefab, parent);
        }
        
    }
}