using UnityEngine;
using System.Collections;

public class RandomColorSelector : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        Renderer rend = GetComponent<Renderer>();
        Color rand = RandomColorLerper.GetRandomColor();
        Color newColor = new Color(rand.r, rand.g, rand.b, .7f);
        rend.material.color = newColor;
	}
	
}
