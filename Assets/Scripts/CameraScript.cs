using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Vector2 turn;

    public Animator anim;
    public KeyCode RaiseKey;
    public KeyCode IdleKey;

    public GameObject CameraRaise;

    

    public GameObject IdleCamera;


    //public GameObject Enemy1;
    //public GameObject Enemy1Player;

    //public GameObject Enemy2;
    //public GameObject Enemy2Player;



    public AudioSource attacksound;



    //float damage = 1.0741f;
    //float damage1 = 1.0741f;

    //public GameObject ParticleExplode;
    //public GameObject ParticleExplode1;

    //private GameObject instantiatedObj;

    //public Transform TargetTung;

    int count = 0;

    public GameObject WonUI;





    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        turn.x += Input.GetAxis("Mouse X");
        turn.x += Input.GetAxis("Mouse X");

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        if(count == 2)
        {
            WonUI.SetActive(true);
        }

        if (Input.GetKeyDown(IdleKey))
        { 
            CameraRaise.SetActive(false);
            IdleCamera.SetActive(true);

            anim.Play("Idle");
        }

        if (Input.GetKeyDown(RaiseKey))
        {

            anim.Play("Raise");
            CameraRaise.SetActive(true);
            IdleCamera.SetActive(false);

        }

        if (Input.GetMouseButtonDown(0))
        {

            anim.Play("Attack");




        }

        
            
        if (Input.GetMouseButtonDown(0))
        {

            anim.Play("Attack");

            //Debug.Log("Distance" + Vector2.Distance(transform.position, Enemy1.transform.position));

            attacksound.Play();

            




            //if (Vector2.Distance(transform.position, Enemy1.transform.position) < 3f)
            //{

            //    Debug.Log("Going");

            //    damage -= 0.300f;

            //    Enemy1.transform.localScale = new Vector3(damage, Enemy1.transform.localScale.y, Enemy1.transform.localScale.z);

                
                
            //    instantiatedObj = Instantiate(ParticleExplode, TargetTung.transform.position, Quaternion.identity);



            //    Destroy(instantiatedObj, 3f);


            //}

            //if (damage < 0.3f)
            //{

            //    instantiatedObj = Instantiate(ParticleExplode1, Enemy1Player.transform.position, Quaternion.identity);



            //    Destroy(instantiatedObj, 3f);

            //    Destroy(Enemy1Player);

            //    count += 1;
            //}

            //if (Vector2.Distance(transform.position, Enemy2.transform.position) < 3f)
            //{

            //    Debug.Log("Going");

            //    damage1 -= 0.300f;

            //    Enemy2.transform.localScale = new Vector3(damage1, Enemy2.transform.localScale.y, Enemy2.transform.localScale.z);



            //    instantiatedObj = Instantiate(ParticleExplode, TargetTung.transform.position, Quaternion.identity);



            //    Destroy(instantiatedObj, 3f);


            //}

            //if (damage1 < 0.3f)
            //{

            //    instantiatedObj = Instantiate(ParticleExplode1, Enemy2Player.transform.position, Quaternion.identity);



            //    Destroy(instantiatedObj, 3f);

            //    Destroy(Enemy2Player);

            //    count += 1;
            //}

        }

    }

    
}
