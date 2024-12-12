using UnityEngine;

public class NextPanel : MonoBehaviour
{
    public GameObject panelToDisactivate;
    public GameObject panelToActivate;

    public void OnButtonClick()
    { 
        panelToDisactivate.SetActive(false);
        panelToActivate.SetActive(true);
    }
}
