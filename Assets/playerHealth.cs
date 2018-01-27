using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {
    public float fullHealth;
    private float currenHealth;
    sprite_controller sprite_movement;

    // Use this for initialization
    void Start() {
        currentHealth = fullHealth;
        sprite_controller = getComponent<sprite_movement>();
    }

    // Update is called once per frame
    void Update() {

    }
    public void takeDamage(float damage){
    if (damage > 100) return; 
        destroyed();
}
public void destroyed()
    {
        instatiate(DeathFX, transform.position, transform.rotation);
        destroy(gameObject);
    }


}
