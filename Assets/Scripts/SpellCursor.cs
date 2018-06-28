using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCursor : MonoBehaviour {

    ParticleSystem.EmissionModule emission;
    ParticleSystem.ShapeModule shape;
    CircleCollider2D circleCollider;

    void Start()
    {
        ParticleSystem ps = transform.parent.GetComponentInChildren<ParticleSystem>();
        emission = ps.emission;
        shape = ps.shape;
        circleCollider = GetComponent<CircleCollider2D>();
    }

    void Update () {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(worldPosition.x, worldPosition.y);
        shape.position = transform.position;
        if(Input.GetMouseButtonDown(0))
        {
            emission.enabled = true;
            circleCollider.enabled = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            emission.enabled = false;
            circleCollider.enabled = false;
        }
	}
}
