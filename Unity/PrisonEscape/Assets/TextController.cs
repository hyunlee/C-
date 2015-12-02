using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cellkey, mirror_1, freedom};
	private States myState; 
	// Use this for initialization
	void Start () 
	{
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () 
	{
	    print (myState);
	    if (myState == States.cell)
	    {
	    	state_cell ();
	    }
		else if (myState == States.sheets_0)
		{
			state_sheets_0();
		}
		else if (myState == States.mirror)
		{
			state_mirror();
		}
		else if (myState == States.mirror_1)
		{
			state_mirror_1();
		}
		else if (myState == States.lock_0)
		{
			state_lock_0();
		}
		else if (myState == States.cellkey)
		{
			state_cellkey();
		}
		else if (myState == States.freedom)
		{
			state_freedom();
		}
	}
	
	void state_cell ()
	{
		text.text = ("You are in a prison cell, and you want to escape. There are" +
		             " some dirty sheets on the bed, a mirror on the wall, and the door" + 
		             " is locked.\n\n" +
		             "Press S to view Sheets, M to view Mirror, and L to view Lock");
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.sheets_0;
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			myState = States.mirror;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			myState = States.lock_0;
		}
	}
	
	void state_sheets_0 ()
	{
		text.text = ("Cockroaches. Guess you aren't so clean afterall." +
		             " You could eat them for protein, but you're full from drinking toilet water." + 
		             "\n\n" +
		             "Press R to Return");
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}
	
	void state_lock_0 ()
	{
		text.text = ("The door is locked." +
		             "\n\n" +
		             "Press R to Return");
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}
	
	void state_mirror ()
	{
		text.text = ("There's something about this mirror...\n" +
		             "Maybe there's something behind it?" + 
		             "\n\n" +
		             "Press F to Find or R to Return");
		if (Input.GetKeyDown(KeyCode.F))
		{
			myState = States.mirror_1;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.cell;
		}
	}
	void state_mirror_1 ()
	{
		text.text = ("You found the key to the lock!" +
					"\n\n" +
					"Press T to Take the key or R to Return");
						
		if (Input.GetKeyDown(KeyCode.T))
		{
			myState = States.cellkey;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.mirror;
		}
	}
	
	void state_cellkey ()
	{
		text.text = ("You have the key to the lock." +
		             "\n What do you want to do now?" + 
		             "\n\n" +
		             "Press E to Escape the prison or do nothing");
			if (Input.GetKeyDown(KeyCode.E))
			{
				myState = States.freedom;
			}
	}
	
	void state_freedom ()
	{
		text.text = ("Ah, delicious freedom!\n" +
		             "Let's hope you don't get caught stealing bananas again..." + 
		             "\n\n" +
		             "Press B for delicious Bananas");
			if (Input.GetKeyDown(KeyCode.B))
			{
				myState = States.cell;
			}
	}
	
}
