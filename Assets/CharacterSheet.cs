using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    // Start is called before the first frame update
    //stat variables set
    [SerializeField] string charName = "";
    [SerializeField] int profBonus = 0;
    [SerializeField] bool finesse;
    [SerializeField][Range(-5, 5)] int str = 0;
    [SerializeField][Range(-5, 5)] int dex = 0;
    int enemyAC = Random.Range(1, 21);

    int RollD20() //D20 function set
    {
        return Random.Range(1, 21);
    }

    void Start()
    {

        int roll = RollD20();

        //Hit modifier logic
        int hitMod;
        if(!finesse)
        {
            hitMod = roll + str + profBonus;
        }
        else
        {
            if(str >= dex)
            {
                hitMod = roll + str + profBonus;
            }
            else
            {
                hitMod = roll + dex + profBonus;
            }
        }

        Debug.Log("Your hit modifier is: " + hitMod);
        Debug.Log("Beat or meet " + enemyAC + " to hit the enemy.");

        if(hitMod >= enemyAC)
        {
            Debug.Log("Huzzah, you've smacked the little bugger!");
        }
        else
        {
            Debug.Log("Scrub, you probably couldn't hit a wall if you walked into it.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
