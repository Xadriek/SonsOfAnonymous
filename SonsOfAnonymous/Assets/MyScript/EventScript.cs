using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class EventScript : MonoBehaviour
{

    public Transform ChatBackGround;
    public Transform Event;
    public Transform Player;

    private PlayerController playerController;

    private DialogueSystem dialogueSystem;

    public string Name;

    [TextArea(5, 10)]
    public string[] sentences;

    void Start()
    {
        dialogueSystem = FindObjectOfType<DialogueSystem>();
        playerController = FindObjectOfType<PlayerController>();
    }

    void FixedUpdate()
    {
        Vector3 Pos = Camera.main.WorldToScreenPoint(Player.position);

        Pos.y += 300;
        Pos.z += 50;
        ChatBackGround.position = Pos;
    }

    public void OnTriggerStay(Collider Other)
    {
        this.gameObject.GetComponent<EventScript>().enabled = true;
        FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
                
            this.gameObject.GetComponent<EventScript>().enabled = true;
            dialogueSystem.Names = Name;
            dialogueSystem.dialogueLines = sentences;
            FindObjectOfType<DialogueSystem>().EventScriptName();
        
    }
    
    public void OnTriggerExit()
    {
        FindObjectOfType<DialogueSystem>().OutOfRange();
        this.gameObject.GetComponent<EventScript>().enabled = false;
        this.Event.gameObject.SetActive(false);
    }
}

