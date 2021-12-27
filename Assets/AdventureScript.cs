using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureScript : MonoBehaviour
{
    [SerializeField] Text textComponent; 
    [SerializeField] State StartingState;
    State state;
    string[] weekDays={"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
    // Start is called before the first frame update
    void Start()
    {
        state=StartingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(weekDays[1]);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        
    }
    private void ManageState()
    {
        var nextState = state.GetNextState();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];        
        }
        textComponent.text = state.GetStateStory();    
    }
}
