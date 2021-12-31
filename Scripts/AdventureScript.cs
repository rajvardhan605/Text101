using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureScript : MonoBehaviour
{
    [SerializeField] Text textComponent; 
    [SerializeField] State StartingState;
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state=StartingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        
    }
    private void ManageState()
    {
        var nextState = state.GetNextState();
        for (int index=0; index<nextState.Length; index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1+index))
            {
                state=nextState[index];
            }
        } 
        textComponent.text= state.GetStateStory(); 
    }
}
