using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public float range = 2f;
    public float minrange = 0.8f;
    public float Attackrange = 0.8f;
    public Animator anim;
    

    public RectTransform rectTransform;

    public AudioSource woodaudio;

    public static float damage = 1f;

    public AudioSource AttackSound;

    float damageenemy = 1.0741f;
    public float damagebite;
    public float damagetowin;
    
    private GameObject instantiatedObj;
    private GameObject instantiatedObj1;

    public GameObject EnemyBar;
    public GameObject PlayerObject;

    public Transform TargetTung;

    public GameObject ParticleExplode;
    public GameObject ParticleExplode1;

    private int nextUpdate = 1;

    public GameObject Bar;


    // Start is called before the first frame update
    void Start()
    {
        anim.Play("Lumbering");

    }

    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("See Distance: " + Vector3.Distance(transform.position, Player.position));
        if(Vector3.Distance(transform.position, Player.position) < range && Vector3.Distance(transform.position, Player.position) > minrange)
        {
            enemy.SetDestination(Player.position);
            anim.Play("Walk");
            woodaudio.Stop();
        }

        

        if (Vector3.Distance(transform.position, Player.position) < Attackrange)
        {
            enemy.SetDestination(Player.position);
            anim.Play("Attack");


            if (Time.time >= nextUpdate)
            {
                Debug.Log(Time.time + ">=" + nextUpdate);
                // Change the next update (current second+1)
                nextUpdate = Mathf.FloorToInt(Time.time) + 2;
                // Call your fonction
                UpdateEverySecond();
            }


            //if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
            //{  //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
                
            //    damage -= 0.1f;

            //    //HealthBar.rectTransform.localScale = new Vector(damage, 1f, 1f);
            //    rectTransform.localScale = new Vector3(damage, rectTransform.localScale.y, rectTransform.localScale.z);

            //    AttackSound.Play();

            //    Debug.Log("Damage");
            //}
            //else
            //{

            //    Debug.Log("playing");

            //}

            void UpdateEverySecond()
            {
                damage -= 0.1f;

                //HealthBar.rectTransform.localScale = new Vector(damage, 1f, 1f);
                rectTransform.localScale = new Vector3(damage, rectTransform.localScale.y, rectTransform.localScale.z);

                AttackSound.Play();

                Debug.Log("Damage");
                // ...

            }



            if (Vector3.Distance(transform.position, PlayerObject.transform.position) < 3f)
            {

                

                if (Input.GetMouseButtonDown(0))
                {

                    damageenemy -= damagebite;

                }

                EnemyBar.transform.localScale = new Vector3(damageenemy, EnemyBar.transform.localScale.y, EnemyBar.transform.localScale.z);

                //instantiatedObj = Instantiate(ParticleExplode, TargetTung.transform.position, Quaternion.identity);



                //Destroy(instantiatedObj, 3f);





            }

            if (damageenemy < damagetowin)
            {

                //instantiatedObj1 = Instantiate(ParticleExplode1, transform.position, Quaternion.identity);



                //Destroy(instantiatedObj, 3f);

                //Destroy(gameObject);

                
                Destroy(Bar);

                anim.Play("Die");





                GameManager.count += 1;

                enabled = false;




            }

        }

        

        
    }

    

    //void OnTriggerEnter(Collider player)
    //{
    //    if(player.gameObject.tag == "Player")
    //    {
    //        enemy.SetDestination(Player.position);
    //    }

    //}
}
