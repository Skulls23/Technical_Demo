using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public TextMeshProUGUI ruleText;

    private int count;
    private static int MAX_COUNT = 6;

    private bool archerKilled = false;

    private bool isShielded = false;

    void Start()
    {
        countText.SetText(count + "/" + MAX_COUNT);
    }

    public void ArcherKilled()
    {
        archerKilled = true;
        ChangeRule();
    }

    public bool IsShielded {get; set;}

    //Function to do an action when hitting a collider
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectibles"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.SetText(count + "/" + MAX_COUNT);
            if(count == MAX_COUNT)
                ChangeRule();
        }
    }

    void ChangeRule()
    {
        if (count == MAX_COUNT && !archerKilled)
            ruleText.SetText("Kill the archer");
        else if (count < MAX_COUNT && archerKilled)
            ruleText.SetText("Catch the 6 skulls");
        else
            ruleText.SetText("You've finished this wonderful technical demo");
    }
}
