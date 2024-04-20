using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int points = 10;

    // Start is called before the first frame update
    protected virtual void Eat()
    {
        // GameManager.Instance.PelletEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman")) {
            Eat();
        }
    }
}
