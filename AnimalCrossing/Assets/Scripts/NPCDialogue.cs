using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    //public Text npcText;
    public TextMeshProUGUI npcText;
    public string[] npcDialogue;
    private int index;
    public float textSpeed;
    public bool canTalk = false;
    public GameObject interactText;

    //public GameObject player;
    CharacterController playerControls;

    private void Start()
    {
        playerControls = GetComponent<CharacterController>();
    }

    private void Update()
    {
        TalkToNPC();

        if(npcText.text == npcDialogue[index] && Input.GetKeyDown(KeyCode.Space))
        {
            NextLine();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canTalk = true;
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canTalk = false;
            interactText.SetActive(false);
            ResetText();
        }
    }

    void TalkToNPC()
    {
        if(canTalk)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                
                canTalk = false;
                if (dialoguePanel.activeInHierarchy)
                {
                    ResetText();
                    interactText.SetActive(false);     
                }
                else
                {
                    dialoguePanel.SetActive(true);
                    interactText.SetActive(false);
                    StartCoroutine(Typing());
                }
            }
 
        }
    
    }

    public void ResetText()
    {
        npcText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
        
    }

    IEnumerator Typing()
    {
        foreach(char letter in npcDialogue[index].ToCharArray())
        {
            npcText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if(index < npcDialogue.Length - 1)
        {
            index++;
            npcText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            ResetText();
        }
    }
}
