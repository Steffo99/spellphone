using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDot : MonoBehaviour {

    public Sprite inactiveSprite;
    public Sprite activeSprite;
    public short number;

    bool active;
    SpellPad spellPad;
    SpriteRenderer spriteRenderer;

	void Start () {
        active = false;
        spellPad = GetComponentInParent<SpellPad>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	void Update () {
		if(Input.GetMouseButtonUp(0))
        {
            active = false;
            spriteRenderer.sprite = inactiveSprite;
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cursor" && !active)
        {
            spellPad.sequence.Enqueue(number);
            active = true;
            spriteRenderer.sprite = activeSprite;
        }
    }
}
