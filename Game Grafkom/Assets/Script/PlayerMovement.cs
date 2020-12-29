using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
    public bool pindah;
	private Rigidbody2D rb;
	private Vector3 change;
	private Animator animator;

    public Playerdata data;
    public flag flags;
    public CameraMovement camove;
    public int loads;
    // Start is called before the first frame update


    public void save(){
        //data.satu = flags.satu;
        //data.dua = flags.dua;
        //data.tiga = flags.tiga;

        //data.position = new float[3];
        //data.position[0] = transform.position.x;
        //data.position[1] = transform.position.y;
        //data.position[2] = transform.position.z;
//
//        //data.camera = new float[3];
//        //data.camera[0] = camove.transform.position.x;
//        //data.camera[1] = camove.transform.position.y;
        //data.camera[2] = camove.transform.position.z;

        SaveSytem.SavePlayer(flags,this,camove);

    }

    public void load(){
        data = SaveSytem.LoadPlayer();

        flags.satu = data.satu;
        flags.dua = data.dua;
        flags.tiga = data.tiga;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

        //Vector3 camera;
        camove.maxPosition.x = data.maxx;
        camove.maxPosition.y = data.maxy;
        camove.minPosition.x = data.minx;
        camove.minPosition.y = data.miny;
    }


    void Start()
    {
        GameObject msc = GameObject.FindGameObjectWithTag("Music");
        if(msc) Destroy(msc);
    	animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        pindah = true;
        loads = 0;
        loads = PlayerPrefs.GetInt("load");

        if(loads == 1){
            load();
        }
    }

    // Update is called once per frame
    void Update()
    {   if(pindah){
            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");
            animationmovement();
        }
        /*if(change != Vector3.zero){
        MoveCharacter();
        animator.SetFloat("MoveX", change.x);
        animator.SetFloat("MoveY", change.y);
        }*/
    
    }

    void animationmovement(){
    	if(change != Vector3.zero){
    	  	MoveCharacter();
        	animator.SetFloat("MoveX", change.x);
        	animator.SetFloat("MoveY", change.y);
        	animator.SetBool("walking", true);
        } else {
        	animator.SetBool("walking", false);
        }
    }

    //move character
    void MoveCharacter(){
    	rb.MovePosition(
    		transform.position + change * speed * Time.deltaTime
    		);
    }
}
