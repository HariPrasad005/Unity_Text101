using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State State;
    void Start()
    {
        State = startingState;
        textComponent.text = State.getStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        manageState();   
    }

    private void manageState()
    {
        var nextStates = State.getNextState();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                State = nextStates[index];
            }
        }
        textComponent.text = State.getStateStory();
    }
}
