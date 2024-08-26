using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitySwitcher : MonoBehaviour
{
    [SerializeField] int currentUtility = 0;

    void Start()
    {
        SetUtilityActive();
    }

    // Update is called once per frame
    void Update()
    {
        int previousUtility = currentUtility;

        ProcessKeyInput();

        if (previousUtility != currentUtility)
        {
            SetUtilityActive();
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentUtility = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentUtility = 1;
        }
    }

    private void SetUtilityActive() // find which utility is active.
    {
        int utilityIndex = 0; // the first utility (the torch) under the utility object will be given an index
                              // of 0, 1 for the second utility (the NV camera).

        foreach (Transform utility in transform)
        {
            if (utilityIndex == currentUtility) // if the utility in hand has an index of 0
            {
                utility.gameObject.SetActive(true); // make that utility set as active
            }
            else // otherwise any other indexed utility
            {
                utility.gameObject.SetActive(false); // will be set to false and not be seen.
            }
            utilityIndex++; // add 1 to the index and go through the SetUtilityActive
                           // function again until active utility is found
        }

    }
}
