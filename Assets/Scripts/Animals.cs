using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    
    public float jumpTimer = 2f;
    public float lifePoints=200;
    public int speed;
    public int damagePoints = 10;
    public float jumpForce = 2.0f;
    public PlayerAttributes playerStats;

    protected string collisionText;
    protected Vector3 jump;
    protected bool isGrounded;
    protected Rigidbody rb;

    // Towards player vector, variables
    public Transform Character;
    protected Vector3 directionOfCharacter;
    protected bool playerInView =false;
    // Towards player vector, variables

    void Update()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerInView = true;//see jumpFromTimeToTime(), if (playerInView == true)
            playerStats.generalInfoText.text = "Player has entered " + this.gameObject.name + "'s field of view";

        }
        
    }
    

    private void OnTriggerExit(Collider other)
    {
        playerInView = false;
        playerStats.generalInfoText.text = "Player has exited " + this.gameObject.name + "'s field of view";
        
    }

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(JumpFromTimeToTime(jumpTimer));
        
       
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name=="Player")
        {
            GetInfoTextString(other);
            InflictDamage();
            playerStats.lifePointsText.text = playerStats.lifePoints.ToString();
            playerStats.generalInfoText.text = collisionText;
        }
        
    }

    void GetInfoTextString(Collision other)
    {
        collisionText = (other.gameObject.name + " collided with " + this.gameObject.name + ";  Damage taken " + damagePoints + ", from " + this.gameObject.name).ToString();
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    public virtual void SetLifePoints()
    {
        lifePoints = 200;
    }

    public virtual void TakeDamage()
    {
        lifePoints -=damagePoints;
    }

    public virtual void InflictDamage()
    {
        playerStats.lifePoints -= 10;
    }

 

    public virtual IEnumerator JumpFromTimeToTime(float time)
    {
       
            while (true)
            {

                yield return new WaitForSeconds(time);
            if (playerInView)
            {
                directionOfCharacter = Character.transform.position - transform.position;
                directionOfCharacter = directionOfCharacter.normalized;    // Get Direction to Move Towards
                rb.AddForce(directionOfCharacter * jumpForce, ForceMode.Impulse);

            }
            else
            {
                jump = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                isGrounded = false;

            }
            
            
            }
        
        
    }
}
