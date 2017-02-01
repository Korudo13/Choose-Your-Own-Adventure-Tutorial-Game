using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Script : MonoBehaviour {

    public Text questionText;
    public Text answerText;
    public Button trueButton;
    public Button falseButton;

    public bool option1;
    public bool option2;

    private enum States
    {
        question, trueState, falseState
    };

    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.question;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.question)
        {
            Question_Function();
        }

        else if(myState == States.trueState)
        {
            TrueState_Function();
        }

        else if(myState == States.falseState)
        {
            FalseState_Function();
        }
	}


    void OnEnable()
    {
        trueButton.onClick.AddListener(delegate {  option1 = true; });
        falseButton.onClick.AddListener(delegate { option2 = true; });
    }

    void Question_Function()
    {
        questionText.text = "Ice is cold.";

        if(option1 == true)
        {
            myState = States.trueState;
        }

        else if(option2 == true)
        {
            myState = States.falseState;
        }
    }

    void TrueState_Function()
    {
        answerText.text = "You're an Einstein, Albert!";
    }


    void FalseState_Function()
    {
        answerText.text = "...are you an idiot?";
    }
}
