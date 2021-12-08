using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
	public Transform Zombie;
	public Transform Player;
	public double dangerDistance = 1.32;
    private float timerSpeed1 = 9f;
    private float timerSpeed2 = 3f;
    private float lastTimeStamp = 0;

    public Text txt;
    public int i = 0;
    public string[] dialog2 = {
        "You can control the view by your mouse.",
    	"I should move, or Mr. Z will catch me.",
    	"Mr. Z is a zombie.",
        "He will eat me if he catch me.",
    	"But I'd better not be too far away from Mr. Z.",
    	"Mr. Z is not smart.",
    	"He will eat himself if I go too far from him.",
    	"If Mr. Z dies, I probably will die of loneliness.",
    	"You ask why?",
    	"Because I am in an isolated island, ",
    	"and there is no other person in here.",
    	"Why only me and Mr. Z live here?",
    	"I guess the creator just don't want to add more models.",
        "So she don't need to write more code.",
    	"Yes, I know. I am a game character and you are the player.",
        "Why I know this?",
        "Come on, it's just a small island and there is nothing outside.",
        "The creator didn't even set a air wall to keep me from the boundary.",
        "Sometime I even clip into map geometry.",
        "If you were me, you would know you live in a game box too.",
        "...",
    	"I am fine. At least I am smarter than Mr. Z.",
    	"He don't even speak.",
    	"But I am glad Mr. Z is here.",
    	"He is slow,",
    	"so he couldn't catch me if you don't want.",
    	"And Mr. Z it not smart.",
    	"Sometime he even stuck himself against the wall.",
    	"So you'd better pay attention to him.",
    	"Or he may die because I go too far from him.",
    	"Sometime I was tired of running.",
    	"Mr. Z always try to catch me.",
    	"He never understand what's social distance.",
    	"Get too close is not good for both of us.",
    	"I will die first, and he will die after me.",
    	"Because he will eat himself after eating all my body.",
    	"Are you tired?",
    	"I hope you are not.",
    	"Or I will be caught because you stop controlling me.",
    	"By the way, if Mr. Z is dead,",
    	"don't let me see his body.",
    	"Then I can pretend he is still alive.",
    	"Are you tired?",
    	"I can't believe you are still playing the boring game.",
    	"It just a small island and there is nothing you can do.",
    	"And I, the only character you can control, ",
    	"cannot do anything other than idle and run ... and die.",
    	"Are you still playing?",
    	"Just give up. ",
    	"There is no any other thing you can do.",
    	"I am not sure are you tired or not,",
    	"but I am tired anyway.",
    	"Maybe you can stop to do something else.",
    	"I will be fine.",
    	"I am just a game character.",
    	"I will relive again and again when player start the game.",
    	"So does Mr. Z.",
    	"You can stop the game to do something interesting.",
    	"And I can give Mr. Z a hug,",
        ""
    };
    //float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Canvas/Text").GetComponent<Text>();   
        txt.text = "You can move me by the arrow keys on your keyboard."; 
    }

    // Update is called once per frame
    void Update()
    {
    	float distance = Vector3.Distance(Zombie.position, Player.position);
        if(distance<=dangerDistance){
            txt.text = "";
            i = 1000;
        }

        if (Time.time - lastTimeStamp >= timerSpeed1){
            lastTimeStamp = Time.time;
            txt.text = "";
        }
        if (Time.time - lastTimeStamp >= timerSpeed2){
            lastTimeStamp = Time.time;
            if(i < dialog2.Length){ 
                txt.text = dialog2[i];
                i++;
            }
        } 
    	// timer += Time.time;
    	// if (timer >= 1000){
    	// 	txt.text = "";
    	// }

    	// if(i < dialog.Length - 1){		
    	// 	if (timer >= 1600){
    	// 		txt.text = dialog[i];
    	// 		i++;
    	// 		timer = 0;
    	// 	}
    	// }
    	
	     
    }
}
