using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePanel : MonoBehaviour
{
    
        public GameObject panel;
    bool state = true;

        public void SwitchShowHide()
        {
           
            panel.gameObject.SetActive(false);
        state = false;
        }
    
}
