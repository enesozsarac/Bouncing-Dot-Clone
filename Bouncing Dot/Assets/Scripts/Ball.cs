using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
        private Game_Manager gm;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Sprite[] ballSprite;
    public float jumpPower;
    public string currentColor;
    void Start()
    {
        gm = GameObject.FindObjectOfType<Game_Manager>();
        RamdomBall(4);
    }
    void Update()
    {
        
    }

    public void RamdomBall(int index)
    {
        switch(index)
        {
            case 0 : currentColor = "Red";
                    sr.sprite = ballSprite[0];
                    gameObject.tag = "Red";
                    break;
            case 1 : currentColor = "Yellow";
                    sr.sprite = ballSprite[1];
                    gameObject.tag = "Yellow";
                    break;
            case 2 : currentColor = "Blue";
                    sr.sprite = ballSprite[2];
                    gameObject.tag = "Blue";
                    break;
            case 3 : currentColor = "Purple";
                    sr.sprite = ballSprite[3];
                    gameObject.tag = "Purple";
                    break;
            case 4 : currentColor = "Green";
                    sr.sprite = ballSprite[4];
                    gameObject.tag = "Green";
                    break;      
            case 5 : currentColor = "Orange";
                    sr.sprite = ballSprite[5];
                    gameObject.tag = "Orange";
                    break;
        }           

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        rb.velocity = Vector3.up*jumpPower;
        if (other.gameObject.tag != currentColor)
        {
            gm.RestartGame();
        }
        else
        {
            gm.score += 1;
            int randomNumber = Random.Range(0,6);
            RamdomBall(randomNumber);
        }
    }

}
