using UnityEngine;
using Urd.Popup;
using Urd.Services;
using Urd.Utils;

public class DebugOpenPopup : MonoBehaviour
{
    [SerializeField] 
    private bool _enabled;

    [SerializeField] 
    private KeyCode _keyCode;
    
    void Update()
    {
        if (!_enabled)
        {
            return;
        }
        
        if (Input.GetKeyDown(_keyCode))
        {
            dynamic popupInfoModel = new PopupInfoModel();
            StaticServiceLocator.Get<INavigationService>().Open(popupInfoModel, null);
        }
    }

    private void OnOpenPopup(bool success)
    {
        Debug.Log($"Popup Opened {success}");
    }
}
