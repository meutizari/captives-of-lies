using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject SelectedPanel;
    public bool openPanel;
    private int pnlOpener = 0;
    public void PanelHandler(){
        pnlOpener++;
        if(pnlOpener%2==0){
            openPanel = false;
        } else {
            openPanel = true;
        }
        SelectedPanel.SetActive(openPanel);
    }
}
