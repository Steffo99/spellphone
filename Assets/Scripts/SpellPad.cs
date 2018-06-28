using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellPad : MonoBehaviour {

    public Queue<short> sequence;

    void Start()
    {
        sequence = new Queue<short>();
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            CastSpell();
        }
    }

    void CastSpell()
    {
        string sequenceString = "";
        while(sequence.Count != 0)
        {
            short s = sequence.Dequeue();
            sequenceString += s.ToString() + " ";
        }
        Debug.Log(sequenceString);
        sequence = new Queue<short>();
    }
}
